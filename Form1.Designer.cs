namespace document_management_system
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtBoxKullAdı1 = new TextBox();
            txtBoxŞifre1 = new TextBox();
            radioButKullanıcı1 = new RadioButton();
            radioButFsekreteri1 = new RadioButton();
            butOnayla1 = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-4, 3);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(169, 152);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(473, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(151, 83);
            label1.TabIndex = 1;
            label1.Text = "Giriş";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(366, 252);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(99, 45);
            label2.TabIndex = 2;
            label2.Text = "Şifre :";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(313, 165);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(151, 50);
            label3.TabIndex = 3;
            label3.Text = "Kullanıcı adı :";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtBoxKullAdı1
            // 
            txtBoxKullAdı1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxKullAdı1.Location = new Point(496, 165);
            txtBoxKullAdı1.Margin = new Padding(4, 5, 4, 5);
            txtBoxKullAdı1.Multiline = true;
            txtBoxKullAdı1.Name = "txtBoxKullAdı1";
            txtBoxKullAdı1.Size = new Size(198, 47);
            txtBoxKullAdı1.TabIndex = 4;
            // 
            // txtBoxŞifre1
            // 
            txtBoxŞifre1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxŞifre1.Location = new Point(496, 247);
            txtBoxŞifre1.Margin = new Padding(4, 5, 4, 5);
            txtBoxŞifre1.Multiline = true;
            txtBoxŞifre1.Name = "txtBoxŞifre1";
            txtBoxŞifre1.PasswordChar = '*';
            txtBoxŞifre1.Size = new Size(198, 47);
            txtBoxŞifre1.TabIndex = 5;
            // 
            // radioButKullanıcı1
            // 
            radioButKullanıcı1.Location = new Point(561, 348);
            radioButKullanıcı1.Margin = new Padding(4, 5, 4, 5);
            radioButKullanıcı1.Name = "radioButKullanıcı1";
            radioButKullanıcı1.Size = new Size(134, 32);
            radioButKullanıcı1.TabIndex = 6;
            radioButKullanıcı1.TabStop = true;
            radioButKullanıcı1.Text = "Kullanıcı ";
            radioButKullanıcı1.UseVisualStyleBackColor = true;
            // 
            // radioButFsekreteri1
            // 
            radioButFsekreteri1.AutoSize = true;
            radioButFsekreteri1.Location = new Point(366, 348);
            radioButFsekreteri1.Margin = new Padding(4, 5, 4, 5);
            radioButFsekreteri1.Name = "radioButFsekreteri1";
            radioButFsekreteri1.Size = new Size(163, 29);
            radioButFsekreteri1.TabIndex = 7;
            radioButFsekreteri1.TabStop = true;
            radioButFsekreteri1.Text = "Fakülte sekreteri";
            radioButFsekreteri1.UseVisualStyleBackColor = true;
            // 
            // butOnayla1
            // 
            butOnayla1.BackColor = SystemColors.GradientActiveCaption;
            butOnayla1.FlatStyle = FlatStyle.Flat;
            butOnayla1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            butOnayla1.Location = new Point(404, 415);
            butOnayla1.Margin = new Padding(4, 5, 4, 5);
            butOnayla1.Name = "butOnayla1";
            butOnayla1.Size = new Size(291, 65);
            butOnayla1.TabIndex = 8;
            butOnayla1.Text = "Onayla";
            butOnayla1.UseVisualStyleBackColor = false;
            
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(799, 132);
            pictureBox2.Margin = new Padding(4, 5, 4, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(306, 295);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1123, 508);
            Controls.Add(radioButKullanıcı1);
            Controls.Add(radioButFsekreteri1);
            Controls.Add(pictureBox2);
            Controls.Add(butOnayla1);
            Controls.Add(txtBoxŞifre1);
            Controls.Add(txtBoxKullAdı1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giriş";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtBoxKullAdı1;
        private TextBox txtBoxŞifre1;
        private RadioButton radioButKullanıcı1;
        private RadioButton radioButFsekreteri1;
        private Button butOnayla1;
        private PictureBox pictureBox2;
    }
}