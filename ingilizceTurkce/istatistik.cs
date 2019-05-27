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
    public partial class istatistik : UserControl
    {
        public istatistik()
        {
            InitializeComponent();
        }
        kelimeIslemleri kelime_islemleri = new kelimeIslemleri();
        int ay1 = 0, ay2 = 0, ay3 = 0, ay4 = 0, ay5 = 0, ay6 = 0, ay7 = 0, ay8 = 0, ay9 = 0, ay10 = 0, ay11 = 0, ay12 = 0;

        private void İstatistik_Load(object sender, EventArgs e)
        {
          
            chart1.Series["Kelime"].Points.AddXY("1", 45);
            chart1.Series["Kelime"].Points.AddXY("2", 25);
            chart1.Series["Kelime"].Points.AddXY("3", 50);
            chart1.Series["Kelime"].Points.AddXY("4", 17);
            chart1.Series["Kelime"].Points.AddXY("5", 0);
            chart1.Series["Kelime"].Points.AddXY("6", 5);
        }
        ListView liste = new ListView();
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem!=null)
            {
                liste = kelime_islemleri.istatistik();
                for (int i = 0; i < liste.Items.Count; i++)
                {
                    DateTime zaman = Convert.ToDateTime(liste.Items[i].SubItems[1].Text);
                    if (zaman.Year==Convert.ToInt32(comboBox1.SelectedItem.ToString()))
                    {
                        if (zaman.Month == 1 && Convert.ToInt32(liste.Items[i].SubItems[0].Text) > 1)
                        {
                            ay1++;
                        }
                        else if (zaman.Month == 2 && Convert.ToInt32(liste.Items[i].SubItems[0].Text) > 1)
                        {
                            ay2++;
                        }
                        else if (zaman.Month == 3 && Convert.ToInt32(liste.Items[i].SubItems[0].Text) > 1)
                        {
                            ay3++;
                        }
                        else if (zaman.Month == 4 && Convert.ToInt32(liste.Items[i].SubItems[0].Text) > 1)
                        {
                            ay4++;
                        }
                        else if (zaman.Month == 5 && Convert.ToInt32(liste.Items[i].SubItems[0].Text) > 1)
                        {
                            ay5++;
                        }
                        else if (zaman.Month == 6 && Convert.ToInt32(liste.Items[i].SubItems[0].Text) > 1)
                        {
                            ay6++;
                        }
                        else if (zaman.Month == 7 && Convert.ToInt32(liste.Items[i].SubItems[0].Text) > 1)
                        {
                            ay7++;
                        }
                        else if (zaman.Month == 8 && Convert.ToInt32(liste.Items[i].SubItems[0].Text) > 1)
                        {
                            ay8++;
                        }
                        else if (zaman.Month == 9 && Convert.ToInt32(liste.Items[i].SubItems[0].Text) > 1)
                        {
                            ay9++;
                        }
                        else if (zaman.Month == 10 && Convert.ToInt32(liste.Items[i].SubItems[0].Text) > 1)
                        {
                            ay10++;
                        }
                        else if (zaman.Month == 11 && Convert.ToInt32(liste.Items[i].SubItems[0].Text) > 1)
                        {
                            ay11++;
                        }
                        else if (zaman.Month == 12 && Convert.ToInt32(liste.Items[i].SubItems[0].Text) > 1)
                        {
                            ay12++;
                        }
                    }
                    

                }

               
                chart1.Series.Clear();
                chart1.Series.Add("Kelime");
                chart1.Series["Kelime"].Points.AddXY("Ocak", ay1);
                chart1.Series["Kelime"].Points.AddXY("Şubat", ay2);
                chart1.Series["Kelime"].Points.AddXY("Mart", ay3);
                chart1.Series["Kelime"].Points.AddXY("Nisan", ay4);
                chart1.Series["Kelime"].Points.AddXY("Mayıs", ay5);
                chart1.Series["Kelime"].Points.AddXY("Haziran", ay6);
                chart1.Series["Kelime"].Points.AddXY("Temmuz", ay7);
                chart1.Series["Kelime"].Points.AddXY("Ağustos", ay8);
                chart1.Series["Kelime"].Points.AddXY("Eylül", ay9);
                chart1.Series["Kelime"].Points.AddXY("Ekim", ay10);
                chart1.Series["Kelime"].Points.AddXY("Kasım", ay11);
                chart1.Series["Kelime"].Points.AddXY("Aralık", ay12);
                ay1 = 0; ay2 = 0; ay3 = 0; ay4 = 0; ay5 = 0; ay6 = 0; ay7 = 0; ay8 = 0; ay9 = 0; ay10 = 0; ay11 = 0; ay12 = 0;

            }
        }
    }
}
