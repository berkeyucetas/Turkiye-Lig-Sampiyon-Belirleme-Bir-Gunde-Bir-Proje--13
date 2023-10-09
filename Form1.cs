using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Türkiye_Lig_Şampiyon_Belirleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rastgele = new Random();
        int gsp = 0;
        int fbp = 0;
        int bjkp = 0;
        int tsp = 0;


        private void btnhafta2_Click(object sender, EventArgs e)
        {
            btnhafta2.Enabled = false;
            int a = rastgele.Next(0, 5);
            int b = rastgele.Next(0, 5);
            int c = rastgele.Next(0, 5);
            int d = rastgele.Next(0, 5);
            lh2gs.Text = a.ToString();
            lh2fb.Text = b.ToString();
            lh2ts.Text = c.ToString();
            lh2bjk.Text = d.ToString();
            if (Convert.ToInt32(lh2fb.Text) > Convert.ToInt32(lh2gs.Text))
            {
                fbp = fbp + 2;
                lfbp.Text = fbp.ToString();
            }
            else if (Convert.ToInt32(lh2fb.Text) < Convert.ToInt32(lh2gs.Text))
            {
                 gsp = gsp + 2;
                lgsp.Text = gsp.ToString();
            }
            else if (Convert.ToInt32(lh2gs.Text) == Convert.ToInt32(lh2fb.Text))
            {
                gsp = gsp + 1;
                lgsp.Text = gsp.ToString();
                fbp = fbp + 1;
                lfbp.Text = fbp.ToString();
            }
            if (Convert.ToInt32(lh2bjk.Text) > Convert.ToInt32(lh2ts.Text))
            {
                bjkp = bjkp + 2;
                lbjkp.Text = bjkp.ToString();
            }
            else if (Convert.ToInt32(lh2bjk.Text) < Convert.ToInt32(lh2ts.Text))
            {
                tsp = tsp + 2;
                ltsp.Text = tsp.ToString();
            }
            else if (Convert.ToInt32(lh2bjk.Text) == Convert.ToInt32(lh2ts.Text))
            {
                bjkp = bjkp + 1;
                lbjkp.Text = bjkp.ToString();
                tsp = tsp + 1;
                ltsp.Text = tsp.ToString();
            }

        }

        private void btnhafta3_Click(object sender, EventArgs e)
        {
            btnhafta3.Enabled = false;
            int a = rastgele.Next(0, 5);
            int b = rastgele.Next(0, 5);
            int c = rastgele.Next(0, 5);
            int d = rastgele.Next(0, 5);
            lh3gs.Text = a.ToString();
            lh3fb.Text = b.ToString();
            lh3ts.Text = c.ToString();
            lh3bjk.Text = d.ToString();
            if (Convert.ToInt32(lh3ts.Text) > Convert.ToInt32(lh3gs.Text))
            {
                tsp = tsp + 2;
                ltsp.Text = tsp.ToString();
            }
            else if (Convert.ToInt32(lh3ts.Text) < Convert.ToInt32(lh3gs.Text))
            {
                gsp = gsp + 2;
                lgsp.Text = gsp.ToString();
            }
            else if (Convert.ToInt32(lh3ts.Text) == Convert.ToInt32(lh3gs.Text))
            {
                gsp = gsp + 1;
                lgsp.Text = gsp.ToString();
                tsp = tsp + 1;
                ltsp.Text = tsp.ToString();
            }
            if (Convert.ToInt32(lh3bjk.Text) > Convert.ToInt32(lh3fb.Text))
            {
                bjkp = bjkp + 2;
                lbjkp.Text = bjkp.ToString();
            }
            else if (Convert.ToInt32(lh3bjk.Text) < Convert.ToInt32(lh3fb.Text))
            {
                fbp = fbp + 2;
                lfbp.Text = fbp.ToString();
            }
            else if (Convert.ToInt32(lh3bjk.Text) == Convert.ToInt32(lh3fb.Text))
            {
                bjkp = bjkp + 1;
                lbjkp.Text = bjkp.ToString();
                fbp = fbp + 1;
                lfbp.Text = fbp.ToString();
            }

        }

        private void btnhafta4_Click(object sender, EventArgs e)
        {
            btnhafta4.Enabled = false;
            int a = rastgele.Next(0, 5);
            int b = rastgele.Next(0, 5);
            int c = rastgele.Next(0, 5);
            int d = rastgele.Next(0, 5);
            lh4gs.Text = a.ToString();
            lh4fb.Text = b.ToString();
            lh4ts.Text = c.ToString();
            lh4bjk.Text = d.ToString();
            if (Convert.ToInt32(lh4bjk.Text) > Convert.ToInt32(lh4gs.Text))
            {
                bjkp = bjkp + 2;
                lbjkp.Text = bjkp.ToString();
            }
            else if (Convert.ToInt32(lh4bjk.Text) < Convert.ToInt32(lh4gs.Text))
            {
                gsp = gsp + 2;
                lgsp.Text = gsp.ToString();
            }
            else if (Convert.ToInt32(lh4bjk.Text) == Convert.ToInt32(lh4gs.Text))
            {
                gsp = gsp + 1;
                lgsp.Text = gsp.ToString();
                bjkp = bjkp + 1;
                lbjkp.Text = bjkp.ToString();
            }
            if (Convert.ToInt32(lh4ts.Text) > Convert.ToInt32(lh4fb.Text))
            {
                tsp = tsp + 2;
                ltsp.Text = tsp.ToString();
            }
            else if (Convert.ToInt32(lh4ts.Text) < Convert.ToInt32(lh4fb.Text))
            {
                fbp = fbp + 2;
                lfbp.Text = fbp.ToString();
            }
            else if (Convert.ToInt32(lh4ts.Text) == Convert.ToInt32(lh4fb.Text))
            {
                tsp = tsp + 1;
                ltsp.Text = tsp.ToString();
                fbp = fbp + 1;
                lfbp.Text = fbp.ToString();
            }

        }

        private void btnhafta5_Click(object sender, EventArgs e)
        {
            btnhafta5.Enabled = false;
            int a = rastgele.Next(0, 5);
            int b = rastgele.Next(0, 5);
            int c = rastgele.Next(0, 5);
            int d = rastgele.Next(0, 5);
            lh5gs.Text = a.ToString();
            lh5fb.Text = b.ToString();
            lh5ts.Text = c.ToString();
            lh5bjk.Text = d.ToString();
            if (Convert.ToInt32(lh5bjk.Text) > Convert.ToInt32(lh5gs.Text))
            {
                bjkp = bjkp + 2;
                lbjkp.Text = bjkp.ToString();
            }
            else if (Convert.ToInt32(lh5bjk.Text) < Convert.ToInt32(lh5gs.Text))
            {
                gsp = gsp + 2;
                lgsp.Text = gsp.ToString();
            }
            else if (Convert.ToInt32(lh5bjk.Text) == Convert.ToInt32(lh5gs.Text))
            {
                gsp = gsp + 1;
                lgsp.Text = gsp.ToString();
                bjkp = bjkp + 1;
                lbjkp.Text = bjkp.ToString();
            }
            if (Convert.ToInt32(lh5ts.Text) > Convert.ToInt32(lh5fb.Text))
            {
                tsp = tsp + 2;
                ltsp.Text = tsp.ToString();
            }
            else if (Convert.ToInt32(lh5ts.Text) < Convert.ToInt32(lh5fb.Text))
            {
                fbp = fbp + 2;
                lfbp.Text = fbp.ToString();
            }
            else if (Convert.ToInt32(lh5ts.Text) == Convert.ToInt32(lh5fb.Text))
            {
                tsp = tsp + 1;
                ltsp.Text = tsp.ToString();
                fbp = fbp + 1;
                lfbp.Text = fbp.ToString();
            }

        }

        private void btnhafta6_Click(object sender, EventArgs e)
        {
            btnhafta6.Enabled = false;
            int a = rastgele.Next(0, 5);
            int b = rastgele.Next(0, 5);
            int c = rastgele.Next(0, 5);
            int d = rastgele.Next(0, 5);
            lh6gs.Text = a.ToString();
            lh6fb.Text = b.ToString();
            lh6ts.Text = c.ToString();
            lh6bjk.Text = d.ToString();
            if (Convert.ToInt32(lh6ts.Text) > Convert.ToInt32(lh6gs.Text))
            {
                tsp = tsp + 2;
                ltsp.Text = tsp.ToString();
            }
            else if (Convert.ToInt32(lh6ts.Text) < Convert.ToInt32(lh6gs.Text))
            {
                gsp = gsp + 2;
                lgsp.Text = gsp.ToString();
            }
            else if (Convert.ToInt32(lh6ts.Text) == Convert.ToInt32(lh6gs.Text))
            {
                gsp = gsp + 1;
                lgsp.Text = gsp.ToString();
                tsp = tsp + 1;
                ltsp.Text = tsp.ToString();
            }
            if (Convert.ToInt32(lh6bjk.Text) > Convert.ToInt32(lh6fb.Text))
            {
                bjkp = bjkp + 2;
                lbjkp.Text = bjkp.ToString();
            }
            else if (Convert.ToInt32(lh6bjk.Text) < Convert.ToInt32(lh6fb.Text))
            {
                fbp = fbp + 2;
                lfbp.Text = fbp.ToString();
            }
            else if (Convert.ToInt32(lh6bjk.Text) == Convert.ToInt32(lh6fb.Text))
            {
                bjkp = bjkp + 1;
                lbjkp.Text = bjkp.ToString();
                fbp = fbp + 1;
                lfbp.Text = fbp.ToString();
            }

        }

        private void btnhafta1_Click(object sender, EventArgs e)
        {
            btnhafta1.Enabled = false;
            int a = rastgele.Next(0, 5);
            int b = rastgele.Next(0, 5);
            int c = rastgele.Next(0, 5);
            int d = rastgele.Next(0, 5);
            lh1gs.Text = a.ToString();
            lh1fb.Text = b.ToString();
            lh1ts.Text = c.ToString();
            lh1bjk.Text = d.ToString();
            if (Convert.ToInt32(lh1gs.Text) > Convert.ToInt32(lh1fb.Text))
            {
                gsp = gsp + 2;
                lgsp.Text = gsp.ToString();
            }
            else if (Convert.ToInt32(lh1gs.Text) < Convert.ToInt32(lh1fb.Text))
            {
                fbp = fbp + 2;
                lfbp.Text = fbp.ToString();
            }
            else if (Convert.ToInt32(lh1gs.Text) == Convert.ToInt32(lh1fb.Text))
            {
                gsp = gsp + 1;
                lgsp.Text = gsp.ToString();
                fbp = fbp + 1;
                lfbp.Text = fbp.ToString();
            }
            if (Convert.ToInt32(lh1bjk.Text) > Convert.ToInt32(lh1ts.Text))
            {
                bjkp = bjkp + 2;
                lbjkp.Text = bjkp.ToString();
            }
            else if (Convert.ToInt32(lh1bjk.Text) < Convert.ToInt32(lh1ts.Text))
            {
                tsp = tsp + 2;
                ltsp.Text = tsp.ToString();
            }
            else if (Convert.ToInt32(lh1bjk.Text) == Convert.ToInt32(lh1ts.Text))
            {
                bjkp = bjkp + 1;
                lbjkp.Text = bjkp.ToString();
                tsp = tsp + 1;
                ltsp.Text = tsp.ToString();
            }

        }

        private void btnkontrol_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lgsp.Text) > Convert.ToInt32(lfbp.Text)&& Convert.ToInt32(lgsp.Text) > Convert.ToInt32(lbjkp.Text) && Convert.ToInt32(lgsp.Text) > Convert.ToInt32(ltsp.Text))
            {
                axWindowsMediaPlayer1.URL = "C:\\Users\\bekoo\\Desktop\\DERS\\C# Uygulama\\Türkiye Lig Şampiyon Belirleme\\müzik\\gs.mp3";
                MessageBox.Show(lgsp.Text +" "+ "puan ile bu sezonun Türkiye Şampiyonu Galatasaray");
            }
            if (Convert.ToInt32(lfbp.Text) > Convert.ToInt32(lgsp.Text) && Convert.ToInt32(lfbp.Text) > Convert.ToInt32(lbjkp.Text) && Convert.ToInt32(lfbp.Text) > Convert.ToInt32(ltsp.Text))
            {
                axWindowsMediaPlayer1.URL = "C:\\Users\\bekoo\\Desktop\\DERS\\C# Uygulama\\Türkiye Lig Şampiyon Belirleme\\müzik\\fb.mp3";
                MessageBox.Show(lfbp.Text + " " + "puan ile bu sezonun Türkiye Şampiyonu Fenerbahçe");
            }
            if (Convert.ToInt32(lbjkp.Text) > Convert.ToInt32(lfbp.Text) && Convert.ToInt32(lbjkp.Text) > Convert.ToInt32(lgsp.Text) && Convert.ToInt32(lbjkp.Text) > Convert.ToInt32(ltsp.Text))
            {
                axWindowsMediaPlayer1.URL = "C:\\Users\\bekoo\\Desktop\\DERS\\C# Uygulama\\Türkiye Lig Şampiyon Belirleme\\müzik\\bjk.mp3";
                MessageBox.Show(lbjkp.Text + " " + "puan ile bu sezonun Türkiye Şampiyonu Beşiktaş");
            }
            if (Convert.ToInt32(ltsp.Text) > Convert.ToInt32(lfbp.Text) && Convert.ToInt32(ltsp.Text) > Convert.ToInt32(lbjkp.Text) && Convert.ToInt32(ltsp.Text) > Convert.ToInt32(lgsp.Text))
            {
                axWindowsMediaPlayer1.URL = "C:\\Users\\bekoo\\Desktop\\DERS\\C# Uygulama\\Türkiye Lig Şampiyon Belirleme\\müzik\\ts.mp3";
                MessageBox.Show(ltsp.Text + " " + "puan ile bu sezonun Türkiye Şampiyonu Trabzonspor");
            }

        }
    }
}
