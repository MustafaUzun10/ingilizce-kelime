namespace ingilizceTurkce
{
    partial class GirisYap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisYap));
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.KayitOlBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.SifreTxt = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.KullaniciAdiTxt = new System.Windows.Forms.TextBox();
            this.GirisSayfaBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label1.Location = new System.Drawing.Point(51, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 30);
            this.label1.TabIndex = 38;
            this.label1.Text = "Şifrenizi Giriniz";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(680, 196);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 51);
            this.label4.TabIndex = 37;
            this.label4.Text = "Kaydolun";
            // 
            // KayitOlBtn
            // 
            this.KayitOlBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.KayitOlBtn.FlatAppearance.BorderSize = 0;
            this.KayitOlBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KayitOlBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KayitOlBtn.ForeColor = System.Drawing.Color.White;
            this.KayitOlBtn.Location = new System.Drawing.Point(627, 263);
            this.KayitOlBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.KayitOlBtn.Name = "KayitOlBtn";
            this.KayitOlBtn.Size = new System.Drawing.Size(347, 42);
            this.KayitOlBtn.TabIndex = 36;
            this.KayitOlBtn.Text = "Kaydol";
            this.KayitOlBtn.UseVisualStyleBackColor = false;
            this.KayitOlBtn.Click += new System.EventHandler(this.KayitOlBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label2.Location = new System.Drawing.Point(51, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 30);
            this.label2.TabIndex = 35;
            this.label2.Text = "Kullanıcı Adınızı Giriniz";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(56, 279);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(68, 60);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 34;
            this.pictureBox4.TabStop = false;
            // 
            // SifreTxt
            // 
            this.SifreTxt.Font = new System.Drawing.Font("Century Gothic", 26F);
            this.SifreTxt.Location = new System.Drawing.Point(131, 279);
            this.SifreTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SifreTxt.Multiline = true;
            this.SifreTxt.Name = "SifreTxt";
            this.SifreTxt.Size = new System.Drawing.Size(299, 61);
            this.SifreTxt.TabIndex = 33;
            this.SifreTxt.TextChanged += new System.EventHandler(this.SifreTxt_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(56, 153);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(68, 61);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            // 
            // KullaniciAdiTxt
            // 
            this.KullaniciAdiTxt.Font = new System.Drawing.Font("Century Gothic", 26F);
            this.KullaniciAdiTxt.Location = new System.Drawing.Point(132, 153);
            this.KullaniciAdiTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.KullaniciAdiTxt.Multiline = true;
            this.KullaniciAdiTxt.Name = "KullaniciAdiTxt";
            this.KullaniciAdiTxt.Size = new System.Drawing.Size(299, 61);
            this.KullaniciAdiTxt.TabIndex = 31;
            // 
            // GirisSayfaBtn
            // 
            this.GirisSayfaBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.GirisSayfaBtn.FlatAppearance.BorderSize = 0;
            this.GirisSayfaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GirisSayfaBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GirisSayfaBtn.ForeColor = System.Drawing.Color.White;
            this.GirisSayfaBtn.Location = new System.Drawing.Point(56, 377);
            this.GirisSayfaBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GirisSayfaBtn.Name = "GirisSayfaBtn";
            this.GirisSayfaBtn.Size = new System.Drawing.Size(373, 57);
            this.GirisSayfaBtn.TabIndex = 30;
            this.GirisSayfaBtn.Text = "Giriş Yap";
            this.GirisSayfaBtn.UseVisualStyleBackColor = false;
            this.GirisSayfaBtn.Click += new System.EventHandler(this.GirisSayfaBtn_Click);
            // 
            // GirisYap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.KayitOlBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.SifreTxt);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.KullaniciAdiTxt);
            this.Controls.Add(this.GirisSayfaBtn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GirisYap";
            this.Size = new System.Drawing.Size(1089, 653);
            this.Load += new System.EventHandler(this.GirisYap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button KayitOlBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox SifreTxt;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox KullaniciAdiTxt;
        private System.Windows.Forms.Button GirisSayfaBtn;
    }
}
