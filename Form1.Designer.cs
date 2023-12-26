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
            radioButKullınıcı1 = new RadioButton();
            radButFsekreteri = new RadioButton();
            button1 = new Button();
            pictureBox2 = new PictureBox();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(118, 91);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(331, 9);
            label1.Name = "label1";
            label1.Size = new Size(106, 50);
            label1.TabIndex = 1;
            label1.Text = "Giriş";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(256, 151);
            label2.Name = "label2";
            label2.Size = new Size(69, 27);
            label2.TabIndex = 2;
            label2.Text = "Şifre :";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(219, 99);
            label3.Name = "label3";
            label3.Size = new Size(106, 30);
            label3.TabIndex = 3;
            label3.Text = "Kullanıcı adı :";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtBoxKullAdı1
            // 
            txtBoxKullAdı1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxKullAdı1.Location = new Point(347, 99);
            txtBoxKullAdı1.Multiline = true;
            txtBoxKullAdı1.Name = "txtBoxKullAdı1";
            txtBoxKullAdı1.Size = new Size(140, 30);
            txtBoxKullAdı1.TabIndex = 4;
            // 
            // txtBoxŞifre1
            // 
            txtBoxŞifre1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxŞifre1.Location = new Point(347, 148);
            txtBoxŞifre1.Multiline = true;
            txtBoxŞifre1.Name = "txtBoxŞifre1";
            txtBoxŞifre1.PasswordChar = '*';
            txtBoxŞifre1.Size = new Size(140, 30);
            txtBoxŞifre1.TabIndex = 5;
            // 
            // radioButKullınıcı1
            // 
            radioButKullınıcı1.AutoSize = true;
            radioButKullınıcı1.Location = new Point(121, 22);
            radioButKullınıcı1.Name = "radioButKullınıcı1";
            radioButKullınıcı1.Size = new Size(94, 19);
            radioButKullınıcı1.TabIndex = 6;
            radioButKullınıcı1.TabStop = true;
            radioButKullınıcı1.Text = "radioButton1";
            radioButKullınıcı1.UseVisualStyleBackColor = true;
            // 
            // radButFsekreteri
            // 
            radButFsekreteri.AutoSize = true;
            radButFsekreteri.Location = new Point(6, 22);
            radButFsekreteri.Name = "radButFsekreteri";
            radButFsekreteri.Size = new Size(110, 19);
            radButFsekreteri.TabIndex = 7;
            radButFsekreteri.TabStop = true;
            radButFsekreteri.Text = "Fakülte sekreteri";
            radButFsekreteri.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(283, 249);
            button1.Name = "button1";
            button1.Size = new Size(204, 39);
            button1.TabIndex = 8;
            button1.Text = "Onayla";
            button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(559, 79);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(214, 177);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radButFsekreteri);
            groupBox1.Controls.Add(radioButKullınıcı1);
            groupBox1.Location = new Point(229, 196);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(270, 47);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(786, 305);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox2);
            Controls.Add(button1);
            Controls.Add(txtBoxŞifre1);
            Controls.Add(txtBoxKullAdı1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giriş";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private RadioButton radioButKullınıcı1;
        private RadioButton radButFsekreteri;
        private Button button1;
        private PictureBox pictureBox2;
        private GroupBox groupBox1;
    }
}