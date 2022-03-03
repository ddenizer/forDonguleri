using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kullaniciGirisEkraniDizilerle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[,] dizi1 = new string[2, 2];
        int x = 0;
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (x < dizi1.GetLength(0))
            {
                dizi1[x, 0] = textBox1.Text;
                dizi1[x, 1] = textBox2.Text;
                x++;
            }
            linkLabel1.Visible = true;
            button2.Visible = true;
           
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < dizi1.GetLength(0); i++)
            {          
                listBox1.Items.Add(dizi1[i, 0] + " " + dizi1[i, 1]);       
            }
            if (listBox1.Items.Count == 2)
            {
                button1.Visible = false;             
            }                     
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dizi1[0, 0] == null)
            {
                MessageBox.Show("Kullanıcı Bulunamadı");
                button2.Visible = false;
                button1.Visible = false;
                linkLabel2.Visible = true;
                listBox1.Visible = true;
                linkLabel1.Visible = false;
            }
           

            for (int i = 0; i < 2; i++)
            {
                if (dizi1[i, 0] == textBox1.Text && dizi1[i, 1] == textBox2.Text)
                {
                    MessageBox.Show("Giriş Başarılı");                  
                }
               
            }
            
            
            

        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            button1.Visible = true;
        }
    }
}
