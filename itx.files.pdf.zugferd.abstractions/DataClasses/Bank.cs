using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itx.files.pdf.zugferd
{
    public class Bank
    {

        //
        // Zusammenfassung:
        //     Payment service provider identifier
        public string BIC { get; set; } = string.Empty;

        //
        // Zusammenfassung:
        //     Legacy bank identifier
        public string Bankleitzahl { get; set; } = string.Empty;

        //
        // Zusammenfassung:
        //     Clear text name of the bank
        public string Name { get; set; } = string.Empty;
    }
}
