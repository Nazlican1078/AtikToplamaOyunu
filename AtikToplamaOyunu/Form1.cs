using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace AtikToplamaOyunu
{
   
    public partial class Form1 : Form
    {
        ArrayList images = new ArrayList();
       

        public int saniye = 60;
        public int puan;
        public Form1()
        {
            InitializeComponent();
        }      
        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;       
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye--;
            time.Text = Convert.ToString(saniye) + " SN";
            if (saniye==0)
            {
                timer1.Stop();
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = true;

                organiklistBox1.Items.Clear();
                kagitlistBox2.Items.Clear();
                camlistBox3.Items.Clear();
                metallistBox4.Items.Clear();

                progressBar1.Value = 0;
                progressBar2.Value = 0;
                progressBar3.Value = 0;
                progressBar4.Value = 0;               
            }         
        }

        private void time_Click(object sender, EventArgs e)
        {
           
        }

        public void button9_Click(object sender, EventArgs e)//YENİ OYUN BUTONU
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;

            organiklistBox1.Items.Clear();
            kagitlistBox2.Items.Clear();
            camlistBox3.Items.Clear();
            metallistBox4.Items.Clear();

            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer1.Start();
            button9.Enabled = false;

            progressBar1.Value = 0;
            progressBar2.Value = 0;
            progressBar3.Value = 0;
            progressBar4.Value = 0;
            Random r = new Random();
            string rastgele;
            images.Add(@"camsise.jpg");
            images.Add(@"bardak.jpg");
            images.Add(@"gazete.jpg");
            images.Add(@"dergi.jpg");
            images.Add(@"domates.jpg");
            images.Add(@"salatalik.jpg");
            images.Add(@"kolakutusu.jpg");
            images.Add(@"salcakutusu.jpg");
            pictureBox1.ImageLocation = (string)images[r.Next(0, 8)];
        }

        private void button1_Click(object sender, EventArgs e)//ORGANİK ATIK KUTUSU
        {
            button3.Enabled = false;
            int Opuan, Opuan2;
            Image resimler = new Image();
            KutuKapasite kapasiteler = new KutuKapasite();
           
            Random r = new Random();
            if (pictureBox1.ImageLocation == images[4])
            {
                resimler.domates = "Domates";
                resimler.Hacim = 150;
                organiklistBox1.Items.Add(resimler.domates + "(" + resimler.Hacim + ")");
                pictureBox1.ImageLocation = (string)images[r.Next(0, 8)];
                Opuan = resimler.Hacim;
                puan = puan + Opuan;
                button12.Text = Convert.ToString(puan);
          
                progressBar1.Minimum = 0;
                progressBar1.Maximum = 750;
                progressBar1.Value = progressBar1.Value + resimler.Hacim;
            

            }
            if(pictureBox1.ImageLocation == images[5])
            {
                resimler.salatalik = "Salatalik";
                resimler.Hacim = 120;
                organiklistBox1.Items.Add(resimler.salatalik + "(" + resimler.Hacim + ")");
                pictureBox1.ImageLocation = (string)images[r.Next(0, 8)];
                Opuan2 = resimler.Hacim;
                puan = puan + Opuan2;
                button12.Text = Convert.ToString(puan);

                progressBar1.Minimum = 0;
                progressBar1.Maximum = 800;
                progressBar1.Value = progressBar1.Value + resimler.Hacim;
            }
            if(progressBar1.Value>=(kapasiteler.OrganikKutuKapasite * 75)/100)
            {
                progressBar1.Enabled = false;
                button3.Enabled = true;
                button1.Enabled = false;
            }
            

        }
        private void button5_Click(object sender, EventArgs e) //CAM ATIK KUTUSU BUTONU
        {
               button7.Enabled = false;
               int Cpuan1, Cpuan2;
               Image resimler1 = new Image();
               KutuKapasite kapasiteler = new KutuKapasite();
               Random r = new Random();
            if (pictureBox1.ImageLocation == images[0])
            {
               
                resimler1.camsise = "Cam Şişe";
                resimler1.Hacim = 600;
                camlistBox3.Items.Add(resimler1.camsise + "(" + resimler1.Hacim + ")");
                pictureBox1.ImageLocation = (string)images[r.Next(0, 8)];
                Cpuan1 = resimler1.Hacim;
                puan = puan + Cpuan1;
                button12.Text = Convert.ToString(puan);
                progressBar3.Minimum = 0;
                progressBar3.Maximum = 3000;
                progressBar3.Value = progressBar3.Value + resimler1.Hacim;

            }
            if(pictureBox1.ImageLocation == images[1])
            {
                resimler1.bardak = "Bardak";
                resimler1.Hacim = 250;
                camlistBox3.Items.Add(resimler1.bardak + "(" + resimler1.Hacim + ")");
                pictureBox1.ImageLocation = (string)images[r.Next(0, 8)];
                Cpuan2 = resimler1.Hacim;
                puan = puan + Cpuan2;
                button12.Text = Convert.ToString(puan);
                progressBar3.Minimum = 0;
                progressBar3.Maximum = 3000;
                progressBar3.Value = progressBar3.Value + resimler1.Hacim;
            }
            if (progressBar3.Value >= (kapasiteler.CamKutuKapasite * 75)/100)
            {

                progressBar3.Enabled = false;
                button7.Enabled = true;
                button5.Enabled = false;
            }

        }
        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)//KAĞIT ATIK KUTUSU
        {
            KutuKapasite kapasiteler = new KutuKapasite();
            button4.Enabled = false;
            int Kpuan1, Kpuan2;
            Image resimler2 = new Image();
            Random r = new Random();
            if (pictureBox1.ImageLocation == images[2])
            {
                resimler2.gazete = "Gazete";
                resimler2.Hacim = 250;
                kagitlistBox2.Items.Add(resimler2.gazete + "(" + resimler2.Hacim + ")");    
                pictureBox1.ImageLocation = (string)images[r.Next(0, 8)];
                Kpuan1 = resimler2.Hacim;
                puan = puan + Kpuan1;
                button12.Text = Convert.ToString(puan);
                progressBar2.Minimum = 0;
                progressBar2.Maximum = 1500;
                progressBar2.Value = progressBar2.Value + resimler2.Hacim;

            }
            if(pictureBox1.ImageLocation == images[3])
            {
                resimler2.dergi = "Dergi";
                resimler2.Hacim = 200;
                kagitlistBox2.Items.Add(resimler2.dergi + "(" + resimler2.Hacim + ")");
                pictureBox1.ImageLocation = (string)images[r.Next(0, 8)];
                Kpuan2 = resimler2.Hacim;
                puan = puan + Kpuan2;
                button12.Text = Convert.ToString(puan);
                progressBar2.Minimum = 0;
                progressBar2.Maximum = 1500;
                progressBar2.Value = progressBar2.Value + resimler2.Hacim;
            }
               if(progressBar2.Value>=(kapasiteler.KagitKutuKapasite * 75)/100)
            {
                progressBar2.Enabled = false;
                button4.Enabled = true;
                button2.Enabled = false;
            }  
         }

        private void button6_Click(object sender, EventArgs e)//METAL ATIK KUTUSU
        {
            button8.Enabled = false;
            int Mpuan1, Mpuan2;
            KutuKapasite kapasiteler = new KutuKapasite();
            Image resimler3 = new Image();
            Random r = new Random();
            if (pictureBox1.ImageLocation == images[6])
            {
                resimler3.kolakutusu = "Kola Kutusu";
                resimler3.Hacim = 350;
                metallistBox4.Items.Add(resimler3.kolakutusu + "(" + resimler3.Hacim + ")");
                pictureBox1.ImageLocation = (string)images[r.Next(0, 8)];
                Mpuan1 = resimler3.Hacim;
                puan = puan + Mpuan1;
                button12.Text = Convert.ToString(puan);

                progressBar4.Minimum = 0;
                progressBar4.Maximum = 2350;
                progressBar4.Value = progressBar4.Value + resimler3.Hacim;
            }
            if (pictureBox1.ImageLocation == images[7])
            {
                resimler3.salcakutusu = "Salça Kutusu";
                resimler3.Hacim = 550;
                metallistBox4.Items.Add(resimler3.salcakutusu + "(" + resimler3.Hacim + ")");
                pictureBox1.ImageLocation = (string)images[r.Next(0, 8)];
                Mpuan2 = resimler3.Hacim;
                puan = puan + Mpuan2;
                button12.Text = Convert.ToString(puan);
                progressBar4.Minimum = 0;
                progressBar4.Maximum = 2350;
                progressBar4.Value = progressBar4.Value + resimler3.Hacim;
            }
            if(progressBar4.Value>=(kapasiteler.MetalKutuKapasite * 75)/100)
            {
                progressBar4.Enabled = false;
                button8.Enabled = true;
                button6.Enabled = false;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
           
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            organiklistBox1.Items.Clear();
            button1.Enabled = true;
            progressBar1.Enabled = true;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 1000;
            progressBar1.Value = 0;

            saniye = saniye + 3;
            time.Text = Convert.ToString(saniye) + " SN";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            kagitlistBox2.Items.Clear();
            button2.Enabled = true;
            progressBar2.Enabled = true;
            progressBar2.Minimum = 0;
            progressBar2.Maximum = 2000;
            progressBar2.Value = 0;
            saniye = saniye + 3;
            time.Text = Convert.ToString(saniye) + " SN";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            camlistBox3.Items.Clear();
            button5.Enabled = true;
            progressBar3.Enabled = true;
            progressBar3.Minimum = 0;
            progressBar3.Maximum = 3000;
            progressBar3.Value = 0;
            saniye = saniye + 3;
            time.Text = Convert.ToString(saniye) + " SN";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            metallistBox4.Items.Clear();
            button6.Enabled = true;
            progressBar4.Enabled = true;
            progressBar4.Minimum = 0;
            progressBar4.Maximum = 2500;
            progressBar4.Value = 0;
            saniye = saniye + 3;
            time.Text = Convert.ToString(saniye) + " SN";
        }

    }

    public interface IAtik
    {
        int Hacim { get; }
        System.Drawing.Image Image { get; }
    }

    public interface IDolabilen
    {
        int Kapasite { get; set; }
        int DoluHacim { get; set; }
        int DolulukOrani { get; }
    }
    public class KutuKapasite : IDolabilen
    {
        public int Dhacim;
        public int kapasite;
        public int Dorani;
        public int OrganikKutuKapasite = 700, KagitKutuKapasite=1200, CamKutuKapasite=2200, MetalKutuKapasite=2300;
        public int DoluHacim
        {
            
            get { return Dhacim; }
            set { Dhacim = value; }         
        }
        public int DolulukOrani
        {
            get { return Dorani; }
            
        }
        public int Kapasite
        {
            get { return kapasite; }
            set { kapasite = value; }
            
        }
    }
    public interface IAtikKutusu : IDolabilen
    {
        int BosaltmaPuani { get; }
        bool Ekle();
        bool Bosalt();
    }

    public class Image : IAtik
    {
        private int AtikHacim;
        System.Drawing.Image AtikImage;
        public string camsise, bardak, gazete, dergi,domates,salatalik,kolakutusu,salcakutusu;
        public int Hacim
        {
            get { return AtikHacim; }
            set { AtikHacim = value; }
        }
        System.Drawing.Image IAtik.Image
        {
           get { return AtikImage; }
          
        }  
    }
}


