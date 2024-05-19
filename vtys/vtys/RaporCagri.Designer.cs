namespace vtys
{
    partial class RaporCagri
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
            this.btnRapor = new System.Windows.Forms.Button();
            this.btnYeniCagri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRapor
            // 
            this.btnRapor.Location = new System.Drawing.Point(56, 197);
            this.btnRapor.Name = "btnRapor";
            this.btnRapor.Size = new System.Drawing.Size(164, 95);
            this.btnRapor.TabIndex = 0;
            this.btnRapor.Text = "RAPORLAR";
            this.btnRapor.UseVisualStyleBackColor = true;
            // 
            // btnYeniCagri
            // 
            this.btnYeniCagri.Location = new System.Drawing.Point(301, 197);
            this.btnYeniCagri.Name = "btnYeniCagri";
            this.btnYeniCagri.Size = new System.Drawing.Size(164, 95);
            this.btnYeniCagri.TabIndex = 0;
            this.btnYeniCagri.Text = "YENİ ÇAĞRI";
            this.btnYeniCagri.UseVisualStyleBackColor = true;
            this.btnYeniCagri.Click += new System.EventHandler(this.btnYeniCagri_Click);
            // 
            // RaporCagri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 518);
            this.Controls.Add(this.btnYeniCagri);
            this.Controls.Add(this.btnRapor);
            this.Name = "RaporCagri";
            this.Text = "RaporCagri";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRapor;
        private System.Windows.Forms.Button btnYeniCagri;
    }
}