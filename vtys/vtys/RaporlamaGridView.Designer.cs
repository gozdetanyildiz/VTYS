namespace vtys
{
    partial class RaporlamaGridView
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ornekDataSet1 = new vtys.OrnekDataSet1();
            this.musteriBilgiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.musteri_BilgiTableAdapter = new vtys.OrnekDataSet1TableAdapters.Musteri_BilgiTableAdapter();
            this.musAdSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gorusmekonusuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gorusmeTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gorusmeBaslamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gorusmeBitisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gorusmeDurumuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ornekDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriBilgiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.musAdSoyadDataGridViewTextBoxColumn,
            this.gorusmekonusuDataGridViewTextBoxColumn,
            this.gorusmeTarihiDataGridViewTextBoxColumn,
            this.gorusmeBaslamaDataGridViewTextBoxColumn,
            this.gorusmeBitisDataGridViewTextBoxColumn,
            this.gorusmeDurumuDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.musteriBilgiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(30, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 371);
            this.dataGridView1.TabIndex = 0;
            // 
            // ornekDataSet1
            // 
            this.ornekDataSet1.DataSetName = "OrnekDataSet1";
            this.ornekDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // musteriBilgiBindingSource
            // 
            this.musteriBilgiBindingSource.DataMember = "Musteri_Bilgi";
            this.musteriBilgiBindingSource.DataSource = this.ornekDataSet1;
            // 
            // musteri_BilgiTableAdapter
            // 
            this.musteri_BilgiTableAdapter.ClearBeforeFill = true;
            // 
            // musAdSoyadDataGridViewTextBoxColumn
            // 
            this.musAdSoyadDataGridViewTextBoxColumn.DataPropertyName = "MusAdSoyad";
            this.musAdSoyadDataGridViewTextBoxColumn.HeaderText = "MusAdSoyad";
            this.musAdSoyadDataGridViewTextBoxColumn.Name = "musAdSoyadDataGridViewTextBoxColumn";
            // 
            // gorusmekonusuDataGridViewTextBoxColumn
            // 
            this.gorusmekonusuDataGridViewTextBoxColumn.DataPropertyName = "Gorusmekonusu";
            this.gorusmekonusuDataGridViewTextBoxColumn.HeaderText = "Gorusmekonusu";
            this.gorusmekonusuDataGridViewTextBoxColumn.Name = "gorusmekonusuDataGridViewTextBoxColumn";
            // 
            // gorusmeTarihiDataGridViewTextBoxColumn
            // 
            this.gorusmeTarihiDataGridViewTextBoxColumn.DataPropertyName = "GorusmeTarihi";
            this.gorusmeTarihiDataGridViewTextBoxColumn.HeaderText = "GorusmeTarihi";
            this.gorusmeTarihiDataGridViewTextBoxColumn.Name = "gorusmeTarihiDataGridViewTextBoxColumn";
            // 
            // gorusmeBaslamaDataGridViewTextBoxColumn
            // 
            this.gorusmeBaslamaDataGridViewTextBoxColumn.DataPropertyName = "GorusmeBaslama";
            this.gorusmeBaslamaDataGridViewTextBoxColumn.HeaderText = "GorusmeBaslama";
            this.gorusmeBaslamaDataGridViewTextBoxColumn.Name = "gorusmeBaslamaDataGridViewTextBoxColumn";
            // 
            // gorusmeBitisDataGridViewTextBoxColumn
            // 
            this.gorusmeBitisDataGridViewTextBoxColumn.DataPropertyName = "GorusmeBitis";
            this.gorusmeBitisDataGridViewTextBoxColumn.HeaderText = "GorusmeBitis";
            this.gorusmeBitisDataGridViewTextBoxColumn.Name = "gorusmeBitisDataGridViewTextBoxColumn";
            // 
            // gorusmeDurumuDataGridViewTextBoxColumn
            // 
            this.gorusmeDurumuDataGridViewTextBoxColumn.DataPropertyName = "GorusmeDurumu";
            this.gorusmeDurumuDataGridViewTextBoxColumn.HeaderText = "GorusmeDurumu";
            this.gorusmeDurumuDataGridViewTextBoxColumn.Name = "gorusmeDurumuDataGridViewTextBoxColumn";
            // 
            // RaporlamaGridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 474);
            this.Controls.Add(this.dataGridView1);
            this.Name = "RaporlamaGridView";
            this.Text = "RaporlamaGridView";
            this.Load += new System.EventHandler(this.RaporlamaGridView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ornekDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriBilgiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private OrnekDataSet1 ornekDataSet1;
        private System.Windows.Forms.BindingSource musteriBilgiBindingSource;
        private OrnekDataSet1TableAdapters.Musteri_BilgiTableAdapter musteri_BilgiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn musAdSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gorusmekonusuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gorusmeTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gorusmeBaslamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gorusmeBitisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gorusmeDurumuDataGridViewTextBoxColumn;
    }
}