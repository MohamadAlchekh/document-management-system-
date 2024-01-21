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
    public partial class EmanetEkleme : Form
    {
        bool sidebarExpand = true;
        public EmanetEkleme()
        {
            InitializeComponent();
            FillTable();
            FillTable2();
            panelgrid.MaximumSize = new Size(1268, 714);


            sidebarExpand = false;
            //dataGridView1.Columns[0].Visible = false;
            //dataGridView2.Columns[0].Visible = false;

        }
        MySqlConnection connection = new MySqlConnection("Server=172.21.54.148;Database=NYP23-7;User=NYP23-7;Password=Uludag9512357.;");

        public DataTable Show_Data()
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("select * from EvrakEkleme ", connection);
            da.Fill(dt);
            return dt;
        }
        void FillTable()
        {
            dataGridView1.DataSource = Show_Data();
        }
        void DeleteFromArchive()
        {
            string query = "DELETE From EvrakEkleme Where id=@id";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@id", labelid.Text);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            FillTable();

            cmd.ExecuteNonQuery();
        }
        public DataTable Show_Data2()
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("select * from EmanetEkleme ", connection);
            da.Fill(dt);
            return dt;
        }
        void FillTable2()
        {
            dataGridView2.DataSource = Show_Data2();
        }
        void DeleteFromEmanet()
        {
            string query = "DELETE From EmanetEkleme Where id=@id";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@id", labelid.Text);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            FillTable2();

            cmd.ExecuteNonQuery();
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
                txtBoxAçıklama10.Text == "")
            {
                MessageBox.Show("Lütfen alanları doldurun");
            }
            else
            {
                MySqlCommand cmd =
                new MySqlCommand(
                "insert into EmanetEkleme(`DosyaTuru`, `DosyaDepartman`, `RafNo`, `Ad`, `Soyad`, `TC`, `TelefonNumarasi`, `E-Posta`, `VerisTarihi`, `TeslimTarihi`, `Aciklama`)" +
                "VALUES (@DosyaTuru,@DosyaDepartman,@RafNo,@Ad,@Soyad,@TC,@TelefonNumarasi,@EPosta,@VerisTarihi,@TeslimTarihi,@Aciklama)", connection);
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

                MessageBox.Show("Evrak Emanete Başarıyla Eklendi");

                connection.Open();
                DeleteFromArchive();
                cmd.ExecuteNonQuery();
                connection.Close();
                FillTable2();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            labelid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            comboBoxDokumanTuru10.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            comboBoxDepartman10.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxRafNo10.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtBoxAçıklama10.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();

        }

        private void textBoxARA10_TextChanged(object sender, EventArgs e)
        {
            connection.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM EvrakEkleme WHERE id LIKE CONCAT('%', @parm1, '%') " +
                                        "OR DosyaTuru LIKE CONCAT('%', @parm1, '%') " +
                                        "OR DosyaDepartman LIKE CONCAT('%', @parm1, '%') " +
                                        "OR RafNo LIKE CONCAT('%', @parm1, '%') " +
                                        "OR Tarih LIKE CONCAT('%', @parm1, '%') " +
                                        "OR Aciklama LIKE CONCAT('%', @parm1, '%') ", connection);
            cmd.Parameters.AddWithValue("@parm1", textBoxARA10.Text);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            connection.Close();
        }

        private void textBoxARA10E_TextChanged(object sender, EventArgs e)
        {
            connection.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM EmanetEkleme WHERE id LIKE CONCAT('%', @parm1, '%') " +
                                        "OR DosyaTuru LIKE CONCAT('%', @parm1, '%') " +
                                        "OR DosyaDepartman LIKE CONCAT('%', @parm1, '%') " +
                                        "OR RafNo LIKE CONCAT('%', @parm1, '%') " +
                                        "OR Ad LIKE CONCAT('%', @parm1, '%') " +
                                        "OR Soyad LIKE CONCAT('%', @parm1, '%') " +
                                        "OR TC LIKE CONCAT('%', @parm1, '%') " +
                                        "OR TelefonNumarasi LIKE CONCAT('%', @parm1, '%')" +
                                        "OR `E-Posta` LIKE CONCAT('%', @parm1, '%') " +
                                        "OR VerisTarihi LIKE CONCAT('%', @parm1, '%') " +
                                        "OR TeslimTarihi LIKE CONCAT('%', @parm1, '%') " +
                                        "OR Aciklama LIKE CONCAT('%', @parm1, '%') ", connection);

            cmd.Parameters.AddWithValue("@parm1", textBoxARA10E.Text);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView2.DataSource = dt;

            connection.Close();
        }

        private void buttonArşiveGeriVer_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd =
               new MySqlCommand(
               "insert into EvrakEkleme(`DosyaTuru`, `DosyaDepartman`, `RafNo`,`Tarih`, `Aciklama`)" +
                "VALUES (@DosyaTuru,@DosyaDepartman,@RafNo,@Tarih,@Aciklama)", connection);
            cmd.Parameters.AddWithValue("@DosyaTuru", comboBoxDokumanTuru10.Text);
            cmd.Parameters.AddWithValue("@DosyaDepartman", comboBoxDepartman10.Text);
            cmd.Parameters.AddWithValue("@RafNo", textBoxRafNo10.Text);
            cmd.Parameters.AddWithValue("@Tarih", DateTime.Now);
            cmd.Parameters.AddWithValue("@Aciklama", txtBoxAçıklama10.Text);


            MessageBox.Show("Evrak Emanetten Arşive Başarıyla Eklendi");

            connection.Open();
            DeleteFromEmanet();
            cmd.ExecuteNonQuery();
            connection.Close();
            FillTable();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            labelid.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            comboBoxDokumanTuru10.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            comboBoxDepartman10.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            textBoxRafNo10.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            textBoxAD10.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            textBoxSoyad10.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
            maskedTextBoxTcNo10.Text = dataGridView2.CurrentRow.Cells[6].Value.ToString();
            maskedTextBoxTeleNo10.Text = dataGridView2.CurrentRow.Cells[7].Value.ToString();
            textBoxEPosta10.Text = dataGridView2.CurrentRow.Cells[8].Value.ToString();
            dateTimePickerVerişTarihi10.Text = dataGridView2.CurrentRow.Cells[9].Value.ToString();
            dateTimePickerGeriVerilecekTarih10.Text = dataGridView2.CurrentRow.Cells[10].Value.ToString();
            txtBoxAçıklama10.Text = dataGridView2.CurrentRow.Cells[11].Value.ToString();

        }

        private void labelARA4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void timerpanel_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                panelgrid.Width -= 10;
                if (panelgrid.Width == panelgrid.MinimumSize.Width)
                {
                    timerpanel.Stop();
                    sidebarExpand = false;
                }
                else
                {
                    panelgrid.Width += 10;
                    if (panelgrid.Width == panelgrid.MaximumSize.Width)
                    {
                        timerpanel.Stop();
                        sidebarExpand = true;
                    }
                }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                panelgrid.Width = panelgrid.MinimumSize.Width;
                dataGridView2.Size = new Size(772, 366);
                sidebarExpand = false;
            }
            else
            {
                panelgrid.Width = panelgrid.MaximumSize.Width;

                dataGridView2.Size = new Size(1326, 366);
                sidebarExpand = true;
            }
        }
    }
}
