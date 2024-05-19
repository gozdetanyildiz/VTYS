using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vtys
{
    public partial class mustericagrilistesiForm : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-8D4PG33\\SQLEXPRESS;Initial Catalog=Ornek;Integrated Security=True");
        SqlCommandBuilder commandBuilder;
        SqlDataAdapter adtr;
        DataTable tbl = new DataTable();

        public mustericagrilistesiForm()
        {
            InitializeComponent();
            GetList();
        }

        DataTable GetList()
        {
            tbl.Clear();
            adtr = new SqlDataAdapter("Select * from Musteri_Bilgi", connection);
            adtr.Fill(tbl);
            DataGridView1.DataSource = tbl;
            return tbl;
        }


        private void raporla_Click(object sender, EventArgs e)
        {
            commandBuilder = new SqlCommandBuilder(adtr);
            adtr.Update(tbl);
            GetList();
           // yenicagriForm yenicagriForm = new yenicagriForm();
            //yenicagriForm.ShowDialog();

        }

        private void mustericagrilistesiForm_Load(object sender, EventArgs e)
        {

        }

        private void yenicagribtn_Click(object sender, EventArgs e)
        {
             yenicagriForm yenicagriForm = new yenicagriForm();
             yenicagriForm.ShowDialog();
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
