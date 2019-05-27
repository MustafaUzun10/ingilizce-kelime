using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ingilizceTurkce
{
    class kullaniciIslemleri
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=database.mdb;");

       
        public void kayitOL(string kullanici_adi,string ad_soyad,string mail,string sifre)
        {
            try
            {
                con.Open();
                OleDbCommand komut = new OleDbCommand("INSERT INTO kullanicilar (kullanici_adi,ad_soyad,mail,sifre) VALUES ('" + kullanici_adi + "','" + ad_soyad + "','" + mail + "','" + sifre + "')", con);
                komut.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Kayıt işlemi onaylandı.");
            }
            catch (Exception error)
            {
                MessageBox.Show("Kayıt işlemi gerçekleştirilemedi."+ error);
                con.Close();
            }
        }

        public int giris(string kullanici_adi, string sifre)
        {
            int sayac = 0;
            try
            {
                
                con.Open();
                OleDbCommand komut = new OleDbCommand("SELECT * from kullanicilar WHERE kullanici_adi='" + kullanici_adi + "' AND  sifre='"+sifre +"'", con);
                OleDbDataReader komutOku= komut.ExecuteReader();
                while (komutOku.Read())
                {
                    Form1.kullanici_adi = komutOku["kullanici_adi"].ToString();
                    MessageBox.Show("Başarılı bir şekilde giriş yaptınız.");
                    sayac++;
                }
                if (sayac==0)
                {
                    MessageBox.Show("Kullanıcı yok yada hatalı giriş yaptınız.");
                }
                con.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("Giriş işlemi gerçekleştirilemedi." + error);
                con.Close();
            }
            return sayac;
        }
        public int kullanici_kontrol()
        {
            int kullaniciVar = 0;
            try
            {
                int sayac = 0;
                con.Open();
                OleDbCommand komut = new OleDbCommand("SELECT * from kullanicilar", con);
                OleDbDataReader komutOku = komut.ExecuteReader();
                while (komutOku.Read())
                {
                    sayac++;
                }
                if (sayac > 0)
                {
                    kullaniciVar = 1;
                }
                con.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("Kullanıcı bulma işlemi gerçekleştirilemedi." + error);
                con.Close();
            }
            return kullaniciVar;
        }



    }
}
