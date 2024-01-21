using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Ocsp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace document_management_system
{
    public partial class Departmanİşlemleri : Form
    {
        DosyaDepartman dosyadep = new DosyaDepartman();
        private Arşiveevrakeklemek form6;
        MySqlConnection connection = new MySqlConnection("Server=172.21.54.148;Database=NYP23-7;User=NYP23-7;Password=Uludag9512357.;");

        public Departmanİşlemleri()
        {
            InitializeComponent();
            FillTable();
            //dataGridView1.Columns[0].Visible = false;
        }
        private void butDepEkle3_Click(object sender, EventArgs e)
        {
            if (textBoxDepartmanEkle7.Text == "")
            {
                MessageBox.Show("Lütfen alanları doldurun");
            }
            else
            {
                DosyaDepartmanEkle();
            }
        }
        void DosyaDepartmanEkle()
        {
            dosyadep.AddDosya(textBoxDepartmanEkle7.Text);
            FillTable();
            MessageBox.Show($"Yeni Departman \n\"{textBoxDepartmanEkle7.Text}\" Olarak Belirlendi");
        }
        void FillTable()
        {
            dataGridView1.DataSource = dosyadep.Show_Data();
        }

        private void textBoxARA4_TextChanged(object sender, EventArgs e)
        {
            connection.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM DosyaDepartman WHERE id LIKE CONCAT('%', @parm1, '%') " + "OR DosyaDepartman LIKE CONCAT('%', @parm1, '%') ", connection);
            cmd.Parameters.AddWithValue("@parm1", textBoxARA7.Text);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            connection.Close();
        }

        private void butGüncelleDep_Click(object sender, EventArgs e)
        {
            connection.Open();
            string query = "UPDATE DosyaDepartman SET DosyaDepartman = @DosyaDepartman Where id=@id ";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@id", labelid.Text);
            cmd.Parameters.AddWithValue("@DosyaDepartman", textBoxDepartmanEkle7.Text);
            MessageBox.Show("Departman başarıyla güncellendi");
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            FillTable();
            cmd.ExecuteNonQuery();
            connection.Close();
        }


        private void butSilDep_Click(object sender, EventArgs e)
        {
            connection.Open();
            string query = "DELETE From DosyaDepartman Where id=@id";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@id", labelid.Text);
            MessageBox.Show("Departman başarıyla silindi");
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            FillTable();

            cmd.ExecuteNonQuery();
            connection.Close();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            labelid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxDepartmanEkle7.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
