using s2industries.ZUGFeRD;
using s2industries.ZUGFeRD.PDF;

namespace itx.files.pdf.zugferd
{
    public class InvoiceFactory
    {
        private delegate void SetBusinessPartnerTaxRegistrationsDelegate(string no, TaxRegistrationSchemeID schemeId);

        public void CreateAsync(InvoiceData data, string pdfTargetFilename)
        {
            var desc = CreateDescriptor(data);

            FileStream stream = new FileStream(pdfTargetFilename, FileMode.Create, FileAccess.Write);
            desc.Save(stream, ZUGFeRDVersion.Version23, Profile.XRechnung);
            stream.Flush();
            stream.Close();
        }

        public async Task CreateAsync(InvoiceData data, string pdfTargetFilename, string pdfSourceFilename)
        {
            var desc = CreateDescriptor(data);

            await InvoicePdfProcessor.SaveToPdfAsync(
                pdfTargetFilename,
                ZUGFeRDVersion.Version23,
                Profile.Comfort,
                ZUGFeRDFormats.CII,
                pdfSourceFilename,
                desc);

        }

#if(TEST)
        public InvoiceDescriptor CreateDescriptorOnTest(InvoiceData data)
        {
            return CreateDescriptor(data);
        }
#endif

        private InvoiceDescriptor CreateDescriptor(InvoiceData data)
        {
            InvoiceDescriptor desc = InvoiceDescriptor.CreateInvoice("471102", new DateTime(2013, 6, 5), CurrencyCodes.EUR, "GE2020211-471102");
            desc.Name = data.Name;
            desc.InvoiceNo = data.InvoiceNo;
            desc.InvoiceDate = data.InvoiceDate;
            //desc.ReferenceOrderNo = "AB-312";
            foreach (var note in data.Notes)
            {
                if (note.SubjectCode.HasValue)
                {
                    if (Enum.TryParse<SubjectCodes>(note.SubjectCode.Value.ToString(), out var oValue))
                    {
                        // success
                        desc.AddNote(note.Text, oValue);
                    }
                    else
                    {
                        desc.AddNote(note.Text);
                    }
                }
                else
                {
                    desc.AddNote(note.Text);
                }
            }
            
            desc.SetBuyer(
                data.Buyer.Name,
                data.Buyer.Zip,
                data.Buyer.City, 
                data.Buyer.Street,
                Enum.Parse<CountryCodes>(data.Buyer.CountryCode, true));
            SetBusinessPartnerTaxRegistrations(desc.AddBuyerTaxRegistration, data.Buyer);
            //desc.SetBuyerContact("Hans Muster");
            // desc.SetBuyerOrderReferenceDocument("2013-471331", new DateTime(2013, 03, 01));

            desc.SetSeller(
                data.Seller.Name, 
                data.Seller.Zip, 
                data.Seller.City, 
                data.Seller.Street, 
                Enum.Parse<CountryCodes>(data.Seller.CountryCode, true));
            SetBusinessPartnerTaxRegistrations(desc.AddSellerTaxRegistration, data.Seller);
            foreach(var bankAccount in data.Seller.BankAccounts)
            {
                desc.CreditorBankAccounts.Add(new s2industries.ZUGFeRD.BankAccount()
                {
                    ID = bankAccount.Id,
                    Name = bankAccount.Name,
                    IBAN = bankAccount.IBAN,
                    BIC = bankAccount.Bank.BIC,
                    BankName = bankAccount.Bank.Name,
                    Bankleitzahl = bankAccount.Bank.Bankleitzahl,
                });
            }

            // desc.SetDeliveryNoteReferenceDocument("2013-51111", new DateTime(2013, 6, 3));
            // desc.ActualDeliveryDate = new DateTime(2013, 6, 3);

            desc.SetTotals(data.LineTotalAmount, data.ChargeTotalAmount, data.AllowanceTotalAmount, data.TaxBasisTotalAmount, data.TaxTotalAmount, data.GrandTotalAmount, null, data.DuePayableAmount);
            desc.Currency = CurrencyCodes.EUR;
            desc.TaxCurrency = CurrencyCodes.EUR;
            foreach (var item in data.VatItems.Items)
            {
                desc.AddApplicableTradeTax(item.BaseAmount, item.Rate, item.TaxAmount, TaxTypes.VAT, TaxCategoryCodes.S);
            }

            // desc.AddLogisticsServiceCharge(5.80m, "Versandkosten", TaxTypes.VAT, TaxCategoryCodes.S, 7m);

            foreach(var item in data.PaymentTerms)
            {
                if(!item.TermsType.HasValue)
                {
                    desc.AddTradePaymentTerms(item.Description, item.DueDate);
                }
                else if(item.TermsType == PaymentTermsType.Discount 
                    && item.DiscountPercentage.HasValue
                    && item.DiscountDaysUntilDue.HasValue)
                {
                    desc.AddTradePaymentTerms(item.Description, item.DueDate, s2industries.ZUGFeRD.PaymentTermsType.Skonto, item.DiscountDaysUntilDue, item.DiscountPercentage);
                }
            }
            return desc;
        }

        private void SetBusinessPartnerTaxRegistrations(SetBusinessPartnerTaxRegistrationsDelegate setRegistration, BusinessPartner bp)
        {
            if (!string.IsNullOrWhiteSpace(bp.TaxRegistrationFcId))
            {
                setRegistration(bp.TaxRegistrationFcId, TaxRegistrationSchemeID.FC);
            }
            if (!string.IsNullOrWhiteSpace(bp.TaxRegistrationVaId))
            {
                setRegistration(bp.TaxRegistrationVaId, TaxRegistrationSchemeID.VA);
            }
            if (string.IsNullOrWhiteSpace(bp.TaxRegistrationFcId) && string.IsNullOrWhiteSpace(bp.TaxRegistrationVaId))
            {
                throw new ArgumentException("Businesspartner must have at least one tax registration ID (fiscal code or VAT ID).");
            }
        }


    }
}
