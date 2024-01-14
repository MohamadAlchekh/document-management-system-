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

        bool sidebarExpand = true;
        private bool mouseDown;
        private Point lastLocation;


        private void Form2_Load(object sender, EventArgs e)
        {
            // Standart başlık çubuğundaki minimize, maximize ve kapatma düğmelerini gizleme
            //  this.ControlBox = false;
            //
            //this.WindowState = FormWindowState.Maximized;
        }


        public Form2()
        {

            InitializeComponent();
            bupanel.Height = butAnasayfa.Height;

            sidebar.MinimumSize = new Size(89, 582);
            sidebar.Width = sidebar.MinimumSize.Width;
            sidebarExpand = false;

            //this.Text = string.Empty;
            //this.ControlBox = false;

        }
        private void CenterControl(Control control)
        {
            control.Location = new Point(
                (mainpanel.Width - control.Width) / 2,
                (mainpanel.Height - control.Height) / 2
            );
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




        private void butAnasayfa_Click_1(object sender, EventArgs e)
        {
            //loadform(new Form10());
            //bupanel.Location = new System.Drawing.Point(0, butAnasayfa.Location.Y);

        }

        private void FdosyaBtn_Click(object sender, EventArgs e)
        {
            loadform(new Form3());
            bupanel.Location = new System.Drawing.Point(0, FdosyaBtn.Location.Y);

        }

        private void FdepartmanBtn_Click(object sender, EventArgs e)
        {
            loadform(new Form7());
            bupanel.Location = new System.Drawing.Point(0, FdepartmanBtn.Location.Y);

        }

        private void FgecikmisBtn_Click(object sender, EventArgs e)
        {

            loadform(new Form8());

            bupanel.Location = new System.Drawing.Point(0, FgecikmisBtn.Location.Y);

        }

        private void FmemurBtn_Click(object sender, EventArgs e)
        {
            loadform(new Form4());
            bupanel.Location = new System.Drawing.Point(0, FmemurBtn.Location.Y);

        }

        private void FhesapBtn_Click(object sender, EventArgs e)
        {

            loadform(new Form5());
            bupanel.Location = new System.Drawing.Point(0, FhesapBtn.Location.Y);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    timer1.Stop();
                    sidebarExpand = false;
                }
                else
                {
                    sidebar.Width += 10;
                    if (sidebar.Width == sidebar.MaximumSize.Width)
                    {
                        timer1.Stop();
                        sidebarExpand = true;
                    }
                }
            }

        }

        private void menuButton_Click_1(object sender, EventArgs e)
        {


            if (sidebarExpand)
            {
                sidebar.Width = sidebar.MinimumSize.Width;
                sidebarExpand = false;
            }
            else
            {
                sidebar.Width = sidebar.MaximumSize.Width;
                sidebarExpand = true;
            }

        }

        private void Maxbtn2_Click(object sender, EventArgs e)
        {

            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;

            }
            else
            {
                this.WindowState = FormWindowState.Normal;

            }


        }

        private void Minbtn_Click_1(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Minimized;

        }

        private void kapat_Click_1(object sender, EventArgs e)
        {

            Application.Exit();

        }

        private void panel2_MouseDown_1(object sender, MouseEventArgs e)
        {

            mouseDown = true;
            lastLocation = e.Location;
        }

        private void panel2_MouseMove_1(object sender, MouseEventArgs e)
        {


            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }


        }

        private void panel2_MouseUp_1(object sender, MouseEventArgs e)
        {

            mouseDown = false;

        }
    }
}
