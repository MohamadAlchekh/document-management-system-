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
            butOnayla4 = new Button();
            radioButHayır4 = new RadioButton();
            radioButEvet4 = new RadioButton();
            label6 = new Label();
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
            label1.Text = "Memur işlemleri";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.BackColor = SystemColors.Control;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(269, 94);
            label7.Name = "label7";
            label7.Size = new Size(210, 53);
            label7.TabIndex = 24;
            label7.Text = "Memur Kullanıcı oluştur";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.BackColor = SystemColors.Control;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(250, 168);
            label8.Name = "label8";
            label8.Size = new Size(99, 33);
            label8.TabIndex = 25;
            label8.Text = "Kullanıcı adı :";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtBoxKullAdı4
            // 
            txtBoxKullAdı4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxKullAdı4.Location = new Point(366, 168);
            txtBoxKullAdı4.Multiline = true;
            txtBoxKullAdı4.Name = "txtBoxKullAdı4";
            txtBoxKullAdı4.Size = new Size(148, 33);
            txtBoxKullAdı4.TabIndex = 26;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(250, 220);
            label2.Name = "label2";
            label2.Size = new Size(99, 33);
            label2.TabIndex = 27;
            label2.Text = "Şifre :";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtBoxŞifre4
            // 
            txtBoxŞifre4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxŞifre4.Location = new Point(366, 220);
            txtBoxŞifre4.Multiline = true;
            txtBoxŞifre4.Name = "txtBoxŞifre4";
            txtBoxŞifre4.PasswordChar = '*';
            txtBoxŞifre4.Size = new Size(148, 33);
            txtBoxŞifre4.TabIndex = 28;
            // 
            // butOnayla4
            // 
            butOnayla4.BackColor = SystemColors.GradientActiveCaption;
            butOnayla4.FlatStyle = FlatStyle.Flat;
            butOnayla4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            butOnayla4.Location = new Point(269, 331);
            butOnayla4.Name = "butOnayla4";
            butOnayla4.Size = new Size(204, 39);
            butOnayla4.TabIndex = 31;
            butOnayla4.Text = "Onayla";
            butOnayla4.UseVisualStyleBackColor = false;
            // 
            // radioButHayır4
            // 
            radioButHayır4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            radioButHayır4.Location = new Point(503, 281);
            radioButHayır4.Name = "radioButHayır4";
            radioButHayır4.Size = new Size(64, 23);
            radioButHayır4.TabIndex = 41;
            radioButHayır4.TabStop = true;
            radioButHayır4.Text = "Hayır";
            radioButHayır4.TextAlign = ContentAlignment.TopLeft;
            radioButHayır4.UseVisualStyleBackColor = true;
            // 
            // radioButEvet4
            // 
            radioButEvet4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            radioButEvet4.Location = new Point(414, 281);
            radioButEvet4.Name = "radioButEvet4";
            radioButEvet4.Size = new Size(55, 23);
            radioButEvet4.TabIndex = 40;
            radioButEvet4.TabStop = true;
            radioButEvet4.Text = "Evet";
            radioButEvet4.TextAlign = ContentAlignment.TopLeft;
            radioButEvet4.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.BackColor = SystemColors.Control;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(250, 277);
            label6.Name = "label6";
            label6.Size = new Size(143, 29);
            label6.TabIndex = 39;
            label6.Text = "Yetkisi var mı :";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(radioButHayır4);
            Controls.Add(radioButEvet4);
            Controls.Add(label6);
            Controls.Add(butOnayla4);
            Controls.Add(txtBoxŞifre4);
            Controls.Add(label2);
            Controls.Add(txtBoxKullAdı4);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
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
        private Button butOnayla4;
        private RadioButton radioButHayır4;
        private RadioButton radioButEvet4;
        private Label label6;
    }
}