namespace document_management_system
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            label1 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtBoxKullAdı4 = new TextBox();
            label2 = new Label();
            txtBoxŞifre4 = new TextBox();
            label3 = new Label();
            txtBoxŞifreTekrarla4 = new TextBox();
            butOnayla4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(272, 9);
            label1.Name = "label1";
            label1.Size = new Size(207, 46);
            label1.TabIndex = 2;
            label1.Text = "Kullanıcı işlemleri ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.BackColor = SystemColors.Control;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(31, 68);
            label7.Name = "label7";
            label7.Size = new Size(210, 53);
            label7.TabIndex = 24;
            label7.Text = "Kullanıcı oluştur";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.BackColor = SystemColors.Control;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(12, 142);
            label8.Name = "label8";
            label8.Size = new Size(99, 33);
            label8.TabIndex = 25;
            label8.Text = "Kullanıcı adı :";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtBoxKullAdı4
            // 
            txtBoxKullAdı4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxKullAdı4.Location = new Point(128, 142);
            txtBoxKullAdı4.Multiline = true;
            txtBoxKullAdı4.Name = "txtBoxKullAdı4";
            txtBoxKullAdı4.Size = new Size(148, 33);
            txtBoxKullAdı4.TabIndex = 26;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 194);
            label2.Name = "label2";
            label2.Size = new Size(99, 33);
            label2.TabIndex = 27;
            label2.Text = "Şifre :";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtBoxŞifre4
            // 
            txtBoxŞifre4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxŞifre4.Location = new Point(128, 194);
            txtBoxŞifre4.Multiline = true;
            txtBoxŞifre4.Name = "txtBoxŞifre4";
            txtBoxŞifre4.Size = new Size(148, 33);
            txtBoxŞifre4.TabIndex = 28;
            // 
            // label3
            // 
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 246);
            label3.Name = "label3";
            label3.Size = new Size(99, 33);
            label3.TabIndex = 29;
            label3.Text = "Şifre tekrarla :";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtBoxŞifreTekrarla4
            // 
            txtBoxŞifreTekrarla4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxŞifreTekrarla4.Location = new Point(128, 246);
            txtBoxŞifreTekrarla4.Multiline = true;
            txtBoxŞifreTekrarla4.Name = "txtBoxŞifreTekrarla4";
            txtBoxŞifreTekrarla4.Size = new Size(148, 33);
            txtBoxŞifreTekrarla4.TabIndex = 30;
            // 
            // butOnayla4
            // 
            butOnayla4.BackColor = SystemColors.GradientActiveCaption;
            butOnayla4.FlatStyle = FlatStyle.Flat;
            butOnayla4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            butOnayla4.Location = new Point(37, 308);
            butOnayla4.Name = "butOnayla4";
            butOnayla4.Size = new Size(204, 39);
            butOnayla4.TabIndex = 31;
            butOnayla4.Text = "Onayla";
            butOnayla4.UseVisualStyleBackColor = false;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(butOnayla4);
            Controls.Add(txtBoxŞifreTekrarla4);
            Controls.Add(label3);
            Controls.Add(txtBoxŞifre4);
            Controls.Add(label2);
            Controls.Add(txtBoxKullAdı4);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form4";
            Text = "Kullanıcı işlemleri ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label7;
        private Label label8;
        private TextBox txtBoxKullAdı4;
        private Label label2;
        private TextBox txtBoxŞifre4;
        private Label label3;
        private TextBox txtBoxŞifreTekrarla4;
        private Button butOnayla4;
    }
}