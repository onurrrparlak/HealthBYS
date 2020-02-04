using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
namespace HealthBYS
{
    class cAdminler
    {
        cGenel gnl = new cGenel();
        
        #region Fields
        private int _adminID;
        private string _adminKullaniciAdi;
        private string _adminSifre;
        private string _adminMail;
        private int _adminTelefon;

        #endregion
        #region Properties
        public int AdminID {
          get { return _adminID; }
            set { _adminID = value; }
        }
        public string AdminKullaniciAdi {
            get { return _adminKullaniciAdi; }
            set { _adminKullaniciAdi = value; }
        }
        public string AdminSifre {
            get { return _adminSifre; }
            set { _adminSifre = value; }
        }
        public string AdminMail {
            get { return _adminMail; }
            set { _adminMail = value; }
        }
        public int AdminTelefon {
            get { return _adminTelefon; }
            set { _adminTelefon = value; }
        }
        #endregion


        public bool adminEntryControl(string password, int userID)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM admin where adminID=@Id and adminSifre=@password", con);
            cmd.Parameters.Add("@Id", System.Data.SqlDbType.VarChar).Value = userID;
            cmd.Parameters.Add("@password", System.Data.SqlDbType.VarChar).Value = password;
            
            
            try
            {
              if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                result = Convert.ToBoolean(cmd.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                String hata = ex.Message;
                throw;
            }



            return result;
        }
        public void adminGetByInformation(ComboBox cb)
        {
            cb.Items.Clear();

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM admin", con);
            
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cAdminler p = new cAdminler();
                p._adminID = Convert.ToInt32(dr["adminID"]);
                p._adminKullaniciAdi = Convert.ToString(dr["adminKullaniciAdi"]);
                p._adminMail = Convert.ToString(dr["adminMail"]);
                p._adminSifre = Convert.ToString(dr["adminSifre"]);
                p._adminTelefon = Convert.ToInt32(dr["adminTelefon"]);


                cb.Items.Add(p);
            }
            dr.Close();
            con.Close();
        }
        public override string ToString()
        {
            return AdminKullaniciAdi;
        }
    }
}
