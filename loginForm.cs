using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace vtys
{
    public partial class loginForm : Form
    {
        SqlConnection con;
        SqlDataReader dr;
        SqlCommand com;

        public loginForm()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string selectedOption = cmbyetki.SelectedItem.ToString();
            string user = kullanici_adi.Text;
            string password = sifre.Text;

            con = new SqlConnection("Data Source=DESKTOP-8D4PG33\\SQLEXPRESS;Initial Catalog=Ornek;Integrated Security=True"); //Data Source=DESKTOP-8D4PG33\\SQLEXPRESS;Initial Catalog=Ornek;Integrated Security=True"
            com = new SqlCommand(); 
            con.Open();
            com.Connection = con;
            com.CommandText = "Select*From Kullanici_Bilgi where kullanici_adi='"+user+"'And sifre='"+password+"'";
            dr = com.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Tebrikler Giriş Başarılı");
                if (selectedOption == "Müşteri Temsilcisi")
                {
                    musteritemForm form1 = new musteritemForm(); // Yetki 1'e göre formu oluştur
                    form1.Show();
                }
                else if (selectedOption == "Takım Lideri")
                {
                    takimlidForm form2 = new takimlidForm(); // Yetki 2'ye göre formu oluştur
                    form2.Show();
                }
                else if (selectedOption == "Grup Yöneticisi")
                {
                    grupyoneticisiform form3 = new grupyoneticisiform(); // Yetki 3'e göre formu oluştur
                    form3.Show();
                }
            }
            else
            { 
                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre");
            }
            con.Close();

        }

        private void loginForm_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-8D4PG33\\SQLEXPRESS;Initial Catalog=Ornek;Integrated Security=True");
            SqlCommand com = new SqlCommand("SELECT * FROM Yetkiler",con);
            SqlDataReader dr;
            con.Open();
            dr = com.ExecuteReader();

            while (dr.Read())
            {
                cmbyetki.Items.Add(dr["yetkiler"]);
                
            }
            con.Close();
            if (con.State != ConnectionState.Closed) //con kapanıp kapanmadığını kontrol eden kod
            {
                con.Close();
            }


        }
    }
}
