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

namespace document_management_system
{
    public partial class Form5 : Form
    {
        //MySqlConnection Con = new MySqlConnection("Server=172.21.54.148;Database=NYP23-7;User=NYP23-7;Password=Uludag9512357.;");

        public Form5()
        {
            InitializeComponent();
        }

        private void butOnayla5_Click(object sender, EventArgs e)
        {
            FakulteSekreteri fs = new FakulteSekreteri();
            fs.UpdateFakulteSekreteriBilgileri(txtBoxKullAdıGüncelle5.Text, txtBoxŞifreGüncelle5.Text);


        }

        private void txtBoxŞifreGüncelle5_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                txtBoxŞifreGüncelle5.UseSystemPasswordChar = true;
            }
            else
                txtBoxŞifreGüncelle5.UseSystemPasswordChar = false;

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
