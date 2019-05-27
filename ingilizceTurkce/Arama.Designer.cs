namespace ingilizceTurkce
{
    partial class Arama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Arama));
            this.SilBtn = new System.Windows.Forms.Button();
            this.AramaBtn = new System.Windows.Forms.PictureBox();
            this.SearchTB = new System.Windows.Forms.TextBox();
            this.DuzenleBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TurkceTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ingilizceTxt = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TumKelimelerBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AramaBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // SilBtn
            // 
            this.SilBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.SilBtn.FlatAppearance.BorderSize = 0;
            this.SilBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SilBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SilBtn.ForeColor = System.Drawing.Color.White;
            this.SilBtn.Location = new System.Drawing.Point(664, 281);
            this.SilBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SilBtn.Name = "SilBtn";
            this.SilBtn.Size = new System.Drawing.Size(347, 52);
            this.SilBtn.TabIndex = 55;
            this.SilBtn.Text = "Sil";
            this.SilBtn.UseVisualStyleBackColor = false;
            this.SilBtn.Click += new System.EventHandler(this.SilBtn_Click);
            // 
            // AramaBtn
            // 
            this.AramaBtn.Image = ((System.Drawing.Image)(resources.GetObject("AramaBtn.Image")));
            this.AramaBtn.Location = new System.Drawing.Point(576, 6);
            this.AramaBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AramaBtn.Name = "AramaBtn";
            this.AramaBtn.Size = new System.Drawing.Size(57, 32);
            this.AramaBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AramaBtn.TabIndex = 54;
            this.AramaBtn.TabStop = false;
            this.AramaBtn.Click += new System.EventHandler(this.AramaBtn_Click);
            // 
            // SearchTB
            // 
            this.SearchTB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SearchTB.Location = new System.Drawing.Point(15, 6);
            this.SearchTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchTB.Multiline = true;
            this.SearchTB.Name = "SearchTB";
            this.SearchTB.Size = new System.Drawing.Size(555, 32);
            this.SearchTB.TabIndex = 53;
            // 
            // DuzenleBtn
            // 
            this.DuzenleBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.DuzenleBtn.FlatAppearance.BorderSize = 0;
            this.DuzenleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DuzenleBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DuzenleBtn.ForeColor = System.Drawing.Color.White;
            this.DuzenleBtn.Location = new System.Drawing.Point(664, 199);
            this.DuzenleBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DuzenleBtn.Name = "DuzenleBtn";
            this.DuzenleBtn.Size = new System.Drawing.Size(347, 52);
            this.DuzenleBtn.TabIndex = 52;
            this.DuzenleBtn.Text = "Güncelle";
            this.DuzenleBtn.UseVisualStyleBackColor = false;
            this.DuzenleBtn.Click += new System.EventHandler(this.DuzenleBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label1.Location = new System.Drawing.Point(716, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 21);
            this.label1.TabIndex = 51;
            this.label1.Text = "Türkçe";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(664, 142);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // TurkceTxt
            // 
            this.TurkceTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TurkceTxt.Location = new System.Drawing.Point(711, 142);
            this.TurkceTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TurkceTxt.Multiline = true;
            this.TurkceTxt.Name = "TurkceTxt";
            this.TurkceTxt.Size = new System.Drawing.Size(299, 32);
            this.TurkceTxt.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label2.Location = new System.Drawing.Point(716, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 21);
            this.label2.TabIndex = 48;
            this.label2.Text = "İngilizce ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(664, 66);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 47;
            this.pictureBox2.TabStop = false;
            // 
            // ingilizceTxt
            // 
            this.ingilizceTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ingilizceTxt.Location = new System.Drawing.Point(711, 66);
            this.ingilizceTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ingilizceTxt.Multiline = true;
            this.ingilizceTxt.Name = "ingilizceTxt";
            this.ingilizceTxt.Size = new System.Drawing.Size(299, 32);
            this.ingilizceTxt.TabIndex = 46;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.Control;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(15, 47);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(617, 493);
            this.listView1.TabIndex = 45;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.ListView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Seviye";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Türkçe";
            this.columnHeader2.Width = 144;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "İngilizce";
            this.columnHeader3.Width = 162;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "ID";
            // 
            // TumKelimelerBTN
            // 
            this.TumKelimelerBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.TumKelimelerBTN.FlatAppearance.BorderSize = 0;
            this.TumKelimelerBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TumKelimelerBTN.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TumKelimelerBTN.ForeColor = System.Drawing.Color.White;
            this.TumKelimelerBTN.Location = new System.Drawing.Point(664, 357);
            this.TumKelimelerBTN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TumKelimelerBTN.Name = "TumKelimelerBTN";
            this.TumKelimelerBTN.Size = new System.Drawing.Size(347, 52);
            this.TumKelimelerBTN.TabIndex = 56;
            this.TumKelimelerBTN.Text = "Tüm Kelimeleri Getir";
            this.TumKelimelerBTN.UseVisualStyleBackColor = false;
            this.TumKelimelerBTN.Click += new System.EventHandler(this.TumKelimelerBTN_Click);
            // 
            // Arama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TumKelimelerBTN);
            this.Controls.Add(this.SilBtn);
            this.Controls.Add(this.AramaBtn);
            this.Controls.Add(this.SearchTB);
            this.Controls.Add(this.DuzenleBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TurkceTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.ingilizceTxt);
            this.Controls.Add(this.listView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Arama";
            this.Size = new System.Drawing.Size(1089, 653);
            this.Load += new System.EventHandler(this.Arama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AramaBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SilBtn;
        private System.Windows.Forms.PictureBox AramaBtn;
        private System.Windows.Forms.TextBox SearchTB;
        private System.Windows.Forms.Button DuzenleBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TurkceTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox ingilizceTxt;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button TumKelimelerBTN;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}
