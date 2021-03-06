﻿using BulkMail.Data;
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
        MailData data;
        MailAdressList listeAdress;
        List<String> PiecesJointes = new List<string>();
        DataDAO dataDAO = new DataDAO();
        public MainView()
        {
            InitializeComponent();
            Console.WriteLine();
            listeAdress = new MailAdressList();
        }

        private void UpdateFields()
        {
            mailSender.Text = (String)data.Email[1];
            mailObject.Text = (String)data.Email[0];
            mailContent.Text = (String)data.Email[2];
            PiecesJointes = data.PiecesJointes;
            UpdatePiecesJointes();
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
                data = new MailData(false);
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
            dataDAO.saveData(data, data.Filepath);
        }

        private void addAdressFileButton_Click(object sender, EventArgs e)
        {
            List<String> Adresses = FileUtils.importMailList();
            listeAdress.AddAdressList(Adresses);
            listeAdress.Show();
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

        private void send_Click(object sender, EventArgs e)
        {

        }

        private void SMTPitem_Click(object sender, EventArgs e)
        {
            SMTPsettings settings = new SMTPsettings();
            if(settings.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void openAttachments_Click(object sender, EventArgs e)
        {
            List<String> totalPJ = new List<string>();
            foreach (String pieceJointe in PiecesJointes)
            {
                String file = pieceJointe.Substring(pieceJointe.LastIndexOf(@"\") + 1);
                totalPJ.Add(file);
            }
            PiecesJointesView PJView = new PiecesJointesView(totalPJ);
            if (PJView.ShowDialog() == DialogResult.Cancel)
            {
                List<int> removedPiecesJointes = PJView.getIndexesRemoved();
                foreach (int item in removedPiecesJointes)
                {
                    PiecesJointes.RemoveAt(item);
                }
                UpdatePiecesJointes();
            }
        }

        private void chargerUneCampagneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openXML = new OpenFileDialog();
            openXML.Filter = "Fichier XML (*.xml)|*.xml";
            if(openXML.ShowDialog() == DialogResult.OK)
            {
                data = dataDAO.loadData(openXML.FileName);
                UpdateFields();
                sauvegarderToolStripMenuItem.Enabled = true;
                sauvegarderSousToolStripMenuItem.Enabled = true;
                envoisToolStripMenuItem.Enabled = true;
            }
        }
    }
}
