using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hesapMakinesi2
{
    public partial class Form1 : Form

    {
        int _ilksayi;
        int sonuc;
        char _islem;
        bool _ekrantemizlencekmi ;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlencekmi)
            {
                ekranlabel.Text = "";
                _ekrantemizlencekmi = false;
            }



            if (ekranlabel.Text == "0")
            {
                ekranlabel.Text = "";
            }
            ekranlabel.Text += "1";


           


        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (_ekrantemizlencekmi)
            {
                ekranlabel.Text = "";

                _ekrantemizlencekmi = false;
            }
            if (ekranlabel.Text == "0")
            {
                ekranlabel.Text = "";
            }
            ekranlabel.Text += "2";

           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlencekmi)
            {
                ekranlabel.Text = "";
                _ekrantemizlencekmi = false;
            }
            if (ekranlabel.Text == "0")
            {
                ekranlabel.Text = "";
            }
            ekranlabel.Text += "3";

           
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlencekmi)
            {
                ekranlabel.Text = "";
                _ekrantemizlencekmi = false;
            }
            if (ekranlabel.Text == "0")
            {
                ekranlabel.Text = "";
            }
            ekranlabel.Text += "4";

            
        }

        private void button7_Click(object sender, EventArgs e)
        {

            if (_ekrantemizlencekmi)
            {
                ekranlabel.Text = "";
                _ekrantemizlencekmi = false;
            }
            if (ekranlabel.Text == "0")
            {
                ekranlabel.Text = "";
            }
            ekranlabel.Text += "5";

            
        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (_ekrantemizlencekmi)
            {
                ekranlabel.Text = "";
                _ekrantemizlencekmi = false;
            }
            if (ekranlabel.Text == "0")
            {
                ekranlabel.Text = "";
            }
            ekranlabel.Text += "6";

           
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlencekmi)
            {
                ekranlabel.Text = "";
                _ekrantemizlencekmi = false;
            }
            if (ekranlabel.Text == "0")
            {
                ekranlabel.Text = "";
            }
            ekranlabel.Text += "7";

           
        }

        private void button11_Click(object sender, EventArgs e)
        {

            if (_ekrantemizlencekmi)
            {
                ekranlabel.Text = "";
                _ekrantemizlencekmi = false;
            }
            if (ekranlabel.Text == "0")
            {
                ekranlabel.Text = "";
            }
            ekranlabel.Text += "8";

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlencekmi)
            {
                ekranlabel.Text = "";
                _ekrantemizlencekmi = false;
            }
            if (ekranlabel.Text == "0")
            {
                ekranlabel.Text = "";
            }
            ekranlabel.Text += "9";

           
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlencekmi)
            {
                ekranlabel.Text = "";
                _ekrantemizlencekmi = false;
            }
            if (ekranlabel.Text == "0")
            {
                ekranlabel.Text = "";
            }
            ekranlabel.Text += "0";

          
        }

        private void button16_Click(object sender, EventArgs e)
        {
            ekranlabel.Text = "";
         
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _islem = '+';
            _ekrantemizlencekmi = true;
            _ilksayi = Convert.ToInt32(ekranlabel.Text);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            _islem = '-';
            _ekrantemizlencekmi = true;
            _ilksayi = Convert.ToInt32(ekranlabel.Text);

        }

        private void button9_Click(object sender, EventArgs e)
        {
            _islem = '*';
            _ekrantemizlencekmi = true;
            _ilksayi = Convert.ToInt32(ekranlabel.Text);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            _islem = '/';
            _ekrantemizlencekmi = true;
            _ilksayi = Convert.ToInt32(ekranlabel.Text);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            int _ikincisayi = Convert.ToInt32(ekranlabel.Text);
            
           switch (_islem)
            {

                case '+':
                    sonuc = _ilksayi + _ikincisayi;
                    break;

                case '-':
                    sonuc = _ilksayi - _ikincisayi;
                    break;

                case '*':
                    sonuc = _ilksayi * _ikincisayi;
                    break;

                case '/':
                    if (_ikincisayi == )
                    {
                       
                        ekranlabel.Text = ("Hata");
                        break;
                        
                    }
                    else
                    {
                        sonuc = _ilksayi / _ikincisayi;
                        break;
                    }
                    
            }
            

            ekranlabel.Text = Convert.ToString(sonuc);
        }
    }
}
