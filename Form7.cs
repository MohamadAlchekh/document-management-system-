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

namespace document_management_system
{
    public partial class Form7 : Form
    {
        DosyaDepartman dosyadep = new DosyaDepartman();
        private Form6 form6;


        public Form7()
        {
            InitializeComponent();
            FillTable();
            dataGridView1.Columns[0].Visible = false;
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

    }
}
