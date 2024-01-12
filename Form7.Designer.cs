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
            SuspendLayout();
            // 
            // butDepEkle3
            // 
            butDepEkle3.Anchor = AnchorStyles.None;
            butDepEkle3.BackColor = SystemColors.GradientActiveCaption;
            butDepEkle3.FlatStyle = FlatStyle.Flat;
            butDepEkle3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            butDepEkle3.Location = new Point(367, 337);
            butDepEkle3.Margin = new Padding(4, 5, 4, 5);
            butDepEkle3.Name = "butDepEkle3";
            butDepEkle3.Size = new Size(291, 65);
            butDepEkle3.TabIndex = 30;
            butDepEkle3.Text = "Departman Ekle";
            butDepEkle3.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.BackColor = SystemColors.Control;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(367, 207);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(291, 72);
            label7.TabIndex = 29;
            label7.Text = "Departman işlemleri";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1024, 609);
            Controls.Add(butDepEkle3);
            Controls.Add(label7);
            Name = "Form7";
            Text = "Form7";
            ResumeLayout(false);
        }

        #endregion

        private Button butDepEkle3;
        private Label label7;
    }
}