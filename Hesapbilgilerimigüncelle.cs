﻿using MySql.Data.MySqlClient;
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
    public partial class Hesapbilgilerimigüncelle : Form
    {
        //MySqlConnection Con = new MySqlConnection("Server=172.21.54.148;Database=NYP23-7;User=NYP23-7;Password=Uludag9512357.;");

        public Hesapbilgilerimigüncelle()
        {
            InitializeComponent();
        }

        private void butOnayla5_Click(object sender, EventArgs e)
        {

            if (txtBoxKullAdıGüncelle5.Text == "" || txtBoxŞifreGüncelle5.Text == "")
            {
                MessageBox.Show("Lütfen alanları doldurun");
            }
            else
            {
                FakulteSekreteri fs = new FakulteSekreteri();
                fs.UpdateFakulteSekreteriBilgileri(txtBoxKullAdıGüncelle5.Text, txtBoxŞifreGüncelle5.Text);
            }


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


    }
}
