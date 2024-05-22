using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace vtys
{
    public partial class yenicagriForm : Form
    {
        private readonly string connectionString = "Data Source=DESKTOP-8D4PG33\\SQLEXPRESS;Initial Catalog=Ornek;Integrated Security=True";

        public yenicagriForm()
        {
            InitializeComponent();
            LoadComboBoxItems();
        }

        private void LoadComboBoxItems()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    SqlCommand com = new SqlCommand("SELECT * FROM Konu", con);
                    SqlDataReader dr = com.ExecuteReader();
                    while (dr.Read())
                    {
                        cmbgorusmekonusu.Items.Add(dr["konu_adi"]);
                    }
                    dr.Close();

                    SqlCommand com2 = new SqlCommand("SELECT * FROM Durum", con);
                    SqlDataReader dr2 = com2.ExecuteReader();
                    while (dr2.Read())
                    {
                        cmbgorusmedurumu.Items.Add(dr2["durum_Adi"]);
                    }
                    dr2.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            try
            {
                string musAdSoyad = txtadsoyad.Text;
                string veriGK = cmbgorusmekonusu.SelectedItem?.ToString();
                int day = DTPtarih.Value.Day;
                int month = DTPtarih.Value.Month;
                int year = DTPtarih.Value.Year;
                DateTime gorusmeTarihi = new DateTime(year, month, day);
                string veriBaslamaSaati = txtbaşlamasaati.Text;
                string veriBitisSaati = txtbitissaati.Text;
                //TimeSpan baslamaSaat = TimeSpan.ParseExact(veriBaslamaSaati, "HH:mm", CultureInfo.InvariantCulture);
                //TimeSpan bitisSaat = TimeSpan.ParseExact(veriBitisSaati, "HH:mm", CultureInfo.InvariantCulture);
                // Başlangıç ve bitiş saatleri arasındaki farkı bulma
                //TimeSpan konusmaSuresi = bitisSaat - baslamaSaat;
                // Konuşma süresini dakika cinsine dönüştürme
                //int konusmaSureDakika = (int)konusmaSuresi.TotalMinutes;
                string veriGD = cmbgorusmedurumu.SelectedItem?.ToString();
                /*string veriADSOYAD = txtadsoyad.Text;
                string veriBaslamaSaati = txtbaşlamasaati.Text;
                string veriBitisSaati = txtbitissaati.Text;
                string veriGK = cmbgorusmekonusu.SelectedItem?.ToString();
                string veriGD = cmbgorusmedurumu.SelectedItem?.ToString();

                DateTime veriTarih = DTPtarih.Value.Date;

                TimeSpan baslamaSaat = TimeSpan.ParseExact(veriBaslamaSaati, "HH:mm", CultureInfo.InvariantCulture);
                TimeSpan bitisSaat = TimeSpan.ParseExact(veriBitisSaati, "HH:mm", CultureInfo.InvariantCulture);
                //veriTarih = veriTarih.Add(baslamaSaat);
                DateTime bitisTarih = veriTarih.Add(bitisSaat - baslamaSaat);
                */

                int islemiyapan = Classes.KullanıcıBilgileri.KullaniciID;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Musteri_Bilgileri (MusAdSoyad, GorusmeKonusu, GorusmeTarihi, GorusmeBaslama, GorusmeBitis, GorusmeDurumu,islemiyapan) VALUES (@MusAdSoyad, @Gorusmekonusu, @GorusmeTarihi, @GorusmeBaslama, @GorusmeBitis, @GorusmeDurumu, @islemiyapan)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MusAdSoyad", musAdSoyad);
                        command.Parameters.AddWithValue("@Gorusmekonusu", veriGK);
                        command.Parameters.AddWithValue("@GorusmeTarihi", gorusmeTarihi);
                        command.Parameters.AddWithValue("@GorusmeBaslama", veriBaslamaSaati);
                        command.Parameters.AddWithValue("@GorusmeBitis", veriBitisSaati);
                        command.Parameters.AddWithValue("@GorusmeDurumu", veriGD);
                        command.Parameters.AddWithValue("@islemiyapan", islemiyapan);

                        int result = command.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Veri başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            mustericagrilistesiForm anasayfa = new mustericagrilistesiForm();
                            anasayfa.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Veri eklenirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
