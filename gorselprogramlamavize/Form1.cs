using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace gorselprogramlamavize
{
    public partial class uye_ekleme : Form
    {
        private SQLiteConnection connection;
        private SQLiteDataAdapter dataAdapter;
        private DataTable dataTable;

        public uye_ekleme()
        {
            InitializeComponent();
            InitializeDatabase();
        }

        private void InitializeDatabase()
        {
            connection = new SQLiteConnection("Data Source=database.db;Version=3;");
            string createTableQuery = @"CREATE TABLE IF NOT EXISTS Uyeler (
                                        id INTEGER PRIMARY KEY AUTOINCREMENT,
                                        isim TEXT,
                                        soyisim TEXT,
                                        tc TEXT,
                                        eposta TEXT)";

            SQLiteCommand command = new SQLiteCommand(createTableQuery, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void LoadData()
        {
            dataAdapter = new SQLiteDataAdapter("SELECT * FROM Uyeler", connection);
            dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void uye_ekleme_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void uyeeklemebutonu_Click(object sender, EventArgs e)
        {
            connection.Open();
            string insertQuery = @"INSERT INTO Uyeler (isim, soyisim, tc, eposta) 
                                    VALUES (@isim, @soyisim, @tc, @eposta)";

            SQLiteCommand command = new SQLiteCommand(insertQuery, connection);
            command.Parameters.AddWithValue("@isim", textBox1.Text);
            command.Parameters.AddWithValue("@soyisim", textBox2.Text);
            command.Parameters.AddWithValue("@tc", textBox3.Text);
            command.Parameters.AddWithValue("@eposta", textBox4.Text);

            command.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Üye baþarýyla eklendi.");

            // Verileri yeniden yükle
            LoadData();
        }

        private void uyesilmebutonu_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                connection.Open();
                string deleteQuery = "DELETE FROM Uyeler WHERE id=@id";

                SQLiteCommand command = new SQLiteCommand(deleteQuery, connection);
                command.Parameters.AddWithValue("@id", dataGridView1.SelectedRows[0].Cells["id"].Value);

                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Üye baþarýyla silindi.");

                // Verileri yeniden yükle
                LoadData();
            }
            else
            {
                MessageBox.Show("Lütfen bir satýr seçin.");
            }
        }

        private void uyeguncellemebutonu_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                connection.Open();
                string updateQuery = @"UPDATE Uyeler 
                                        SET isim=@isim, soyisim=@soyisim, tc=@tc, eposta=@eposta 
                                        WHERE id=@id";

                SQLiteCommand command = new SQLiteCommand(updateQuery, connection);
                command.Parameters.AddWithValue("@isim", textBox1.Text);
                command.Parameters.AddWithValue("@soyisim", textBox2.Text);
                command.Parameters.AddWithValue("@tc", textBox3.Text);
                command.Parameters.AddWithValue("@eposta", textBox4.Text);
                command.Parameters.AddWithValue("@id", dataGridView1.SelectedRows[0].Cells["id"].Value);

                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Üye baþarýyla güncellendi.");

                // Verileri yeniden yükle
                LoadData();
            }
            else
            {
                MessageBox.Show("Lütfen bir satýr seçin.");
            }
        }
    }
}
