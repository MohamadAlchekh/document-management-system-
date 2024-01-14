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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
            FillTable();
            FillTable2();
            dataGridView1.Columns[0].Visible = false;
            dataGridView2.Columns[0].Visible = false;

        }
        MySqlConnection Con = new MySqlConnection("Server=172.21.54.148;Database=NYP23-7;User=NYP23-7;Password=Uludag9512357.;");

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
        public DataTable Show_Data2()
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("select * from EmanetEkleme ", Con);
            da.Fill(dt);
            return dt;
        }
        void FillTable2()
        {
            dataGridView2.DataSource = Show_Data2();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBoxDokumanTuru10.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            comboBoxDepartman10.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxRafNo10.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void buttonOnayla6_Click(object sender, EventArgs e)
        {
            if (comboBoxDokumanTuru10.Text == "" ||
                comboBoxDepartman10.Text == "" ||
                textBoxRafNo10.Text == "" ||
                textBoxAD10.Text == "" ||
                textBoxSoyad10.Text == "" ||
                maskedTextBoxTcNo10.Text == "" ||
                maskedTextBoxTeleNo10.Text == "" ||
                textBoxEPosta10.Text == "" ||
                dateTimePickerVerişTarihi10.Value == null ||
                dateTimePickerGeriVerilecekTarih10.Value == null ||
                txtBoxAçıklama10.Text == "" ||
                comboBoxTeslimBilgisi10.Text == "")
            {
                MessageBox.Show("Lütfen alanları doldurun");
            }
            else
            {
                MySqlCommand cmd =
                new MySqlCommand(
                "insert into EmanetEkleme(`DosyaTuru`, `DosyaDepartman`, `RafNo`, `Ad`, `Soyad`, `TC`, `TelefonNumarasi`, `E-Posta`, `VerisTarihi`, `TeslimTarihi`, `Aciklama`,`TeslimBilgisi`)" +
                "VALUES (@DosyaTuru,@DosyaDepartman,@RafNo,@Ad,@Soyad,@TC,@TelefonNumarasi,@EPosta,@VerisTarihi,@TeslimTarihi,@Aciklama,@TeslimBilgisi)", Con);
                cmd.Parameters.AddWithValue("@DosyaTuru", comboBoxDokumanTuru10.Text);
                cmd.Parameters.AddWithValue("@DosyaDepartman", comboBoxDepartman10.Text);
                cmd.Parameters.AddWithValue("@RafNo", textBoxRafNo10.Text);
                cmd.Parameters.AddWithValue("@AD", textBoxAD10.Text);
                cmd.Parameters.AddWithValue("@Soyad", textBoxSoyad10.Text);
                cmd.Parameters.AddWithValue("@TC", maskedTextBoxTcNo10.Text);
                cmd.Parameters.AddWithValue("@TelefonNumarasi", maskedTextBoxTeleNo10.Text);
                cmd.Parameters.AddWithValue("@EPosta", textBoxEPosta10.Text);
                cmd.Parameters.AddWithValue("@VerisTarihi", dateTimePickerVerişTarihi10.Value);
                cmd.Parameters.AddWithValue("@TeslimTarihi", dateTimePickerGeriVerilecekTarih10.Value);
                cmd.Parameters.AddWithValue("@Aciklama", txtBoxAçıklama10.Text);
                cmd.Parameters.AddWithValue("@TeslimBilgisi", comboBoxTeslimBilgisi10.Text);

                MessageBox.Show("Evrak Emanete Başarıyla Eklendi");

                Con.Open();
                cmd.ExecuteNonQuery();
                Con.Close();
                FillTable2();
            }
        }
    }
}
