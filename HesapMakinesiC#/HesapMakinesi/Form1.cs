using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {

      private char _islem;// _ değişkenin her yerde geçerli oldugunu belirtir.
      private bool _ekranTemilenecekMi; //ekran temizleme sorgusu
      private int _ilkSayi;  
        public Form1()
        {
            InitializeComponent();
        }

        private void SAYI1Buton_Click(object sender, EventArgs e)
        {
            if (_ekranTemilenecekMi)
            {
                EkranLabel.Text = "";
                _ekranTemilenecekMi = false;
            }
            if (EkranLabel.Text == "0") EkranLabel.Text = ""; //ekranda 0 duruyorsa onu sil
            EkranLabel.Text += "1"; 

        }

        private void SAYI2Buton_Click(object sender, EventArgs e)
        {
            if (_ekranTemilenecekMi)
            {
                EkranLabel.Text = "";
                _ekranTemilenecekMi = false;
            }
            if (EkranLabel.Text == "0") EkranLabel.Text = "";
            EkranLabel.Text += "2";
        }

        private void SAYI3Buton_Click(object sender, EventArgs e)
        {
            if (_ekranTemilenecekMi)
            {
                EkranLabel.Text = "";
                _ekranTemilenecekMi = false;
            }
            if (EkranLabel.Text == "0") EkranLabel.Text = "";
            EkranLabel.Text += "3";
        }

        private void SAYI4Buton_Click(object sender, EventArgs e)
        {
            if (_ekranTemilenecekMi)
            {
                EkranLabel.Text = "";
                _ekranTemilenecekMi = false;
            }
            if (EkranLabel.Text == "0") EkranLabel.Text = "";
            EkranLabel.Text += "4";
        }

        private void SAYI5Buton_Click(object sender, EventArgs e)
        {
            if (_ekranTemilenecekMi)
            {
                EkranLabel.Text = "";
                _ekranTemilenecekMi = false;
            }
            if (EkranLabel.Text == "0") EkranLabel.Text = "";
            EkranLabel.Text += "5";
        }

        private void SAYI6Buton_Click(object sender, EventArgs e)
        {
            if (_ekranTemilenecekMi)
            {
                EkranLabel.Text = "";
                _ekranTemilenecekMi = false;
            }
            if (EkranLabel.Text == "0") EkranLabel.Text = "";
            EkranLabel.Text += "6";
        }

        private void SAYI7Buton_Click(object sender, EventArgs e)
        {
            if (_ekranTemilenecekMi)
            {
                EkranLabel.Text = "";
                _ekranTemilenecekMi = false;
            }
            if (EkranLabel.Text == "0") EkranLabel.Text = "";
            EkranLabel.Text += "7";
        }

        private void SAYI8Buton_Click(object sender, EventArgs e)
        {
            if (_ekranTemilenecekMi)
            {
                EkranLabel.Text = "";
                _ekranTemilenecekMi = false;
            }
            if (EkranLabel.Text == "0") EkranLabel.Text = "";
            EkranLabel.Text += "8";
        }

        private void SAYI9Buton_Click(object sender, EventArgs e)
        {
            if (_ekranTemilenecekMi)
            {
                EkranLabel.Text = "";
                _ekranTemilenecekMi = false;
            }
            if (EkranLabel.Text == "0") EkranLabel.Text = "";
            EkranLabel.Text += "9";
        }

        private void SAYI0Buton_Click(object sender, EventArgs e)
        {
            if (_ekranTemilenecekMi)
            {
                EkranLabel.Text = "";
                _ekranTemilenecekMi = false;
            }
            if (EkranLabel.Text == "0") EkranLabel.Text = "";
            EkranLabel.Text += "0"; 
        }

        private void TOPLAMAButon_Click(object sender, EventArgs e)
        {
            TOPLAMAButon.Enabled = false; // Butonu devre dışı bırak

            TOPLAMAButon.Enabled = true; // İşlem tamamlandığında butonu etkinleştir
            _islem = '+';
            _ekranTemilenecekMi = true;
            _ilkSayi =Convert.ToInt32(EkranLabel.Text); //koyduğumuz + ifadesini sayısal bir değer için kullanacak.
            //sadece +'ya basıldığı zaman ekranı temizleyecek. 
            //Butonlara tek tek ekledik sayılara bastıgımızda silme fakat + butonuna basıldıgında sil.
            
         
        }

         private void ÇIKARMAButon_Click(object sender, EventArgs e)
        {
            ÇIKARMAButon.Enabled = false; 

            ÇIKARMAButon.Enabled = true;
            _islem = '-';
            _ekranTemilenecekMi = true;
            _ilkSayi = Convert.ToInt32(EkranLabel.Text);

        }

        private void ÇARPMAButon_Click(object sender, EventArgs e)
        {
            ÇARPMAButon.Enabled = false;

            ÇARPMAButon.Enabled = true;
            _islem = '*';
            _ekranTemilenecekMi = true;
            _ilkSayi = Convert.ToInt32(EkranLabel.Text);
        }

        private void BÖLMEButon_Click(object sender, EventArgs e)
        {
            BÖLMEButon.Enabled = false;

            BÖLMEButon.Enabled = true;
            _islem = '/';
            _ekranTemilenecekMi = true;
            _ilkSayi = Convert.ToInt32(EkranLabel.Text);
        }

        private void EŞİTTİRButon_Click(object sender, EventArgs e)
        {
            int ikincisayi = Convert.ToInt32(EkranLabel.Text);
            int sonuc;
            EŞİTTİRButon.Enabled = false;

            EŞİTTİRButon.Enabled = true;

            switch (_islem)
            {
            
                case '+':
                    sonuc = _ilkSayi + ikincisayi;
                    break;
                case '-':
                    sonuc = _ilkSayi - ikincisayi;
                    break;
                case '/':
                    sonuc = _ilkSayi / ikincisayi;
                    break;
                case '*':
                    sonuc = _ilkSayi * ikincisayi;
                    break;
                    default:
                    sonuc=0;
                    break;
            }
          EkranLabel.Text = Convert.ToString(sonuc); //Sonuç değer almazsa değersiz kalacagını söylüyor.
          //Default kullanarak if else yapısı gibi yukarıdaki şartlar sağlanmazsa sonucun sıfır olarak gözüktürebiliriz.


        }

        private void CsilmeButon_Click(object sender, EventArgs e)
        {
            EkranLabel.Text = "";

        }

        
    }

}
