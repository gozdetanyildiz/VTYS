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

    public partial class yenicagriForm : Form
    {
        /*SqlConnection con;
        SqlDataReader dr;
        SqlCommand com;
        SqlDataAdapter da;*/

        public yenicagriForm()
        {
            InitializeComponent();
        }
        /*void MusteriGetir()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-8D4PG33\\SQLEXPRESS;Initial Catalog=Ornek;Integrated Security=True");
            con.Open();
            da = new SqlDataAdapter("SELECT *FROM Musteri_Bilgi", con);
            DataTable Tablo= new DataTable(); 
            da.Fill(Tablo);

        }*/

        private void yenicagriForm_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-8D4PG33\\SQLEXPRESS;Initial Catalog=Ornek;Integrated Security=True"))
            {
                SqlCommand com = new SqlCommand("SELECT * FROM Gorusme_Konusu", con);
                SqlCommand com2 = new SqlCommand("SELECT * FROM Gorusme_Durumu", con);
                SqlDataReader dr;
                SqlDataReader dr2;

                // Bağlantıyı aç
                con.Open();

                // İlk sorguyu çalıştır
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    cmbgorusmekonusu.Items.Add(dr["gorusmekonusu"]);
                }
                dr.Close(); // İlk SqlDataReader'ı kapat

                // İkinci sorguyu çalıştır
                dr2 = com2.ExecuteReader();
                while (dr2.Read())
                {
                    cmbgorusmedurumu.Items.Add(dr2["gorusme_durumu"]);
                }
                dr2.Close(); // İkinci SqlDataReader'ı kapat

                // Bağlantıyı kapat
                con.Close();


            }
        }

        private void btnekle_Click(object sender, EventArgs e)
        {

        }
    }
}
