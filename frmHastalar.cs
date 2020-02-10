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
    public partial class frmHastalar : Form
    {
        public frmHastalar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu menu = new frmMenu();
            menu.Show();
        }

        private void btnYeniHastaKayit_Click(object sender, EventArgs e)
        {
          
            frmHastaEkleme m = new frmHastaEkleme();
            cGenel._hastaEkleme = 1;
            m.Show();
        }

        private void frmHastalar_Load(object sender, EventArgs e)
        {
            cHastalar c = new cHastalar();
            c.hastalariGetir(lvHastalar);
            
        }

        private void btnDuzenle_click(object sender, EventArgs e)
        {
            if (lvHastalar.SelectedItems.Count > 0)
            {
                frmHastaEkleme frm = new frmHastaEkleme();
                cGenel._hastaEkleme = 1;
                cGenel._hastaID = Convert.ToInt32(lvHastalar.SelectedItems[0].SubItems[0].Text);

                
                
                frm.Show();
            }
        }
    }
}
