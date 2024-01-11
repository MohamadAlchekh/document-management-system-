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

namespace document_management_system
{
    public partial class Form1 : Form
    {
        MySqlConnection Con = new MySqlConnection("Server=172.21.54.148;Database=NYP23-7;User=NYP23-7;Password=Uludag9512357.;");
        int i;
        public Form1()
        {
            InitializeComponent();
        }

        private void butOnayla1_Click(object sender, EventArgs e)
        {
            i = 0;
            Con.Open();
            MySqlCommand cmd = Con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from FSlogin where FSUsername='" + txtBoxKullAdı1.Text + "' and FSpass='" + txtBoxŞifre1.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());

            if (i == 1 && radioButFsekreteri1.Checked)
            {
                Form2 form2 = new Form2();
                form2.Show();
            }
            else if (i == 1 && !radioButFsekreteri1.Checked)
            {
                MessageBox.Show("Lütfen kişi seçin");
            }
            else if (i == 0)
            {
                MessageBox.Show("Girdiğiniz şifre ya da kullanıcı adı yanlıştır");
            }

            Con.Close();
        }


    }
}