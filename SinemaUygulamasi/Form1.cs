using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[,,] musteri = new int[2, 6, 6];
        int secim = 0;

        int[] koltuk = new int[6];
        private void button10_Click(object sender, EventArgs e)
        {
            int x = 0, y = 0;
            //int index2 = 0;

            if (radioButton1.Checked)
            {
                x = 0;
                y = 0;
            }
            else if (radioButton2.Checked)
            {
                x = 0;
                y = 1;
            }
            else if (radioButton3.Checked)
            {
                x = 0;
                y = 2;
            }
            else if (radioButton4.Checked)
            {
                x = 1;
                y = 0;
            }
            else if (radioButton5.Checked)
            {
                x = 1;
                y = 1;
            }
            else if (radioButton6.Checked)
            {
                x = 1;
                y = 2;
            }

            for (int i = 0; i < musteri.GetLength(2); i++)
            {
                musteri[x, y, i] = (koltuk[i]);
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            label4.Text = "_________";
            label5.Text = "_________";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < musteri.GetLength(0); i++)
            {
                for (int j = 0; j < musteri.GetLength(1); j++)
                {
                    for (int y = 0; y < musteri.GetLength(2); y++)
                    {
                        if (musteri[i, j, y] == 1)
                        {
                            listBox1.Items.Add("KAT: " + (i + 1) + "  SALON: " + (j + 1) + "  KOLTUK: " + (y + 1) + "\n");
                        }

                    }

                }
            }
        }



        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Array.Clear(koltuk, 0, koltuk.Length);
            secim = 1;
            if (musteri[0, 0, 0] == 0)
            {
                checkBox1.Checked = false;
            }
            else
            {
                checkBox1.Checked = true;
            }
            if (musteri[0, 0, 1] == 0)
            {
                checkBox2.Checked = false;
            }
            else
            {
                checkBox2.Checked = true;
            }
            if (musteri[0, 0, 2] == 0)
            {
                checkBox3.Checked = false;
            }
            else
            {
                checkBox3.Checked = true;
            }
            if (musteri[0, 0, 3] == 0)
            {
                checkBox4.Checked = false;
            }
            else
            {
                checkBox4.Checked = true;
            }
            if (musteri[0, 0, 4] == 0)
            {
                checkBox5.Checked = false;
            }
            else
            {
                checkBox5.Checked = true;
            }
            if (musteri[0, 0, 5] == 0)
            {
                checkBox6.Checked = false;
            }
            else
            {
                checkBox6.Checked = true;
            }

            label4.Text = "KAT1";
            label5.Text = "SALON1";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Array.Clear(koltuk, 0, koltuk.Length);
            secim = 2;
            if (musteri[0, 0, 0] == 0)
            {
                checkBox1.Checked = false;
            }
            else
            {
                checkBox1.Checked = true;
            }
            if (musteri[0, 0, 1] == 0)
            {
                checkBox2.Checked = false;
            }
            else
            {
                checkBox2.Checked = true;
            }
            if (musteri[0, 0, 2] == 0)
            {
                checkBox3.Checked = false;
            }
            else
            {
                checkBox3.Checked = true;
            }
            if (musteri[0, 0, 3] == 0)
            {
                checkBox4.Checked = false;
            }
            else
            {
                checkBox4.Checked = true;
            }
            if (musteri[0, 0, 4] == 0)
            {
                checkBox5.Checked = false;
            }
            else
            {
                checkBox5.Checked = true;
            }
            if (musteri[0, 0, 5] == 0)
            {
                checkBox6.Checked = false;
            }
            else
            {
                checkBox6.Checked = true;
            }
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            label4.Text = "KAT1";
            label5.Text = "SALON2";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                koltuk[0] = 1;
            }
            else
            {
                koltuk[0] = 0;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                koltuk[1] = 1;
            }
            else
            {
                koltuk[1] = 0;
            }

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                koltuk[2] = 1;
            }
            else
            {
                koltuk[2] = 0;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                koltuk[3] = 1;
            }
            else
            {
                koltuk[3] = 0;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                koltuk[4] = 1;
            }
            else
            {
                koltuk[4] = 0;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                koltuk[5] = 1;
            }
            else
            {
                koltuk[5] = 0;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label4.Text = "KAT1";
            label5.Text = "SALON3";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            label4.Text = "KAT2";
            label5.Text = "SALON1";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            label4.Text = "KAT2";
            label5.Text = "SALON2";
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            label4.Text = "KAT2";
            label5.Text = "SALON3";
        }
    }
}
