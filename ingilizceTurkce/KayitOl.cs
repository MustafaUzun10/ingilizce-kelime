using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ingilizceTurkce
{
    public partial class KayitOl : UserControl
    {
        public KayitOl()
        {
            InitializeComponent();
        }
        kullaniciIslemleri kullanici_islem = new kullaniciIslemleri();
        private void KayitOlBtn_Click(object sender, EventArgs e)
        {
                kullanici_islem.kayitOL(KullaniciAdiTxt.Text, AdSoyadTxt.Text, mailTxt.Text, SifreTxt.Text);
        }

        private void KayitOl_Load(object sender, EventArgs e)
        {
            SifreTxt.PasswordChar = '*';
            SifreTxt.MaxLength = 14;
            
        }

        

        private void GirisSayfaBtn_Click(object sender, EventArgs e)
        {
            if (!Form1.Instance.PnlContainer.Controls.ContainsKey("GirisYap"))
            {
                GirisYap gy = new GirisYap();
                gy.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainer.Controls.Add(gy);

            }
            Form1.Instance.PnlContainer.Controls["GirisYap"].BringToFront();
        }
    }
}
