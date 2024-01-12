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
        public Form2()
        {
            InitializeComponent();
            sidebar.MinimumSize = new Size(96, 718);
            sidebar.Width = sidebar.MinimumSize.Width;
            sidebarExpand = false;
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
            loadform(new Form7());
        }

        private void FmemurBtn_Click(object sender, EventArgs e)
        {
            loadform(new Form4());
        }

        private void FgecikmisBtn_Click(object sender, EventArgs e)
        {
            loadform(new Form8());
        }

        private void FhesapBtn_Click(object sender, EventArgs e)
        {
            loadform(new Form5());
        }

        private void butAnasayfa_Click(object sender, EventArgs e)
        {
            loadform(new Form9());
        }

        private void MenuTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    MenuTimer.Stop();
                    sidebarExpand = false;
                }
                else
                {
                    sidebar.Width += 10;
                    if (sidebar.Width == sidebar.MaximumSize.Width)
                    {
                        MenuTimer.Stop();
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
        private void CenterControl(Control control)
        {
            control.Location = new Point(
                (mainpanel.Width - control.Width) / 2,
                (mainpanel.Height - control.Height) / 2
            );
        }



        private void Minbtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void kapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void panel2_MouseMove(object sender, MouseEventArgs e)
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

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }
    }
}
