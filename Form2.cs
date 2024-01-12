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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void loadform(object form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form fh = form as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;



            this.mainpanel.Controls.Add(fh);

            this.mainpanel.Tag = fh;
            fh.BringToFront();
            fh.Show();

        }
        private void FdosyaBtn_Click(object sender, EventArgs e)
        {
            loadform(new Form3());
        }

        private void FdepartmanBtn_Click(object sender, EventArgs e)
        {

        }

        private void FmemurBtn_Click(object sender, EventArgs e)
        {
            loadform(new Form4());
        }

        private void FgecikmisBtn_Click(object sender, EventArgs e)
        {

        }

        private void FhesapBtn_Click(object sender, EventArgs e)
        {
            loadform(new Form5());
        }
    }
}
