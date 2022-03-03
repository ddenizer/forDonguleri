using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carkıfelek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] dizi1 = new int[10];
        char[] harf = new char[10];
        int kalanTahminSayisi = 9;
        int index = 0;
        Random rastgele = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            char girilenHarf = Convert.ToChar(textBox1.Text);
            listBox1.Items.Add(girilenHarf);
            if (listBox1.Items.Count == 10)
            {
                button1.Enabled = false;
                MessageBox.Show("Tahmin hakkınız bitti");
            }
            label9.Text = kalanTahminSayisi + " hakkınız kaldı.";
            kalanTahminSayisi--;

            foreach (char c in harf)
            {
                if (girilenHarf == c)
                {
                    if (girilenHarf == harf[0])
                    {
                        label1.Text = girilenHarf.ToString();
                    }
                    else if (girilenHarf == harf[1])
                    {
                        label2.Text = girilenHarf.ToString();
                    }
                    else if (girilenHarf == harf[2])
                    {
                        label3.Text = girilenHarf.ToString();
                    }
                    else if (girilenHarf == harf[3])
                    {
                        label4.Text = girilenHarf.ToString();
                    }
                    else if (girilenHarf == harf[4])
                    {
                        label5.Text = girilenHarf.ToString();
                    }
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < dizi1.Length; i++)
            {
                dizi1[i] = rastgele.Next(65, 91);
            }
            foreach (int j in dizi1)
            {
                harf[index] = (char)j;
                index++;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            char ipucu = harf[0];
            char ipucu1 = harf[1];
            char ipucu2 = harf[2];
            char ipucu3 = harf[3];
            char ipucu4 = harf[4];

            if (label1.Text == "_")
            {
                label1.Text = ipucu.ToString();
            }
            else if (label2.Text == "_")
            {
                label2.Text = ipucu1.ToString();
            }
            else if (label3.Text == "_")
            {
                label3.Text = ipucu2.ToString();
            }
            else if (label4.Text == "_")
            {
                label4.Text = ipucu3.ToString();
            }
            else if (label5.Text == "_")
            {
                label5.Text = ipucu4.ToString();
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            char ipucu = harf[0];
            char ipucu1 = harf[1];
            char ipucu2 = harf[2];
            char ipucu3 = harf[3];
            char ipucu4 = harf[4];

            if (label2.Text == "_")
            {
                label3.Text = ipucu.ToString();
            }
            if (label4.Text == "_")
            {
                label4.Text = ipucu1.ToString();
            }
            if (label1.Text == "_")
            {
                label1.Text = ipucu2.ToString();
            }
            if (label5.Text == "_")
            {
                label5.Text = ipucu3.ToString();
            }
            if (label2.Text == "_")
            {
                label2.Text = ipucu4.ToString();
            }
        }
    }
}
