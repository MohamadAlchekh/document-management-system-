namespace document_management_system
{
    partial class Form6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            MemurTimer = new System.Windows.Forms.Timer(components);
            MemurMenu = new Panel();
            MemurAna = new Button();
            bupanel2 = new Panel();
            MemurMenu2 = new Panel();
            menuButton = new PictureBox();
            label2 = new Label();
            MemurEvrak = new Button();
            MemurEmanet = new Button();
            panel2 = new Panel();
            Minbtn2 = new Button();
            Maxbtn2 = new Button();
            kapat2 = new Button();
            MemurPanel = new Panel();
            MemurMenu.SuspendLayout();
            MemurMenu2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menuButton).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // MemurTimer
            // 
            MemurTimer.Interval = 10;
            MemurTimer.Tick += MemurTimer_Tick;
            // 
            // MemurMenu
            // 
            MemurMenu.BackColor = Color.FromArgb(41, 128, 185);
            MemurMenu.Controls.Add(MemurAna);
            MemurMenu.Controls.Add(bupanel2);
            MemurMenu.Controls.Add(MemurMenu2);
            MemurMenu.Controls.Add(MemurEvrak);
            MemurMenu.Controls.Add(MemurEmanet);
            resources.ApplyResources(MemurMenu, "MemurMenu");
            MemurMenu.Name = "MemurMenu";
            // 
            // MemurAna
            // 
            MemurAna.BackColor = Color.FromArgb(41, 128, 185);
            MemurAna.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(MemurAna, "MemurAna");
            MemurAna.ForeColor = Color.White;
            MemurAna.Image = Properties.Resources.home__2_;
            MemurAna.Name = "MemurAna";
            MemurAna.UseVisualStyleBackColor = false;
            MemurAna.Click += MemurAna_Click;
            // 
            // bupanel2
            // 
            bupanel2.BackColor = Color.FromArgb(51, 52, 78);
            resources.ApplyResources(bupanel2, "bupanel2");
            bupanel2.Name = "bupanel2";
            // 
            // MemurMenu2
            // 
            MemurMenu2.BackColor = Color.FromArgb(81, 116, 148);
            MemurMenu2.Controls.Add(menuButton);
            MemurMenu2.Controls.Add(label2);
            resources.ApplyResources(MemurMenu2, "MemurMenu2");
            MemurMenu2.Name = "MemurMenu2";
            // 
            // menuButton
            // 
            menuButton.Cursor = Cursors.Hand;
            menuButton.Image = Properties.Resources.icons8_menu_50;
            resources.ApplyResources(menuButton, "menuButton");
            menuButton.Name = "menuButton";
            menuButton.TabStop = false;
            menuButton.Click += menuButton_Click;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.ForeColor = Color.White;
            label2.Name = "label2";
            // 
            // MemurEvrak
            // 
            MemurEvrak.BackColor = Color.FromArgb(41, 128, 185);
            MemurEvrak.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(MemurEvrak, "MemurEvrak");
            MemurEvrak.ForeColor = Color.White;
            MemurEvrak.Image = Properties.Resources.add_document;
            MemurEvrak.Name = "MemurEvrak";
            MemurEvrak.UseVisualStyleBackColor = false;
            MemurEvrak.Click += MemurEvrak_Click;
            // 
            // MemurEmanet
            // 
            MemurEmanet.BackColor = Color.FromArgb(41, 128, 185);
            MemurEmanet.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(MemurEmanet, "MemurEmanet");
            MemurEmanet.ForeColor = Color.White;
            MemurEmanet.Image = Properties.Resources.information;
            MemurEmanet.Name = "MemurEmanet";
            MemurEmanet.UseVisualStyleBackColor = false;
            MemurEmanet.Click += MemurEmanet_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(51, 52, 78);
            panel2.Controls.Add(Minbtn2);
            panel2.Controls.Add(Maxbtn2);
            panel2.Controls.Add(kapat2);
            resources.ApplyResources(panel2, "panel2");
            panel2.Name = "panel2";
            // 
            // Minbtn2
            // 
            Minbtn2.BackColor = Color.DimGray;
            resources.ApplyResources(Minbtn2, "Minbtn2");
            Minbtn2.FlatAppearance.BorderSize = 0;
            Minbtn2.ForeColor = Color.WhiteSmoke;
            Minbtn2.Name = "Minbtn2";
            Minbtn2.UseVisualStyleBackColor = false;
            Minbtn2.Click += Minbtn2_Click;
            // 
            // Maxbtn2
            // 
            Maxbtn2.BackColor = Color.DimGray;
            resources.ApplyResources(Maxbtn2, "Maxbtn2");
            Maxbtn2.FlatAppearance.BorderSize = 0;
            Maxbtn2.ForeColor = Color.White;
            Maxbtn2.Image = Properties.Resources.squares__2_2;
            Maxbtn2.Name = "Maxbtn2";
            Maxbtn2.UseVisualStyleBackColor = false;
            Maxbtn2.Click += Maxbtn2_Click;
            // 
            // kapat2
            // 
            kapat2.BackColor = Color.DimGray;
            resources.ApplyResources(kapat2, "kapat2");
            kapat2.FlatAppearance.BorderSize = 0;
            kapat2.ForeColor = Color.White;
            kapat2.Name = "kapat2";
            kapat2.UseVisualStyleBackColor = false;
            kapat2.Click += kapat2_Click;
            // 
            // MemurPanel
            // 
            resources.ApplyResources(MemurPanel, "MemurPanel");
            MemurPanel.Name = "MemurPanel";
            // 
            // Form6
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            Controls.Add(MemurPanel);
            Controls.Add(MemurMenu);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form6";
            MemurMenu.ResumeLayout(false);
            MemurMenu2.ResumeLayout(false);
            MemurMenu2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)menuButton).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer MemurTimer;
        private Panel MemurMenu;
        private Button MemurAna;
        private Panel bupanel2;
        private Panel MemurMenu2;
        private PictureBox menuButton;
        private Label label2;
        private Button MemurEvrak;
        private Button MemurEmanet;
        private Panel panel2;
        private Button Minbtn2;
        private Button Maxbtn2;
        private Button kapat2;
        private Panel MemurPanel;
    }
}