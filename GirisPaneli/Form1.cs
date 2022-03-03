using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GirisPaneli
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int i = 1;
        string kullanici1 = null, kullanici2 = null, kullanici3 = null, sifre1 = null, sifre2 = null, sifre3 = null;
        bool durum = false;
        private void button1_Click(object sender, EventArgs e)
        {

            if (i == 1)
            {
                button2.Visible = true;
                button1.Visible = false;
                kullanici1 = textBox1.Text;
                sifre1 = textBox2.Text;
                MessageBox.Show("1. Kaydı Oluşturdunuz.");
                i++;
            }
            else if (i == 2)
            {
                button2.Visible = true;
                button1.Visible = true;
                kullanici2 = textBox1.Text;
                sifre2 = textBox2.Text;
                MessageBox.Show("2. Kaydı Oluşturdunuz.");
                i++;
            }
            else if (i == 3)
            {
                button2.Visible = true;
                button1.Visible = true;
                kullanici3 = textBox1.Text;
                sifre3 = textBox2.Text;
                MessageBox.Show("3. Kaydı Oluşturdunuz.");
                i++;
            }
            else
            {
                MessageBox.Show("Daha fazla kayıt oluşturamazsınız.");
            }
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (durum == false)
            {
                MessageBox.Show("Lütfen Yeni Kayıt Oluşturun.");
                button2.Visible = false;
                button1.Visible = true;
            }
            else
            {
                if (kullanici1 == textBox1.Text && sifre1 == textBox2.Text)
                {
                    button2.Visible = true;
                    button1.Visible = false;
                    MessageBox.Show("Başarıyla Giriş Yaptınız.");
                }
                else if (kullanici2 == textBox1.Text && sifre2 == textBox2.Text)
                {
                    button2.Visible = true;
                    button1.Visible = true;
                    MessageBox.Show("Başarıyla Giriş Yaptınız.");
                }
                else if (kullanici3 == textBox1.Text && sifre3 == textBox2.Text)
                {
                    button2.Visible = true;
                    button1.Visible = true;
                    MessageBox.Show("Başarıyla Giriş Yaptınız.");
                }
                else
                {
                    button2.Visible = true;
                    button1.Visible = false;
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı");
                }
            }
            
        } 

    }
}

