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
    
    public partial class GirisYap : UserControl
    {
        
        public GirisYap()
        {
            InitializeComponent();
            
        }
        kullaniciIslemleri kullanici_islem = new kullaniciIslemleri();
        private void GirisSayfaBtn_Click(object sender, EventArgs e)
        {
           int kullanicigiris= kullanici_islem.giris(KullaniciAdiTxt.Text, SifreTxt.Text);
            if (kullanicigiris==1)
            {
                Form1.kullanicivar = 1;
            }
           
        }

        private void KayitOlBtn_Click(object sender, EventArgs e)
        {
            if (!Form1.Instance.PnlContainer.Controls.ContainsKey("KayitOl"))
            {
                KayitOl ko = new KayitOl();
                ko.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainer.Controls.Add(ko);

            }
            Form1.Instance.PnlContainer.Controls["KayitOl"].BringToFront();
        }

        private void SifreTxt_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void GirisYap_Load(object sender, EventArgs e)
        {
            SifreTxt.PasswordChar = '*';
            SifreTxt.MaxLength = 14;
        }
    }
}
