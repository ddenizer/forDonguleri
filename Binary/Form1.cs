using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Binary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sonuc = "";
            int sayi = int.Parse(textBox1.Text);
            for (int i = sayi; i > 0; i = i / 2)
            {
                sonuc = (i % 2).ToString() + sonuc;
            }
            label3.Text= sonuc;
        }
    }
}
