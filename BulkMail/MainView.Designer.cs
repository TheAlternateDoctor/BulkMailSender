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
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.sauvegarderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sauvegarderSousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.envoisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnFichierDadressesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherLaListeDadresseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autonettoyageDesDoublonsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exporterLaListeDadressesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.paramètresSMTPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
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
            this.addCampagne.Size = new System.Drawing.Size(249, 22);
            this.addCampagne.Text = "Démarrer une campagne";
            this.addCampagne.Click += new System.EventHandler(this.addCampagne_Click);
            // 
            // chargerUneCampagneToolStripMenuItem
            // 
            this.chargerUneCampagneToolStripMenuItem.Name = "chargerUneCampagneToolStripMenuItem";
            this.chargerUneCampagneToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.chargerUneCampagneToolStripMenuItem.Text = "Charger une campagne";
            // 
            // loadRecent
            // 
            this.loadRecent.Name = "loadRecent";
            this.loadRecent.Size = new System.Drawing.Size(249, 22);
            this.loadRecent.Text = "Charger une campagne récente...";
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
            this.ajouterUnFichierDadressesToolStripMenuItem,
            this.afficherLaListeDadresseToolStripMenuItem,
            this.autonettoyageDesDoublonsToolStripMenuItem,
            this.exporterLaListeDadressesToolStripMenuItem,
            this.toolStripMenuItem3,
            this.paramètresSMTPToolStripMenuItem});
            this.envoisToolStripMenuItem.Name = "envoisToolStripMenuItem";
            this.envoisToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.envoisToolStripMenuItem.Text = "Envois";
            // 
            // ajouterUnFichierDadressesToolStripMenuItem
            // 
            this.ajouterUnFichierDadressesToolStripMenuItem.Name = "ajouterUnFichierDadressesToolStripMenuItem";
            this.ajouterUnFichierDadressesToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.ajouterUnFichierDadressesToolStripMenuItem.Text = "Ajouter un fichier d\'adresses";
            // 
            // afficherLaListeDadresseToolStripMenuItem
            // 
            this.afficherLaListeDadresseToolStripMenuItem.Name = "afficherLaListeDadresseToolStripMenuItem";
            this.afficherLaListeDadresseToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.afficherLaListeDadresseToolStripMenuItem.Text = "Afficher la liste d\'adresses";
            // 
            // autonettoyageDesDoublonsToolStripMenuItem
            // 
            this.autonettoyageDesDoublonsToolStripMenuItem.Name = "autonettoyageDesDoublonsToolStripMenuItem";
            this.autonettoyageDesDoublonsToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.autonettoyageDesDoublonsToolStripMenuItem.Text = "Autonettoyage des doublons";
            // 
            // exporterLaListeDadressesToolStripMenuItem
            // 
            this.exporterLaListeDadressesToolStripMenuItem.Name = "exporterLaListeDadressesToolStripMenuItem";
            this.exporterLaListeDadressesToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.exporterLaListeDadressesToolStripMenuItem.Text = "Exporter la liste d\'adresses";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(224, 6);
            // 
            // paramètresSMTPToolStripMenuItem
            // 
            this.paramètresSMTPToolStripMenuItem.Name = "paramètresSMTPToolStripMenuItem";
            this.paramètresSMTPToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.paramètresSMTPToolStripMenuItem.Text = "Paramètres SMTP";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainView";
            this.Text = "Form1";
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
        private System.Windows.Forms.ToolStripMenuItem paramètresSMTPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnFichierDadressesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficherLaListeDadresseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autonettoyageDesDoublonsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exporterLaListeDadressesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadRecent;
    }
}

