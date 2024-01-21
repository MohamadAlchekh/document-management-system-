namespace document_management_system
{
    partial class Giriş
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giriş));
            label1 = new Label();
            txtBoxKullAdı1 = new TextBox();
            txtBoxŞifre1 = new TextBox();
            radioButKullanıcı1 = new RadioButton();
            radioButFsekreteri1 = new RadioButton();
            butOnayla1 = new Button();
            pictureBox2 = new PictureBox();
            checkBox1 = new CheckBox();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            pictureBox4 = new PictureBox();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(540, 12);
            label1.Name = "label1";
            label1.Size = new Size(138, 50);
            label1.TabIndex = 1;
            label1.Text = "Giriş Yap";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtBoxKullAdı1
            // 
            txtBoxKullAdı1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxKullAdı1.Location = new Point(65, 13);
            txtBoxKullAdı1.Multiline = true;
            txtBoxKullAdı1.Name = "txtBoxKullAdı1";
            txtBoxKullAdı1.Size = new Size(559, 30);
            txtBoxKullAdı1.TabIndex = 4;
            txtBoxKullAdı1.TextChanged += txtBoxKullAdı1_TextChanged;
            txtBoxKullAdı1.KeyDown += txtBoxKullAdı1_KeyDown;
            // 
            // txtBoxŞifre1
            // 
            txtBoxŞifre1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxŞifre1.Location = new Point(65, 12);
            txtBoxŞifre1.Multiline = true;
            txtBoxŞifre1.Name = "txtBoxŞifre1";
            txtBoxŞifre1.PasswordChar = '*';
            txtBoxŞifre1.Size = new Size(559, 30);
            txtBoxŞifre1.TabIndex = 5;
            txtBoxŞifre1.KeyDown += txtBoxŞifre1_KeyDown;
            // 
            // radioButKullanıcı1
            // 
            radioButKullanıcı1.Cursor = Cursors.Hand;
            radioButKullanıcı1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButKullanıcı1.Location = new Point(661, 280);
            radioButKullanıcı1.Name = "radioButKullanıcı1";
            radioButKullanıcı1.Size = new Size(111, 29);
            radioButKullanıcı1.TabIndex = 6;
            radioButKullanıcı1.TabStop = true;
            radioButKullanıcı1.Text = "Memur";
            radioButKullanıcı1.UseVisualStyleBackColor = true;
            // 
            // radioButFsekreteri1
            // 
            radioButFsekreteri1.AutoSize = true;
            radioButFsekreteri1.Cursor = Cursors.Hand;
            radioButFsekreteri1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButFsekreteri1.Location = new Point(432, 282);
            radioButFsekreteri1.Name = "radioButFsekreteri1";
            radioButFsekreteri1.Size = new Size(141, 25);
            radioButFsekreteri1.TabIndex = 7;
            radioButFsekreteri1.TabStop = true;
            radioButFsekreteri1.Text = "Fakülte sekreteri";
            radioButFsekreteri1.UseVisualStyleBackColor = true;
            // 
            // butOnayla1
            // 
            butOnayla1.BackColor = SystemColors.GradientActiveCaption;
            butOnayla1.Cursor = Cursors.Hand;
            butOnayla1.FlatStyle = FlatStyle.Flat;
            butOnayla1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            butOnayla1.Location = new Point(500, 340);
            butOnayla1.Name = "butOnayla1";
            butOnayla1.Size = new Size(204, 39);
            butOnayla1.TabIndex = 8;
            butOnayla1.Text = "Giriş Yap";
            butOnayla1.UseVisualStyleBackColor = false;
            butOnayla1.Click += butOnayla1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.padlock__1_;
            pictureBox2.Location = new Point(19, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 41);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 44;
            pictureBox2.TabStop = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Cursor = Cursors.Hand;
            checkBox1.Location = new Point(630, 15);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(60, 19);
            checkBox1.TabIndex = 39;
            checkBox1.Text = "Göster";
            checkBox1.TextAlign = ContentAlignment.TopCenter;
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(51, 52, 78);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(276, 492);
            panel1.TabIndex = 40;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(12, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(105, 109);
            pictureBox3.TabIndex = 84;
            pictureBox3.TabStop = false;
            // 
            // label6
            // 
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(47, 277);
            label6.Name = "label6";
            label6.Size = new Size(226, 30);
            label6.TabIndex = 6;
            label6.Text = "Döküman Yönetim Sistemi";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(97, 219);
            label5.Name = "label5";
            label5.Size = new Size(176, 30);
            label5.TabIndex = 5;
            label5.Text = "İşletme Fakültesi";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(66, 163);
            label4.Name = "label4";
            label4.Size = new Size(210, 30);
            label4.TabIndex = 4;
            label4.Text = "Bursa Uludağ Üniversitesi";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(txtBoxŞifre1);
            panel2.Controls.Add(checkBox1);
            panel2.Location = new Point(282, 201);
            panel2.Name = "panel2";
            panel2.Size = new Size(705, 56);
            panel2.TabIndex = 41;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(16, 12);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(43, 52);
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.SteelBlue;
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(txtBoxKullAdı1);
            panel3.Location = new Point(282, 134);
            panel3.Name = "panel3";
            panel3.Size = new Size(705, 56);
            panel3.TabIndex = 42;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(16, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(43, 53);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Giriş
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(999, 492);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(radioButKullanıcı1);
            Controls.Add(radioButFsekreteri1);
            Controls.Add(pictureBox2);
            Controls.Add(butOnayla1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Giriş";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giriş";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox txtBoxKullAdı1;
        private TextBox txtBoxŞifre1;
        private RadioButton radioButKullanıcı1;
        private RadioButton radioButFsekreteri1;
        private Button butOnayla1;
        private PictureBox pictureBox2;
        private CheckBox checkBox1;
        private Panel panel1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox1;
    }
}