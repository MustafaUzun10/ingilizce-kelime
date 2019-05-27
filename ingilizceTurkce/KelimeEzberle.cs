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
    public partial class KelimeEzberle : UserControl
    {
        public KelimeEzberle()
        {
            InitializeComponent();
        }

        kelimeIslemleri ke = new kelimeIslemleri();
       

        private void SayacBtn_Click_1(object sender, EventArgs e)
        {
            if (SayacBtn.Text== "Baslat")
            {
                timer1.Start();
                SayacBtn.Text = "Durdur";
            }
            else
            {
                timer1.Stop();
                SayacBtn.Text = "Baslat";
            }
            
            
        }

        private void KelimeEzberle_Load(object sender, EventArgs e)
        {
          
        }

        private void Timer1_Tick_1(object sender, EventArgs e)
        {
            timeLabel.Text = (Convert.ToInt32(timeLabel.Text) - 1).ToString();
            if (timeLabel.Text == "0")
            {
                timeLabel.Text = "6";
                string[] kelime = ke.rastgele_kelime();
                label1.Text = kelime[1];
                label2.Text = kelime[0];
            }
        }
    }
}
