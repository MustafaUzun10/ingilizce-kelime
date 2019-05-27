namespace ingilizceTurkce
{
    partial class TestCoz
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestCoz));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.soruLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cevapABtn = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cevapBbtn = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(160)))), ((int)(((byte)(211)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(142, 26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.soruLabel);
            this.panel1.Location = new System.Drawing.Point(342, 26);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 160);
            this.panel1.TabIndex = 10;
            this.panel1.MouseEnter += new System.EventHandler(this.Panel1_MouseEnter);
            this.panel1.MouseLeave += new System.EventHandler(this.Panel1_MouseLeave);
            // 
            // soruLabel
            // 
            this.soruLabel.AutoSize = true;
            this.soruLabel.Font = new System.Drawing.Font("Century Gothic", 22.2F);
            this.soruLabel.Location = new System.Drawing.Point(20, 47);
            this.soruLabel.Name = "soruLabel";
            this.soruLabel.Size = new System.Drawing.Size(114, 45);
            this.soruLabel.TabIndex = 0;
            this.soruLabel.Text = "Hello";
            this.soruLabel.MouseEnter += new System.EventHandler(this.Label1_MouseEnter);
            this.soruLabel.MouseLeave += new System.EventHandler(this.Label1_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.cevapABtn);
            this.panel2.Location = new System.Drawing.Point(153, 363);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(341, 130);
            this.panel2.TabIndex = 12;
            this.panel2.Click += new System.EventHandler(this.Panel2_Click);
            this.panel2.MouseEnter += new System.EventHandler(this.Panel2_MouseEnter);
            this.panel2.MouseLeave += new System.EventHandler(this.Panel2_MouseLeave);
            // 
            // cevapABtn
            // 
            this.cevapABtn.AutoSize = true;
            this.cevapABtn.Font = new System.Drawing.Font("Century Gothic", 22.2F);
            this.cevapABtn.Location = new System.Drawing.Point(3, 41);
            this.cevapABtn.Name = "cevapABtn";
            this.cevapABtn.Size = new System.Drawing.Size(136, 45);
            this.cevapABtn.TabIndex = 1;
            this.cevapABtn.Text = "Naber";
            this.cevapABtn.MouseEnter += new System.EventHandler(this.Label2_MouseEnter);
            this.cevapABtn.MouseLeave += new System.EventHandler(this.Label2_MouseLeave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.cevapBbtn);
            this.panel3.Location = new System.Drawing.Point(681, 364);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(365, 130);
            this.panel3.TabIndex = 13;
            this.panel3.Click += new System.EventHandler(this.Panel3_Click);
            this.panel3.MouseEnter += new System.EventHandler(this.Panel3_MouseEnter);
            this.panel3.MouseLeave += new System.EventHandler(this.Panel3_MouseLeave);
            // 
            // cevapBbtn
            // 
            this.cevapBbtn.AutoSize = true;
            this.cevapBbtn.Font = new System.Drawing.Font("Century Gothic", 22.2F);
            this.cevapBbtn.Location = new System.Drawing.Point(3, 41);
            this.cevapBbtn.Name = "cevapBbtn";
            this.cevapBbtn.Size = new System.Drawing.Size(192, 45);
            this.cevapBbtn.TabIndex = 2;
            this.cevapBbtn.Text = "Merhaba";
            this.cevapBbtn.MouseEnter += new System.EventHandler(this.Label3_MouseEnter);
            this.cevapBbtn.MouseLeave += new System.EventHandler(this.Label3_MouseLeave);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(534, 364);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(147, 130);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 363);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(141, 130);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(67, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(309, 49);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cevabı Seçiniz";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(357, 239);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(443, 81);
            this.panel4.TabIndex = 14;
            // 
            // TestCoz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel4);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TestCoz";
            this.Size = new System.Drawing.Size(1089, 653);
            this.Load += new System.EventHandler(this.TestCoz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label soruLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label cevapABtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label cevapBbtn;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
    }
}
