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
        MailAdressList listeAdress;
        List<String> PiecesJointes = new List<string>();
        public MainView()
        {
            InitializeComponent();
            Console.WriteLine();
            listeAdress = new MailAdressList();
        }

        private void addCampagne_Click(object sender, EventArgs e)
        {
            CampagneAdd addForm = new CampagneAdd();
            addForm.FormClosed += new FormClosedEventHandler(addForm_FormClosed);
            addForm.ShowDialog();

            sauvegarderToolStripMenuItem.Enabled = true;
            sauvegarderSousToolStripMenuItem.Enabled = true;
            envoisToolStripMenuItem.Enabled = true;
        }
        private void addForm_FormClosed(object subSender, FormClosedEventArgs subE)
        {
            Console.WriteLine("Event triggered");
            if (!((CampagneAdd)subSender).CampagneName.Equals("") && ((CampagneAdd)subSender).isClosedClean)
            {
                data = new XMLState(false);
                data.Nom = ((CampagneAdd)subSender).CampagneName;
            }
        }

        private void sauvegarderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!data.isLoaded)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Fichier XML (*.xml)|*.xml";
                saveFileDialog.RestoreDirectory = true;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    data.Filepath = saveFileDialog.FileName;
                }
            }
            SaveXML.SaveFile(data, data.Filepath);
        }

        private void addAdressFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openAdressFile = new OpenFileDialog();
            openAdressFile.Filter = "Fichier TXT (*.txt)|*.txt|Fichier CSV (*.csv)|*.csv";
            if (openAdressFile.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(openAdressFile.FileName);
            }
        }

        private void afficherLaListeDadresseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listeAdress.Show();
        }

        private void mailAttachmentsAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog newPJ = new OpenFileDialog();
            newPJ.Multiselect = true;
            if(newPJ.ShowDialog() == DialogResult.OK)
            {
                foreach (String item in newPJ.FileNames)
                {
                    PiecesJointes.Add(item);
                }
                UpdatePiecesJointes();
            }
        }

        private void UpdatePiecesJointes()
        {
            String totalPJ = "";
            if (PiecesJointes.Count != 0)
            {
                foreach (String pieceJointe in PiecesJointes)
                {
                    String file = pieceJointe.Substring(pieceJointe.LastIndexOf(@"\") + 1);
                    if (PiecesJointes.IndexOf(pieceJointe) == PiecesJointes.Count - 1)
                        totalPJ += file;
                    else
                        totalPJ += file + ", ";
                }
                mailAttachmentsList.Text = totalPJ;
            }
            else
                mailAttachmentsList.Text = "Aucune pièce jointe";
        }

        private void mailAttachmentsList_Click(object sender, EventArgs e)
        {
            List<String> totalPJ = new List<string>();
            foreach (String pieceJointe in PiecesJointes)
            {
                String file = pieceJointe.Substring(pieceJointe.LastIndexOf(@"\") + 1);
                totalPJ.Add(file);
            }
            PiecesJointesView PJView = new PiecesJointesView(totalPJ);
            if(PJView.ShowDialog() == DialogResult.Cancel){
                List<int> removedPiecesJointes = PJView.getIndexesRemoved();
                foreach (int item in removedPiecesJointes)
                {
                    PiecesJointes.RemoveAt(item);
                }
                UpdatePiecesJointes();
            }
        }
    }
}
