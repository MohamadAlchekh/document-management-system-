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
        private DataTable dataTable;

        public Form4()
        {
            InitializeComponent();
            FillTable();
            //dataGridView1.Columns[0].Visible = false;
        }
        MySqlConnection connection = new MySqlConnection("Server=172.21.54.148;Database=NYP23-7;User=NYP23-7;Password=Uludag9512357.;");

        private void butOnayla4_Click(object sender, EventArgs e)
        {
            if (radioButEvet4.Checked || radioButHayır4.Checked)
            {
                groupBox1.Text = " ";
            }
            if (txtBoxAD4.Text == "" || txtBoxSoyAd4.Text == "" || txtBoxKullAdı4.Text == "" || txtBoxŞifre4.Text == "" || maskedTextBoxTcNo4.Text == "" || maskedTextBoxTeleNo4.Text == "" || groupBox1.Text == "")
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                txtBoxŞifre4.UseSystemPasswordChar = true;
            }
            else
                txtBoxŞifre4.UseSystemPasswordChar = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtBoxAD4.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtBoxSoyAd4.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            maskedTextBoxTcNo4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            maskedTextBoxTeleNo4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtBoxKullAdı4.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtBoxŞifre4.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            string s = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            if (s == "Var")
            {
                radioButEvet4.Checked = true;
            }
            else if (s == "Yok")
            {
                radioButHayır4.Checked = true;
            }
        }

        void MemurGüncelle()
        {
            if (radioButEvet4.Checked)
            {
                memur.UpdateMemur(Convert.ToInt16(lblId.Text), txtBoxAD4.Text, txtBoxSoyAd4.Text, maskedTextBoxTcNo4.Text, maskedTextBoxTeleNo4.Text, txtBoxKullAdı4.Text, txtBoxŞifre4.Text, "Var");
                MessageBox.Show("Memur başarıyla güncellendi");
                FillTable();
            }
            else if (radioButHayır4.Checked)
            {
                memur.UpdateMemur(Convert.ToInt16(lblId.Text), txtBoxAD4.Text, txtBoxSoyAd4.Text, maskedTextBoxTcNo4.Text, maskedTextBoxTeleNo4.Text, txtBoxKullAdı4.Text, txtBoxŞifre4.Text, "Yok");
                MessageBox.Show("Memur başarıyla güncellendi");
                FillTable();
            }
        }
        private void butGüncelle4_Click(object sender, EventArgs e)
        {
            if (radioButEvet4.Checked || radioButHayır4.Checked)
            {
                groupBox1.Text = " ";
            }
            if (txtBoxAD4.Text == "" || txtBoxSoyAd4.Text == "" || txtBoxKullAdı4.Text == "" || txtBoxŞifre4.Text == "" || maskedTextBoxTcNo4.Text == "" || maskedTextBoxTeleNo4.Text == "" || groupBox1.Text == "")
            {
                MessageBox.Show("Lütfen alanları doldurun");
            }
            else
            {
                MemurGüncelle();
                FillTable();
            }
        }

        private void butSil4_Click(object sender, EventArgs e)
        {
            memur.DeleteMemur(Convert.ToInt16(lblId.Text));
            MessageBox.Show("Memur başarıyla silindi");
            FillTable();
        }

        private void textBoxARA4_TextChanged(object sender, EventArgs e)
        {
            connection.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM Memur_Bilgileri WHERE id LIKE CONCAT('%', @parm1, '%') " +
                                        "OR Ad LIKE CONCAT('%', @parm1, '%') " +
                                        "OR Soyad LIKE CONCAT('%', @parm1, '%') " +
                                        "OR TcNo LIKE CONCAT('%', @parm1, '%') " +
                                        "OR PhoneNumber LIKE CONCAT('%', @parm1, '%') " +
                                        "OR Username LIKE CONCAT('%', @parm1, '%') " +
                                        "OR Password LIKE CONCAT('%', @parm1, '%') " +
                                        "OR Yetki LIKE CONCAT('%', @parm1, '%')", connection);
            cmd.Parameters.AddWithValue("@parm1", textBoxARA4.Text);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;

            connection.Close();
        }


    }
}
