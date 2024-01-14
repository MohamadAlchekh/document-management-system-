namespace document_management_system
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            mainpanel = new Panel();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            sidebar = new Panel();
            FdepartmanBtn = new Button();
            bupanel = new Panel();
            butAnasayfa = new Button();
            FgecikmisBtn = new Button();
            panel3 = new Panel();
            menuButton = new PictureBox();
            label2 = new Label();
            FdosyaBtn = new Button();
            FhesapBtn = new Button();
            FmemurBtn = new Button();
            panel2 = new Panel();
            Minbtn = new Button();
            Maxbtn2 = new Button();
            kapat = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            mainpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            sidebar.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menuButton).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // mainpanel
            // 
            mainpanel.BackColor = SystemColors.ActiveCaption;
            mainpanel.Controls.Add(label3);
            mainpanel.Controls.Add(pictureBox1);
            mainpanel.Dock = DockStyle.Fill;
            mainpanel.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            mainpanel.Location = new Point(186, 25);
            mainpanel.Margin = new Padding(2);
            mainpanel.Name = "mainpanel";
            mainpanel.Size = new Size(839, 582);
            mainpanel.TabIndex = 18;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(248, 32);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(383, 33);
            label3.TabIndex = 17;
            label3.Text = "Hoşgeldiniz Fakülte Sekreteri";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(29, 0);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(195, 156);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(41, 128, 185);
            sidebar.Controls.Add(FdepartmanBtn);
            sidebar.Controls.Add(bupanel);
            sidebar.Controls.Add(butAnasayfa);
            sidebar.Controls.Add(FgecikmisBtn);
            sidebar.Controls.Add(panel3);
            sidebar.Controls.Add(FdosyaBtn);
            sidebar.Controls.Add(FhesapBtn);
            sidebar.Controls.Add(FmemurBtn);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 25);
            sidebar.Margin = new Padding(2);
            sidebar.MaximumSize = new Size(186, 900);
            sidebar.MinimumSize = new Size(89, 582);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(186, 582);
            sidebar.TabIndex = 16;
            // 
            // FdepartmanBtn
            // 
            FdepartmanBtn.BackColor = Color.FromArgb(41, 128, 185);
            FdepartmanBtn.FlatAppearance.BorderSize = 0;
            FdepartmanBtn.FlatStyle = FlatStyle.Flat;
            FdepartmanBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            FdepartmanBtn.ForeColor = Color.White;
            FdepartmanBtn.Image = (Image)resources.GetObject("FdepartmanBtn.Image");
            FdepartmanBtn.ImageAlign = ContentAlignment.MiddleLeft;
            FdepartmanBtn.Location = new Point(17, 237);
            FdepartmanBtn.Name = "FdepartmanBtn";
            FdepartmanBtn.Size = new Size(174, 70);
            FdepartmanBtn.TabIndex = 14;
            FdepartmanBtn.Text = "Departman İşlemleri";
            FdepartmanBtn.TextAlign = ContentAlignment.MiddleLeft;
            FdepartmanBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            FdepartmanBtn.UseVisualStyleBackColor = false;
            FdepartmanBtn.Click += FdepartmanBtn_Click;
            // 
            // bupanel
            // 
            bupanel.BackColor = Color.FromArgb(51, 52, 78);
            bupanel.Location = new Point(0, 69);
            bupanel.Margin = new Padding(2);
            bupanel.Name = "bupanel";
            bupanel.Size = new Size(13, 52);
            bupanel.TabIndex = 1;
            // 
            // butAnasayfa
            // 
            butAnasayfa.BackColor = Color.FromArgb(41, 128, 185);
            butAnasayfa.FlatAppearance.BorderSize = 0;
            butAnasayfa.FlatStyle = FlatStyle.Flat;
            butAnasayfa.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            butAnasayfa.ForeColor = Color.White;
            butAnasayfa.Image = (Image)resources.GetObject("butAnasayfa.Image");
            butAnasayfa.ImageAlign = ContentAlignment.MiddleLeft;
            butAnasayfa.Location = new Point(16, 68);
            butAnasayfa.Name = "butAnasayfa";
            butAnasayfa.Size = new Size(174, 70);
            butAnasayfa.TabIndex = 13;
            butAnasayfa.Text = "  Ana Sayfa";
            butAnasayfa.TextAlign = ContentAlignment.MiddleLeft;
            butAnasayfa.TextImageRelation = TextImageRelation.ImageBeforeText;
            butAnasayfa.UseVisualStyleBackColor = false;
            butAnasayfa.Click += butAnasayfa_Click_1;
            // 
            // FgecikmisBtn
            // 
            FgecikmisBtn.BackColor = Color.FromArgb(41, 128, 185);
            FgecikmisBtn.FlatAppearance.BorderSize = 0;
            FgecikmisBtn.FlatStyle = FlatStyle.Flat;
            FgecikmisBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            FgecikmisBtn.ForeColor = Color.White;
            FgecikmisBtn.Image = (Image)resources.GetObject("FgecikmisBtn.Image");
            FgecikmisBtn.ImageAlign = ContentAlignment.MiddleLeft;
            FgecikmisBtn.Location = new Point(17, 324);
            FgecikmisBtn.Name = "FgecikmisBtn";
            FgecikmisBtn.Size = new Size(174, 70);
            FgecikmisBtn.TabIndex = 12;
            FgecikmisBtn.Text = "Gecikmiş Emanetler";
            FgecikmisBtn.TextAlign = ContentAlignment.MiddleLeft;
            FgecikmisBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            FgecikmisBtn.UseVisualStyleBackColor = false;
            FgecikmisBtn.Click += FgecikmisBtn_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(81, 116, 148);
            panel3.Controls.Add(menuButton);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(210, 68);
            panel3.TabIndex = 1;
            // 
            // menuButton
            // 
            menuButton.Cursor = Cursors.Hand;
            menuButton.Image = Properties.Resources.menu__1_;
            menuButton.Location = new Point(25, 7);
            menuButton.Margin = new Padding(2);
            menuButton.Name = "menuButton";
            menuButton.Size = new Size(53, 50);
            menuButton.TabIndex = 14;
            menuButton.TabStop = false;
            menuButton.Click += menuButton_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(105, 23);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(50, 21);
            label2.TabIndex = 13;
            label2.Text = "Menü";
            // 
            // FdosyaBtn
            // 
            FdosyaBtn.BackColor = Color.FromArgb(41, 128, 185);
            FdosyaBtn.FlatAppearance.BorderSize = 0;
            FdosyaBtn.FlatStyle = FlatStyle.Flat;
            FdosyaBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            FdosyaBtn.ForeColor = Color.White;
            FdosyaBtn.Image = (Image)resources.GetObject("FdosyaBtn.Image");
            FdosyaBtn.ImageAlign = ContentAlignment.MiddleLeft;
            FdosyaBtn.Location = new Point(17, 150);
            FdosyaBtn.Name = "FdosyaBtn";
            FdosyaBtn.Size = new Size(174, 70);
            FdosyaBtn.TabIndex = 10;
            FdosyaBtn.Text = "Dosya Türü   Belirle";
            FdosyaBtn.TextAlign = ContentAlignment.MiddleLeft;
            FdosyaBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            FdosyaBtn.UseVisualStyleBackColor = false;
            FdosyaBtn.Click += FdosyaBtn_Click;
            // 
            // FhesapBtn
            // 
            FhesapBtn.BackColor = Color.FromArgb(41, 128, 185);
            FhesapBtn.FlatAppearance.BorderSize = 0;
            FhesapBtn.FlatStyle = FlatStyle.Flat;
            FhesapBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            FhesapBtn.ForeColor = Color.White;
            FhesapBtn.Image = (Image)resources.GetObject("FhesapBtn.Image");
            FhesapBtn.ImageAlign = ContentAlignment.MiddleLeft;
            FhesapBtn.Location = new Point(17, 498);
            FhesapBtn.Name = "FhesapBtn";
            FhesapBtn.Size = new Size(174, 70);
            FhesapBtn.TabIndex = 9;
            FhesapBtn.Text = "Hesap Bilgilerim";
            FhesapBtn.TextAlign = ContentAlignment.MiddleLeft;
            FhesapBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            FhesapBtn.UseVisualStyleBackColor = false;
            FhesapBtn.Click += FhesapBtn_Click;
            // 
            // FmemurBtn
            // 
            FmemurBtn.BackColor = Color.FromArgb(41, 128, 185);
            FmemurBtn.FlatAppearance.BorderSize = 0;
            FmemurBtn.FlatStyle = FlatStyle.Flat;
            FmemurBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            FmemurBtn.ForeColor = Color.White;
            FmemurBtn.Image = (Image)resources.GetObject("FmemurBtn.Image");
            FmemurBtn.ImageAlign = ContentAlignment.MiddleLeft;
            FmemurBtn.Location = new Point(17, 411);
            FmemurBtn.Name = "FmemurBtn";
            FmemurBtn.Size = new Size(174, 70);
            FmemurBtn.TabIndex = 11;
            FmemurBtn.Text = "Memur İşlemleri";
            FmemurBtn.TextAlign = ContentAlignment.MiddleLeft;
            FmemurBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            FmemurBtn.UseVisualStyleBackColor = false;
            FmemurBtn.Click += FmemurBtn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(51, 52, 78);
            panel2.Controls.Add(Minbtn);
            panel2.Controls.Add(Maxbtn2);
            panel2.Controls.Add(kapat);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1025, 25);
            panel2.TabIndex = 17;
            panel2.MouseDown += panel2_MouseDown_1;
            panel2.MouseMove += panel2_MouseMove_1;
            panel2.MouseUp += panel2_MouseUp_1;
            // 
            // Minbtn
            // 
            Minbtn.BackColor = Color.DimGray;
            Minbtn.Dock = DockStyle.Right;
            Minbtn.FlatAppearance.BorderSize = 0;
            Minbtn.FlatStyle = FlatStyle.Flat;
            Minbtn.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Minbtn.ForeColor = Color.WhiteSmoke;
            Minbtn.Image = Properties.Resources.icons8_minus_241;
            Minbtn.Location = new Point(911, 0);
            Minbtn.Margin = new Padding(2);
            Minbtn.Name = "Minbtn";
            Minbtn.Size = new Size(38, 25);
            Minbtn.TabIndex = 3;
            Minbtn.UseVisualStyleBackColor = false;
            Minbtn.Click += Minbtn_Click_1;
            // 
            // Maxbtn2
            // 
            Maxbtn2.BackColor = Color.DimGray;
            Maxbtn2.Dock = DockStyle.Right;
            Maxbtn2.FlatAppearance.BorderSize = 0;
            Maxbtn2.FlatStyle = FlatStyle.Flat;
            Maxbtn2.ForeColor = Color.White;
            Maxbtn2.Image = (Image)resources.GetObject("Maxbtn2.Image");
            Maxbtn2.Location = new Point(949, 0);
            Maxbtn2.Margin = new Padding(2);
            Maxbtn2.Name = "Maxbtn2";
            Maxbtn2.Size = new Size(38, 25);
            Maxbtn2.TabIndex = 2;
            Maxbtn2.UseVisualStyleBackColor = false;
            Maxbtn2.Click += Maxbtn2_Click;
            // 
            // kapat
            // 
            kapat.BackColor = Color.DimGray;
            kapat.Dock = DockStyle.Right;
            kapat.FlatAppearance.BorderSize = 0;
            kapat.FlatStyle = FlatStyle.Flat;
            kapat.ForeColor = Color.White;
            kapat.Location = new Point(987, 0);
            kapat.Margin = new Padding(2);
            kapat.Name = "kapat";
            kapat.Size = new Size(38, 25);
            kapat.TabIndex = 1;
            kapat.Text = "X";
            kapat.UseVisualStyleBackColor = false;
            kapat.Click += kapat_Click_1;
            // 
            // timer1
            // 
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1025, 607);
            Controls.Add(mainpanel);
            Controls.Add(sidebar);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(2);
            Name = "Form2";
            StartPosition = FormStartPosition.Manual;
            Text = "Form2";
            WindowState = FormWindowState.Maximized;
            mainpanel.ResumeLayout(false);
            mainpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            sidebar.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)menuButton).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel mainpanel;
        private Label label3;
        private PictureBox pictureBox1;
        private Panel sidebar;
        private Button FdepartmanBtn;
        private Panel bupanel;
        private Button butAnasayfa;
        private Panel panel3;
        private PictureBox menuButton;
        private Label label2;
        private Button FdosyaBtn;
        private Button FgecikmisBtn;
        private Button FhesapBtn;
        private Button FmemurBtn;
        private Panel panel2;
        private Button Minbtn;
        private Button Maxbtn2;
        private Button kapat;
        private System.Windows.Forms.Timer timer1;
    }
}