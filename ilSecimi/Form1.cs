using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ilSecimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbBanka.Items.Add("34");
            cmbBanka.Items.Add("35");
            cmbBanka.Items.Add("01");
            cmbBanka.Items.Add("45");
            cmbBanka.Items.Add("07");
            cmbBanka.Items.Add("06");
            cmbBanka.Items.Add("48");
            cmbBanka.Items.Add("42");

            comboBox1.Items.Add("İstanbul");
            comboBox1.Items.Add("İzmir");
            comboBox1.Items.Add("Adana");
            comboBox1.Items.Add("Manisa");
            comboBox1.Items.Add("Antalya");
            comboBox1.Items.Add("Ankara");
            comboBox1.Items.Add("Muğla");
            comboBox1.Items.Add("Konya");
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
           
        }

        private void cmbBanka_SelectedIndexChanged(object sender, EventArgs e)
        {
             if (radioButton1.Checked == true || radioButton2.Checked == true)
            {
                #region switchli secim
                switch (cmbBanka.Text)
                {
                    case "34":
                        {
                            label6.Text = "İstanbul";
                            break;
                        }
                    case "35":
                        {
                            label6.Text = "İzmir";
                            break;
                        }
                    case "01":
                        {
                            label6.Text = "Adana";
                            break;
                        }
                    case "45":
                        {
                            label6.Text = "Manisa";
                            break;
                        }
                    case "07":
                        {
                            label6.Text = "Antalya";
                            break;
                        }
                    case "06":
                        {
                            label6.Text = "Ankara";
                            break;
                        }
                    case "48":
                        {
                            label6.Text = "Muğla";
                            break;
                        }
                    case "42":
                        {
                            label6.Text = "Konya";
                            break;
                        }
                }
                #endregion
                
            }
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
              if (radioButton1.Checked == true || radioButton2.Checked == true)
            {
                #region ifli secim
                switch (comboBox1.Text)
                {
                    case "İstanbul":
                        {
                            label5.Text = "34";
                            break;
                        }
                    case "İzmir":
                        {
                            label5.Text = "35";
                            break;
                        }
                    case "Adana":
                        {
                            label5.Text = "01";
                            break;
                        }
                    case "Manisa":
                        {
                            label5.Text = "45";
                            break;
                        }
                    case "Antalya":
                        {
                            label5.Text = "07";
                            break;
                        }
                    case "Ankara":
                        {
                            label5.Text = "06";
                            break;
                        }
                    case "Muğla":
                        {
                            label5.Text = "48";
                            break;
                        }
                    case "Konya":
                        {
                            label5.Text = "42";
                            break;
                        }
                }
                #endregion

            }
        }
    }
}
