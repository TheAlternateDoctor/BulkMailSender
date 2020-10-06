namespace BulkMail
{
    partial class MailAdressList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ListAdresses = new System.Windows.Forms.ListView();
            this.Adresse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AddAdress = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListAdresses
            // 
            this.ListAdresses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Adresse});
            this.ListAdresses.HideSelection = false;
            this.ListAdresses.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ListAdresses.LabelEdit = true;
            this.ListAdresses.Location = new System.Drawing.Point(9, 48);
            this.ListAdresses.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ListAdresses.Name = "ListAdresses";
            this.ListAdresses.Size = new System.Drawing.Size(583, 307);
            this.ListAdresses.TabIndex = 0;
            this.ListAdresses.UseCompatibleStateImageBehavior = false;
            this.ListAdresses.View = System.Windows.Forms.View.Details;
            this.ListAdresses.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.ListAdresses_AfterLabelEdit);
            this.ListAdresses.DoubleClick += new System.EventHandler(this.ListAdresses_DoubleClick);
            this.ListAdresses.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListAdresses_KeyPress);
            // 
            // Adresse
            // 
            this.Adresse.Text = "Adresse Email";
            this.Adresse.Width = 700;
            // 
            // AddAdress
            // 
            this.AddAdress.Location = new System.Drawing.Point(9, 10);
            this.AddAdress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddAdress.Name = "AddAdress";
            this.AddAdress.Size = new System.Drawing.Size(104, 34);
            this.AddAdress.TabIndex = 1;
            this.AddAdress.Text = "Ajouter une adresse";
            this.AddAdress.UseVisualStyleBackColor = true;
            this.AddAdress.Click += new System.EventHandler(this.AddAdress_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(117, 10);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 34);
            this.button2.TabIndex = 2;
            this.button2.Text = "Enlever les doublons";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.removeDoubles);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(229, 10);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 34);
            this.button3.TabIndex = 3;
            this.button3.Text = "Exporter";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.exporter);
            // 
            // MailAdressList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.AddAdress);
            this.Controls.Add(this.ListAdresses);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MailAdressList";
            this.Text = "MailAdressList";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ListAdresses;
        private System.Windows.Forms.Button AddAdress;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ColumnHeader Adresse;
    }
}