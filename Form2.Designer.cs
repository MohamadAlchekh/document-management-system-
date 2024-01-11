namespace document_management_system
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            label1 = new Label();
            butHesapBilgiGüncelle2 = new Button();
            butDosyaTürleri2 = new Button();
            butMemurişlemleri2 = new Button();
            butGecikmisEmanetler2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(291, 9);
            label1.Name = "label1";
            label1.Size = new Size(206, 47);
            label1.TabIndex = 2;
            label1.Text = "Fakülte sekreteri";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // butHesapBilgiGüncelle2
            // 
            butHesapBilgiGüncelle2.BackColor = SystemColors.GradientActiveCaption;
            butHesapBilgiGüncelle2.FlatStyle = FlatStyle.Flat;
            butHesapBilgiGüncelle2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            butHesapBilgiGüncelle2.Location = new Point(111, 258);
            butHesapBilgiGüncelle2.Name = "butHesapBilgiGüncelle2";
            butHesapBilgiGüncelle2.Size = new Size(248, 96);
            butHesapBilgiGüncelle2.TabIndex = 9;
            butHesapBilgiGüncelle2.Text = "Hesap bilgilerimi güncelle";
            butHesapBilgiGüncelle2.UseVisualStyleBackColor = false;
            butHesapBilgiGüncelle2.Click += butHesapBilgiGüncelle2_Click;
            // 
            // butDosyaTürleri2
            // 
            butDosyaTürleri2.BackColor = SystemColors.GradientActiveCaption;
            butDosyaTürleri2.FlatStyle = FlatStyle.Flat;
            butDosyaTürleri2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            butDosyaTürleri2.Location = new Point(418, 119);
            butDosyaTürleri2.Name = "butDosyaTürleri2";
            butDosyaTürleri2.Size = new Size(248, 96);
            butDosyaTürleri2.TabIndex = 10;
            butDosyaTürleri2.Text = "Arşive konulabilecek dosya türleri";
            butDosyaTürleri2.UseVisualStyleBackColor = false;
            butDosyaTürleri2.Click += butDosyaTürleri2_Click;
            // 
            // butMemurişlemleri2
            // 
            butMemurişlemleri2.BackColor = SystemColors.GradientActiveCaption;
            butMemurişlemleri2.FlatStyle = FlatStyle.Flat;
            butMemurişlemleri2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            butMemurişlemleri2.Location = new Point(111, 119);
            butMemurişlemleri2.Name = "butMemurişlemleri2";
            butMemurişlemleri2.Size = new Size(248, 96);
            butMemurişlemleri2.TabIndex = 11;
            butMemurişlemleri2.Text = "Memur işlemleri";
            butMemurişlemleri2.UseVisualStyleBackColor = false;
            butMemurişlemleri2.Click += butKullişlemleri2_Click;
            // 
            // butGecikmisEmanetler2
            // 
            butGecikmisEmanetler2.BackColor = SystemColors.GradientActiveCaption;
            butGecikmisEmanetler2.FlatStyle = FlatStyle.Flat;
            butGecikmisEmanetler2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            butGecikmisEmanetler2.Location = new Point(418, 258);
            butGecikmisEmanetler2.Name = "butGecikmisEmanetler2";
            butGecikmisEmanetler2.Size = new Size(248, 96);
            butGecikmisEmanetler2.TabIndex = 12;
            butGecikmisEmanetler2.Text = "Gecikmiş emanetler";
            butGecikmisEmanetler2.UseVisualStyleBackColor = false;
            butGecikmisEmanetler2.Click += butGecikmisEmanetler2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(butGecikmisEmanetler2);
            Controls.Add(butMemurişlemleri2);
            Controls.Add(butDosyaTürleri2);
            Controls.Add(butHesapBilgiGüncelle2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fakülte sekreteri";
            Load += Form2_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button butHesapBilgiGüncelle2;
        private Button butDosyaTürleri2;
        private Button butMemurişlemleri2;
        private Button butGecikmisEmanetler2;
    }
}