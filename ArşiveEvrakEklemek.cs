using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Org.BouncyCastle.Asn1.Cmp.Challenge;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace document_management_system
{

    public partial class Arşiveevrakeklemek : Form
    {
        MySqlConnection connection = new MySqlConnection("Server=172.21.54.148;Database=NYP23-7;User=NYP23-7;Password=Uludag9512357.;");

        public Arşiveevrakeklemek()
        {
            InitializeComponent();
            FillTable();
            AddDepToComboBox();
            AddDosTuruToComboBox();
        }

        MySqlConnection Con = new MySqlConnection("Server=172.21.54.148;Database=NYP23-7;User=NYP23-7;Password=Uludag9512357.;");
        private void butOnayla6_Click(object sender, EventArgs e)
        {

            if (comboBoxDokumanTuru6.Text == "" || comboBoxDepartman6.Text == "" || textBoxRafNo6.Text == "" || dateTimePickerTarih6.Value == null || txtBoxAçıklama6.Text == "")
            {
                MessageBox.Show("Lütfen alanları doldurun");
            }
            else
            {
                MySqlCommand cmd =
                new MySqlCommand(
                "insert into EvrakEkleme(`DosyaTuru`, `DosyaDepartman`, `RafNo`, `Tarih`, `Aciklama`)" +
                "VALUES (@DosyaTuru,@DosyaDepartman,@RafNo,@Tarih,@Aciklama)", Con);
                cmd.Parameters.AddWithValue("@DosyaTuru", comboBoxDokumanTuru6.Text);
                cmd.Parameters.AddWithValue("@DosyaDepartman", comboBoxDepartman6.Text);
                cmd.Parameters.AddWithValue("@RafNo", textBoxRafNo6.Text);
                cmd.Parameters.AddWithValue("@Tarih", dateTimePickerTarih6.Value);
                cmd.Parameters.AddWithValue("@Aciklama", txtBoxAçıklama6.Text);
                MessageBox.Show("Evrak Arşive Başarıyla Eklendi");

                Con.Open();
                cmd.ExecuteNonQuery();
                Con.Close();
                FillTable();
            }
        }
        public DataTable Show_Data()
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("select * from EvrakEkleme ", Con);
            da.Fill(dt);
            return dt;
        }
        void FillTable()
        {
            dataGridView1.DataSource = Show_Data();
        }


        void AddDepToComboBox()
        {
            string connectionString = "Server=172.21.54.148;Database=NYP23-7;User=NYP23-7;Password=Uludag9512357.;";
            string query = "SELECT * FROM DosyaDepartman;";

            MySqlConnection connection = null;
            MySqlCommand command = null;
            MySqlDataReader reader = null;

            try
            {
                List<string> dosyaDepartmanValues = new List<string>();

                connection = new MySqlConnection(connectionString);
                connection.Open();

                command = new MySqlCommand(query, connection);
                reader = command.ExecuteReader();

                // Check if the result set has rows
                if (reader.HasRows)
                {
                    // Iterate through the rows
                    while (reader.Read())
                    {
                        // Replace "ColumnName" with the actual column name from DosyaDepartman
                        string value = reader["DosyaDepartman"].ToString();

                        // Add the value to the list
                        dosyaDepartmanValues.Add(value);
                    }
                }
                // Now, dosyaDepartmanValues contains the values from the specified column in DosyaDepartman
                foreach (var value in dosyaDepartmanValues)
                {
                    comboBoxDepartman6.Items.Add(value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Make sure to close connections and dispose of resources in the finally block
                if (reader != null)
                    reader.Close();

                if (command != null)
                    command.Dispose();

                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }
        }


        void AddDosTuruToComboBox()
        {
            string connectionString = "Server=172.21.54.148;Database=NYP23-7;User=NYP23-7;Password=Uludag9512357.;";
            string query = "SELECT * FROM DosyaTuru;";

            MySqlConnection connection = null;
            MySqlCommand command = null;
            MySqlDataReader reader = null;

            try
            {
                List<string> dosyaturu = new List<string>();

                connection = new MySqlConnection(connectionString);
                connection.Open();

                command = new MySqlCommand(query, connection);
                reader = command.ExecuteReader();

                // Check if the result set has rows
                if (reader.HasRows)
                {
                    // Iterate through the rows
                    while (reader.Read())
                    {
                        // Replace "ColumnName" with the actual column name from DosyaDepartman
                        string value = reader["DosyaTuru"].ToString();

                        // Add the value to the list
                        dosyaturu.Add(value);
                    }
                }
                // Now, dosyaDepartmanValues contains the values from the specified column in DosyaDepartman
                foreach (var value in dosyaturu)
                {
                    comboBoxDokumanTuru6.Items.Add(value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                if (command != null)
                    command.Dispose();

                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }
        }

        private void textBoxARA6_TextChanged(object sender, EventArgs e)
        {
            connection.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM EvrakEkleme WHERE id LIKE CONCAT('%', @parm1, '%') " +
                                         "OR DosyaTuru LIKE CONCAT('%', @parm1, '%') " +
                                         "OR DosyaDepartman LIKE CONCAT('%', @parm1, '%') " +
                                         "OR RafNo LIKE CONCAT('%', @parm1, '%') " +
                                         "OR Tarih LIKE CONCAT('%', @parm1, '%') " +
                                         "OR Aciklama LIKE CONCAT('%', @parm1, '%') ", connection);
            cmd.Parameters.AddWithValue("@parm1", textBoxARA6.Text);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;

            connection.Close();
        }
    }
}
