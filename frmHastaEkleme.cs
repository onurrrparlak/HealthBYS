using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthBYS
{
    public partial class frmHastaEkleme : Form
    {
        public frmHastaEkleme()
        {
            InitializeComponent();
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txttxtTelNo.Text.Length> 11)
            {
                if (txthastaAd.Text == "" || txthastaSoyad.Text == "")
                {
                    MessageBox.Show("Lütfen Hasta Adı ve Soyadı giriniz");
                }else
                {
                    cHastalar c = new cHastalar();
                    bool sonuc = c.hastaVarMi(txttxtTelNo.Text);
                    if (!sonuc)
                    {
                        c.hastaAdi = txthastaAd.Text;
                        c.hastaSoyadi = txthastaSoyad.Text;
                        c.hastaTC = txthastaTC.Text;
                        c.hastaTel = txttxtTelNo.Text;
                        c.hastaBaba = txthastaBaba.Text;
                        
                        txthastaid.Text = c.hastaEkle(c).ToString();

                        if (txthastaid.Text != "")
                        {
                           
                            MessageBox.Show("Hasta Eklendi");
                        }
                        else
                        {
                            MessageBox.Show("Hasta Eklenemedi");
                        }
                    }
                }
                     
            }
            else
            {
                MessageBox.Show("Telefon No 11 haneli olmalıdır");
            }
        }
    }
}
