using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlisverisHesabi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked==true)
            {
                int adet = int.Parse(textBox1.Text);
                int fiyat = 20 * adet;
                label7.Text = fiyat.ToString();
                double toplam = (fiyat * 0.1) + fiyat;
                label5.Text = toplam.ToString();
            }
            else if (radioButton2.Checked == true)
            {
                int adet = int.Parse(textBox1.Text);
                int fiyat = 10 * adet;
                label7.Text = fiyat.ToString();
                double toplam = (fiyat * 0.5) + fiyat;
                label5.Text = toplam.ToString();
            }
            else
            {
                int adet = int.Parse(textBox1.Text);
                int fiyat = 40 * adet;
                label7.Text = fiyat.ToString();
                double toplam = (fiyat * 0.18) + fiyat;
                label5.Text = toplam.ToString();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            label8.Text = "% 1";
            comboBox1.Items.Add("Izgara Köfte");
            comboBox1.Items.Add("Izgara Tavuk");
            comboBox1.Items.Add("Hamburger");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            label8.Text = "% 5";
            comboBox1.Items.Add("Kola");
            comboBox1.Items.Add("Çay");
            comboBox1.Items.Add("Su");
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            label8.Text = "% 18";
            comboBox1.Items.Add("Kazak");
            comboBox1.Items.Add("Pantolon");
            comboBox1.Items.Add("Elbise");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label7.Text = "00";
            label8.Text = "00";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
