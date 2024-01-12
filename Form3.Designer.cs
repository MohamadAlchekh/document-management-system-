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
            label7 = new Label();
            butDepEkle3 = new Button();
            butTürBelirle3 = new Button();
            label2 = new Label();
            textBoxAD6 = new TextBox();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(276, 9);
            label1.Name = "label1";
            label1.Size = new Size(230, 73);
            label1.TabIndex = 3;
            label1.Text = "Arşive konulabilecek dosya türleri";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.BackColor = SystemColors.Control;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(510, 117);
            label7.Name = "label7";
            label7.Size = new Size(204, 43);
            label7.TabIndex = 23;
            label7.Text = "Departman işlemleri";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // butDepEkle3
            // 
            butDepEkle3.BackColor = SystemColors.GradientActiveCaption;
            butDepEkle3.FlatStyle = FlatStyle.Flat;
            butDepEkle3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            butDepEkle3.Location = new Point(510, 226);
            butDepEkle3.Name = "butDepEkle3";
            butDepEkle3.Size = new Size(204, 39);
            butDepEkle3.TabIndex = 26;
            butDepEkle3.Text = "Departman Ekle";
            butDepEkle3.UseVisualStyleBackColor = false;
            butDepEkle3.Click += butDepEkle3_Click;
            // 
            // butTürBelirle3
            // 
            butTürBelirle3.BackColor = SystemColors.GradientActiveCaption;
            butTürBelirle3.FlatStyle = FlatStyle.Flat;
            butTürBelirle3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            butTürBelirle3.Location = new Point(42, 226);
            butTürBelirle3.Name = "butTürBelirle3";
            butTürBelirle3.Size = new Size(204, 39);
            butTürBelirle3.TabIndex = 29;
            butTürBelirle3.Text = "Dosya türü belirle";
            butTürBelirle3.UseVisualStyleBackColor = false;
            butTürBelirle3.Click += butTürBelirle3_Click;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(42, 117);
            label2.Name = "label2";
            label2.Size = new Size(204, 43);
            label2.TabIndex = 27;
            label2.Text = "Departman işlemleri";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxAD6
            // 
            textBoxAD6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAD6.Location = new Point(510, 180);
            textBoxAD6.Multiline = true;
            textBoxAD6.Name = "textBoxAD6";
            textBoxAD6.Size = new Size(204, 40);
            textBoxAD6.TabIndex = 49;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(42, 180);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(204, 39);
            textBox1.TabIndex = 50;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(textBoxAD6);
            Controls.Add(butTürBelirle3);
            Controls.Add(label2);
            Controls.Add(butDepEkle3);
            Controls.Add(label7);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Evrak işlemleri";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label7;
        private Button butDepEkle3;
        private Button butTürBelirle3;
        private Label label2;
        public TextBox textBoxAD6;
        public TextBox textBox1;
    }
}