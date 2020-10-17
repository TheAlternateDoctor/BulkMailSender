using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BulkMail
{
    public partial class SMTPsettings : Form
    {
        public SMTPsettings()
        {
            InitializeComponent();
        }

        public String getServer()
        {
            return serverName.Text;
        }
        public int getPort()
        {
            return int.Parse(portNumber.Text);
        }
        public String getUsername()
        {
            return serverName.Text;
        }
        public String getPassword()
        {
            return serverName.Text;
        }
    }
}
