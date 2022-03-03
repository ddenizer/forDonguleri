using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finansUygulamasi
{
    public partial class FinansUygulamasıForm : Form
    {
        public FinansUygulamasıForm()
        {
            InitializeComponent();
        }

        private void FinansUygulamasıForm_Load(object sender, EventArgs e)
        {
            cmbBanka.Items.Add("Akbank");
            cmbBanka.Items.Add("Garanti Bankası");
            cmbBanka.Items.Add("Ziraat Bankası");
            cmbBanka.Items.Add("İş Bankası");
            cmbBanka.Items.Add("Halk Bankası");
            cmbBanka.Items.Add("Vakıfbank");
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                #region ifli kısım
                int anapara=int.Parse(txtAnaPara.Text);
                int faiz=int.Parse(lblFaiz.Text);
                int gun = int.Parse(txtGun.Text);
                lblKazanc.Text =((anapara*faiz*gun)/36500).ToString();
                #endregion
            }
            else
            {
                #region switchli kısım
                int anapara = int.Parse(txtAnaPara.Text);
                int faiz = int.Parse(lblFaiz.Text);
                int gun = int.Parse(txtGun.Text);
                lblKazanc.Text = ((anapara * faiz * gun) / 36500).ToString();
                #endregion
            }
        }

        private void cmbBanka_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbBanka.Text)
            {
                case "Akbank":
                    {
                        lblFaiz.Text = "17";
                        break;
                    }
                case "Garanti Bankası":
                    {
                        lblFaiz.Text = "19";
                        break;
                    }
                case "Ziraat Bankası":
                    {
                        lblFaiz.Text = "22";
                        break;
                    }
                case "İş Bankası":
                    {
                        lblFaiz.Text = "18";
                        break;
                    }
                case "Halk Bankası":
                    {
                        lblFaiz.Text = "20";
                        break;
                    }
                case "Vakıfbank":
                    {
                        lblFaiz.Text = "21";
                        break;
                    }
            }
        }
    }
}
