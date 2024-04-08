using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace gorselprogramlamavize
{
    public partial class kitap_ekle : Form
    {
        private SQLiteConnection connection;
        private SQLiteDataAdapter dataAdapter;
        private DataTable dataTable;

        public kitap_ekle()
        {
            InitializeComponent();
            InitializeDatabase();
        }

        private void InitializeDatabase()
        {
            connection = new SQLiteConnection("Data Source=database.db;Version=3;");
            string createTableQuery = @"CREATE TABLE IF NOT EXISTS Kitaplar (
                                        id INTEGER PRIMARY KEY AUTOINCREMENT,
                                        kitapismi TEXT,
                                        kitapturu TEXT,
                                        yazaradi TEXT,
                                        basimyili TEXT,
                                        baskisayisi TEXT)";

            SQLiteCommand command = new SQLiteCommand(createTableQuery, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void LoadData()
        {
            dataAdapter = new SQLiteDataAdapter("SELECT * FROM Kitaplar", connection);
            dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void kitap_ekle_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void kitapeklemebutonu_Click(object sender, EventArgs e)
        {
            connection.Open();
            string insertQuery = @"INSERT INTO Kitaplar (kitapismi, kitapturu, yazaradi, basimyili, baskisayisi) 
                                    VALUES (@kitapismi, @kitapturu, @yazaradi, @basimyili, @baskisayisi)";

            SQLiteCommand command = new SQLiteCommand(insertQuery, connection);
            command.Parameters.AddWithValue("@kitapismi", textBox1.Text);
            command.Parameters.AddWithValue("@kitapturu", textBox2.Text);
            command.Parameters.AddWithValue("@yazaradi", textBox3.Text);
            command.Parameters.AddWithValue("@basimyili", textBox5.Text);
            command.Parameters.AddWithValue("@baskisayisi", textBox4.Text);

            command.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Veri başarıyla eklendi.");

            // Verileri yeniden yükle
            LoadData();
        }

        private void kitapsilmebutonu_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                connection.Open();
                string deleteQuery = "DELETE FROM Kitaplar WHERE id=@id";

                SQLiteCommand command = new SQLiteCommand(deleteQuery, connection);
                command.Parameters.AddWithValue("@id", dataGridView1.SelectedRows[0].Cells["id"].Value);

                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Veri başarıyla silindi.");

                // Verileri yeniden yükle
                LoadData();
            }
            else
            {
                MessageBox.Show("Lütfen bir satır seçin.");
            }
        }

        private void kitapguncellemebutonu_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                connection.Open();
                string updateQuery = @"UPDATE Kitaplar 
                                        SET kitapismi=@kitapismi, kitapturu=@kitapturu, yazaradi=@yazaradi, 
                                            basimyili=@basimyili, baskisayisi=@baskisayisi 
                                        WHERE id=@id";

                SQLiteCommand command = new SQLiteCommand(updateQuery, connection);
                command.Parameters.AddWithValue("@kitapismi", textBox1.Text);
                command.Parameters.AddWithValue("@kitapturu", textBox2.Text);
                command.Parameters.AddWithValue("@yazaradi", textBox3.Text);
                command.Parameters.AddWithValue("@basimyili", textBox5.Text);
                command.Parameters.AddWithValue("@baskisayisi", textBox4.Text);
                command.Parameters.AddWithValue("@id", dataGridView1.SelectedRows[0].Cells["id"].Value);

                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Veri başarıyla güncellendi.");

                // Verileri yeniden yükle
                LoadData();
            }
            else
            {
                MessageBox.Show("Lütfen bir satır seçin.");
            }
        }
    }
}
