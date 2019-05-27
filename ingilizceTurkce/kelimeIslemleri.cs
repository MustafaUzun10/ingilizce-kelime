using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ingilizceTurkce
{
    class kelimeIslemleri
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=database.mdb;");
        public string[] rastgele_kelime()
        {
            string[] kelime=new string[2];
            Random rasgele = new Random(); int kelimeSayi = 0;
            int id = rasgele.Next(0,kelime_sayisi());
            try
            {
                
                con.Open();
                OleDbCommand komut = new OleDbCommand("SELECT * from kelimeler WHERE ID=" + id , con);
                OleDbDataReader komutOku = komut.ExecuteReader();
                while (komutOku.Read())
                {
                    kelime[0]=komutOku["turkce_kelime"].ToString();
                    kelime[1] = komutOku["ingilizce_kelime"].ToString();
                    kelimeSayi++;
                }
                if (kelimeSayi==0)
                {
                   rastgele_kelime();
                }
                con.Close();

            }
            catch (Exception error)
            {
                MessageBox.Show("Kelime getirme işlemi gerçekleştirilemedi." + error);
                con.Close();
            }
            return kelime;
        }

        public int  kelime_sayisi()
        {
            int id = 0;
            try
            {
                con.Open();
                OleDbCommand komut = new OleDbCommand("SELECT * from kelimeler ORDER BY ID desc ", con);
                OleDbDataReader komutOku = komut.ExecuteReader();
                while (komutOku.Read())
                {
                    id = Convert.ToInt32(komutOku["id"]);
                    break;
                }
                con.Close();

            }
            catch (Exception error)
            {
                MessageBox.Show("Kelime getirme işlemi gerçekleştirilemedi." + error);
                con.Close();
            }
            return id;

        }

        public void kelime_ekle(string turkce_kelime, string ingilizce_kelime,string kelime_turu,string cumle)
        {
            int id = kelime_sayisi()+1;
            try
            {
                con.Open();
                OleDbCommand kelime_ekleme_komutu = new OleDbCommand("INSERT INTO kelimeler (ID,turkce_kelime,ingilizce_kelime,kelime_turu,kelime_sorulma_tarihi,cumle) VALUES ('"+id +"','"+ turkce_kelime + "','" + ingilizce_kelime + "','" + kelime_turu + "','" + DateTime.Now + "','" +cumle + "')", con);
                kelime_ekleme_komutu.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Kelime ekleme işlemi başarılı.");

            }
            catch (Exception error)
            {
                MessageBox.Show("Kelime ekleme işlemi gerçekleştirilemedi." + error);
                con.Close();
            }
            
        }


        public string[] kelimeara(string aranan_kelime)
        {
            string[] kelime = new string[4];
            
            try
            {
                int sayac = 0;
                con.Open();
                OleDbCommand komut = new OleDbCommand("SELECT * from kelimeler WHERE turkce_kelime='" + aranan_kelime+"' or ingilizce_kelime='"+aranan_kelime+"'", con);
                OleDbDataReader komutOku = komut.ExecuteReader();
                while (komutOku.Read())
                {
                    kelime[0] = komutOku["seviye"].ToString();
                    kelime[1] = komutOku["turkce_kelime"].ToString();
                    kelime[2] = komutOku["ingilizce_kelime"].ToString();
                    kelime[3] = komutOku["ID"].ToString();

                    sayac++;
                }
                if (sayac==0)
                {
                    kelime = null;
                }
                
                con.Close();

            }
            catch (Exception error)
            {
                MessageBox.Show("Kelime getirme işlemi gerçekleştirilemedi." + error);
                con.Close();
            }
            return kelime;
        } 

        public ListView kelime_listele()
        {
            ListView aramaListesi = new ListView();
            try
            {
                con.Open();
                OleDbCommand aramaKomut = new OleDbCommand("SELECT * from kelimeler", con);
                OleDbDataReader komutOku = aramaKomut.ExecuteReader();
                while (komutOku.Read())
                {
                    ListViewItem item = new ListViewItem(komutOku["seviye"].ToString());
                    item.SubItems.Add(komutOku["turkce_kelime"].ToString());
                    item.SubItems.Add(komutOku["ingilizce_kelime"].ToString());
                    item.SubItems.Add(komutOku["ID"].ToString());
                    aramaListesi.Items.Add(item);
                }

                con.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("Arama işlemi tamamlanamadı"+ error);
                con.Close();
            }

            return aramaListesi;
        }

        public void kelime_guncelle(int id,string turkce_kelime, string ingilizce_kelime)
        {
            try
            {
                con.Open();
                OleDbCommand komut_Kelime_Guncelle = new OleDbCommand("Update kelimeler SET turkce_kelime='" + turkce_kelime + "' , ingilizce_kelime='" + ingilizce_kelime + "' WHERE ID="+id , con);
                komut_Kelime_Guncelle.ExecuteNonQuery();
                MessageBox.Show("Kelime başarı ile güncellendi.");
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Güncelleme işlemi başarılı olmadı."+e);
                con.Close();
            }
            
        }

        public void kelime_sil(int id)
        {
            try
            {
                con.Open();
                OleDbCommand komut_sil = new OleDbCommand("Delete from kelimeler WHERE ID="+id, con);
                komut_sil.ExecuteNonQuery();
                MessageBox.Show("Kelime başarı ile silindi.");
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Silme işlemi başarılı olmadı." + e);
                con.Close();
            }

        }



        public ListView sinav_kelimeleri()
        {
            ListView sinav_listesi = new ListView();
            try
            {
                con.Open();
                OleDbCommand aramaKomut = new OleDbCommand("SELECT * from kelimeler", con);
                OleDbDataReader komutOku = aramaKomut.ExecuteReader();
                while (komutOku.Read())
                {
                    DateTime time =Convert.ToDateTime( komutOku["kelime_sorulma_tarihi"]);
                    if (time<DateTime.Now)
                    {
                        ListViewItem item = new ListViewItem(komutOku["seviye"].ToString());
                        item.SubItems.Add(komutOku["turkce_kelime"].ToString());
                        item.SubItems.Add(komutOku["ingilizce_kelime"].ToString());
                        item.SubItems.Add(komutOku["ID"].ToString());
                        sinav_listesi.Items.Add(item);
                    }
                    
                }

                con.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("Arama işlemi tamamlanamadı" + error);
                con.Close();
            }

            return sinav_listesi;
        }
        DateTime t;
        public void cevap_guncelle(int id,int seviye)
        {
            try
            {
                int x = 0;
                if (seviye==1)
                {
                    x = 1;
                    t = DateTime.Now.AddDays(x);
                }
                else if (seviye == 2)
                {
                    x = 7;
                    t = DateTime.Now.AddDays(x);
                }
                else if(seviye == 3)
                {
                    x = 20;
                    t = DateTime.Now.AddDays(x);
                }
                else if(seviye == 4)
                {
                    x = 40;
                    t = DateTime.Now.AddDays(x);
                }
                else if(seviye == 5)
                {
                    x = 50;
                    t = DateTime.Now.AddDays(x);
                }
                else if(seviye == 6)
                {
                    x = 80;
                    t = DateTime.Now.AddDays(x);
                }
                else if(seviye == 7)
                {
                    x = 90;
                    t = DateTime.Now.AddDays(x);
                }

                con.Open();
                OleDbCommand komut_Kelime_Guncelle = new OleDbCommand("Update kelimeler SET seviye='" + seviye + "' , kelime_sorulma_tarihi='" + t + "' WHERE ID=" + id, con);
                komut_Kelime_Guncelle.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Cevap kayıt işlemi başarılı olmadı." + e);
                con.Close();
            }
        }

        public ListView istatistik()
        {
            ListView kelimeler = new ListView();
            try
            {
                con.Open();
                OleDbCommand istatistik_komut = new OleDbCommand("Select * from kelimeler", con);
                OleDbDataReader reader = istatistik_komut.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["seviye"].ToString());
                    item.SubItems.Add(reader["kelime_sorulma_tarihi"].ToString());
                    kelimeler.Items.Add(item);
                }
                con.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show("İşlem sırasında bir hata meydana geldi." + e);
                con.Close();
            }
            return kelimeler;
        }


    }
}
