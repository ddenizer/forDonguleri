using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5eblunmeyeni
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int toplam = 0, secim = 0;
            int sayi1 = int.Parse(textBox1.Text);
            int sayi2 = int.Parse(textBox2.Text);

            for (int i = sayi1; i <= sayi2; i++)
            {
                if (i % 5 == 0 && i % 7 != 0)
                {
                    Sayilar.Items.Add(i.ToString());
                    secim++;
                    toplam += i;
                }
            }
            label7.Text = toplam.ToString();
            label9.Text = secim.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
