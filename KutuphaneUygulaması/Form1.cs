using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneUygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (comboBox1.Text)
            {
                case "Suç ve Ceza":
                    {
                        label4.Text = "25";
                        break;
                    }
                case "Sefiller":
                    {
                        label4.Text = "30";
                        break;
                    }
                case "Oblomov":
                    {
                        label4.Text = "22";
                        break;
                    }
                case "Karamazov Kardeşler":
                    {
                        label4.Text = "23";
                        break;
                    }
                case "Ezilenler":
                    {
                        label4.Text = "15";
                        break;
                    }
                case "Savaş ve Barış":
                    {
                        label4.Text = "32";
                        break;
                    }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Suç ve Ceza");
            comboBox1.Items.Add("Sefiller");
            comboBox1.Items.Add("Oblomov");
            comboBox1.Items.Add("Karamazov Kardeşler");
            comboBox1.Items.Add("Ezilenler");
            comboBox1.Items.Add("Savaş ve Barış");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Sepet.Items.Add(label4.Text);
            listBox1.Items.Add(comboBox1.Text);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sepet.Items.Clear();
            listBox1.Items.Clear();
            comboBox1.Text = "";
            label8.Text = "00";
            label4.Text = "00";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double toplam = 0, indirimliToplam = 0;
            
            if (radioButton1.Checked==true)
            {
                for (int i = 0; i < Sepet.Items.Count; i++)
                {
                    toplam += Convert.ToDouble(Sepet.Items[i]);
                }
                indirimliToplam = toplam - ((toplam * 15) / 100);
                label8.Text= indirimliToplam.ToString();
            }
            else if (radioButton3.Checked==true)
            {
                for (int i = 0; i < Sepet.Items.Count; i++)
                {
                    toplam += Convert.ToDouble(Sepet.Items[i]);
                }
                indirimliToplam = toplam - ((toplam * 20) / 100);
                label8.Text = indirimliToplam.ToString();
            }
            else
            {
                for (int i = 0; i < Sepet.Items.Count; i++)
                {
                    toplam += Convert.ToDouble(Sepet.Items[i]);
                }
                label8.Text = toplam.ToString();
            }

        }
    }
}
