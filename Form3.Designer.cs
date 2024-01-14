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
            butTürBelirle3 = new Button();
            label1 = new Label();
            textBoxDepartmanEkle3 = new TextBox();
            textBoxDosyaTuruBelirle3 = new TextBox();
            dataGridView1 = new DataGridView();
            textBoxDosyaBelirle33 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // butTürBelirle3
            // 
            butTürBelirle3.Anchor = AnchorStyles.None;
            butTürBelirle3.BackColor = SystemColors.GradientActiveCaption;
            butTürBelirle3.FlatStyle = FlatStyle.Flat;
            butTürBelirle3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            butTürBelirle3.Location = new Point(211, 222);
            butTürBelirle3.Name = "butTürBelirle3";
            butTürBelirle3.Size = new Size(264, 66);
            butTürBelirle3.TabIndex = 32;
            butTürBelirle3.Text = "Dosya türü belirle";
            butTürBelirle3.UseVisualStyleBackColor = false;
            butTürBelirle3.Click += butTürBelirle3_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(211, 25);
            label1.Name = "label1";
            label1.Size = new Size(230, 73);
            label1.TabIndex = 30;
            label1.Text = "Arşive konulabilecek dosya türleri";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxDepartmanEkle3
            // 
            textBoxDepartmanEkle3.Location = new Point(0, 0);
            textBoxDepartmanEkle3.Name = "textBoxDepartmanEkle3";
            textBoxDepartmanEkle3.Size = new Size(100, 23);
            textBoxDepartmanEkle3.TabIndex = 0;
            // 
            // textBoxDosyaTuruBelirle3
            // 
            textBoxDosyaTuruBelirle3.Location = new Point(0, 0);
            textBoxDosyaTuruBelirle3.Name = "textBoxDosyaTuruBelirle3";
            textBoxDosyaTuruBelirle3.Size = new Size(100, 23);
            textBoxDosyaTuruBelirle3.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(545, 115);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(406, 173);
            dataGridView1.TabIndex = 37;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // textBoxDosyaBelirle33
            // 
            textBoxDosyaBelirle33.Anchor = AnchorStyles.None;
            textBoxDosyaBelirle33.Location = new Point(211, 150);
            textBoxDosyaBelirle33.Multiline = true;
            textBoxDosyaBelirle33.Name = "textBoxDosyaBelirle33";
            textBoxDosyaBelirle33.Size = new Size(264, 56);
            textBoxDosyaBelirle33.TabIndex = 38;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1279, 562);
            Controls.Add(textBoxDosyaBelirle33);
            Controls.Add(dataGridView1);
            Controls.Add(butTürBelirle3);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button butTürBelirle3;
        private Label label1;
        public TextBox textBoxDepartmanEkle3;
        public TextBox textBoxDosyaTuruBelirle3;
        private DataGridView dataGridView1;
        private TextBox textBoxDosyaBelirle33;
    }
}