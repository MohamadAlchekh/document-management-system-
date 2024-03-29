namespace document_management_system
{
    partial class Arşiveevrakeklemek
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Arşiveevrakeklemek));
            label1 = new Label();
            butOnayla6 = new Button();
            dateTimePickerTarih6 = new DateTimePicker();
            label4 = new Label();
            comboBoxDepartman6 = new ComboBox();
            label3 = new Label();
            comboBoxDokumanTuru6 = new ComboBox();
            label7 = new Label();
            txtBoxAçıklama6 = new TextBox();
            label9 = new Label();
            textBoxRafNo6 = new TextBox();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            labelARA4 = new Label();
            textBoxARA6 = new TextBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(160, 9);
            label1.Name = "label1";
            label1.Size = new Size(188, 42);
            label1.TabIndex = 4;
            label1.Text = "Arşive Evrak Ekle";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // butOnayla6
            // 
            butOnayla6.Anchor = AnchorStyles.None;
            butOnayla6.BackColor = SystemColors.GradientActiveCaption;
            butOnayla6.FlatStyle = FlatStyle.Flat;
            butOnayla6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            butOnayla6.Location = new Point(196, 477);
            butOnayla6.Name = "butOnayla6";
            butOnayla6.Size = new Size(204, 39);
            butOnayla6.TabIndex = 39;
            butOnayla6.Text = "Onayla";
            butOnayla6.UseVisualStyleBackColor = false;
            butOnayla6.Click += butOnayla6_Click;
            // 
            // dateTimePickerTarih6
            // 
            dateTimePickerTarih6.Anchor = AnchorStyles.None;
            dateTimePickerTarih6.CustomFormat = "dd-MM-yyyy";
            dateTimePickerTarih6.Format = DateTimePickerFormat.Custom;
            dateTimePickerTarih6.Location = new Point(216, 262);
            dateTimePickerTarih6.Name = "dateTimePickerTarih6";
            dateTimePickerTarih6.Size = new Size(200, 23);
            dateTimePickerTarih6.TabIndex = 33;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(130, 262);
            label4.Name = "label4";
            label4.Size = new Size(65, 23);
            label4.TabIndex = 32;
            label4.Text = "Tarih :";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBoxDepartman6
            // 
            comboBoxDepartman6.Anchor = AnchorStyles.None;
            comboBoxDepartman6.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDepartman6.FormattingEnabled = true;
            comboBoxDepartman6.Items.AddRange(new object[] { "YBS", "İşletme", "UAT" });
            comboBoxDepartman6.Location = new Point(216, 186);
            comboBoxDepartman6.Name = "comboBoxDepartman6";
            comboBoxDepartman6.Size = new Size(200, 23);
            comboBoxDepartman6.TabIndex = 31;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(100, 184);
            label3.Name = "label3";
            label3.Size = new Size(95, 23);
            label3.TabIndex = 30;
            label3.Text = "Departman :";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBoxDokumanTuru6
            // 
            comboBoxDokumanTuru6.Anchor = AnchorStyles.None;
            comboBoxDokumanTuru6.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDokumanTuru6.FormattingEnabled = true;
            comboBoxDokumanTuru6.Items.AddRange(new object[] { "YBS", "İşletme", "UAT" });
            comboBoxDokumanTuru6.Location = new Point(216, 143);
            comboBoxDokumanTuru6.Name = "comboBoxDokumanTuru6";
            comboBoxDokumanTuru6.Size = new Size(200, 23);
            comboBoxDokumanTuru6.TabIndex = 42;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(70, 143);
            label7.Name = "label7";
            label7.Size = new Size(125, 23);
            label7.TabIndex = 41;
            label7.Text = "Döküman Türü :";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtBoxAçıklama6
            // 
            txtBoxAçıklama6.Anchor = AnchorStyles.None;
            txtBoxAçıklama6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxAçıklama6.Location = new Point(216, 309);
            txtBoxAçıklama6.Multiline = true;
            txtBoxAçıklama6.Name = "txtBoxAçıklama6";
            txtBoxAçıklama6.Size = new Size(200, 106);
            txtBoxAçıklama6.TabIndex = 44;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(119, 305);
            label9.Name = "label9";
            label9.Size = new Size(76, 30);
            label9.TabIndex = 43;
            label9.Text = "Açıklama :";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxRafNo6
            // 
            textBoxRafNo6.Anchor = AnchorStyles.None;
            textBoxRafNo6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxRafNo6.Location = new Point(216, 220);
            textBoxRafNo6.Multiline = true;
            textBoxRafNo6.Name = "textBoxRafNo6";
            textBoxRafNo6.Size = new Size(144, 31);
            textBoxRafNo6.TabIndex = 60;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(119, 216);
            label2.Name = "label2";
            label2.Size = new Size(76, 31);
            label2.TabIndex = 59;
            label2.Text = "Raf No :";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(31, 112);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(625, 404);
            dataGridView1.TabIndex = 61;
            // 
            // labelARA4
            // 
            labelARA4.Anchor = AnchorStyles.None;
            labelARA4.BackColor = Color.Transparent;
            labelARA4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelARA4.ForeColor = SystemColors.ButtonFace;
            labelARA4.Location = new Point(31, 54);
            labelARA4.Name = "labelARA4";
            labelARA4.Size = new Size(76, 41);
            labelARA4.TabIndex = 72;
            labelARA4.Text = "Ara :";
            labelARA4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxARA6
            // 
            textBoxARA6.Anchor = AnchorStyles.None;
            textBoxARA6.Location = new Point(93, 54);
            textBoxARA6.Multiline = true;
            textBoxARA6.Name = "textBoxARA6";
            textBoxARA6.Size = new Size(162, 41);
            textBoxARA6.TabIndex = 71;
            textBoxARA6.TextAlign = HorizontalAlignment.Center;
            textBoxARA6.TextChanged += textBoxARA6_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(51, 52, 78);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(labelARA4);
            panel1.Controls.Add(textBoxARA6);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(461, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(678, 541);
            panel1.TabIndex = 73;
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
            // Arşiveevrakeklemek
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1139, 541);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(textBoxRafNo6);
            Controls.Add(label2);
            Controls.Add(txtBoxAçıklama6);
            Controls.Add(label9);
            Controls.Add(comboBoxDokumanTuru6);
            Controls.Add(label7);
            Controls.Add(butOnayla6);
            Controls.Add(dateTimePickerTarih6);
            Controls.Add(label4);
            Controls.Add(comboBoxDepartman6);
            Controls.Add(label3);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Arşiveevrakeklemek";
            Text = "Memur";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button butOnayla6;
        private DateTimePicker dateTimePickerTarih6;
        private Label label4;
        private ComboBox comboBoxDepartman6;
        private Label label3;
        private ComboBox comboBoxDokumanTuru6;
        private Label label7;
        private TextBox txtBoxAçıklama6;
        private Label label9;
        private TextBox textBoxRafNo6;
        private Label label2;
        private DataGridView dataGridView1;
        private Label labelARA4;
        private TextBox textBoxARA6;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}