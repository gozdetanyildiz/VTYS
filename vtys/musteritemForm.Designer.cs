namespace vtys
{
    partial class musteritemForm
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
            this.btnmustericagriliste = new System.Windows.Forms.Button();
            this.btnaylikprimliste = new System.Windows.Forms.Button();
            this.btnitirazlarim = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnmustericagriliste
            // 
            this.btnmustericagriliste.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnmustericagriliste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmustericagriliste.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnmustericagriliste.ForeColor = System.Drawing.Color.White;
            this.btnmustericagriliste.Location = new System.Drawing.Point(94, 287);
            this.btnmustericagriliste.Name = "btnmustericagriliste";
            this.btnmustericagriliste.Size = new System.Drawing.Size(206, 46);
            this.btnmustericagriliste.TabIndex = 0;
            this.btnmustericagriliste.Text = "MÜŞTERİ ÇAĞRI LİSTESİ";
            this.btnmustericagriliste.UseVisualStyleBackColor = false;
            this.btnmustericagriliste.Click += new System.EventHandler(this.btnmustericagriliste_Click);
            // 
            // btnaylikprimliste
            // 
            this.btnaylikprimliste.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnaylikprimliste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaylikprimliste.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnaylikprimliste.ForeColor = System.Drawing.Color.White;
            this.btnaylikprimliste.Location = new System.Drawing.Point(94, 339);
            this.btnaylikprimliste.Name = "btnaylikprimliste";
            this.btnaylikprimliste.Size = new System.Drawing.Size(206, 46);
            this.btnaylikprimliste.TabIndex = 1;
            this.btnaylikprimliste.Text = "AYLIK PRİM LİSTESİ";
            this.btnaylikprimliste.UseVisualStyleBackColor = false;
            this.btnaylikprimliste.Click += new System.EventHandler(this.btnaylikprimliste_Click);
            // 
            // btnitirazlarim
            // 
            this.btnitirazlarim.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnitirazlarim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnitirazlarim.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnitirazlarim.ForeColor = System.Drawing.Color.White;
            this.btnitirazlarim.Location = new System.Drawing.Point(94, 391);
            this.btnitirazlarim.Name = "btnitirazlarim";
            this.btnitirazlarim.Size = new System.Drawing.Size(206, 43);
            this.btnitirazlarim.TabIndex = 2;
            this.btnitirazlarim.Text = "İTİRAZLARIM";
            this.btnitirazlarim.UseVisualStyleBackColor = false;
            this.btnitirazlarim.Click += new System.EventHandler(this.btnitirazlarim_Click);
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(94, 148);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(206, 91);
            this.listBox1.TabIndex = 3;
            // 
            // musteritemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::vtys.Properties.Resources.indir__1_;
            this.ClientSize = new System.Drawing.Size(401, 600);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnitirazlarim);
            this.Controls.Add(this.btnaylikprimliste);
            this.Controls.Add(this.btnmustericagriliste);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "musteritemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Temsilcisi";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnmustericagriliste;
        private System.Windows.Forms.Button btnaylikprimliste;
        private System.Windows.Forms.Button btnitirazlarim;
        private System.Windows.Forms.ListBox listBox1;
    }
}