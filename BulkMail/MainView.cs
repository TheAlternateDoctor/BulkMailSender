using BulkMail.xml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BulkMail
{
    public partial class MainView : Form
    {
        XMLState data;
        public MainView()
        {
            InitializeComponent();
            Console.WriteLine();
        }

        private void addCampagne_Click(object sender, EventArgs e)
        {
            CampagneAdd addForm = new CampagneAdd();
            addForm.FormClosed += new FormClosedEventHandler(addForm_FormClosed);
            addForm.ShowDialog();
            
            sauvegarderToolStripMenuItem.Enabled = true;
        }
        private void addForm_FormClosed(object subSender, FormClosedEventArgs subE)
        {
            Console.WriteLine("Event triggered");
            if (!((CampagneAdd)subSender).CampagneName.Equals("") && ((CampagneAdd)subSender).isClosedClean)
            {
                data = new XMLState();
                data.Nom = ((CampagneAdd)subSender).CampagneName;
            }
        }

        private void sauvegarderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveXML.SaveFile(data,"test.xml");
        }
    }
}
