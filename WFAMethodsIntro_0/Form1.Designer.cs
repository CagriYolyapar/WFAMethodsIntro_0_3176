namespace WFAMethodsIntro_0
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.LstSonuc = new System.Windows.Forms.ListBox();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.TxtSayi1 = new System.Windows.Forms.TextBox();
            this.TxtSayi2 = new System.Windows.Forms.TextBox();
            this.BtnTopla = new System.Windows.Forms.Button();
            this.TxtIsim = new System.Windows.Forms.TextBox();
            this.BtnSelamla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(240, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(224, 195);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(240, 308);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "button1";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(224, 384);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 1;
            this.button4.Text = "button2";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // LstSonuc
            // 
            this.LstSonuc.FormattingEnabled = true;
            this.LstSonuc.ItemHeight = 16;
            this.LstSonuc.Location = new System.Drawing.Point(29, 31);
            this.LstSonuc.Name = "LstSonuc";
            this.LstSonuc.Size = new System.Drawing.Size(182, 260);
            this.LstSonuc.TabIndex = 2;
            // 
            // BtnEkle
            // 
            this.BtnEkle.Location = new System.Drawing.Point(29, 327);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(111, 38);
            this.BtnEkle.TabIndex = 3;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.UseVisualStyleBackColor = true;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // TxtSayi1
            // 
            this.TxtSayi1.Location = new System.Drawing.Point(422, 81);
            this.TxtSayi1.Name = "TxtSayi1";
            this.TxtSayi1.Size = new System.Drawing.Size(100, 22);
            this.TxtSayi1.TabIndex = 4;
            // 
            // TxtSayi2
            // 
            this.TxtSayi2.Location = new System.Drawing.Point(641, 81);
            this.TxtSayi2.Name = "TxtSayi2";
            this.TxtSayi2.Size = new System.Drawing.Size(100, 22);
            this.TxtSayi2.TabIndex = 4;
            // 
            // BtnTopla
            // 
            this.BtnTopla.Location = new System.Drawing.Point(536, 131);
            this.BtnTopla.Name = "BtnTopla";
            this.BtnTopla.Size = new System.Drawing.Size(108, 36);
            this.BtnTopla.TabIndex = 5;
            this.BtnTopla.Text = "Topla";
            this.BtnTopla.UseVisualStyleBackColor = true;
            this.BtnTopla.Click += new System.EventHandler(this.BtnTopla_Click);
            // 
            // TxtIsim
            // 
            this.TxtIsim.Location = new System.Drawing.Point(577, 293);
            this.TxtIsim.Name = "TxtIsim";
            this.TxtIsim.Size = new System.Drawing.Size(100, 22);
            this.TxtIsim.TabIndex = 6;
            // 
            // BtnSelamla
            // 
            this.BtnSelamla.Location = new System.Drawing.Point(577, 335);
            this.BtnSelamla.Name = "BtnSelamla";
            this.BtnSelamla.Size = new System.Drawing.Size(75, 23);
            this.BtnSelamla.TabIndex = 7;
            this.BtnSelamla.Text = "Selamla";
            this.BtnSelamla.UseVisualStyleBackColor = true;
            this.BtnSelamla.Click += new System.EventHandler(this.BtnSelamla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 504);
            this.Controls.Add(this.BtnSelamla);
            this.Controls.Add(this.TxtIsim);
            this.Controls.Add(this.BtnTopla);
            this.Controls.Add(this.TxtSayi2);
            this.Controls.Add(this.TxtSayi1);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.LstSonuc);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox LstSonuc;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.TextBox TxtSayi1;
        private System.Windows.Forms.TextBox TxtSayi2;
        private System.Windows.Forms.Button BtnTopla;
        private System.Windows.Forms.TextBox TxtIsim;
        private System.Windows.Forms.Button BtnSelamla;
    }
}

