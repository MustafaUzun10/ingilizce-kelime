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
    public partial class TestCoz : UserControl
    {
        public TestCoz()
        {
            InitializeComponent();
        }
        kelimeIslemleri kelime_islemler = new kelimeIslemleri();
        int seviye = 0; int id = 0;
        private void Panel2_MouseEnter(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(193, 0, 0);
        }

        private void Panel2_MouseLeave(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void Panel3_MouseEnter(object sender, EventArgs e)
        {
            panel3.BackColor = Color.FromArgb(193, 0, 0);
        }

        private void Panel3_MouseLeave(object sender, EventArgs e)
        {
            panel3.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void Panel1_MouseEnter(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(92, 160, 211);
        }

        private void Panel1_MouseLeave(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void Label2_MouseEnter(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(193, 0, 0);
        }

        private void Label2_MouseLeave(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void Label3_MouseEnter(object sender, EventArgs e)
        {
            panel3.BackColor = Color.FromArgb(193, 0, 0);
        }

        private void Label3_MouseLeave(object sender, EventArgs e)
        {
            panel3.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void Label1_MouseEnter(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(92, 160, 211);
        }

        
        

        private void Label1_MouseLeave(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(255, 255, 255);
        }

        ListView sinav_list = new ListView();
        int soru = 0; int rand = 0;
        private void TestCoz_Load(object sender, EventArgs e)
        {
            sinav_list = kelime_islemler.sinav_kelimeleri();
            if (sinav_list.Items.Count>0)
            {
                soru_cagir();
            }
        }

        public void soru_cagir()
        {
            if (soru<sinav_list.Items.Count)
            {
                seviye = Convert.ToInt32(sinav_list.Items[soru].SubItems[0].Text);
                string turkce_kelime = sinav_list.Items[soru].SubItems[1].Text;
                string ingilizce_kelime = sinav_list.Items[soru].SubItems[2].Text;
                id = Convert.ToInt32(sinav_list.Items[soru].SubItems[3].Text);
                soruLabel.Text = ingilizce_kelime;
                Random rnd = new Random();
                rand = rnd.Next(0, 2);
                if (rand == 0)
                {
                    cevapABtn.Text = turkce_kelime;
                }
                else
                {
                    cevapBbtn.Text = turkce_kelime;
                }
                if (rand != 0)
                {
                    cevapABtn.Text = kelime_islemler.rastgele_kelime()[0];
                }
                else if (rand != 1)
                {
                    cevapBbtn.Text = kelime_islemler.rastgele_kelime()[0];
                }

                soru++;
            }
            else
            {
                MessageBox.Show("Cevaplanacak kelime kalmadı.");
            }     
            
        }

        

        public void yanlis_cevap()
        {
            seviye = 1;
            kelime_islemler.cevap_guncelle(id, seviye);
        }
        public void dogru_cevap()
        {
            seviye++;
            kelime_islemler.cevap_guncelle(id, seviye);
        }

        private void Panel2_Click(object sender, EventArgs e)
        {
            if (rand == 0)
            {
                MessageBox.Show("Doğru Cevap");
                dogru_cevap();
                soru_cagir();
            }
            else if (rand == 1)
            {
                MessageBox.Show("Yanlış Cevap");
                yanlis_cevap();
                soru_cagir();
            }
        }

        private void Panel3_Click(object sender, EventArgs e)
        {
           if (rand == 0)
            {
                MessageBox.Show("Yanlış Cevap");
                yanlis_cevap();
                soru_cagir();
            }
            else if (rand == 1)
            {
                MessageBox.Show("Doğru Cevap");
                dogru_cevap();
                soru_cagir();
            }
        }

        
    }
}
