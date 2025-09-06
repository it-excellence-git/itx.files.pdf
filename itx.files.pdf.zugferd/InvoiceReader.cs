using s2industries.ZUGFeRD;
using s2industries.ZUGFeRD.PDF;

namespace itx.files.pdf.zugferd
{
    public class InvoiceReader
    {
        public string PdfSourceFilename { get; init; }

        public InvoiceDescriptor? Descriptor { get; private set; }

        public InvoiceReader(string pdfSourceFilename)
        {
            PdfSourceFilename = pdfSourceFilename;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task Read()
        {


            Descriptor = await InvoicePdfProcessor.LoadFromPdfAsync(PdfSourceFilename);
        }
    }
}
