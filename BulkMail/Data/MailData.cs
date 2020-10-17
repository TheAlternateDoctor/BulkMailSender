using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkMail.Data
{
    public class MailData
    {
        public String Nom{ get; set; }
        public List<String> EmailList { get; set; }
        public object[] Email { get; set;  }
        public List<String> PiecesJointes { get; set; }
        public bool isLoaded { get; set; }
        public String Filepath { get; set; }

        public String SMTPServer { get; set; }
        public int Port { get; set; }
        public String Username { get; set; }
        public String Password { get; set; }

        public MailData(bool isLoaded)
        {
            this.isLoaded = isLoaded;
            Email = new object[3];
            EmailList = new List<string>();
            PiecesJointes = new List<string>();
        }

        protected void EscapeStrings()
        {

        }
    }
}
