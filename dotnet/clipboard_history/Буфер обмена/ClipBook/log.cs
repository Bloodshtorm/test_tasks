using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace ClipBook
{
    public class Log
    {
        public DateTime data;
        public Log()
        {
            Uploads = new List<Upload>();
        }
        public List<Upload> Uploads { get; set; }

    }

    
}
