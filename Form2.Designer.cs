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
            butEvrakişlemleri2 = new Button();
            butKullişlemleri2 = new Button();
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
            butHesapBilgiGüncelle2.Location = new Point(269, 254);
            butHesapBilgiGüncelle2.Name = "butHesapBilgiGüncelle2";
            butHesapBilgiGüncelle2.Size = new Size(248, 96);
            butHesapBilgiGüncelle2.TabIndex = 9;
            butHesapBilgiGüncelle2.Text = "Hesap bilgilerimi güncelle";
            butHesapBilgiGüncelle2.UseVisualStyleBackColor = false;
            // 
            // butEvrakişlemleri2
            // 
            butEvrakişlemleri2.BackColor = SystemColors.GradientActiveCaption;
            butEvrakişlemleri2.FlatStyle = FlatStyle.Flat;
            butEvrakişlemleri2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            butEvrakişlemleri2.Location = new Point(418, 119);
            butEvrakişlemleri2.Name = "butEvrakişlemleri2";
            butEvrakişlemleri2.Size = new Size(248, 96);
            butEvrakişlemleri2.TabIndex = 10;
            butEvrakişlemleri2.Text = "Evrak işlemleri";
            butEvrakişlemleri2.UseVisualStyleBackColor = false;
            // 
            // butKullişlemleri2
            // 
            butKullişlemleri2.BackColor = SystemColors.GradientActiveCaption;
            butKullişlemleri2.FlatStyle = FlatStyle.Flat;
            butKullişlemleri2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            butKullişlemleri2.Location = new Point(111, 119);
            butKullişlemleri2.Name = "butKullişlemleri2";
            butKullişlemleri2.Size = new Size(248, 96);
            butKullişlemleri2.TabIndex = 11;
            butKullişlemleri2.Text = "Kullanıcı işlemleri";
            butKullişlemleri2.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(butKullişlemleri2);
            Controls.Add(butEvrakişlemleri2);
            Controls.Add(butHesapBilgiGüncelle2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            Text = "Fakülte sekreteri";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button butHesapBilgiGüncelle2;
        private Button butEvrakişlemleri2;
        private Button butKullişlemleri2;
    }
}