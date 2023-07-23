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
        char _islem;
        bool _ekranTemizlenecekMi;
        int _ilkSayi;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi == true)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi == true)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi == true)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "3";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            _islem = '*';
            _ekranTemizlenecekMi = true;
            _ilkSayi = Convert.ToInt32(ekranLabel.Text);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int ikinciSayi = Convert.ToInt32(ekranLabel.Text);
            int sonuc;

            switch (_islem)
            {
                case '+':
                    sonuc = _ilkSayi + ikinciSayi;
                    break;
                case '-':
                    sonuc = _ilkSayi - ikinciSayi;
                    break;
                case '*':
                    sonuc = _ilkSayi * ikinciSayi;
                    break;
                case '/':
                    sonuc= _ilkSayi/ ikinciSayi;
                    break;
                default:
                    sonuc = 0;
                    break;
            }
            ekranLabel.Text = Convert.ToString(sonuc);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi == true)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi == true)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "5";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi == true)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "6";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi == true)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi == true)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "8";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi == true)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "9";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi == true)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "0";
        }

        private void artiButton_Click(object sender, EventArgs e)
        {
            _islem = '+';
            _ekranTemizlenecekMi = true;
            _ilkSayi = Convert.ToInt32(ekranLabel.Text);
        }

        private void eksiButton_Click(object sender, EventArgs e)
        {
            _islem = '-';
            _ekranTemizlenecekMi = true;
            _ilkSayi = Convert.ToInt32(ekranLabel.Text);
        }

        private void boluButton_Click(object sender, EventArgs e)
        {
            _islem = '/';
            _ekranTemizlenecekMi = true;
            _ilkSayi = Convert.ToInt32(ekranLabel.Text);
        }

        private void temizleButton_Click(object sender, EventArgs e)
        {
            ekranLabel.Text = "0";
        }
    }
}
