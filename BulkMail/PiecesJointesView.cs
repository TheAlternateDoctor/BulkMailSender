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
    public partial class PiecesJointesView : Form
    {
        List<int> PiecesJointesRemoved = new List<int>();
        List<String> PiecesJointes;
        public PiecesJointesView(List<String> PiecesJointes)
        {
            InitializeComponent();
            foreach (String PieceJointe in PiecesJointes)
            {
                AttachmentList.Items.Add(PieceJointe);
                this.PiecesJointes = PiecesJointes;
            }
        }
        private void remove_Click(object sender, EventArgs e)
        {
            List<int> removedInList = new List<int>();
            foreach (String item in AttachmentList.SelectedItems)
            {
                PiecesJointesRemoved.Add(PiecesJointes.IndexOf(item));
                removedInList.Add(AttachmentList.Items.IndexOf(item));
            }
            foreach (int item in removedInList)
            {
                AttachmentList.Items.RemoveAt(item);
            }
        }
        private void AttachmentList_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                List<int> removedInList = new List<int>();
                foreach (String item in AttachmentList.SelectedItems)
                {
                    PiecesJointesRemoved.Add(PiecesJointes.IndexOf(item));
                    removedInList.Add(AttachmentList.Items.IndexOf(item));
                }
                foreach (int item in removedInList)
                {
                    AttachmentList.Items.RemoveAt(item);
                }
            }
        }
        public List<int> getIndexesRemoved()
        {
            return PiecesJointesRemoved;
        }
    }
}
