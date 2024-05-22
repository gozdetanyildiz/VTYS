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
            /*com.Connection = con;
            com.CommandText = "SELECT * FROM SistemKullanicilari WHERE kullanici_adi=@user AND sifre=@password";
            com.Parameters.AddWithValue("@user", user);
            com.Parameters.AddWithValue("@password", password);
            dr = com.ExecuteReader();
            */

            DataSet ds = new DataSet();
            string sql2 = "select * from SistemKullanicilari where kullanici_adi = '" + user + "'and sifre = '" + password + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql2, con);
            ds = new DataSet();
            da.Fill(ds, "KULLANICIDENEME");

            if (ds.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show("Tebrikler Giriş Başarılı");
                string kulad = ds.Tables[0].Rows[0]["kullanici_adi"].ToString();
                string kulid = ds.Tables[0].Rows[0]["kullanici_id"].ToString();


                Classes.KullanıcıBilgileri.KullaniciAd =kulad;
                Classes.KullanıcıBilgileri.KullaniciID = Convert.ToInt32(kulid);

                switch (selectedOption)
                {
                    case "Müşteri Temsilcisi":
                        musteritemForm form1 = new musteritemForm(); // Asistan için formu oluştur
                        form1.Show();
                        break;
                    case "Takım Lideri":
                        takimlidForm form2 = new takimlidForm(); // Takım lideri için formu oluştur
                        form2.Show();
                        break;
                    case "Grup Yöneticisi":
                        grupyoneticisiform form3 = new grupyoneticisiform(); // Grup yöneticisi için formu oluştur
                        form3.Show();
                        break;
                    default:
                        MessageBox.Show("Geçersiz kullanıcı rolü!");
                        break;
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
