namespace itx.files.pdf.zugferd
{
    public class BusinessPartner
    {
        public string Name { get; set; } = "Default Seller Name";
        public string Street { get; set; } = "Default Street 1";
        public string Zip { get; set; } = "12345";
        public string City { get; set; } = "Default City";
        public string CountryCode { get; set; } = "DE";
        /// <summary>
        /// Fiscal Code (local tax ID / national tax number)
        /// - in Germany usually without country code, e.g. 201/113/40209
        /// </summary>
        public string? TaxRegistrationFcId { get; set; }
        /// <summary>
        /// Value Added Tax number (VAT ID) 
        /// - in EU countries usually starts with country code, e.g. DE123456789
        /// </summary>
        public string? TaxRegistrationVaId { get; set; }
        public Contact? Contact { get; set; }

        public BankAccount[] BankAccounts { get; set; } = [];
    }
}
