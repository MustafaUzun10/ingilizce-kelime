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
    public partial class Arama : UserControl
    {
        
        public  Arama()
        {
            InitializeComponent();
        }
        kelimeIslemleri kelime_islemleri = new kelimeIslemleri();
        ListView tum_kelimeler = new ListView();

        private void AramaBtn_Click(object sender, EventArgs e)
        {
            string[] gelen_kelime = kelime_islemleri.kelimeara(SearchTB.Text);
            if (gelen_kelime!=null)
            {
                ListViewItem kelimeL = new ListViewItem(gelen_kelime[0]);
                kelimeL.SubItems.Add(gelen_kelime[1]);
                kelimeL.SubItems.Add(gelen_kelime[2]);
                kelimeL.SubItems.Add(gelen_kelime[3]);
                listView1.Items.Add(kelimeL);
            }
            else
            {
                MessageBox.Show("Aradığınız kelime bulunamadı");
            }
        }

        private void Arama_Load(object sender, EventArgs e)
        {
            tum_kelimeler = kelime_islemleri.kelime_listele();

            
        }

        private void TumKelimelerBTN_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            for (int i = 0; i < tum_kelimeler.Items.Count; i++)
            {
                ListViewItem item =new  ListViewItem(tum_kelimeler.Items[i].Text);
                item.SubItems.Add(tum_kelimeler.Items[i].SubItems[1]);
                item.SubItems.Add(tum_kelimeler.Items[i].SubItems[2]);
                item.SubItems.Add(tum_kelimeler.Items[i].SubItems[3]);

                listView1.Items.Add(item);
            }
        }
        int id = 0; 
        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count>0)
            {
                id = Convert.ToInt32(listView1.SelectedItems[0].SubItems[3].Text);
                TurkceTxt.Text = listView1.SelectedItems[0].SubItems[1].Text;
                ingilizceTxt.Text = listView1.SelectedItems[0].SubItems[2].Text;
            }
        }

        private void DuzenleBtn_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0 && TurkceTxt.Text!=""&& ingilizceTxt.Text!="")
            {
                kelime_islemleri.kelime_guncelle(id,TurkceTxt.Text,ingilizceTxt.Text);
                listView1.SelectedItems[0].SubItems[1].Text = TurkceTxt.Text;
                listView1.SelectedItems[0].SubItems[2].Text = ingilizceTxt.Text;
            }
            else
            {
                MessageBox.Show("Bir kelime seçin, yada eğer kelime kutuları boş ise doldurun.");
            }
            
        }

        private void SilBtn_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                kelime_islemleri.kelime_sil(id);
                TurkceTxt.Text = "";
                ingilizceTxt.Text = "";
                listView1.Items.RemoveAt(listView1.SelectedItems[0].Index);
            }
            else
            {
                MessageBox.Show("Bir kelime seçin");
            }
        }
    }
}
