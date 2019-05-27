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
    public partial class KelimeEkle : UserControl
    {
        Boolean isWord;
        string kelimeTuru = null;
        kelimeIslemleri ke = new kelimeIslemleri();
        public void colorChange(Boolean isWord)
        {
            if (isWord == true)
            {
                Word.BackColor = Color.FromArgb(182, 172, 0);
                Fiil.BackColor = Color.FromArgb(240, 240, 240);
            }
            else
            {
                Fiil.BackColor = Color.FromArgb(182, 172, 0);
                Word.BackColor = Color.FromArgb(240, 240, 240);
            }
        }
        public KelimeEkle()
        {

            InitializeComponent();
            isWord = true;

        }

        

        private void Fiil_Click_1(object sender, EventArgs e)
        {
            isWord = false;
            colorChange(isWord);
            kelimeTuru = "Fiil";
        }

        private void Word_Click_1(object sender, EventArgs e)
        {
            isWord = true;
            colorChange(isWord);
            kelimeTuru = "İsim";
        }

        private void KelimeEkleBtn_Click(object sender, EventArgs e)
        {
            if (kelimeTuru==null)
            {
                MessageBox.Show("Kelime türünü seçiniz.");
            }
            else
            {
                ke.kelime_ekle(TurkceKelimeTxt.Text, İngilizceKelimeTxt.Text, kelimeTuru,cumleTxt.Text);
            }
        }
    }
}
