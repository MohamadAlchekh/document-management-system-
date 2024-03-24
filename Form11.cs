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
    public partial class Form11 : Form
    {
        bool menubuyut = true;
        private bool mouseDown;
        private Point lastLocation;
        public Form11()
        {
            InitializeComponent();

            MemurMenu.MinimumSize = new Size(70, 586);
            MemurMenu.Width = MemurMenu.MinimumSize.Width;
            menubuyut = false;
            bupanel2.Height = MemurEvrak.Height;

        }
        private void CenterControl(Control control)
        {
            control.Location = new Point(
                (MemurPanel.Width - control.Width) / 2,
                (MemurPanel.Height - control.Height) / 2
            );
        }
        private void formyukle(object form)
        {
            if (this.MemurPanel.Controls.Count > 0)
                this.MemurPanel.Controls.RemoveAt(0);
            Form fh = form as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;



            this.MemurPanel.Controls.Add(fh);

            this.MemurPanel.Tag = fh;
            fh.BringToFront();
            fh.Show();
            CenterControl(fh);
        }
        private void MemurTimer_Tick_1(object sender, EventArgs e)
        {

            if (menubuyut)
            {
                MemurMenu.Width -= 10;
                if (MemurMenu.Width == MemurMenu.MinimumSize.Width)
                {
                    MemurTimer.Stop();
                    menubuyut = false;
                }
                else
                {
                    MemurMenu.Width += 10;
                    if (MemurMenu.Width == MemurMenu.MaximumSize.Width)
                    {
                        MemurTimer.Stop();
                        menubuyut = true;
                    }
                }
            }

        }
        private void MemurEvrak_Click(object sender, EventArgs e)
        {
            formyukle(new Arşiveevrakeklemek());
            bupanel2.Location = new System.Drawing.Point(0, MemurEvrak.Location.Y);
        }
        private void MemurEmanet_Click(object sender, EventArgs e)
        {
            formyukle(new EmanetEkleme());
            bupanel2.Location = new System.Drawing.Point(0, MemurEmanet.Location.Y);
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            if (menubuyut)
            {
                MemurMenu.Width = MemurMenu.MinimumSize.Width;
                menubuyut = false;
            }
            else
            {
                MemurMenu.Width = MemurMenu.MaximumSize.Width;
                menubuyut = true;
            }
        }

        private void Minbtn_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Minimized;
        }

        private void Maxbtn2_Click(object sender, EventArgs e)
        {
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
        }

        private void kapat_Click(object sender, EventArgs e)
        {

            Application.Exit();

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

        private void MemurAna_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            formyukle(new MemurAna());
            bupanel2.Location = new System.Drawing.Point(0, button1.Location.Y);
        }
    }
}
