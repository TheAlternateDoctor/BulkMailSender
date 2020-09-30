using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkMail.xml
{
    public class XMLState
    {
        public String Nom{ get; set; }
        public List<String> EmailList { get; set; }
        public object[] Email { get; set;  }
        public List<String> PiecesJointes { get; set; }

        public XMLState()
        {
            Email = new object[3];
        }

        protected void EscapeStrings()
        {

        }
    }
}
