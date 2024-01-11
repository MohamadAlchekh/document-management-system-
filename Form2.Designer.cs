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
            label1 = new Label();
            sidebar = new Panel();
            MemurDepartman = new Button();
            bupanel = new Panel();
            butAnasayfa = new Button();
            panel3 = new Panel();
            menuButton = new PictureBox();
            label2 = new Label();
            butDosyaTürleri2 = new Button();
            butGecikmisEmanetler2 = new Button();
            butHesapBilgiGüncelle2 = new Button();
            butMemurişlemleri2 = new Button();
            panel2 = new Panel();
            Minbtn = new Button();
            Maxbtn2 = new Button();
            kapat = new Button();
            sidebarTimer = new System.Windows.Forms.Timer(components);
            mainpanel = new Panel();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            sidebar.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menuButton).BeginInit();
            panel2.SuspendLayout();
            mainpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(416, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(294, 78);
            label1.TabIndex = 2;
            label1.Text = "Fakülte sekreteri";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(41, 128, 185);
            sidebar.Controls.Add(MemurDepartman);
            sidebar.Controls.Add(bupanel);
            sidebar.Controls.Add(butAnasayfa);
            sidebar.Controls.Add(panel3);
            sidebar.Controls.Add(butDosyaTürleri2);
            sidebar.Controls.Add(butGecikmisEmanetler2);
            sidebar.Controls.Add(butHesapBilgiGüncelle2);
            sidebar.Controls.Add(butMemurişlemleri2);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 41);
            sidebar.MaximumSize = new Size(265, 1500);
            sidebar.MinimumSize = new Size(96, 716);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(265, 716);
            sidebar.TabIndex = 13;
            // 
            // MemurDepartman
            // 
            MemurDepartman.BackColor = Color.FromArgb(41, 128, 185);
            MemurDepartman.FlatAppearance.BorderSize = 0;
            MemurDepartman.FlatStyle = FlatStyle.Flat;
            MemurDepartman.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            MemurDepartman.ForeColor = Color.White;
            MemurDepartman.Image = (Image)resources.GetObject("MemurDepartman.Image");
            MemurDepartman.ImageAlign = ContentAlignment.MiddleLeft;
            MemurDepartman.Location = new Point(21, 305);
            MemurDepartman.Margin = new Padding(4, 5, 4, 5);
            MemurDepartman.Name = "MemurDepartman";
            MemurDepartman.Size = new Size(248, 86);
            MemurDepartman.TabIndex = 14;
            MemurDepartman.Text = "Departman İşlemleri";
            MemurDepartman.TextAlign = ContentAlignment.MiddleLeft;
            MemurDepartman.TextImageRelation = TextImageRelation.ImageBeforeText;
            MemurDepartman.UseVisualStyleBackColor = false;
            MemurDepartman.Click += MemurDepartman_Click;
            // 
            // bupanel
            // 
            bupanel.BackColor = Color.FromArgb(51, 52, 78);
            bupanel.Location = new Point(0, 115);
            bupanel.Name = "bupanel";
            bupanel.Size = new Size(18, 87);
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
            butAnasayfa.Location = new Point(21, 116);
            butAnasayfa.Margin = new Padding(4, 5, 4, 5);
            butAnasayfa.Name = "butAnasayfa";
            butAnasayfa.Size = new Size(248, 86);
            butAnasayfa.TabIndex = 13;
            butAnasayfa.Text = "  Ana Sayfa";
            butAnasayfa.TextAlign = ContentAlignment.MiddleLeft;
            butAnasayfa.TextImageRelation = TextImageRelation.ImageBeforeText;
            butAnasayfa.UseVisualStyleBackColor = false;
            butAnasayfa.Click += butAnasayfa_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(81, 116, 148);
            panel3.Controls.Add(menuButton);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(300, 114);
            panel3.TabIndex = 1;
            // 
            // menuButton
            // 
            menuButton.Cursor = Cursors.Hand;
            menuButton.Image = Properties.Resources.icons8_menu_50;
            menuButton.Location = new Point(23, 29);
            menuButton.Name = "menuButton";
            menuButton.Size = new Size(47, 53);
            menuButton.TabIndex = 14;
            menuButton.TabStop = false;
            menuButton.Click += menuButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(100, 40);
            label2.Name = "label2";
            label2.Size = new Size(77, 32);
            label2.TabIndex = 13;
            label2.Text = "Menü";
            // 
            // butDosyaTürleri2
            // 
            butDosyaTürleri2.BackColor = Color.FromArgb(41, 128, 185);
            butDosyaTürleri2.FlatAppearance.BorderSize = 0;
            butDosyaTürleri2.FlatStyle = FlatStyle.Flat;
            butDosyaTürleri2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            butDosyaTürleri2.ForeColor = Color.White;
            butDosyaTürleri2.Image = (Image)resources.GetObject("butDosyaTürleri2.Image");
            butDosyaTürleri2.ImageAlign = ContentAlignment.MiddleLeft;
            butDosyaTürleri2.Location = new Point(21, 209);
            butDosyaTürleri2.Margin = new Padding(4, 5, 4, 5);
            butDosyaTürleri2.Name = "butDosyaTürleri2";
            butDosyaTürleri2.Size = new Size(248, 86);
            butDosyaTürleri2.TabIndex = 10;
            butDosyaTürleri2.Text = "Dosya Türü   Belirle";
            butDosyaTürleri2.TextAlign = ContentAlignment.MiddleLeft;
            butDosyaTürleri2.TextImageRelation = TextImageRelation.ImageBeforeText;
            butDosyaTürleri2.UseVisualStyleBackColor = false;
            butDosyaTürleri2.Click += butDosyaTürleri2_Click;
            // 
            // butGecikmisEmanetler2
            // 
            butGecikmisEmanetler2.BackColor = Color.FromArgb(41, 128, 185);
            butGecikmisEmanetler2.FlatAppearance.BorderSize = 0;
            butGecikmisEmanetler2.FlatStyle = FlatStyle.Flat;
            butGecikmisEmanetler2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            butGecikmisEmanetler2.ForeColor = Color.White;
            butGecikmisEmanetler2.Image = (Image)resources.GetObject("butGecikmisEmanetler2.Image");
            butGecikmisEmanetler2.ImageAlign = ContentAlignment.MiddleLeft;
            butGecikmisEmanetler2.Location = new Point(21, 495);
            butGecikmisEmanetler2.Margin = new Padding(4, 5, 4, 5);
            butGecikmisEmanetler2.Name = "butGecikmisEmanetler2";
            butGecikmisEmanetler2.Size = new Size(248, 86);
            butGecikmisEmanetler2.TabIndex = 12;
            butGecikmisEmanetler2.Text = "Gecikmiş Emanetler";
            butGecikmisEmanetler2.TextAlign = ContentAlignment.MiddleLeft;
            butGecikmisEmanetler2.TextImageRelation = TextImageRelation.ImageBeforeText;
            butGecikmisEmanetler2.UseVisualStyleBackColor = false;
            butGecikmisEmanetler2.Click += butGecikmisEmanetler2_Click;
            // 
            // butHesapBilgiGüncelle2
            // 
            butHesapBilgiGüncelle2.BackColor = Color.FromArgb(41, 128, 185);
            butHesapBilgiGüncelle2.FlatAppearance.BorderSize = 0;
            butHesapBilgiGüncelle2.FlatStyle = FlatStyle.Flat;
            butHesapBilgiGüncelle2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            butHesapBilgiGüncelle2.ForeColor = Color.White;
            butHesapBilgiGüncelle2.Image = (Image)resources.GetObject("butHesapBilgiGüncelle2.Image");
            butHesapBilgiGüncelle2.ImageAlign = ContentAlignment.MiddleLeft;
            butHesapBilgiGüncelle2.Location = new Point(21, 590);
            butHesapBilgiGüncelle2.Margin = new Padding(4, 5, 4, 5);
            butHesapBilgiGüncelle2.Name = "butHesapBilgiGüncelle2";
            butHesapBilgiGüncelle2.Size = new Size(248, 86);
            butHesapBilgiGüncelle2.TabIndex = 9;
            butHesapBilgiGüncelle2.Text = "Hesap Bilgilerim";
            butHesapBilgiGüncelle2.TextAlign = ContentAlignment.MiddleLeft;
            butHesapBilgiGüncelle2.TextImageRelation = TextImageRelation.ImageBeforeText;
            butHesapBilgiGüncelle2.UseVisualStyleBackColor = false;
            butHesapBilgiGüncelle2.Click += butHesapBilgiGüncelle2_Click;
            // 
            // butMemurişlemleri2
            // 
            butMemurişlemleri2.BackColor = Color.FromArgb(41, 128, 185);
            butMemurişlemleri2.FlatAppearance.BorderSize = 0;
            butMemurişlemleri2.FlatStyle = FlatStyle.Flat;
            butMemurişlemleri2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            butMemurişlemleri2.ForeColor = Color.White;
            butMemurişlemleri2.Image = (Image)resources.GetObject("butMemurişlemleri2.Image");
            butMemurişlemleri2.ImageAlign = ContentAlignment.MiddleLeft;
            butMemurişlemleri2.Location = new Point(21, 400);
            butMemurişlemleri2.Margin = new Padding(4, 5, 4, 5);
            butMemurişlemleri2.Name = "butMemurişlemleri2";
            butMemurişlemleri2.Size = new Size(248, 86);
            butMemurişlemleri2.TabIndex = 11;
            butMemurişlemleri2.Text = "Memur İşlemleri";
            butMemurişlemleri2.TextAlign = ContentAlignment.MiddleLeft;
            butMemurişlemleri2.TextImageRelation = TextImageRelation.ImageBeforeText;
            butMemurişlemleri2.UseVisualStyleBackColor = false;
            butMemurişlemleri2.Click += butMemurişlemleri2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(51, 52, 78);
            panel2.Controls.Add(Minbtn);
            panel2.Controls.Add(Maxbtn2);
            panel2.Controls.Add(kapat);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1370, 41);
            panel2.TabIndex = 14;
            panel2.MouseDown += panel2_MouseDown;
            panel2.MouseMove += panel2_MouseMove;
            panel2.MouseUp += panel2_MouseUp;
            // 
            // Minbtn
            // 
            Minbtn.BackColor = Color.DimGray;
            Minbtn.Dock = DockStyle.Right;
            Minbtn.FlatAppearance.BorderSize = 0;
            Minbtn.FlatStyle = FlatStyle.Flat;
            Minbtn.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Minbtn.ForeColor = Color.WhiteSmoke;
            Minbtn.Image = Properties.Resources.icons8_minus_24;
            Minbtn.Location = new Point(1205, 0);
            Minbtn.Name = "Minbtn";
            Minbtn.Size = new Size(55, 41);
            Minbtn.TabIndex = 3;
            Minbtn.UseVisualStyleBackColor = false;
            Minbtn.Click += Minbtn_Click;
            // 
            // Maxbtn2
            // 
            Maxbtn2.BackColor = Color.DimGray;
            Maxbtn2.Dock = DockStyle.Right;
            Maxbtn2.FlatAppearance.BorderSize = 0;
            Maxbtn2.FlatStyle = FlatStyle.Flat;
            Maxbtn2.ForeColor = Color.White;
            Maxbtn2.Image = (Image)resources.GetObject("Maxbtn2.Image");
            Maxbtn2.Location = new Point(1260, 0);
            Maxbtn2.Name = "Maxbtn2";
            Maxbtn2.Size = new Size(55, 41);
            Maxbtn2.TabIndex = 2;
            Maxbtn2.UseVisualStyleBackColor = false;
            Maxbtn2.Click += Maxbtn_Click;
            // 
            // kapat
            // 
            kapat.BackColor = Color.DimGray;
            kapat.Dock = DockStyle.Right;
            kapat.FlatAppearance.BorderSize = 0;
            kapat.FlatStyle = FlatStyle.Flat;
            kapat.ForeColor = Color.White;
            kapat.Location = new Point(1315, 0);
            kapat.Name = "kapat";
            kapat.Size = new Size(55, 41);
            kapat.TabIndex = 1;
            kapat.Text = "X";
            kapat.UseVisualStyleBackColor = false;
            kapat.Click += kapat_Click;
            // 
            // sidebarTimer
            // 
            sidebarTimer.Interval = 10;
            sidebarTimer.Tick += sidebarTimer_Tick;
            // 
            // mainpanel
            // 
            mainpanel.BackColor = SystemColors.ActiveCaption;
            mainpanel.Controls.Add(label3);
            mainpanel.Controls.Add(pictureBox1);
            mainpanel.Dock = DockStyle.Fill;
            mainpanel.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            mainpanel.Location = new Point(265, 41);
            mainpanel.Name = "mainpanel";
            mainpanel.Size = new Size(1105, 716);
            mainpanel.TabIndex = 15;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(262, 29);
            label3.Name = "label3";
            label3.Size = new Size(565, 49);
            label3.TabIndex = 17;
            label3.Text = "Hoşgeldiniz Fakülte Sekreteri";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(238, 186);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(1370, 757);
            Controls.Add(mainpanel);
            Controls.Add(sidebar);
            Controls.Add(panel2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fakülte sekreteri";
            WindowState = FormWindowState.Maximized;
            sidebar.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)menuButton).EndInit();
            panel2.ResumeLayout(false);
            mainpanel.ResumeLayout(false);
            mainpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel sidebar;
        private Panel panel2;
        private Button kapat;
        private Panel panel3;
        private Label label2;
        private PictureBox menuButton;
        private Button butDosyaTürleri2;
        private Button butMemurişlemleri2;
        private Button butHesapBilgiGüncelle2;
        private Button butGecikmisEmanetler2;
        private System.Windows.Forms.Timer sidebarTimer;
        private Button butAnasayfa;
        private Panel mainpanel;
        private Panel bupanel;
        private Button Minbtn;
        private Button Maxbtn2;
        private Button MemurDepartman;
        private Label label3;
        private PictureBox pictureBox1;
    }
}