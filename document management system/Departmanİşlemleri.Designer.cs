namespace document_management_system
{
    partial class Departmanİşlemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Departmanİşlemleri));
            butDepEkle3 = new Button();
            dataGridView1 = new DataGridView();
            textBoxDepartmanEkle7 = new TextBox();
            labelARA4 = new Label();
            textBoxARA7 = new TextBox();
            butSilDep = new Button();
            butGüncelleDep = new Button();
            labelid = new Label();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // butDepEkle3
            // 
            butDepEkle3.Anchor = AnchorStyles.None;
            butDepEkle3.BackColor = Color.YellowGreen;
            butDepEkle3.FlatStyle = FlatStyle.Flat;
            butDepEkle3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            butDepEkle3.Location = new Point(151, 324);
            butDepEkle3.Name = "butDepEkle3";
            butDepEkle3.Size = new Size(100, 39);
            butDepEkle3.TabIndex = 30;
            butDepEkle3.Text = "Kaydet";
            butDepEkle3.UseVisualStyleBackColor = false;
            butDepEkle3.Click += butDepEkle3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(85, 92);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(317, 342);
            dataGridView1.TabIndex = 36;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // textBoxDepartmanEkle7
            // 
            textBoxDepartmanEkle7.Anchor = AnchorStyles.None;
            textBoxDepartmanEkle7.Location = new Point(151, 231);
            textBoxDepartmanEkle7.Multiline = true;
            textBoxDepartmanEkle7.Name = "textBoxDepartmanEkle7";
            textBoxDepartmanEkle7.Size = new Size(330, 56);
            textBoxDepartmanEkle7.TabIndex = 37;
            // 
            // labelARA4
            // 
            labelARA4.Anchor = AnchorStyles.None;
            labelARA4.BackColor = Color.Transparent;
            labelARA4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelARA4.ForeColor = Color.White;
            labelARA4.Location = new Point(39, 29);
            labelARA4.Name = "labelARA4";
            labelARA4.Size = new Size(76, 41);
            labelARA4.TabIndex = 72;
            labelARA4.Text = "Ara :";
            labelARA4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxARA7
            // 
            textBoxARA7.Anchor = AnchorStyles.None;
            textBoxARA7.Location = new Point(121, 29);
            textBoxARA7.Multiline = true;
            textBoxARA7.Name = "textBoxARA7";
            textBoxARA7.Size = new Size(162, 41);
            textBoxARA7.TabIndex = 71;
            textBoxARA7.TextAlign = HorizontalAlignment.Center;
            textBoxARA7.TextChanged += textBoxARA4_TextChanged;
            // 
            // butSilDep
            // 
            butSilDep.Anchor = AnchorStyles.None;
            butSilDep.BackColor = Color.Salmon;
            butSilDep.FlatStyle = FlatStyle.Flat;
            butSilDep.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            butSilDep.Location = new Point(381, 324);
            butSilDep.Name = "butSilDep";
            butSilDep.Size = new Size(100, 39);
            butSilDep.TabIndex = 74;
            butSilDep.Text = "Sil";
            butSilDep.UseVisualStyleBackColor = false;
            butSilDep.Click += butSilDep_Click;
            // 
            // butGüncelleDep
            // 
            butGüncelleDep.Anchor = AnchorStyles.None;
            butGüncelleDep.BackColor = SystemColors.GradientActiveCaption;
            butGüncelleDep.FlatStyle = FlatStyle.Flat;
            butGüncelleDep.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            butGüncelleDep.Location = new Point(270, 324);
            butGüncelleDep.Name = "butGüncelleDep";
            butGüncelleDep.Size = new Size(100, 39);
            butGüncelleDep.TabIndex = 73;
            butGüncelleDep.Text = "Güncelle";
            butGüncelleDep.UseVisualStyleBackColor = false;
            butGüncelleDep.Click += butGüncelleDep_Click;
            // 
            // labelid
            // 
            labelid.Anchor = AnchorStyles.None;
            labelid.BackColor = SystemColors.Control;
            labelid.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelid.Location = new Point(420, 28);
            labelid.Name = "labelid";
            labelid.Size = new Size(44, 21);
            labelid.TabIndex = 75;
            labelid.Text = "id";
            labelid.TextAlign = ContentAlignment.MiddleCenter;
            labelid.Visible = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(51, 52, 78);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(textBoxARA7);
            panel1.Controls.Add(labelARA4);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(513, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(454, 456);
            panel1.TabIndex = 76;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(142, 14);
            label1.Name = "label1";
            label1.Size = new Size(228, 42);
            label1.TabIndex = 77;
            label1.Text = "Departman İşlemleri";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(24, 223);
            label2.Name = "label2";
            label2.Size = new Size(120, 64);
            label2.TabIndex = 82;
            label2.Text = "Departman Ekle:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(105, 109);
            pictureBox1.TabIndex = 83;
            pictureBox1.TabStop = false;
            // 
            // Departmanİşlemleri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(967, 456);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(labelid);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(butSilDep);
            Controls.Add(butGüncelleDep);
            Controls.Add(textBoxDepartmanEkle7);
            Controls.Add(butDepEkle3);
            Margin = new Padding(2);
            Name = "Departmanİşlemleri";
            Text = "Form7";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button butDepEkle3;
        private DataGridView dataGridView1;
        private TextBox textBoxDepartmanEkle7;
        private Label labelARA4;
        private TextBox textBoxARA7;
        private Button butSilDep;
        private Button butGüncelleDep;
        private Label labelid;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
    }
}