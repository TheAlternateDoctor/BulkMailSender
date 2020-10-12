namespace BulkMail
{
    partial class PiecesJointesView
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
            this.AttachmentList = new System.Windows.Forms.ListBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AttachmentList
            // 
            this.AttachmentList.FormattingEnabled = true;
            this.AttachmentList.Location = new System.Drawing.Point(12, 39);
            this.AttachmentList.Name = "AttachmentList";
            this.AttachmentList.Size = new System.Drawing.Size(250, 407);
            this.AttachmentList.TabIndex = 0;
            this.AttachmentList.KeyUp += new System.Windows.Forms.KeyEventHandler(this.AttachmentList_KeyPress);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(12, 10);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(250, 23);
            this.DeleteButton.TabIndex = 1;
            this.DeleteButton.Text = "Supprimer";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.remove_Click);
            // 
            // PiecesJointesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 458);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AttachmentList);
            this.Name = "PiecesJointesView";
            this.Text = "PiecesJointesView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox AttachmentList;
        private System.Windows.Forms.Button DeleteButton;
    }
}