namespace itx.files.pdf.zugferd
{
    public class InvoiceVatItems 
    {
        private List<InvoiceVatItem> _items = new List<InvoiceVatItem>();

        public IEnumerable<InvoiceVatItem> Items => _items.ToArray();

        public InvoiceVatItems Add(decimal rate, decimal baseAmount)
        {
            var existing = _items.FirstOrDefault(i => i.Rate == rate);
            if (existing != null)
            {
                throw new ArgumentException("The rate item of an ivoice mis required to be unique. Calculate the total amount for this rate before.");
            }
            else
            {
                _items.Add(new InvoiceVatItem(rate, baseAmount));
            }
            return this;
        }
    }
}
