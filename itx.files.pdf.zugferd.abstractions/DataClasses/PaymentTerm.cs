namespace itx.files.pdf.zugferd
{
    public class PaymentTerm
    {
        public PaymentTermsType? TermsType { get; set; }

        #region to pay total
        /// <summary>
        /// Invoice description to pay total amount
        /// </summary>
        public string Description { get; set; } = "Default Payment Term";
        /// <summary>
        /// Invoice due date to pay total amount
        /// </summary>
        public DateTime? DueDate { get; set; }

        #endregion

        #region skonto

        public decimal? DiscountPercentage { get; set; }
        /// <summary>
        /// Invoice count of days until due date to pay total amount
        /// </summary>
        public int? DiscountDaysUntilDue { get; set; }


        #endregion
    }
}
