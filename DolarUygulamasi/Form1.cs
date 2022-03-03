using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DolarUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string gun;
        double kur;
        string[] gunler = new string[7];
        double[] dolar = new double[7];
        int sayac = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            gun = textBox1.Text;
            kur = double.Parse(textBox2.Text);
            Dizi1.Items.Add(gun + " " + kur);
            if (Dizi1.Items.Count == 7)
            {
                button1.Enabled = false;
            }
            dolar[sayac] = kur;
            gunler[sayac] = gun;
            sayac++;
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double enBuyuk = 0;
            int gunB = 0;
            for (int i = 0; i < dolar.Length; i++)
            {
                if (dolar[i] > enBuyuk)
                {
                    enBuyuk = dolar[i];
                    gunB=i;
                }
            }
            label6.Text = enBuyuk.ToString();
            label8.Text = gunler[gunB];

            double enKucuk = enBuyuk;
            int gunK = 0;

            for (int i = 0; i < dolar.Length; i++)
            {
                if (dolar[i] < enKucuk)
                {
                    enKucuk = dolar[i];
                    gunK = i;
                }

            }
            label5.Text = enKucuk.ToString();
            label10.Text = gunler[gunK];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dolar.Length; i++)
            {
                listBox1.Items.Add(dolar[i]);
            }
            for (int i = 0; i < gunler.Length; i++)
            {
                listBox2.Items.Add(gunler[i]);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
