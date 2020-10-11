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
    public partial class MailAdressList : Form
    {
        private List<String> Adresses = new List<string>();
        public MailAdressList()
        {
            InitializeComponent();
            Adresses.Add("Test");
            Adresses.Add("Test2");
            Adresses.Add("Test");
            ListAdresses.Items.Add("Test");
            ListAdresses.Items.Add("Test2");
            ListAdresses.Items.Add("Test");
        }

        private void AddAdress_Click(object sender, EventArgs e)
        {
            ListViewItem newAddresse = new ListViewItem("");
            ListAdresses.Items.Add(newAddresse);
            ListAdresses.SelectedIndices.Clear();
            ListAdresses.Items[ListAdresses.Items.Count-1].BeginEdit();
        }

        private void ListAdresses_DoubleClick(object sender, EventArgs e)
        {
            ListAdresses.SelectedItems[0].BeginEdit();
        }

        private void ListAdresses_KeyPress(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            {
                foreach (ListViewItem item in ListAdresses.SelectedItems)
                {
                    Adresses.Remove(item.Text);
                    ListAdresses.Items.Remove(item);
                }
            }
        }

        private void ListAdresses_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            string newaddress = e.Label;
            int index = ListAdresses.Items.IndexOf(ListAdresses.SelectedItems[0]);
            Adresses.Add(newaddress);
        }

        private void removeDoubles(object sender, EventArgs e)
        {
            Adresses = Adresses.Distinct().ToList();
            ListAdresses.Items.Clear();
            foreach (String adresse in Adresses)
            {
                ListAdresses.Items.Add(adresse);
            }
        }

        private void exporter(object sender, EventArgs e)
        {
            OpenFileDialog exportFile = new OpenFileDialog();
            if(exportFile.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllLines(exportFile.FileName, Adresses);
            }
        }

        private void remove_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in ListAdresses.SelectedItems)
            {
                Adresses.Remove(item.Text);
                ListAdresses.Items.Remove(item);
            }
        }

        private void MailAdressList_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }
    }
}
