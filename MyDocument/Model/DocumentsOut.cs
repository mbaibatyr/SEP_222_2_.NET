using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDocument.Model
{
    internal class DocumentsOut
    {
        public int Id { get; set; }
        public string NameDocument { get; set; }
        public DateTime DateDocument { get; set; }
        public string InitiatePerson { get; set; }
        public string Notes { get; set; }
        public string ScanFileName { get; set; }
    }
}
