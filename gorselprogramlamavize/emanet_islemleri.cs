using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace gorselprogramlamavize
{
    public partial class emanet_islemleri : Form
    {
        private SQLiteConnection connection;
        private SQLiteDataAdapter dataAdapter;
        private DataTable dataTable;

        public emanet_islemleri()
        {
            InitializeComponent();
            InitializeDatabase();
        }

        private void InitializeDatabase()
        {
            connection = new SQLiteConnection("Data Source=database.db;Version=3;");
            string createTableQuery = @"CREATE TABLE IF NOT EXISTS Emanetler (
                                        id INTEGER PRIMARY KEY AUTOINCREMENT,
                                        aliciisim TEXT,
                                        kitapislem TEXT,
                                        serino TEXT,
                                        alicitc TEXT,
                                        teslimsuresi TEXT,
                                        gecikmesuresi TEXT,
                                        teslimtarihi TEXT)";

            SQLiteCommand command = new SQLiteCommand(createTableQuery, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void LoadData()
        {
            dataAdapter = new SQLiteDataAdapter("SELECT * FROM Emanetler", connection);
            dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void emanet_islemleri_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void emanetalmabutonu_Click(object sender, EventArgs e)
        {
            connection.Open();
            string insertQuery = @"INSERT INTO Emanetler (aliciisim, kitapislem, serino, alicitc, teslimsuresi, gecikmesuresi, teslimtarihi) 
                                    VALUES (@aliciisim, @kitapislem, @serino, @alicitc, @teslimsuresi, @gecikmesuresi, @teslimtarihi)";

            SQLiteCommand command = new SQLiteCommand(insertQuery, connection);
            command.Parameters.AddWithValue("@aliciisim", aliciisim.Text);
            command.Parameters.AddWithValue("@kitapislem", kitapislem.Text);
            command.Parameters.AddWithValue("@serino", serino.Text);
            command.Parameters.AddWithValue("@alicitc", alicitc.Text);
            command.Parameters.AddWithValue("@teslimsuresi", teslimsuresi.Text);
            command.Parameters.AddWithValue("@gecikmesuresi", gecikmesuresi.Text);
            command.Parameters.AddWithValue("@teslimtarihi", teslimtarihi.Text);

            command.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Veri başarıyla eklendi.");

            // Verileri yeniden yükle
            LoadData();
        }
    }
}
