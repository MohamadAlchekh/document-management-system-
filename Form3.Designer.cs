﻿namespace document_management_system
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
            label2 = new Label();
            label1 = new Label();
            textBoxDepartmanEkle3 = new TextBox();
            textBoxDosyaTuruBelirle3 = new TextBox();
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
          
        
            // 
            // butTürBelirle3
            // 
            butTürBelirle3.Anchor = AnchorStyles.None;
            butTürBelirle3.BackColor = SystemColors.GradientActiveCaption;
            butTürBelirle3.FlatStyle = FlatStyle.Flat;
            butTürBelirle3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            butTürBelirle3.Location = new Point(363, 376);
            butTürBelirle3.Margin = new Padding(4, 5, 4, 5);
            butTürBelirle3.Name = "butTürBelirle3";
            butTürBelirle3.Size = new Size(291, 65);
            butTürBelirle3.TabIndex = 32;
            butTürBelirle3.Text = "Dosya türü belirle";
            butTürBelirle3.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(363, 269);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(291, 72);
            label2.TabIndex = 31;
            label2.Text = "Departman işlemleri";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(338, 54);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(329, 122);
            label1.TabIndex = 30;
            label1.Text = "Arşive konulabilecek dosya türleri";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1208, 625);
            Controls.Add(butTürBelirle3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button butTürBelirle3;
        private Label label2;
        private Label label1;
        public TextBox textBoxDepartmanEkle3;
        public TextBox textBoxDosyaTuruBelirle3;
    }
}