namespace HESAPM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string _islem;
        private bool _ekranTemizlenecekMi = true;
        private int _ilkSayi;
        private double doubleIlkSayi;



        private void button1_Click(object sender, EventArgs e)
        {

            if (label1.Text == "0")
            {
                label1.Text = " ";
            }
            int sayi1 = 1;
            label1.Text += sayi1.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = " ";
            }
            int sayi2 = 2;
            label1.Text = label1.Text + sayi2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = " ";
            }
            int sayi3 = 3;
            label1.Text += sayi3.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = " ";
            }
            int sayi4 = 4;
            label1.Text += sayi4.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = " ";
            }
            int sayi5 = 5;
            label1.Text += sayi5.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = " ";
            }
            int sayi6 = 6;
            label1.Text += sayi6.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = " ";
            }
            int sayi7 = 7;
            label1.Text += sayi7.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = " ";
            }
            int sayi8 = 8;
            label1.Text += sayi8.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = " ";
            }
            int sayi9 = 9;
            label1.Text += sayi9.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = " ";
            }
            int sayi0 = 0;
            label1.Text += sayi0.ToString();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            _islem = "+";
            _ilkSayi = Convert.ToInt16(label1.Text);
            if (_ekranTemizlenecekMi == true)
            {
                label1.Text = "";

            }


        }

        private void button10_Click(object sender, EventArgs e)
        {
            double ikinciSayi = Convert.ToInt16(label1.Text);

            if (_islem == "+")
            {
                label1.Text = (_ilkSayi + ikinciSayi).ToString();
            }
            else if (_islem == "-")
            {
                label1.Text = (_ilkSayi - ikinciSayi).ToString();
            }
            else if (_islem == "*")
            {
                label1.Text = (_ilkSayi * ikinciSayi).ToString();
            }
            else if (_islem == "/")
            {
                label1.Text = ( doubleIlkSayi / ikinciSayi).ToString();
            }

        }

        private void button15_Click(object sender, EventArgs e)
        {
            _islem = "-";
            _ilkSayi = Convert.ToInt16(label1.Text);

            if (_ekranTemizlenecekMi == true)
            {
                label1.Text = "";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            _islem = "*";
            _ilkSayi = Convert.ToInt16(label1.Text);

            if (_ekranTemizlenecekMi == true)
            {
                label1.Text = "";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            _islem = "/";
            doubleIlkSayi = Convert.ToInt16(label1.Text);

            if (_ekranTemizlenecekMi == true)
            {
                label1.Text = "";
            }
        }
    }
}
