namespace document_management_system
{
    partial class Hesapbilgilerimigüncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hesapbilgilerimigüncelle));
            label1 = new Label();
            butOnayla5 = new Button();
            txtBoxŞifreGüncelle5 = new TextBox();
            txtBoxKullAdıGüncelle5 = new TextBox();
            checkBox1 = new CheckBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(212, 9);
            label1.Name = "label1";
            label1.Size = new Size(294, 47);
            label1.TabIndex = 3;
            label1.Text = "Hesap Bilgilerimi Güncelle";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // butOnayla5
            // 
            butOnayla5.Anchor = AnchorStyles.None;
            butOnayla5.BackColor = SystemColors.GradientActiveCaption;
            butOnayla5.Cursor = Cursors.Hand;
            butOnayla5.FlatStyle = FlatStyle.Flat;
            butOnayla5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            butOnayla5.Location = new Point(262, 318);
            butOnayla5.Name = "butOnayla5";
            butOnayla5.Size = new Size(204, 39);
            butOnayla5.TabIndex = 37;
            butOnayla5.Text = "Onayla";
            butOnayla5.UseVisualStyleBackColor = false;
            butOnayla5.Click += butOnayla5_Click;
            // 
            // txtBoxŞifreGüncelle5
            // 
            txtBoxŞifreGüncelle5.Anchor = AnchorStyles.None;
            txtBoxŞifreGüncelle5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxŞifreGüncelle5.Location = new Point(192, 218);
            txtBoxŞifreGüncelle5.Multiline = true;
            txtBoxŞifreGüncelle5.Name = "txtBoxŞifreGüncelle5";
            txtBoxŞifreGüncelle5.PasswordChar = '*';
            txtBoxŞifreGüncelle5.Size = new Size(347, 33);
            txtBoxŞifreGüncelle5.TabIndex = 36;
            // 
            // txtBoxKullAdıGüncelle5
            // 
            txtBoxKullAdıGüncelle5.Anchor = AnchorStyles.None;
            txtBoxKullAdıGüncelle5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxKullAdıGüncelle5.Location = new Point(192, 166);
            txtBoxKullAdıGüncelle5.Multiline = true;
            txtBoxKullAdıGüncelle5.Name = "txtBoxKullAdıGüncelle5";
            txtBoxKullAdıGüncelle5.Size = new Size(347, 33);
            txtBoxKullAdıGüncelle5.TabIndex = 34;
            // 
            // checkBox1
            // 
            checkBox1.Anchor = AnchorStyles.None;
            checkBox1.AutoSize = true;
            checkBox1.Cursor = Cursors.Hand;
            checkBox1.Location = new Point(545, 222);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(60, 19);
            checkBox1.TabIndex = 38;
            checkBox1.Text = "Göster";
            checkBox1.TextAlign = ContentAlignment.TopCenter;
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(51, 52, 78);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(671, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(129, 450);
            panel1.TabIndex = 39;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(105, 109);
            pictureBox1.TabIndex = 81;
            pictureBox1.TabStop = false;
            // 
            // Hesapbilgilerimigüncelle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(checkBox1);
            Controls.Add(butOnayla5);
            Controls.Add(txtBoxŞifreGüncelle5);
            Controls.Add(txtBoxKullAdıGüncelle5);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Hesapbilgilerimigüncelle";
            Text = "Hesap bilgilerimi güncelle";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button butOnayla5;
        private TextBox txtBoxŞifreGüncelle5;
        private TextBox txtBoxKullAdıGüncelle5;
        private CheckBox checkBox1;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}