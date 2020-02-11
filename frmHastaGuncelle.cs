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
            if (txttxtTelNo.Text.Length>= 11)
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
                        c.hastaKan = "";
                        c.hastaCinsiyet = "";
                        c.hastaAdi = txthastaAd.Text;
                        c.hastaSoyadi = txthastaSoyad.Text;
                        c.hastaTC = txthastaTC.Text;
                        c.hastaDG = txthastaDG.Text;
                        c.hastaMeslek = txthastaMeslek.Text;
                        if (txthastaKan.SelectedIndex > -1)
                        {
                            c.hastaKan = txthastaKan.SelectedItem.ToString();
                        }
                        c.hastaTel = txttxtTelNo.Text;
                        c.hastaIl = txthastaIl.Text;
                        c.hastaIlce = txthastaIlce.Text;
                        c.hastaMh = txthastaMahalle.Text;
                        c.hastaCd = txthastaCadde.Text;
                        c.hastaAdres = txthastaAdres.Text;
                        c.hastaBaba = txthastaBaba.Text;
                        c.hastaAnne = txthastaAnne.Text;
                        c.hastaDGyeri = txthastaDgyeri.Text;
                        if (txthastaCinsiyet.SelectedIndex > -1)
                        {
                            c.hastaCinsiyet = txthastaCinsiyet.SelectedItem.ToString();
                        }
                        c.hastaBoy = txthastaBoy.Text;
                        c.hastaKilo = txthastaKilo.Text;
                        c.hastaMail = txthastaMail.Text;
                        c.hastaKasa = txthastaKasa.Text;
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
                     
            }else
            {
                MessageBox.Show("Telefon No 11 haneli olmalıdır");
            }
        }

        private void frmHastaEkleme_Load(object sender, EventArgs e)
        {
            if (cGenel._hastaID > 0)
            {
                cHastalar c = new cHastalar();
                txthastaid.Text = cGenel._hastaID.ToString();
                c.hastalariGetirID(Convert.ToInt32(txthastaid.Text),txthastaAd,txthastaSoyad,txttxtTelNo,txthastaAdres,txthastaMail);
            }

        }

        private void txthastaTC_TextChanged(object sender, EventArgs e)
        {

        }

        private void txthastaTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void txthastaDG_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txthastaBoy_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void txthastaKilo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
