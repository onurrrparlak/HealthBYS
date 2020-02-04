using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace HealthBYS
{
    class cAdminHareketleri
    {
        cGenel gnl = new cGenel();
        #region Field
        private int _ID;
        private int _adminID;
        private string _Islem;
        private DateTime _Tarih;
        private bool _Durum;
        #endregion
        #region Properties
        public int ID
        { 
            get { return _ID; }
            set { _ID = value; }
        }
        public int adminID
        {
            get { return _adminID; }
            set { _adminID = value; }
        }
        public string Islem
        {
            get { return _Islem; }
            set { _Islem = value; }
        }
        public DateTime Tarih
        {
            get { return _Tarih; }
            set { _Tarih = value; }
        }
        public bool Durum
        {
            get { return _Durum; }
            set { _Durum = value; }
        }
        #endregion

        public bool AdminActionSave(cAdminHareketleri aH)
        {
            bool result = false;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("INSERT INTO adminhareketleri(adminID,islem,tarih) VALUES (@adminID,@islem,@tarih) ", con);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@adminID", System.Data.SqlDbType.Int).Value = aH._adminID;
                cmd.Parameters.Add("@islem", System.Data.SqlDbType.VarChar).Value = aH._Islem;
                cmd.Parameters.Add("@tarih", System.Data.SqlDbType.DateTime).Value = aH._Tarih;
                result = Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }
            return result;
        }
    }
}
