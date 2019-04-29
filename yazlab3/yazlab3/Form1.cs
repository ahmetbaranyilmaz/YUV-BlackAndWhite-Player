using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yazlab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int timerSecim = -1;
        private byte[] byteFile, rgb;
        private byte[] yDizi;
        private int byteSayisi;
        private int genislik, yukseklik, cozunurluk;
        private int cerceveSayisi=-1, cerceve = 0;
        private int ySayisi, uSayisi, vSayisi;
        Bitmap[] video;

        private bool yuvEnable()
        {
            int a = 0;
            if (!string.IsNullOrEmpty(genislikTxt.Text) && !string.IsNullOrEmpty(yukseklikTxt.Text) && formatTipi.SelectedIndex != -1)
            {
                return true;
            }
            return false;
        }

        private void genislikTxt_TextChanged(object sender, EventArgs e)
        {
            int parsedValue;
            if (!int.TryParse(genislikTxt.Text, out parsedValue))
            {
                MessageBox.Show("Bu alana sadece sayi yazin");
                genislikTxt.Clear();
                genislikTxt.Focus();
            }
            else
            {
                if (yuvEnable())
                {
                    dosyaSec.Enabled = true;
                }
            }
        }

        private void yukseklikTxt_TextChanged(object sender, EventArgs e)
        {
            int parsedValue;
            if (!int.TryParse(yukseklikTxt.Text, out parsedValue))
            {
                MessageBox.Show("Bu alana sadece sayi yazin");
                yukseklikTxt.Clear();
                yukseklikTxt.Focus();
            }
            else
            {
                if (yuvEnable())
                {
                    dosyaSec.Enabled = true;
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (yuvEnable())
            {
                dosyaSec.Enabled = true;
            }
        }

        private void dosyaSec_Click(object sender, EventArgs e)
        {
            if(timer1.Enabled)
            {
                timer1.Enabled = false;
            }

            yuvAl();
            
        }

        private void dosyaBasarili()
        {
            sabitDegerleriAta();
            islem(cmbIndex());
            donustur();
            label5.Text = "Toplam Cerceve Sayisi: " + cerceveSayisi.ToString();
            butonAktif();
        }

        private void butonAktif()
        {
            label5.Visible = true;
            oynat.Enabled = true;
            durdur.Enabled = true;
            kaydet.Enabled = true;
            sonsuzOynat.Enabled = true;
        }

        private void yuvAl()
        {
            openFileDialog1.Filter = "YUV Dosyalari (*.yuv)|*.yuv";
            openFileDialog1.Title = "YUV Dosyasi Seciniz.";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (cerceveSayisi != -1)
                {
                    cerceve = 0;
                }

                try
                {
                    byteFile = byteDonustur(openFileDialog1.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata " + ex);
                }

                dosyaBasarili();
            }
            else
            {
                if(cerceveSayisi!=-1 && !timer1.Enabled)
                {
                    timer1.Enabled = true;
                }
            }
        }

        private void sabitDegerleriAta()
        {
            genislik = Convert.ToInt32(genislikTxt.Text);
            yukseklik = Convert.ToInt32(yukseklikTxt.Text);
            cozunurluk = genislik * yukseklik;
            ySayisi = cozunurluk;
            yDizi = new byte[ySayisi];
            rgb = new byte[cozunurluk * 3];
            pictureBox1.Width = genislik;
            pictureBox1.Height = yukseklik;
        }

        private void islem(int index)
        {
            if(index == 0)
            {
                format444();
            }
            else if (index == 1)
            {
                format422();
            }
            else
            {
                format420();
            }
        }

        private int cmbIndex()
        {
            return formatTipi.SelectedIndex;
        }

        private void oynat_Click(object sender, EventArgs e)
        {
            timerSecim = 0;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {   
            if(timerSecim == 0)
            {
                if (cerceve == cerceveSayisi - 1)
                {
                    timer1.Enabled = false;
                }
                label4.Text = "Cerceve:" + (cerceve + 1);
                cerceveGoster(cerceve);
                cerceve++;
            }
            else
            {
                if(cerceve == cerceveSayisi)
                {
                    cerceve = 0;
                }
                label4.Text = "Cerceve:" + (cerceve + 1);
                cerceveGoster(cerceve);
                cerceve++;
            }
        }

        private void sonsuzOynat_Click(object sender, EventArgs e)
        {
            timerSecim = 1;
            timer1.Enabled = true;
        }

        private void cerceveGoster(int cerceve)
        {
            // cerceve cerceve oynatmak icin
            pictureBox1.Image = video[cerceve];
        }

        private void durdur_Click(object sender, EventArgs e)
        {
            // goruntu gecisini durdur
            timer1.Enabled = false;
        } 

        private void format444()
        {
            // 444 formatinin degerleri
            cerceveSayisi = byteFile.Length / (cozunurluk * 3);
            video = new Bitmap[cerceveSayisi];
            byteSayisi = ySayisi * 3;
            uSayisi = ySayisi;
            vSayisi = uSayisi;
        }

        private void format422()
        {
            // 422 formatinin degeleri
            cerceveSayisi = byteFile.Length / (cozunurluk * 2);
            video = new Bitmap[cerceveSayisi];
            byteSayisi = ySayisi * 2;
            uSayisi = ySayisi/2;
            vSayisi = uSayisi;    
        }

        private void format420()
        {
            // 420 formatinin degerleri
            cerceveSayisi = (byteFile.Length*2) / (cozunurluk * 3);
            video = new Bitmap[cerceveSayisi];
            byteSayisi = ySayisi * 3/2;
            uSayisi = ySayisi / 4;
            vSayisi = uSayisi;
        }

        private void donustur()
        {
            int i = 0;
            while (i < cerceveSayisi) // Her çerçeveye ayrı işlem yapmak için
            {
                int j = 0, index = 0, pixel = 0;
                while (pixel < ySayisi)
                {
                    yDizi[index++] = byteFile[i * byteSayisi + j]; // cerceve cerceve pixel dolasıp y degerleri alinir
                    j = j + 1;
                    pixel=pixel+1;
                }

                int rgbIndex = 0,sayac=0 , yIndex=0;
                while (rgbIndex < cozunurluk * 3)
                {
                    // 8 bit y degerleri 24 bit hale getirilir
                    if (sayac == 3)
                    {
                        yIndex=yIndex+1;
                        sayac = 0;
                    }
                    rgb[rgbIndex] = yDizi[yIndex];
                    sayac = sayac + 1;
                    rgbIndex = rgbIndex+1;
                }
                // Cerceveler olusturulur
                Bitmap cerceve = new Bitmap(genislik, yukseklik, PixelFormat.Format24bppRgb);
                BitmapData cerceveData = cerceve.LockBits(new Rectangle(0, 0, cerceve.Width, cerceve.Height), ImageLockMode.WriteOnly, cerceve.PixelFormat);
                Marshal.Copy(rgb, 0, cerceveData.Scan0, rgb.Length);
                cerceve.UnlockBits(cerceveData);

                video[i] = cerceve;

                i=i+1;
            }
            cerceveGoster(0);
            label4.Visible = true;
            label4.Text = "Cerceve:" + (cerceve + 1);
        }

        private byte[] byteDonustur(string dosyaAdi)
        {
            // Secilen .yuv dosyasını byte olarak okur
            return File.ReadAllBytes(dosyaAdi);
        }

        private void kaydet_Click(object sender, EventArgs e)
        {
            // Secilen klasöre cerceveleri kayıt etmek icin
            saveFileDialog1.Title = "Nereye Kaydedilsin?";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                for (int cerceve = 0; cerceve < cerceveSayisi; cerceve++)
                {
                    video[cerceve].Save(saveFileDialog1.FileName + "-" + (cerceve + 1) + " .bmp");

                }

                MessageBox.Show("Kayıt Bitti");
            }
        }
    }
}
