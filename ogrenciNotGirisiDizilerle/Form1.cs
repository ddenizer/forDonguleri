using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ogrenciNotGirisiDizilerle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] ogrenci1 = new string[6];
        string[,] ogrenci2 = new string[2,3];
        string[,,] ogrenci3 = new string[1,2,3];
        int indeks1 = 0, indeks2 = 0, indeks3 = 0;
        string satir = "";
        
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                #region Tek boyutlu
                listBox1.Items.Add("Öğrenci Adı" + "\t" + "Ders Adı" + "\t" + "Ders Notu");
                listBox1.Items.Add("----------------------------------------------------");
                for (int i = 0; i < ogrenci1.GetLength(0); i += 3)
                {
                    listBox1.Items.Add(ogrenci1[i] + "\t" + ogrenci1[i + 1] + "\t" + ogrenci1[i + 2]);
                }
                #endregion
            }
            else if (radioButton2.Checked == true)
            {
                #region İki boyutlu dizi
                string satirtoplam = "";
                listBox1.Items.Add("Öğrenci Adı" + "\t" + "Ders Adı" + "\t" + "Ders Notu");
                listBox1.Items.Add("----------------------------------------------------");
                for (int satir = 0; satir < ogrenci2.GetLength(0); satir++)
                {
                    for (int sutun = 0; sutun < ogrenci2.GetLength(1); sutun++)
                    {
                        satirtoplam = satirtoplam + ogrenci2[satir, sutun] + "\t\t";
                    }
                    listBox1.Items.Add(satirtoplam);
                    satirtoplam = "";
                }
                #endregion
            }
            else
            {
                #region Üç boyutlu dizi
                for (int i = 0; i < ogrenci3.GetLength(0); i++)
                {
                    for (int j = 0; j < ogrenci3.GetLength(1); j++)
                    {
                        for (int y = 0; y < ogrenci3.GetLength(2); y++)
                        {
                            satir = satir + ogrenci3[i, j, y] + "\t";
                        }
                        listBox1.Items.Add(satir);
                        satir = "";
                    }
                }
                #endregion
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                #region Tek Boyutlu
                if (indeks1 < ogrenci1.GetLength(0))
                {
                    ogrenci1[indeks1] = textBox1.Text;
                    ogrenci1[indeks1 + 1] = comboBox1.Text;
                    ogrenci1[indeks1 + 2] = textBox2.Text;
                    indeks1 += 3;
                    textBox1.Clear();
                    textBox2.Clear();
                    comboBox1.SelectedIndex = -1;
                    textBox1.Select();
                }
                else
                {
                    MessageBox.Show("Öğrenci Sayısını Aştınız");
                }
                #endregion
            }
            else if(radioButton2.Checked == true)   
            {
                #region iki boyutlu
                if (indeks2<ogrenci2.GetLength(0))
                {
                    ogrenci2[indeks2, 0] = textBox1.Text;
                    ogrenci2[indeks2, 1] = comboBox1.Text;
                    ogrenci2[indeks2, 2] = textBox2.Text;
                    indeks2++;
                    textBox1.Clear();
                    textBox2.Clear();
                    comboBox1.SelectedIndex = -1;
                    textBox1.Select();
                }
                else
                {
                    MessageBox.Show("Öğrenci Sayısını Aştınız");
                }
                #endregion
            }
            else if(radioButton3.Checked == true)
            {
                #region üç Boyutlu
                if (indeks3<2)
                {
                    ogrenci3[0, indeks3, 0] = textBox1.Text;
                    ogrenci3[0, indeks3, 1] = comboBox1.Text;
                    ogrenci3[0, indeks3, 2] = textBox2.Text;
                    indeks3++;
                    textBox1.Clear();
                    textBox2.Clear();
                    comboBox1.SelectedIndex = -1;
                    textBox1.Select();
                }
                else
                {
                    MessageBox.Show("Öğrenci Sayısını Aştınız");
                }
                #endregion
            }

        }
    }
}
