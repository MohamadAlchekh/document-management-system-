using Google.Protobuf.WellKnownTypes;
using K4os.Compression.LZ4.Streams.Abstractions;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace document_management_system
{
    public partial class Form4 : Form
    {
        Memur memur = new Memur();
        public Form4()
        {
            InitializeComponent();
            FillTable();
            dataGridView1.Columns[0].Visible = false;
            
        }
        
        private void butOnayla4_Click(object sender, EventArgs e)
        {
            if (txtBoxAD4.Text == "" || txtBoxSoyAd4.Text == "" || txtBoxKullAdı4.Text == "" || txtBoxŞifre4.Text == "" || maskedTextBoxTcNo4.Text == "" || maskedTextBoxTeleNo4.Text == "")
            {
                MessageBox.Show("Lütfen alanları doldurun");
            }
            else
            {
                memurekleme();
            }
        }

        void memurekleme()
        {
            if (radioButEvet4.Checked)
            {
                memur.AddMemur(txtBoxAD4.Text, txtBoxSoyAd4.Text, maskedTextBoxTcNo4.Text, maskedTextBoxTeleNo4.Text, txtBoxKullAdı4.Text, txtBoxŞifre4.Text, "Var");
                MessageBox.Show("Memur başarıyla eklendi");
                FillTable();
            }
            else if (radioButHayır4.Checked)
            {
                memur.AddMemur(txtBoxAD4.Text, txtBoxSoyAd4.Text, maskedTextBoxTcNo4.Text, maskedTextBoxTeleNo4.Text, txtBoxKullAdı4.Text, txtBoxŞifre4.Text, "Yok");
                MessageBox.Show("Memur başarıyla eklendi");
                FillTable();
            }
        }
        void FillTable()
        {
            dataGridView1.DataSource = memur.Show_Data();
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            this.dataGridView1.ClearSelection();
        }
    }
}
