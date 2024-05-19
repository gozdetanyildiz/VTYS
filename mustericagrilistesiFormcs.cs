using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace vtys
{
    public partial class mustericagrilistesiForm : Form
    {
        // Veritabanı bağlantı dizesi
        private readonly string connectionString = "Data Source=DESKTOP-8D4PG33\\SQLEXPRESS;Initial Catalog=Ornek;Integrated Security=True";

        public mustericagrilistesiForm()
        {
            InitializeComponent();
            InitializeDataGridView();
            GetList();
        }

        private void InitializeDataGridView()
        {
            // DataGridView sütunlarını tanımla
            DataGridView1.Columns.Add("MusAdSoyad", "Müşteri Adı Soyadı");
            DataGridView1.Columns.Add("GorusmeBaslama", "Görüşme Başlama Saati");
            DataGridView1.Columns.Add("GorusmeBitis", "Görüşme Bitiş Saati");
            DataGridView1.Columns.Add("Gorusmekonusu", "Görüşme Konusu");
            DataGridView1.Columns.Add("GorusmeDurumu", "Görüşme Durumu");
            DataGridView1.Columns.Add("GorusmeTarihi", "Görüşme Tarihi");
        }

        private void GetList()
        {
            try
            {
                // Veritabanından verileri getir
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Musteri_Bilgileri", connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    // DataGridView'e verileri yükle
                    foreach (DataRow row in dataTable.Rows)
                    {
                        DataGridView1.Rows.Add(
                            row["MusAdSoyad"].ToString(),
                            row["GorusmeBaslama"].ToString(),
                            row["GorusmeBitis"].ToString(),
                            row["Gorusmekonusu"].ToString(),
                            row["GorusmeDurumu"].ToString(),
                            row["GorusmeTarihi"].ToString()
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                // Veritabanı bağlantı dizesi
                string connectionString = "Data Source=DESKTOP-8D4PG33\\SQLEXPRESS;Initial Catalog=Ornek;Integrated Security=True";

                // Veritabanındaki değişiklikleri kaydet
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Musteri_Bilgi", connectionString);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                DataGridView1.EndEdit();
                dataAdapter.Update(dataTable);

                MessageBox.Show("Veriler başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void yenicagribtn_Click(object sender, EventArgs e)
        {
            // Yeni çağrı formunu aç
            yenicagriForm yenicagriForm = new yenicagriForm();
            yenicagriForm.FormClosed += (s, args) => {
                // Form kapatıldığında DataGridView'i yenile
                DataGridView1.Rows.Clear();
                GetList();
            };
            this.Hide();
            yenicagriForm.ShowDialog();
            
        }
    }
}
 