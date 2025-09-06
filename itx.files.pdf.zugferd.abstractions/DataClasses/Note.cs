using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itx.files.pdf.zugferd.abstractions.DataClasses
{
    public class Note
    {
        public string Text { get; set; } = "Default Note Text";
        public itx.edifact.TextSubjectCodes? SubjectCode { get; set; }
    }
}
