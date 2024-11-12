namespace WFAMethodsIntro_0
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
            this.LstSonuc1 = new System.Windows.Forms.ListBox();
            this.LstSonuc2 = new System.Windows.Forms.ListBox();
            this.LstSonuc3 = new System.Windows.Forms.ListBox();
            this.TxtListBox = new System.Windows.Forms.TextBox();
            this.TxtBaslangic = new System.Windows.Forms.TextBox();
            this.TxtBitis = new System.Windows.Forms.TextBox();
            this.BtnBelirle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LstSonuc1
            // 
            this.LstSonuc1.FormattingEnabled = true;
            this.LstSonuc1.ItemHeight = 16;
            this.LstSonuc1.Location = new System.Drawing.Point(200, 60);
            this.LstSonuc1.Name = "LstSonuc1";
            this.LstSonuc1.Size = new System.Drawing.Size(178, 292);
            this.LstSonuc1.TabIndex = 0;
            // 
            // LstSonuc2
            // 
            this.LstSonuc2.FormattingEnabled = true;
            this.LstSonuc2.ItemHeight = 16;
            this.LstSonuc2.Location = new System.Drawing.Point(411, 60);
            this.LstSonuc2.Name = "LstSonuc2";
            this.LstSonuc2.Size = new System.Drawing.Size(178, 292);
            this.LstSonuc2.TabIndex = 0;
            // 
            // LstSonuc3
            // 
            this.LstSonuc3.FormattingEnabled = true;
            this.LstSonuc3.ItemHeight = 16;
            this.LstSonuc3.Location = new System.Drawing.Point(610, 60);
            this.LstSonuc3.Name = "LstSonuc3";
            this.LstSonuc3.Size = new System.Drawing.Size(178, 292);
            this.LstSonuc3.TabIndex = 0;
            // 
            // TxtListBox
            // 
            this.TxtListBox.Location = new System.Drawing.Point(13, 60);
            this.TxtListBox.Name = "TxtListBox";
            this.TxtListBox.Size = new System.Drawing.Size(100, 22);
            this.TxtListBox.TabIndex = 1;
            // 
            // TxtBaslangic
            // 
            this.TxtBaslangic.Location = new System.Drawing.Point(13, 107);
            this.TxtBaslangic.Name = "TxtBaslangic";
            this.TxtBaslangic.Size = new System.Drawing.Size(100, 22);
            this.TxtBaslangic.TabIndex = 1;
            // 
            // TxtBitis
            // 
            this.TxtBitis.Location = new System.Drawing.Point(12, 156);
            this.TxtBitis.Name = "TxtBitis";
            this.TxtBitis.Size = new System.Drawing.Size(100, 22);
            this.TxtBitis.TabIndex = 1;
            // 
            // BtnBelirle
            // 
            this.BtnBelirle.Location = new System.Drawing.Point(13, 231);
            this.BtnBelirle.Name = "BtnBelirle";
            this.BtnBelirle.Size = new System.Drawing.Size(75, 23);
            this.BtnBelirle.TabIndex = 2;
            this.BtnBelirle.Text = "Belirle";
            this.BtnBelirle.UseVisualStyleBackColor = true;
            this.BtnBelirle.Click += new System.EventHandler(this.BtnBelirle_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnBelirle);
            this.Controls.Add(this.TxtBitis);
            this.Controls.Add(this.TxtBaslangic);
            this.Controls.Add(this.TxtListBox);
            this.Controls.Add(this.LstSonuc3);
            this.Controls.Add(this.LstSonuc2);
            this.Controls.Add(this.LstSonuc1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LstSonuc1;
        private System.Windows.Forms.ListBox LstSonuc2;
        private System.Windows.Forms.ListBox LstSonuc3;
        private System.Windows.Forms.TextBox TxtListBox;
        private System.Windows.Forms.TextBox TxtBaslangic;
        private System.Windows.Forms.TextBox TxtBitis;
        private System.Windows.Forms.Button BtnBelirle;
    }
}