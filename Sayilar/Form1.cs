using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayilar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] dizi = new int[10];
        int sayi;
        private void button1_Click(object sender, EventArgs e)
        {
            sayi = int.Parse(textBox1.Text);
            Dizi1.Items.Add(sayi);
            if (Dizi1.Items.Count == 10)
            {
                button1.Visible = false;
                for (int i = 0; i < Dizi1.Items.Count; i++)
                {
                    dizi[i] = Convert.ToInt32(Dizi1.Items[i]);
                }
            }
            textBox1.Text = "";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                foreach (int i in dizi)
                {
                    if (i % 3 == 0 && i != 0) 
                    {
                        Secimler.Items.Add(i);
                    }
                }
            }
            else if (radioButton2.Checked == true)
            {
                foreach (int i in dizi)
                {
                    if (i % 5 == 0 && i != 0) 
                    {
                        Secimler.Items.Add(i);
                    }
                }
            }
            else if (radioButton3.Checked == true)
            {
                foreach (int i in dizi)
                {
                    if (i == 0 )
                    {
                        Secimler.Items.Add(i);
                    }
                }
            }
            else if (radioButton4.Checked == true)
            {
                foreach (int i in dizi)
                {
                    if (i < 0 && i != 0) 
                    {
                        Secimler.Items.Add(i);
                    }
                }
            }
            else if (radioButton5.Checked == true)
            {
                foreach (int i in dizi)
                {
                    if (i > 0 && i != 0) 
                    {
                        Secimler.Items.Add(i);
                    }
                }
            }
            else if (radioButton6.Checked == true)
            {
                foreach (int i in dizi)
                {
                    if (i % 2 == 0 && i != 0) 
                    {
                        Secimler.Items.Add(i);
                    }
                }
            }
            else if (radioButton7.Checked == true)
            {
                foreach (int i in dizi)
                {
                    if (i % 2 == 1 && i != 0) 
                    {
                        Secimler.Items.Add(i);
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Secimler.Items.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Dizi1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

