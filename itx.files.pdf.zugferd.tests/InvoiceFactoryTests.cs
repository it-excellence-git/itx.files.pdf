using System.Threading.Tasks;
using Xunit;

namespace itx.files.pdf.zugferd.tests
{
    public class InvoiceFactoryTests
    {
        private const string TEST_DIR = "c:\\temp\\FileTests\\Zugferd";
        private const string TEST_SOURCES_DIR = "c:\\temp\\FileTests\\Zugferd\\TestSources";
        private InvoiceFactory Factory { get; init; }

        public InvoiceFactoryTests()
        {
            Factory = new InvoiceFactory();
            try
            {
                var dir = new DirectoryInfo(TEST_DIR);
                foreach (var file in dir.GetFiles())
                {
                    file.Delete();
                }
            }
            catch (IOException)
            {
            }
        }

#if(TEST)
        [Fact]
        public void Create_registeres_tax_at_descriptor()
        {
            // arrange
            var invoicefactory = new InvoiceFactory();
            var data = new InvoiceData()
            {
                Buyer = new Buyer() { TaxRegistrationFcId="123/456/7890" },
                Seller = new Seller() { TaxRegistrationFcId = "201/113/40209" },
                VatItems = new InvoiceVatItems().Add(19m, 200)
            };

            // act
            var desc = invoicefactory.CreateDescriptorOnTest(data);

            // assert
            Assert.NotNull(desc);
            Assert.NotNull(desc.GetApplicableTradeTaxes());
            Assert.Single(desc.GetApplicableTradeTaxes());
            Assert.Equal(data.VatItems.Items.First().BaseAmount, desc.GetApplicableTradeTaxes()[0].BasisAmount);
            Assert.Equal(data.VatItems.Items.First().Rate, desc.GetApplicableTradeTaxes()[0].Percent);
            Assert.Equal(data.VatItems.Items.First().TaxAmount, desc.GetApplicableTradeTaxes()[0].TaxAmount);
        }
#endif

        [Fact]
        public void Create_file_should_work()
        {
            // arrange
            var filename = "xml_only_ZUGFeRD-Test-XRechnung.pdf";
            var filenameWithPath = Path.Combine(TEST_DIR, filename);
            var data = GetItxData();
            // act
            Factory.CreateAsync(new() {

                Buyer = new Buyer() { TaxRegistrationFcId = "123/456/7890" },
                Seller = new() { TaxRegistrationFcId = "sss" } 
            }, filenameWithPath);
            // assert
            _ = FileExists(filenameWithPath);
        }

        [Fact]
        public async Task Read_xml_only_file_should_not_work()
        {
            // arrange
            var filename = "xml_only_ZUGFeRD-Test-XRechnung.pdf";
            var filenameWithPath = Path.Combine(TEST_SOURCES_DIR, filename);
            InvoiceReader reader = new InvoiceReader(filenameWithPath);

            // act, assert
            await Assert.ThrowsAsync<InvalidOperationException>(async () => 
            {
                await reader.Read();
            });
        }

