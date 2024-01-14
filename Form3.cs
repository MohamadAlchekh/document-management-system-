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
    public partial class Form3 : Form
    {
        DosyaTuru dosyaturu = new DosyaTuru();
        public Form3()
        {
            InitializeComponent();
            FillTable();
            dataGridView1.Columns[0].Visible = false;
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
    }
}
