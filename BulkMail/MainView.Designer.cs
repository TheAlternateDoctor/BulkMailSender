namespace BulkMail
{
    partial class MainView
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCampagne = new System.Windows.Forms.ToolStripMenuItem();
            this.chargerUneCampagneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadRecent = new System.Windows.Forms.ToolStripMenuItem();
            this.noToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.sauvegarderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sauvegarderSousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.envoisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAdressFileButton = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherLaListeDadresseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.SMTPitem = new System.Windows.Forms.ToolStripMenuItem();
            this.mailContent = new System.Windows.Forms.RichTextBox();
            this.send = new System.Windows.Forms.Button();
            this.mailSender = new System.Windows.Forms.TextBox();
            this.mailObject = new System.Windows.Forms.TextBox();
            this.mailSenderLabel = new System.Windows.Forms.Label();
            this.mailObjectLabel = new System.Windows.Forms.Label();
            this.mailContentLabel = new System.Windows.Forms.Label();
            this.mail = new System.Windows.Forms.Label();
            this.mailAttachmentsList = new System.Windows.Forms.Label();
            this.mailAttachmentsAdd = new System.Windows.Forms.Button();
            this.openAttachments = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.envoisToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(562, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCampagne,
            this.chargerUneCampagneToolStripMenuItem,
            this.loadRecent,
            this.toolStripMenuItem1,
            this.sauvegarderToolStripMenuItem,
            this.sauvegarderSousToolStripMenuItem,
            this.toolStripMenuItem2,
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // addCampagne
            // 
            this.addCampagne.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.addCampagne.Name = "addCampagne";
            this.addCampagne.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.addCampagne.Size = new System.Drawing.Size(249, 22);
            this.addCampagne.Text = "Démarrer une campagne";
            this.addCampagne.Click += new System.EventHandler(this.addCampagne_Click);
            // 
            // chargerUneCampagneToolStripMenuItem
            // 
            this.chargerUneCampagneToolStripMenuItem.Name = "chargerUneCampagneToolStripMenuItem";
            this.chargerUneCampagneToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.chargerUneCampagneToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.chargerUneCampagneToolStripMenuItem.Text = "Charger une campagne";
            this.chargerUneCampagneToolStripMenuItem.Click += new System.EventHandler(this.chargerUneCampagneToolStripMenuItem_Click);
            // 
            // loadRecent
            // 
            this.loadRecent.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noToolStripMenuItem});
            this.loadRecent.Enabled = false;
            this.loadRecent.Name = "loadRecent";
            this.loadRecent.Size = new System.Drawing.Size(249, 22);
            this.loadRecent.Text = "Charger une campagne récente...";
            // 
            // noToolStripMenuItem
            // 
            this.noToolStripMenuItem.Name = "noToolStripMenuItem";
            this.noToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.noToolStripMenuItem.Text = "No";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(246, 6);
            // 
            // sauvegarderToolStripMenuItem
            // 
            this.sauvegarderToolStripMenuItem.Enabled = false;
            this.sauvegarderToolStripMenuItem.Name = "sauvegarderToolStripMenuItem";
            this.sauvegarderToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.sauvegarderToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.sauvegarderToolStripMenuItem.Text = "Sauvegarder";
            this.sauvegarderToolStripMenuItem.Click += new System.EventHandler(this.sauvegarderToolStripMenuItem_Click);
            // 
            // sauvegarderSousToolStripMenuItem
            // 
            this.sauvegarderSousToolStripMenuItem.Enabled = false;
            this.sauvegarderSousToolStripMenuItem.Name = "sauvegarderSousToolStripMenuItem";
            this.sauvegarderSousToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.sauvegarderSousToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.sauvegarderSousToolStripMenuItem.Text = "Sauvegarder sous";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(246, 6);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            // 
            // envoisToolStripMenuItem
            // 
            this.envoisToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAdressFileButton,
            this.afficherLaListeDadresseToolStripMenuItem,
            this.toolStripMenuItem3,
            this.SMTPitem});
            this.envoisToolStripMenuItem.Enabled = false;
            this.envoisToolStripMenuItem.Name = "envoisToolStripMenuItem";
            this.envoisToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.envoisToolStripMenuItem.Text = "Envois";
            // 
            // addAdressFileButton
            // 
            this.addAdressFileButton.Name = "addAdressFileButton";
            this.addAdressFileButton.Size = new System.Drawing.Size(223, 22);
            this.addAdressFileButton.Text = "Ajouter un fichier d\'adresses";
            this.addAdressFileButton.Click += new System.EventHandler(this.addAdressFileButton_Click);
            // 
            // afficherLaListeDadresseToolStripMenuItem
            // 
            this.afficherLaListeDadresseToolStripMenuItem.Name = "afficherLaListeDadresseToolStripMenuItem";
            this.afficherLaListeDadresseToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.afficherLaListeDadresseToolStripMenuItem.Text = "Afficher la liste d\'adresses";
            this.afficherLaListeDadresseToolStripMenuItem.Click += new System.EventHandler(this.afficherLaListeDadresseToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(220, 6);
            // 
            // SMTPitem
            // 
            this.SMTPitem.Name = "SMTPitem";
            this.SMTPitem.Size = new System.Drawing.Size(223, 22);
            this.SMTPitem.Text = "Paramètres SMTP";
            this.SMTPitem.Click += new System.EventHandler(this.SMTPitem_Click);
            // 
            // mailContent
            // 
            this.mailContent.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mailContent.Location = new System.Drawing.Point(12, 130);
            this.mailContent.Name = "mailContent";
            this.mailContent.Size = new System.Drawing.Size(538, 256);
            this.mailContent.TabIndex = 1;
            this.mailContent.Text = "";
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(12, 392);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(95, 46);
            this.send.TabIndex = 2;
            this.send.Text = "Envoyer";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // mailSender
            // 
            this.mailSender.Location = new System.Drawing.Point(12, 52);
            this.mailSender.Name = "mailSender";
            this.mailSender.Size = new System.Drawing.Size(251, 20);
            this.mailSender.TabIndex = 3;
            // 
            // mailObject
            // 
            this.mailObject.Location = new System.Drawing.Point(12, 91);
            this.mailObject.Name = "mailObject";
            this.mailObject.Size = new System.Drawing.Size(538, 20);
            this.mailObject.TabIndex = 4;
            // 
            // mailSenderLabel
            // 
            this.mailSenderLabel.AutoSize = true;
            this.mailSenderLabel.Location = new System.Drawing.Point(12, 36);
            this.mailSenderLabel.Name = "mailSenderLabel";
            this.mailSenderLabel.Size = new System.Drawing.Size(60, 13);
            this.mailSenderLabel.TabIndex = 5;
            this.mailSenderLabel.Text = "Expéditeur:";
            // 
            // mailObjectLabel
            // 
            this.mailObjectLabel.AutoSize = true;
            this.mailObjectLabel.Location = new System.Drawing.Point(12, 75);
            this.mailObjectLabel.Name = "mailObjectLabel";
            this.mailObjectLabel.Size = new System.Drawing.Size(35, 13);
            this.mailObjectLabel.TabIndex = 6;
            this.mailObjectLabel.Text = "Objet:";
            // 
            // mailContentLabel
            // 
            this.mailContentLabel.AutoSize = true;
            this.mailContentLabel.Location = new System.Drawing.Point(12, 114);
            this.mailContentLabel.Name = "mailContentLabel";
            this.mailContentLabel.Size = new System.Drawing.Size(86, 13);
            this.mailContentLabel.TabIndex = 7;
            this.mailContentLabel.Text = "Contenu du mail:";
            // 
            // mail
            // 
            this.mail.AutoSize = true;
            this.mail.Location = new System.Drawing.Point(270, 36);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(78, 13);
            this.mail.TabIndex = 8;
            this.mail.Text = "Pièces Jointes:";
            // 
            // mailAttachmentsList
            // 
            this.mailAttachmentsList.AutoEllipsis = true;
            this.mailAttachmentsList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mailAttachmentsList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mailAttachmentsList.Location = new System.Drawing.Point(269, 52);
            this.mailAttachmentsList.Name = "mailAttachmentsList";
            this.mailAttachmentsList.Size = new System.Drawing.Size(179, 20);
            this.mailAttachmentsList.TabIndex = 9;
            this.mailAttachmentsList.Text = "Aucune pièce jointe";
            this.mailAttachmentsList.DoubleClick += new System.EventHandler(this.mailAttachmentsList_Click);
            // 
            // mailAttachmentsAdd
            // 
            this.mailAttachmentsAdd.Location = new System.Drawing.Point(528, 26);
            this.mailAttachmentsAdd.Name = "mailAttachmentsAdd";
            this.mailAttachmentsAdd.Size = new System.Drawing.Size(22, 23);
            this.mailAttachmentsAdd.TabIndex = 10;
            this.mailAttachmentsAdd.Text = "+";
            this.mailAttachmentsAdd.UseVisualStyleBackColor = true;
            this.mailAttachmentsAdd.Click += new System.EventHandler(this.mailAttachmentsAdd_Click);
            // 
            // openAttachments
            // 
            this.openAttachments.Location = new System.Drawing.Point(454, 52);
            this.openAttachments.Name = "openAttachments";
            this.openAttachments.Size = new System.Drawing.Size(96, 20);
            this.openAttachments.TabIndex = 11;
            this.openAttachments.Text = "Ouvrir";
            this.openAttachments.UseVisualStyleBackColor = true;
            this.openAttachments.Click += new System.EventHandler(this.openAttachments_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 450);
            this.Controls.Add(this.openAttachments);
            this.Controls.Add(this.mailAttachmentsAdd);
            this.Controls.Add(this.mailAttachmentsList);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.mailContentLabel);
            this.Controls.Add(this.mailObjectLabel);
            this.Controls.Add(this.mailSenderLabel);
            this.Controls.Add(this.mailObject);
            this.Controls.Add(this.mailSender);
            this.Controls.Add(this.send);
            this.Controls.Add(this.mailContent);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainView";
            this.Text = "BulkMail";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCampagne;
        private System.Windows.Forms.ToolStripMenuItem chargerUneCampagneToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sauvegarderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sauvegarderSousToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem envoisToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem SMTPitem;
        private System.Windows.Forms.ToolStripMenuItem addAdressFileButton;
        private System.Windows.Forms.ToolStripMenuItem afficherLaListeDadresseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadRecent;
        private System.Windows.Forms.RichTextBox mailContent;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.TextBox mailSender;
        private System.Windows.Forms.TextBox mailObject;
        private System.Windows.Forms.Label mailSenderLabel;
        private System.Windows.Forms.Label mailObjectLabel;
        private System.Windows.Forms.Label mailContentLabel;
        private System.Windows.Forms.Label mail;
        private System.Windows.Forms.Label mailAttachmentsList;
        private System.Windows.Forms.Button mailAttachmentsAdd;
        private System.Windows.Forms.Button openAttachments;
        private System.Windows.Forms.ToolStripMenuItem noToolStripMenuItem;
    }
}