        [Fact]
        public async Task Create_file_with_embedded_data_should_work()
        {
            // arrange
            //var pdfSourceFilename = "lobn_202507_1033758_53318_00003.pdf";
            var pdfSourceFilename = "Biqx_20250901-01.pdf";
            var targetFilename = $"xml_{pdfSourceFilename}";
            var targetXmlFilename = targetFilename.Replace(".pdf", ".xml");
            var targetFilenameWithPath = Path.Combine(TEST_DIR, targetFilename);
            var targetXmlFilenameWithPath = Path.Combine(TEST_DIR, targetXmlFilename);

            var pdfSourceFilenameWithPath = Path.Combine(TEST_SOURCES_DIR, pdfSourceFilename);
            var data = GetItxData();
            await Factory.CreateAsync(
                data, 
                targetFilenameWithPath, 
                pdfSourceFilenameWithPath);
            
            InvoiceReader reader = new InvoiceReader(targetFilenameWithPath);

            // act
            await reader.Read();
            reader.Descriptor.Save(targetXmlFilenameWithPath);

            // assert
            Assert.NotNull(reader.Descriptor);
            //Assert.Equal(data.Name, reader.Descriptor.Name);
            Assert.Equal(data.InvoiceNo, reader.Descriptor.InvoiceNo);
            Assert.Equal(data.InvoiceDate, reader.Descriptor.InvoiceDate);

            Assert.NotNull(reader.Descriptor.Buyer);
            Assert.Equal(data.Buyer.Name, reader.Descriptor.Buyer.Name);
            Assert.Equal(data.Buyer.City, reader.Descriptor.Buyer.City);
            Assert.Equal(data.Buyer.Zip, reader.Descriptor.Buyer.Postcode);
            Assert.Equal(data.Buyer.Street, reader.Descriptor.Buyer.Street);
            Assert.Equal(data.Buyer.CountryCode, reader.Descriptor.Buyer.Country.GetValueOrDefault().ToString());
            Assert.Contains(reader.Descriptor.BuyerTaxRegistration, tr => tr.No == data.Buyer.TaxRegistrationVaId);

            Assert.NotNull(reader.Descriptor.Seller);
            Assert.Equal(data.Seller.Name, reader.Descriptor.Seller.Name);
            Assert.Equal(data.Seller.City, reader.Descriptor.Seller.City);
            Assert.Equal(data.Seller.Zip, reader.Descriptor.Seller.Postcode);
            Assert.Equal(data.Seller.Street, reader.Descriptor.Seller.Street);
            Assert.Equal(data.Seller.CountryCode, reader.Descriptor.Seller.Country.GetValueOrDefault().ToString());
            Assert.Contains(reader.Descriptor.SellerTaxRegistration, tr => tr.No == data.Seller.TaxRegistrationFcId);

            Assert.NotEmpty(reader.Descriptor.Notes);
            Assert.Contains(reader.Descriptor.Notes, note => note.Content.StartsWith("Der Rechnungsbetrag deckt"));
            Assert.Contains(reader.Descriptor.Notes, note => note.Content.EndsWith("97:09 Std."));

            Assert.NotNull(reader.Descriptor.PaymentTerms);
            Assert.Contains(reader.Descriptor.PaymentTerms, pt => pt.Description.Equals(data.PaymentTerms[0]!.Description));
            Assert.Contains(reader.Descriptor.PaymentTerms, pt => pt.DueDate.HasValue);

            Assert.True(reader.Descriptor.AnyApplicableTradeTaxes());
            Assert.NotNull(reader.Descriptor.Taxes);
            Assert.Single(reader.Descriptor.Taxes);
            Assert.Equal(data.VatItems.Items.First()!.Rate, reader.Descriptor.Taxes[0].Percent);
            Assert.Equal(data.VatItems.Items.First()!.BaseAmount, reader.Descriptor.Taxes[0].BasisAmount);
            Assert.Equal(data.VatItems.Items.First()!.TaxAmount, reader.Descriptor.Taxes[0].TaxAmount);

            Assert.Equal(data.TaxTotalAmount, reader.Descriptor.TaxTotalAmount);
            Assert.Equal(data.TaxBasisTotalAmount, reader.Descriptor.TaxBasisAmount);
            Assert.Equal(data.GrandTotalAmount, reader.Descriptor.GrandTotalAmount);
            Assert.Equal(data.CurrencyCode, reader.Descriptor.Currency.ToString());
            Assert.Equal(data.TaxCurrencyCode, reader.Descriptor.TaxCurrency.ToString());

            Assert.Single(reader.Descriptor.CreditorBankAccounts);
            Assert.Equal(data.Seller.BankAccounts[0].Id, reader.Descriptor.CreditorBankAccounts[0].ID);
            Assert.Equal(data.Seller.BankAccounts[0].Name, reader.Descriptor.CreditorBankAccounts[0].Name);
            Assert.Equal(data.Seller.BankAccounts[0].IBAN, reader.Descriptor.CreditorBankAccounts[0].IBAN);
            Assert.Equal(data.Seller.BankAccounts[0].Bank.BIC, reader.Descriptor.CreditorBankAccounts[0].BIC);
            //Assert.Equal(data.Seller.BankAccounts[0].Bank.Bankleitzahl, reader.Descriptor.CreditorBankAccounts[0].Bankleitzahl);
            //Assert.Equal(data.Seller.BankAccounts[0].Bank.Name, reader.Descriptor.CreditorBankAccounts[0].BankName);
        }

        #region private methods

        private FileInfo FileExists(string fileWithPath)
        {
            var fileInfo = new FileInfo(fileWithPath);
            Assert.True(fileInfo.Exists);
            return fileInfo;
        }

        private InvoiceData GetItxData()
        {

            var netAmount = 3700m;
            var data = new InvoiceData()
            {
                Name = "DIENSTLEISTUNGS-RECHNUNG",
                InvoiceNo = "20250901-01",
                InvoiceDate = new DateTime(2025, 9, 1),
                Notes = [
                    new (){
                        SubjectCode = edifact.TextSubjectCodes.ABD,
                        Text = "Der Rechnungsbetrag deckt 1/12 der vertraglich für 12 Monate vereinbarten 824 Gesamtarbeitsstunden. Davon geleistet im August 2025: 97:09 Std."
                    }
                ],
                Seller = new Seller()
                {
                    Name = "Detlef Regehr",
                    City = "Minden",
                    CountryCode = "DE",
                    Street = "Bachstr. 76",
                    Zip = "32423",
                    TaxRegistrationFcId = "335/5957/5034",
                    Contact = new Contact()
                    {
                        Name = "Detlef Regehr",
                        Email = "detlef.regehr@it-excellence.net",
                        Phone = "+49 177 5359757",
                    },
                    BankAccounts = [
                        new BankAccount()
                        {
                            Id = "50373075",
                            Name = "Detlef Regehr",
                            IBAN = "DE03490501010050373075",
                            Bank = new(){
                                BIC = "WELADED1MIN",
                                Name = "Sparkasse Minden-Lübbecke",
                                Bankleitzahl = "49050101"
                            }
                        }
                    ],
                },
                Buyer = new Buyer()
                {
                    Name = "Biqx GmbH",
                    City = "Braunschweig",
                    CountryCode = "DE",
                    Street = "Berliner Straße 52e",
                    Zip = "38104",
                    TaxRegistrationVaId = "DE309467441"
                },
                PaymentTerms = [
                    new PaymentTerm()
                    {
                        Description = "Rechnungsendbetrag zahlbar innerhalb von 14 Tagen ohne Abzug.",
                        DueDate = DateTime.Now.AddDays(14)
                    }
                ],
                VatItems = new InvoiceVatItems().Add(19m, netAmount)
            };
            return data;
        }

        #endregion
    }
}
