using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace nöbet_lisrtesi
{
    public partial class Form1 : Form
    {
        // Bağlantı dizesi
        string connectionString = "Server=localhost;Database=ameliyathane;Uid=root;Pwd=179212;";
        MySqlConnection connection;

        public Form1()
        {
            InitializeComponent();
            connection = new MySqlConnection(connectionString);
            LoadData();
        }

        // Form yüklendiğinde verileri yükle
        private void Form1_Load(object sender, EventArgs e)
        {
            // Veritabanı bağlantısını kontrol et ve verileri yükle
            LoadData();
        }

        // Veriyi DataGridView'e yükleme
        private void LoadData()
        {
            try
            {
                connection.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM Personel_Ameliyathane", connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }






        // DataGridView'den seçilen veriyi TextBox'a taşıma


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            {
                if (e.RowIndex >= 0)
                {

                    txtAd.Text = dataGridView1.Rows[e.RowIndex].Cells["Ad"].Value.ToString();
                    txtSoyad.Text = dataGridView1.Rows[e.RowIndex].Cells["Soyad"].Value.ToString();
                    txtID.Text = dataGridView1.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                    txtTel_No.Text = dataGridView1.Rows[e.RowIndex].Cells["Telefon"].Value.ToString();
                    txtMeslek.Text = dataGridView1.Rows[e.RowIndex].Cells["Meslek"].Value.ToString();
                }
            }
        }

        private void txtSoyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    connection.Open();
                    string query = "DELETE FROM Personel_Ameliyathane WHERE Id = @id";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@id", txtID.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Personel kaydı başarıyla silindi!");
                    LoadData();  // Silinen veriyi DataGridView'den kaldır
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
                LoadData();
            }

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO Personel_Ameliyathane (Ad, Soyad, Telefon, Meslek) VALUES (@ad, @soyad, @telefon, @meslek)";
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    cmd.Parameters.AddWithValue("@ad", txtAd.Text);
                    cmd.Parameters.AddWithValue("@soyad", txtSoyad.Text);
                    cmd.Parameters.AddWithValue("@telefon", txtTel_No.Text);
                    cmd.Parameters.AddWithValue("@meslek", txtMeslek.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Personel kaydı başarıyla eklendi!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                    // Yeni eklenen veriyi göster
                }
                LoadData();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        // Güncelle Butonu

        {
            // TextBox'ların boş olup olmadığını kontrol edelim
            if (string.IsNullOrEmpty(txtID.Text) || string.IsNullOrEmpty(txtAd.Text) || string.IsNullOrEmpty(txtSoyad.Text) ||
                string.IsNullOrEmpty(txtTel_No.Text) || string.IsNullOrEmpty(txtMeslek.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurduğunuzdan emin olun.");
                return; // Boş alan varsa işlem yapılmasın
            }

            try
            {
                // Veritabanı bağlantısı açılıyor
                connection.Open();

                // Güncelleme SQL sorgusu
                string query = "UPDATE Personel_Ameliyathane SET Ad = @ad, Soyad = @soyad, Telefon = @telefon, Meslek = @meslek WHERE Id = @ID";

                // SQL komutunu oluştur
                MySqlCommand cmd = new MySqlCommand(query, connection);

                // Parametreleri ekle
                cmd.Parameters.AddWithValue("@ID", txtID.Text);
                cmd.Parameters.AddWithValue("@ad", txtAd.Text);
                cmd.Parameters.AddWithValue("@soyad", txtSoyad.Text);
                cmd.Parameters.AddWithValue("@telefon", txtTel_No.Text);
                cmd.Parameters.AddWithValue("@meslek", txtMeslek.Text);

                // Sorguyu çalıştır
                cmd.ExecuteNonQuery();

                MessageBox.Show("Personel kaydı başarıyla güncellendi!");

                // Güncellenen veriyi göster

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                // Bağlantıyı kapat
                connection.Close();
            }
            LoadData();

        }

        private void btnDagit_Click(object sender, EventArgs e)
        {
            
                Form2 form2 = new Form2(); // Yeni bir Form2 nesnesi oluştur
                form2.Show();              // Form2'yi göster
                this.Hide();               // Form1'i gizle (İsterseniz bu kısmı kaldırabilirsiniz)
            }

        }
    }

