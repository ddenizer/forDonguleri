using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayisalLoto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        int[] loto = new int[6];
        int[] lotoSonuc = new int[6];
        Random rastegele = new Random();
        int sayi1, sayi2, sayi3, sayi4, sayi5, sayi6, j = 0, k = 0;
        int dogru = 0;

        private void button3_Click(object sender, EventArgs e)
        {
            if (loto[0] == lotoSonuc[0])
            {
                label10.Text = loto[0].ToString();
                dogru++;
            }
            if (loto[1] == lotoSonuc[1])
            {
                label11.Text = loto[1].ToString();
                dogru++;
            }
            if (loto[2] == lotoSonuc[2])
            {
                label12.Text = loto[2].ToString();
                dogru++;
            }
            if (loto[3] == lotoSonuc[3])
            {
                label13.Text = loto[3].ToString();
                dogru++;
            }
            if (loto[4] == lotoSonuc[4])
            {
                label14.Text = loto[4].ToString();
                dogru++;
            }
            if (loto[5] == lotoSonuc[5])
            {
                label15.Text = loto[5].ToString();
                dogru++;
            }
            label17.Text = dogru + " sayı tutturdunuz";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lotoSonuc.Length; i++)
            {
                lotoSonuc[k] = rastegele.Next(1, 50);
                k++;
            }
            foreach (int i in lotoSonuc)
            {
                listBox1.Items.Add(i);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sayi1 = int.Parse(textBox1.Text);
            sayi2 = int.Parse(textBox2.Text);
            sayi3 = int.Parse(textBox3.Text);
            sayi4 = int.Parse(textBox4.Text);
            sayi5 = int.Parse(textBox5.Text);
            sayi6 = int.Parse(textBox6.Text);

            loto[0] = sayi1;
            loto[1] = sayi2;
            loto[2] = sayi3;
            loto[3] = sayi4;
            loto[4] = sayi5;
            loto[5] = sayi6;

            string sayii = "aa";
            for (int i = 0; i < loto.Length; i++)
            {
                if (loto[i] > 50 && loto[i] < 0)
                {
                    label10.Text = "Lütfen 0 ile 50 arasında sayı girin.";
                }

                listBox2.Items.Add(loto[j]);
                j++;
            }


        }
    }
}
