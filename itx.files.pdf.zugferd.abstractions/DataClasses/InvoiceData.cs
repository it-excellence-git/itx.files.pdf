using itx.files.pdf.zugferd.abstractions.DataClasses;

namespace itx.files.pdf.zugferd
{
    /// <summary>
    /// structured data for an invoice
    /// </summary>
    public class InvoiceData
    {
        /// <summary>
        /// The date when the invoice is issued
        /// </summary>
        public DateTime InvoiceDate { get; set; }

        /// <summary>
        /// The document number of the invoice at seller side
        /// </summary>
        public string InvoiceNo { get; set; } = string.Empty;

        /// <summary>
        /// Code of currency, e.g. EUR, USD, CHF
        /// </summary>
        public string CurrencyCode{ get; set; } = "EUR";

        /// <summary>
        /// Code of currency for tax amounts, e.g. EUR, USD, CHF
        /// </summary>
        public string TaxCurrencyCode { get; set; } = "EUR";

        /// <summary>
        /// Sum of basis amounts that are subject to tax
        /// </summary>
        public decimal TaxBasisTotalAmount => VatItems.Items.Sum(i => i.BaseAmount);

        /// <summary>
        /// Calculated tax amount for all tax positions
        /// </summary>
        public decimal TaxTotalAmount => VatItems.Items.Sum(i => i.TaxAmount);

        /// <summary>
        /// The sum of all cost positions including charges and tax, 
        /// but without allowances
        /// </summary>
        public decimal GrandTotalAmount => TaxBasisTotalAmount + TaxTotalAmount;

        /// <summary>
        /// What's already has been paid (e.g. advance payment)
        /// </summary>
        public decimal? TotalPrepaidAmount { get; set; }

        /// <summary>
        /// Tasächlicher Forderungsbetrag
        /// </summary>
        public decimal DuePayableAmount => GrandTotalAmount - (AllowanceTotalAmount ?? 0m) - (TotalPrepaidAmount ?? 0m);
        /// <summary>
        /// Gebühren wie Versandkosten, Verpackungskosten, etc.
        /// </summary>
        public decimal? ChargeTotalAmount { get; set; }
        /// <summary>
        /// Alle Nachlässe (Rabatte, Skonti, etc.) als positiver Betrag (inkl. Steuer)
        /// </summary>
        public decimal? AllowanceTotalAmount { get; set; }
        /// <summary>
        /// Alles Positionen ohne Zuschläge und Nachlässe und Steuern
        /// </summary>
        public decimal LineTotalAmount => TaxBasisTotalAmount - (ChargeTotalAmount ?? 0m);

        /// <summary>
        /// Name / title of the invoice
        /// </summary>
        public string Name { get; set; } = "DIENSTLEISTUNGS-RECHNUNG";

        /// <summary>
        /// Notes that are relevant e.g. for payment information
        /// </summary>
        public Note[] Notes = [];

        /// <summary>
        /// A set of VAT items that are relevant for this invoice (e.g. 19% and / or 7%)
        /// </summary>
        public InvoiceVatItems VatItems { get; set; } = new InvoiceVatItems();

        /// <summary>
        /// The party that is issuing the invoice (seller, supplier, creditor)
        /// </summary>
        public Seller Seller { get; set; } = new Seller();

        /// <summary>
        /// The party that is receiving the invoice (buyer, customer, debitor)
        /// </summary>
        public Buyer Buyer { get; set; } = new Buyer();

        /// <summary>
        /// Machine readable terms of payment
        /// </summary>
        public PaymentTerm[] PaymentTerms { get; set; } = [];
    }
}
