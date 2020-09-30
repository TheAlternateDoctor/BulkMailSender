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
    public partial class CampagneAdd : Form
    {
        private String _CampagneName;
        public String CampagneName { get => _CampagneName; }
        private bool _CleanClose = false;
        public bool isClosedClean { get => _CleanClose; }
        public CampagneAdd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _CampagneName = nameTextBox.Text;
            _CleanClose = true;
            this.Close();
        }
    }
}
