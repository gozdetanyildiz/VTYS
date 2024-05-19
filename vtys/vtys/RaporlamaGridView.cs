using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vtys
{
    public partial class RaporlamaGridView : Form
    {
        public RaporlamaGridView()
        {
            InitializeComponent();
        }

        private void RaporlamaGridView_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'ornekDataSet1.Musteri_Bilgi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.musteri_BilgiTableAdapter.Fill(this.ornekDataSet1.Musteri_Bilgi);

        }
    }
}
