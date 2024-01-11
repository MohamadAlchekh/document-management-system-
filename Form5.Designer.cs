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
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(347, 29);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(437, 77);
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
            butOnayla5.Location = new Point(407, 407);
            butOnayla5.Margin = new Padding(4, 5, 4, 5);
            butOnayla5.Name = "butOnayla5";
            butOnayla5.Size = new Size(291, 65);
            butOnayla5.TabIndex = 37;
            butOnayla5.Text = "Onayla";
            butOnayla5.UseVisualStyleBackColor = false;
            butOnayla5.Click += butOnayla5_Click;
            // 
            // txtBoxŞifreGüncelle5
            // 
            txtBoxŞifreGüncelle5.Anchor = AnchorStyles.None;
            txtBoxŞifreGüncelle5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxŞifreGüncelle5.Location = new Point(537, 309);
            txtBoxŞifreGüncelle5.Margin = new Padding(4, 5, 4, 5);
            txtBoxŞifreGüncelle5.Multiline = true;
            txtBoxŞifreGüncelle5.Name = "txtBoxŞifreGüncelle5";
            txtBoxŞifreGüncelle5.PasswordChar = '*';
            txtBoxŞifreGüncelle5.Size = new Size(210, 52);
            txtBoxŞifreGüncelle5.TabIndex = 36;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(371, 309);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(141, 55);
            label2.TabIndex = 35;
            label2.Text = "Şifre :";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtBoxKullAdıGüncelle5
            // 
            txtBoxKullAdıGüncelle5.Anchor = AnchorStyles.None;
            txtBoxKullAdıGüncelle5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxKullAdıGüncelle5.Location = new Point(537, 222);
            txtBoxKullAdıGüncelle5.Margin = new Padding(4, 5, 4, 5);
            txtBoxKullAdıGüncelle5.Multiline = true;
            txtBoxKullAdıGüncelle5.Name = "txtBoxKullAdıGüncelle5";
            txtBoxKullAdıGüncelle5.Size = new Size(210, 52);
            txtBoxKullAdıGüncelle5.TabIndex = 34;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.BackColor = SystemColors.Control;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(371, 222);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(141, 55);
            label8.TabIndex = 33;
            label8.Text = "Kullanıcı adı :";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1143, 750);
            Controls.Add(butOnayla5);
            Controls.Add(txtBoxŞifreGüncelle5);
            Controls.Add(label2);
            Controls.Add(txtBoxKullAdıGüncelle5);
            Controls.Add(label8);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form5";
            Text = "Hesap bilgilerimi güncelle";
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
    }
}