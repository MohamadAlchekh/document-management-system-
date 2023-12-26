namespace document_management_system
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            label1 = new Label();
            label8 = new Label();
            label2 = new Label();
            txtBoxAD3 = new TextBox();
            txtBoxSoyAdı3 = new TextBox();
            label3 = new Label();
            comboBoxDepartman3 = new ComboBox();
            label4 = new Label();
            dateTimePickerTarih3 = new DateTimePicker();
            label5 = new Label();
            dateTimePickerGeriVerilecekTarih3 = new DateTimePicker();
            label6 = new Label();
            radioButEvet3 = new RadioButton();
            radioButHayır3 = new RadioButton();
            label7 = new Label();
            butOnayla3 = new Button();
            butDepSil3 = new Button();
            butDepEkle3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(295, 9);
            label1.Name = "label1";
            label1.Size = new Size(206, 47);
            label1.TabIndex = 3;
            label1.Text = "Evrak işlemleri";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.BackColor = SystemColors.Control;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(89, 74);
            label8.Name = "label8";
            label8.Size = new Size(65, 31);
            label8.TabIndex = 10;
            label8.Text = "Ad :";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(89, 127);
            label2.Name = "label2";
            label2.Size = new Size(65, 32);
            label2.TabIndex = 11;
            label2.Text = "Soyad :";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtBoxAD3
            // 
            txtBoxAD3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxAD3.Location = new Point(175, 74);
            txtBoxAD3.Multiline = true;
            txtBoxAD3.Name = "txtBoxAD3";
            txtBoxAD3.Size = new Size(144, 31);
            txtBoxAD3.TabIndex = 12;
            // 
            // txtBoxSoyAdı3
            // 
            txtBoxSoyAdı3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxSoyAdı3.Location = new Point(175, 132);
            txtBoxSoyAdı3.Multiline = true;
            txtBoxSoyAdı3.Name = "txtBoxSoyAdı3";
            txtBoxSoyAdı3.Size = new Size(144, 31);
            txtBoxSoyAdı3.TabIndex = 13;
            // 
            // label3
            // 
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(59, 189);
            label3.Name = "label3";
            label3.Size = new Size(95, 23);
            label3.TabIndex = 14;
            label3.Text = "Departman :";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBoxDepartman3
            // 
            comboBoxDepartman3.FormattingEnabled = true;
            comboBoxDepartman3.Items.AddRange(new object[] { "YBS", "İşletme", "UAT" });
            comboBoxDepartman3.Location = new Point(175, 191);
            comboBoxDepartman3.Name = "comboBoxDepartman3";
            comboBoxDepartman3.Size = new Size(200, 23);
            comboBoxDepartman3.TabIndex = 15;
            // 
            // label4
            // 
            label4.BackColor = SystemColors.Control;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(89, 239);
            label4.Name = "label4";
            label4.Size = new Size(65, 23);
            label4.TabIndex = 16;
            label4.Text = "Tarih :";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dateTimePickerTarih3
            // 
            dateTimePickerTarih3.Location = new Point(175, 239);
            dateTimePickerTarih3.Name = "dateTimePickerTarih3";
            dateTimePickerTarih3.Size = new Size(200, 23);
            dateTimePickerTarih3.TabIndex = 17;
            // 
            // label5
            // 
            label5.BackColor = SystemColors.Control;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(11, 285);
            label5.Name = "label5";
            label5.Size = new Size(143, 29);
            label5.TabIndex = 18;
            label5.Text = "Geri verilecek tarih :";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dateTimePickerGeriVerilecekTarih3
            // 
            dateTimePickerGeriVerilecekTarih3.Location = new Point(175, 285);
            dateTimePickerGeriVerilecekTarih3.Name = "dateTimePickerGeriVerilecekTarih3";
            dateTimePickerGeriVerilecekTarih3.Size = new Size(200, 23);
            dateTimePickerGeriVerilecekTarih3.TabIndex = 19;
            // 
            // label6
            // 
            label6.BackColor = SystemColors.Control;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(11, 335);
            label6.Name = "label6";
            label6.Size = new Size(143, 29);
            label6.TabIndex = 20;
            label6.Text = "Yetkisi var mı :";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // radioButEvet3
            // 
            radioButEvet3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            radioButEvet3.Location = new Point(175, 339);
            radioButEvet3.Name = "radioButEvet3";
            radioButEvet3.Size = new Size(55, 23);
            radioButEvet3.TabIndex = 21;
            radioButEvet3.TabStop = true;
            radioButEvet3.Text = "Evet";
            radioButEvet3.TextAlign = ContentAlignment.TopLeft;
            radioButEvet3.UseVisualStyleBackColor = true;
            // 
            // radioButHayır3
            // 
            radioButHayır3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            radioButHayır3.Location = new Point(264, 339);
            radioButHayır3.Name = "radioButHayır3";
            radioButHayır3.Size = new Size(64, 23);
            radioButHayır3.TabIndex = 22;
            radioButHayır3.TabStop = true;
            radioButHayır3.Text = "Hayır";
            radioButHayır3.TextAlign = ContentAlignment.TopLeft;
            radioButHayır3.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.BackColor = SystemColors.Control;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(573, 98);
            label7.Name = "label7";
            label7.Size = new Size(193, 43);
            label7.TabIndex = 23;
            label7.Text = "Departman işlemleri";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // butOnayla3
            // 
            butOnayla3.BackColor = SystemColors.GradientActiveCaption;
            butOnayla3.FlatStyle = FlatStyle.Flat;
            butOnayla3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            butOnayla3.Location = new Point(100, 377);
            butOnayla3.Name = "butOnayla3";
            butOnayla3.Size = new Size(204, 39);
            butOnayla3.TabIndex = 24;
            butOnayla3.Text = "Onayla";
            butOnayla3.UseVisualStyleBackColor = false;
            // 
            // butDepSil3
            // 
            butDepSil3.BackColor = SystemColors.GradientActiveCaption;
            butDepSil3.FlatStyle = FlatStyle.Flat;
            butDepSil3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            butDepSil3.Location = new Point(562, 222);
            butDepSil3.Name = "butDepSil3";
            butDepSil3.Size = new Size(204, 39);
            butDepSil3.TabIndex = 25;
            butDepSil3.Text = "Departman Sil";
            butDepSil3.UseVisualStyleBackColor = false;
            // 
            // butDepEkle3
            // 
            butDepEkle3.BackColor = SystemColors.GradientActiveCaption;
            butDepEkle3.FlatStyle = FlatStyle.Flat;
            butDepEkle3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            butDepEkle3.Location = new Point(562, 161);
            butDepEkle3.Name = "butDepEkle3";
            butDepEkle3.Size = new Size(204, 39);
            butDepEkle3.TabIndex = 26;
            butDepEkle3.Text = "Departman Ekle";
            butDepEkle3.UseVisualStyleBackColor = false;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(butDepEkle3);
            Controls.Add(butDepSil3);
            Controls.Add(butOnayla3);
            Controls.Add(label7);
            Controls.Add(radioButHayır3);
            Controls.Add(radioButEvet3);
            Controls.Add(label6);
            Controls.Add(dateTimePickerGeriVerilecekTarih3);
            Controls.Add(label5);
            Controls.Add(dateTimePickerTarih3);
            Controls.Add(label4);
            Controls.Add(comboBoxDepartman3);
            Controls.Add(label3);
            Controls.Add(txtBoxSoyAdı3);
            Controls.Add(txtBoxAD3);
            Controls.Add(label2);
            Controls.Add(label8);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form3";
            Text = "Evrak işlemleri";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label8;
        private Label label2;
        private TextBox txtBoxAD3;
        private TextBox txtBoxSoyAdı3;
        private Label label3;
        private ComboBox comboBoxDepartman3;
        private Label label4;
        private DateTimePicker dateTimePickerTarih3;
        private Label label5;
        private DateTimePicker dateTimePickerGeriVerilecekTarih3;
        private Label label6;
        private RadioButton radioButEvet3;
        private RadioButton radioButHayır3;
        private Label label7;
        private Button butOnayla3;
        private Button butDepSil3;
        private Button butDepEkle3;
    }
}