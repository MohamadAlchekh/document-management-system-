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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace document_management_system
{
    public partial class Giriş : Form
    {
        //MySqlConnection Con = new MySqlConnection("Server=172.21.54.148;Database=NYP23-7;User=NYP23-7;Password=Uludag9512357.;");
        //int i;
        private string fakulteConnectionString = "Server=172.21.54.148;Database=NYP23-7;User=NYP23-7;Password=Uludag9512357.;";
        private string kullaniciConnectionString = "Server=172.21.54.148;Database=NYP23-7;User=NYP23-7;Password=Uludag9512357.;";

        public Giriş()
        {
            InitializeComponent();
        }

        private void butOnayla1_Click(object sender, EventArgs e)
        {
            string username = txtBoxKullAdı1.Text;
            string password = txtBoxŞifre1.Text;

            if (txtBoxKullAdı1.Text == "" || txtBoxŞifre1.Text == "")
            {
                MessageBox.Show("Lütfen alanları doldurun");
            }
            else
            {
                islemler();
            }

            void islemler()
            {
                if (radioButFsekreteri1.Checked)
                {
                    if (CheckLogin(username, password, "FSlogin", fakulteConnectionString))
                    {
                        MessageBox.Show("fakülte sekreteri giriş başarılı");
                        Form2 form2 = new Form2();
                        form2.Show();
                    }
                    else
                    {
                        MessageBox.Show("Geçersiz fakülte sekreteri kimlik bilgileri");
                    }
                }
                else if (radioButKullanıcı1.Checked)
                {
                    if (CheckLogin(username, password, "Memur_Bilgileri", kullaniciConnectionString))
                    {
                        MessageBox.Show("Kullanıcı giriş başarılı");
                        Form11 form11 = new Form11();
                        form11.Show();
                    }
                    else
                    {
                        MessageBox.Show("Geçersiz Kullanıcı kimlik bilgileri");
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen bir kullanıcı türü seçin.");
                }
            }


        }

        private bool CheckLogin(string username, string password, string tableName, string connectionString)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();

                string query = $"SELECT * FROM {tableName} WHERE Username = @Username AND Password = @Password";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                return count > 0;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // If the show "göster" button was clicked the Pass will be shown
            if (checkBox1.CheckState == CheckState.Checked)
            {
                txtBoxŞifre1.UseSystemPasswordChar = true;
            }
            else
                txtBoxŞifre1.UseSystemPasswordChar = false;
        }


        private void txtBoxKullAdı1_KeyDown(object sender, KeyEventArgs e)
        {
            // Going down when pressing the down arrow key
            if (e.KeyCode == Keys.Down)
            {
                e.SuppressKeyPress = true;
                txtBoxŞifre1.Focus();
            }
        }

        private void txtBoxŞifre1_KeyDown(object sender, KeyEventArgs e)
        {
            // Going up when pressing the up arrow key
            if (e.KeyCode == Keys.Up)
            {
                e.SuppressKeyPress = true;
                txtBoxKullAdı1.Focus();
            }
        }

        private void txtBoxKullAdı1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}