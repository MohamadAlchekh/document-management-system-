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
    public partial class Form6 : Form
    {
        bool menubuyut = true;
        public Form6()
        {
            InitializeComponent();
            MemurMenu.MinimumSize = new Size(90, 633);
            MemurMenu.Width = MemurMenu.MinimumSize.Width;
            menubuyut = false;
            bupanel2.Height = MemurAna.Height;
        }

        private void MemurTimer_Tick(object sender, EventArgs e)
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

        private void MemurAna_Click(object sender, EventArgs e)
        {

        }

        private void MemurEvrak_Click(object sender, EventArgs e)
        {
            formyukle(new Form8());
            bupanel2.Location = new System.Drawing.Point(0, MemurEvrak.Location.Y);
        }

        private void MemurEmanet_Click(object sender, EventArgs e)
        {
            formyukle(new Form9());
            bupanel2.Location = new System.Drawing.Point(0, MemurEmanet.Location.Y);
        }


        private void Minbtn2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void kapat2_Click(object sender, EventArgs e)
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
    }
}
