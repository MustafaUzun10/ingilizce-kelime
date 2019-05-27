using System;
using System.Windows.Forms;

namespace ingilizceTurkce
{
    public partial class Form1 : Form
    {
        static Form1 _obj;

        public static Form1 Instance
        {

            get
            {
                if (_obj == null)
                {
                    _obj = new Form1();
                }
                return _obj;
            }
        }

        public Panel PnlContainer
        {
            get { return panelMain; }
            set { panelMain = null; }
        }
        public static string kullanici_adi { get; set; }
        public Form1()
        {
            InitializeComponent();
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
        }

        

       public static int kullanicivar=0;

        private void Button3_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button3.Height;
            SidePanel.Top = button3.Top;
            if (!Form1.Instance.PnlContainer.Controls.ContainsKey("KelimeEkle"))
            {
                KelimeEkle ke = new KelimeEkle();
                ke.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainer.Controls.Add(ke);

            }
            Form1.Instance.PnlContainer.Controls["KelimeEkle"].BringToFront();


        }

      
        

       

        private void Button6_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button6.Height;
            SidePanel.Top = button6.Top;
            if (!Form1.Instance.PnlContainer.Controls.ContainsKey("istatistik"))
            {
                istatistik sta = new istatistik();
                sta.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainer.Controls.Add(sta);

            }
            Form1.Instance.PnlContainer.Controls["istatistik"].BringToFront();

        }

       

        private void Button2_Click_1(object sender, EventArgs e)
        {
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
            if (!Form1.Instance.PnlContainer.Controls.ContainsKey("Arama"))
            {
                Arama ar = new Arama();
                ar.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainer.Controls.Add(ar);

            }
            Form1.Instance.PnlContainer.Controls["Arama"].BringToFront();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            if (!Form1.Instance.PnlContainer.Controls.ContainsKey("KelimeEzberle"))
            {
                KelimeEzberle ke = new KelimeEzberle();
                ke.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainer.Controls.Add(ke);

            }
            Form1.Instance.PnlContainer.Controls["KelimeEzberle"].BringToFront();

        }

        private void Menu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _obj = this;
            GirisYap gy = new GirisYap();
            gy.Dock = DockStyle.Fill;
            panelMain.Controls.Add(gy);
            timer1.Start();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button4.Height;
            SidePanel.Top = button4.Top;
            if (!Form1.Instance.PnlContainer.Controls.ContainsKey("TestCoz"))
            {
                TestCoz tc = new TestCoz();
                tc.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainer.Controls.Add(tc);

            }
            Form1.Instance.PnlContainer.Controls["TestCoz"].BringToFront();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {

        }

        private void ExitBtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            
                if (kullanicivar == 0)
                {
                    menu.Visible = false;
                }
                else
                {
                    menu.Visible = true;
                    timer1.Stop();
                }
            
        }
    }
}
