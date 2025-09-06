using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itx.files.pdf.zugferd
{
    //
    // Zusammenfassung:
    //     This class holds information about a bank account. The class is used in different
    //     places, e.g. for holding supplier and customer bank information
    public class BankAccount
    {

        /// <summary>
        /// Bank where account is held
        /// </summary>
        public Bank Bank { get; set; }
        //
        // Zusammenfassung:
        //     National account number (not SEPA)
        public string Id { get; set; } = string.Empty;

        //
        // Zusammenfassung:
        //     IBAN identifier for the bank account. This information is not yet validated.
        public string IBAN { get; set; }

        //
        // Zusammenfassung:
        //     Payment account name
        public string Name { get; set; }
    }
}
