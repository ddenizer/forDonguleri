using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MukemelSayi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = int.Parse(textBox1.Text);
            int toplam = 0, mukSayi;
            mukSayi = sayi * 2;
            for (int i = 1; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    toplam = toplam + i;
                }
            }
            if ((toplam * 2) == mukSayi)
            {
                label3.Text= "Mükemmel sayıdır.";
            }
            else
            {
                label3.Text = "Mükemmel sayı değildir.";
            }
        }
    }
}
