using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
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

            sidebar.MinimumSize = new Size(96, 716);
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







        private void butHesapBilgiGüncelle2_Click(object sender, EventArgs e)
        {
            loadform(new Form5());
            bupanel.Location = new System.Drawing.Point(0, butHesapBilgiGüncelle2.Location.Y);
        }

        private void butGecikmisEmanetler2_Click(object sender, EventArgs e)
        {
            loadform(new Form7());

            bupanel.Location = new System.Drawing.Point(0, butGecikmisEmanetler2.Location.Y);
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarTimer.Stop();
                    sidebarExpand = false;
                }
                else
                {
                    sidebar.Width += 10;
                    if (sidebar.Width == sidebar.MaximumSize.Width)
                    {
                        sidebarTimer.Stop();
                        sidebarExpand = true;
                    }
                }
            }
        }


        private void menuButton_Click(object sender, EventArgs e)
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



        private void butAnasayfa_Click(object sender, EventArgs e)
        {

            loadform(new Form10());
            bupanel.Location = new System.Drawing.Point(0, butAnasayfa.Location.Y);
        }

        private void butDosyaTürleri2_Click(object sender, EventArgs e)
        {
            loadform(new Form3());
            bupanel.Location = new System.Drawing.Point(0, butDosyaTürleri2.Location.Y);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {

            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }

        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }


        private void kapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void Maxbtn_Click(object sender, EventArgs e)
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

        private void Minbtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MemurDepartman_Click(object sender, EventArgs e)
        {
            loadform(new Form11());
            bupanel.Location = new System.Drawing.Point(0, MemurDepartman.Location.Y);
        }

        private void butMemurişlemleri2_Click(object sender, EventArgs e)
        {
            loadform(new Form4());
            bupanel.Location = new System.Drawing.Point(0, butMemurişlemleri2.Location.Y);
        }
    }
}
