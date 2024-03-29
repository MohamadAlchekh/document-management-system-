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

namespace document_management_system
{
    public partial class DosyaTürleri : Form
    {
        MySqlConnection connection = new MySqlConnection("Server=172.21.54.148;Database=NYP23-7;User=NYP23-7;Password=Uludag9512357.;");
        DosyaTuru dosyaturu = new DosyaTuru();
        public DosyaTürleri()
        {
            InitializeComponent();
            FillTable();
            //dataGridView1.Columns[0].Visible = false;
        }

        private void butTürBelirle3_Click(object sender, EventArgs e)
        {
            if (textBoxDosyaBelirle33.Text == "")
            {
                MessageBox.Show("Lütfen alanları doldurun");
            }
            else
            {
                DosyaTuruBelirleme();
            }

        }
        void DosyaTuruBelirleme()
        {
            dosyaturu.AddDosya(textBoxDosyaBelirle33.Text);
            FillTable();
            MessageBox.Show($"Yeni Dosya Türü \n\"{textBoxDosyaBelirle33.Text}\" Olarak Belirlendi");
        }
        void FillTable()
        {
            dataGridView1.DataSource = dosyaturu.Show_Data();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            this.dataGridView1.ClearSelection();
        }

        private void textBoxARA3_TextChanged(object sender, EventArgs e)
        {
            connection.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM DosyaTuru WHERE id LIKE CONCAT('%', @parm1, '%') " + "OR DosyaTuru LIKE CONCAT('%', @parm1, '%') ", connection);
            cmd.Parameters.AddWithValue("@parm1", textBoxARA3.Text);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            connection.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            labelid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxDosyaBelirle33.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void butGüncelleDosyaTuru_Click(object sender, EventArgs e)
        {
            connection.Open();
            string query = "UPDATE DosyaTuru SET DosyaTuru = @DosyaTuru Where id=@id ";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@id", labelid.Text);
            cmd.Parameters.AddWithValue("@DosyaTuru", textBoxDosyaBelirle33.Text);
            MessageBox.Show("Dosya Turu başarıyla güncellendi");
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            FillTable();
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        private void butSilDosyaTuru_Click(object sender, EventArgs e)
        {
            connection.Open();
            string query = "DELETE From DosyaTuru Where id=@id";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@id", labelid.Text);
            MessageBox.Show("Dosya Turu başarıyla silindi");
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            FillTable();

            cmd.ExecuteNonQuery();
            connection.Close();
        }
    }
}
