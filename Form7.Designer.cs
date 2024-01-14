namespace document_management_system
{
    partial class Form7
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
            butDepEkle3 = new Button();
            label7 = new Label();
            dataGridView1 = new DataGridView();
            textBoxDepartmanEkle7 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // butDepEkle3
            // 
            butDepEkle3.Anchor = AnchorStyles.None;
            butDepEkle3.BackColor = SystemColors.GradientActiveCaption;
            butDepEkle3.FlatStyle = FlatStyle.Flat;
            butDepEkle3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            butDepEkle3.Location = new Point(161, 246);
            butDepEkle3.Name = "butDepEkle3";
            butDepEkle3.Size = new Size(244, 74);
            butDepEkle3.TabIndex = 30;
            butDepEkle3.Text = "Departman Ekle";
            butDepEkle3.UseVisualStyleBackColor = false;
            butDepEkle3.Click += butDepEkle3_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.BackColor = SystemColors.Control;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(95, 50);
            label7.Name = "label7";
            label7.Size = new Size(335, 94);
            label7.TabIndex = 29;
            label7.Text = "Departman işlemleri";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(498, 112);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(240, 150);
            dataGridView1.TabIndex = 36;
            // 
            // textBoxDepartmanEkle7
            // 
            textBoxDepartmanEkle7.Anchor = AnchorStyles.None;
            textBoxDepartmanEkle7.Location = new Point(161, 176);
            textBoxDepartmanEkle7.Multiline = true;
            textBoxDepartmanEkle7.Name = "textBoxDepartmanEkle7";
            textBoxDepartmanEkle7.Size = new Size(244, 64);
            textBoxDepartmanEkle7.TabIndex = 37;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1158, 516);
            Controls.Add(textBoxDepartmanEkle7);
            Controls.Add(dataGridView1);
            Controls.Add(butDepEkle3);
            Controls.Add(label7);
            Margin = new Padding(2);
            Name = "Form7";
            Text = "Form7";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button butDepEkle3;
        private Label label7;
        private DataGridView dataGridView1;
        private TextBox textBoxDepartmanEkle7;
    }
}