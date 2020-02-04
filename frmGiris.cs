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
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }
       
        private void girisButon_Click(object sender, EventArgs e)
        {
            cGenel gnl = new cGenel();
            cAdminler p = new cAdminler();
            bool result = p.adminEntryControl(sifreText.Text, cGenel._adminID);


            if (result)
            {
                cAdminHareketleri ch = new cAdminHareketleri();

                ch.adminID = cGenel._adminID;
                ch.Islem = "Giriş Yapıldı";
                ch.Tarih = DateTime.Now;
                ch.AdminActionSave(ch);
                this.Hide();

                
                frmMenu menu = new frmMenu();
                menu.Show();
            }
        }

        private void frmGiris_Load(object sender, EventArgs e)
        {
            cAdminler p = new cAdminler();
            p.adminGetByInformation(cbKullanici);
        }
         
        private void cbKullanici_SelectedIndexChanged(object sender, EventArgs e)
        {
            cAdminler p = (cAdminler)cbKullanici.SelectedItem;
            cGenel._adminID = p.AdminID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak istediğinizden emin misiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
