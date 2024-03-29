namespace document_management_system
{
    partial class MemurAna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemurAna));
            label4 = new Label();
            label8 = new Label();
            label1 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(-10, 226);
            label4.Name = "label4";
            label4.Size = new Size(634, 28);
            label4.TabIndex = 29;
            label4.Text = "-Menü ikonuna tıklayarak yapacağınız işlemi seçebilirsiniz";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left;
            label8.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(-1, 272);
            label8.Name = "label8";
            label8.Size = new Size(683, 28);
            label8.TabIndex = 28;
            label8.Text = "-Evrak Ekle sayfasından arşive eklenecek evrağı belirleyebilirsiniz";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(11, 317);
            label1.Name = "label1";
            label1.Size = new Size(809, 28);
            label1.TabIndex = 27;
            label1.Text = "- Emanet ver sayfasından arşivdeki evrakları tablodan seçip emanet verebilirsiniz";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(353, 29);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(304, 33);
            label3.TabIndex = 26;
            label3.Text = "Sn. Memur Hoşgeldiniz";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(11, 11);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(195, 156);
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // MemurAna
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(917, 450);
            Controls.Add(label4);
            Controls.Add(label8);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Name = "MemurAna";
            Text = "MemurAna";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label8;
        private Label label1;
        private Label label3;
        private PictureBox pictureBox1;
    }
}