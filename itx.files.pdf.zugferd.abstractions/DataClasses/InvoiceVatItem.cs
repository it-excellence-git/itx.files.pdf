using System.Runtime.CompilerServices;

namespace itx.files.pdf.zugferd
{
    /// <summary>
    /// Represents a VAT (Value Added Tax) item, including the tax rate, base amount, and calculated tax amount.
    /// </summary>
    /// <remarks>This record is used to model VAT details for an invoice. The <see cref="TaxAmount"/> property
    /// is automatically calculated  based on the <see cref="Rate"/> and <see cref="BaseAmount"/>, rounded to two
    /// decimal places.</remarks>
    /// <param name="Rate">The aomount to pay excluding tax for this rate</param>
    /// <param name="BaseAmount">Rate as decimal, e.g. 19m for 19%</param>
    public record class InvoiceVatItem(decimal Rate, decimal BaseAmount)
    {
        /// <summary>
        /// Tax to pay for this rate and amount 
        /// (automatically calculated rounded to 2 fractional digits)
        /// </summary>
        public decimal TaxAmount => GetVatAmount(BaseAmount, Rate);


        private decimal GetVatAmount(decimal baseAmount, decimal rate)
        {
            var tax = SalesRound(baseAmount * rate / 100m);
            return tax;
        }

        private decimal SalesRound(decimal amount)
        {
            return Math.Floor(amount * 100m + 0.5m) / 100m;
        }
    }
}
