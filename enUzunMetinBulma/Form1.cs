using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace enUzunMetinBulma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] metin = new string[6];
        int sayac = 0, index = 0, uzunluk = 0;
        string enuzunmetin = "", enuzunmetinler = "";
        private void button1_Click(object sender, EventArgs e)
        {
            string enuzunmetin = textBox1.Text;

            listBox1.Items.Add(enuzunmetin);

            if (listBox1.Items.Count==6)
            {
                button1.Enabled = false;
            }
            metin[sayac] = enuzunmetin;
            sayac++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < metin.Length; i++)
            {
                listBox2.Items.Add(metin[i]);
            }

            int sayac2 = 0;
            for (int j = 0; j < 6; j++)
            {
                if (metin[j].Length > uzunluk)
                {
                    uzunluk = metin[j].Length;
                    enuzunmetin = metin[j];
                    index = j;
                }
            }
            for (int k = 0; k < 6; k++)
            {
                if (metin[index].Length == metin[k].Length)
                {
                    enuzunmetinler = enuzunmetinler + metin[k] + ",";
                    sayac2++;
                }
            }

            if (sayac2 > 1)
            {
                label6.Text = enuzunmetinler;
            }
            else
            {
                label6.Text=(enuzunmetinler.Substring(0, (enuzunmetinler.Length) - 1)).ToString();
            }

            label7.Text = index.ToString();
            label8.Text = uzunluk.ToString();
        }
    }
}
