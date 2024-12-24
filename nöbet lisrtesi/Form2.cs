using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nöbet_lisrtesi
{

    public partial class Form2 : Form
    {
        // MySQL Bağlantı Dizesi
        string connectionString = "Server=localhost;Database=ameliyathane;Uid=root;Pwd=179212;";
        MySqlConnection connection;

        public Form2()
        {
            InitializeComponent();
            connection = new MySqlConnection(connectionString);

        }


        // DataGridView kolonlarını başlat
        private void btnDagit1_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();

                List<string> ameliyathaneler = new List<string>();
                for (int i = 1; i <= 10; i++)
                    ameliyathaneler.Add($"Ameliyathane {i}");

                string[] meslekler = { "Hemşire", "Operatör Doktor", "Asistan Doktor", "Temizlik Görevlisi", "Anestezi Doktor" };
                DataTable dagitimTable = new DataTable();
                dagitimTable.Columns.Add("Ad Soyad");
                dagitimTable.Columns.Add("Meslek");
                dagitimTable.Columns.Add("Ameliyathane");

                Random rnd = new Random();

                foreach (string meslek in meslekler)
                {
                    string query = "SELECT Id, Ad, Soyad FROM Personel_Ameliyathane WHERE LOWER(TRIM(meslek)) = LOWER(@meslek)";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@meslek", meslek);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show($"'{meslek}' mesleği için dağıtılacak personel bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        continue;
                    }

                    int ameliyathaneIndex = 0;

                    foreach (DataRow personel in dt.Rows)
                    {
                        string personelId = personel["Id"].ToString();
                        string personelAdSoyad = $"{personel["Ad"]} {personel["Soyad"]}";
                        string secilenAmeliyathane = ameliyathaneler[rnd.Next(ameliyathaneler.Count)];

                        string updateQuery = "UPDATE Personel_Ameliyathane SET Ameliyathane = @ameliyathane WHERE Id = @id";
                        MySqlCommand updateCmd = new MySqlCommand(updateQuery, connection);
                        updateCmd.Parameters.AddWithValue("@ameliyathane", secilenAmeliyathane);
                        updateCmd.Parameters.AddWithValue("@id", personelId);
                        updateCmd.ExecuteNonQuery();

                        dagitimTable.Rows.Add(personelAdSoyad, meslek, secilenAmeliyathane);
                    }
                }

                // Dağıtım tablosunu DataGridView'de gösteriyoruz.
                dataGridView1.DataSource = dagitimTable;

                MessageBox.Show("Dağıtım başarıyla tamamlandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }
    }
}

















