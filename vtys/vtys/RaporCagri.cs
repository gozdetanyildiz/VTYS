using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using vtys.OrnekDataSet1TableAdapters;

namespace vtys
{
    public partial class RaporCagri : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-8D4PG33\\SQLEXPRESS;Initial Catalog=Ornek;Integrated Security=True");
        SqlCommandBuilder commandBuilder;
        SqlDataAdapter adtr;
        DataTable tbl = new DataTable();

        public RaporCagri()
        {
            InitializeComponent();
            GetList();
        }

        DataTable GetList()
        {
            tbl.Clear();
            adtr = new SqlDataAdapter("Select * from Musteri_Bilgi", connection);
            adtr.Fill(tbl);
            //DataGridView1.DataSource = tbl;
            return tbl;
        }
        private void btnYeniCagri_Click(object sender, EventArgs e)
        {
            mustericagrilistesiForm mustericagrilistesiForm = new mustericagrilistesiForm();
            mustericagrilistesiForm.ShowDialog();
        }

        private void BtnRapor_Click(object sender, EventArgs e)
        {/*
            // Veritabanı bağlantısı oluştur
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-8D4PG33\\SQLEXPRESS;Initial Catalog=Ornek;Integrated Security=True"))
            {
                connection.Open();
                // Depolanan prosedürü çağırmak için SqlCommand oluştur
                using (SqlCommand command = new SqlCommand("sp_Musteri_Bilgi", connection))
                {
                    // Komut tipini belirt (Depolanan prosedür)
                    command.CommandType = CommandType.StoredProcedure;

                    // Parametre ekle , den sonra bi value gelmesi gerekli ama bulamadım
                    command.Parameters.AddWithValue("@MusAdSoyad", );
                    command.Parameters.AddWithValue("@Gorusmekonusu");
                    command.Parameters.AddWithValue("@GorusmeTarihi", Convert.ToDateTime(GorusmeTarihiDateTimePicker.Value));
                    command.Parameters.AddWithValue("@GorusmeBaslama");
                    command.Parameters.AddWithValue("@GorusmeBitis");
                    command.Parameters.AddWithValue("@GorusmeDurumu");

                    // Komutu çalıştır ve sonucu al
                    SqlDataReader reader = command.ExecuteReader();

                    // Sonuçları işleme
                    while (reader.Read())
                    {
                        // Verileri işleyin, örneğin bir DataGridView'e aktarabilirsiniz
                    }

                    // Reader'ı kapat
                    reader.Close();
            */
        }
    }
}

           // Musteri_Bilgi1 musteri_Bilgi1 = new Musteri_Bilgi1();
           // musteri_Bilgi1.ShowDialog();



