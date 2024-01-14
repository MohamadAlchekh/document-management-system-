namespace document_management_system
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            label1 = new Label();
            butOnayla5 = new Button();
            txtBoxŞifreGüncelle5 = new TextBox();
            label2 = new Label();
            txtBoxKullAdıGüncelle5 = new TextBox();
            label8 = new Label();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(266, 9);
            label1.Name = "label1";
            label1.Size = new Size(281, 47);
            label1.TabIndex = 3;
            label1.Text = "Hesap bilgilerimi güncelle";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // butOnayla5
            // 
            butOnayla5.Anchor = AnchorStyles.None;
            butOnayla5.BackColor = SystemColors.GradientActiveCaption;
            butOnayla5.FlatStyle = FlatStyle.Flat;
            butOnayla5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            butOnayla5.Location = new Point(308, 236);
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
            txtBoxŞifreGüncelle5.Location = new Point(399, 177);
            txtBoxŞifreGüncelle5.Multiline = true;
            txtBoxŞifreGüncelle5.Name = "txtBoxŞifreGüncelle5";
            txtBoxŞifreGüncelle5.PasswordChar = '*';
            txtBoxŞifreGüncelle5.Size = new Size(148, 33);
            txtBoxŞifreGüncelle5.TabIndex = 36;
            txtBoxŞifreGüncelle5.TextChanged += txtBoxŞifreGüncelle5_TextChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(283, 177);
            label2.Name = "label2";
            label2.Size = new Size(99, 33);
            label2.TabIndex = 35;
            label2.Text = "Şifre :";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtBoxKullAdıGüncelle5
            // 
            txtBoxKullAdıGüncelle5.Anchor = AnchorStyles.None;
            txtBoxKullAdıGüncelle5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxKullAdıGüncelle5.Location = new Point(399, 125);
            txtBoxKullAdıGüncelle5.Multiline = true;
            txtBoxKullAdıGüncelle5.Name = "txtBoxKullAdıGüncelle5";
            txtBoxKullAdıGüncelle5.Size = new Size(148, 33);
            txtBoxKullAdıGüncelle5.TabIndex = 34;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.BackColor = SystemColors.Control;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(283, 125);
            label8.Name = "label8";
            label8.Size = new Size(99, 33);
            label8.TabIndex = 33;
            label8.Text = "Kullanıcı adı :";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // checkBox1
            // 
            checkBox1.Anchor = AnchorStyles.None;
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(553, 186);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(60, 19);
            checkBox1.TabIndex = 38;
            checkBox1.Text = "Göster";
            checkBox1.TextAlign = ContentAlignment.TopCenter;
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBox1);
            Controls.Add(butOnayla5);
            Controls.Add(txtBoxŞifreGüncelle5);
            Controls.Add(label2);
            Controls.Add(txtBoxKullAdıGüncelle5);
            Controls.Add(label8);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form5";
            Text = "Hesap bilgilerimi güncelle";
            Load += Form5_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button butOnayla5;
        private TextBox txtBoxŞifreGüncelle5;
        private Label label2;
        private TextBox txtBoxKullAdıGüncelle5;
        private Label label8;
        private CheckBox checkBox1;
    }
}