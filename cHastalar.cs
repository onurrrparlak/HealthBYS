using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace HealthBYS
{
    class cHastalar
    {
        cGenel gnl = new cGenel();

        #region Variables
        private int _hastaId;
        private bool _hastaAktif;
        private string _hastaAdi;
        private string _hastaSoyadi;
        private string _hastaTC;
        private string _hastaDG;
        private string _hastaDGyeri;
        private string _hastaMeslek;
        private string _hastaKan;
        private string _hastaTel;
        private string _hastaIl;
        private string _hastaIlce;
        private string _hastaMh;
        private string _hastaCd;
        private string _hastaAdres;
        private string _hastaBaba;
        private string _hastaAnne;
        private string _hastaCinsiyet;
        private string _hastaBoy;
        private string _hastaKilo;
        private string _hastaMail;
        private string _hastaKasa;
        #endregion

        #region Getset
        public int hastaId
        {
            get { return _hastaId; }
            set { _hastaId = value; }
        }
        public bool hastaAktif
        {
            get { return _hastaAktif; }
            set { _hastaAktif = value; }
        }
        public string hastaAdi
        {
            get { return _hastaAdi; }
            set { _hastaAdi = value; }
        }

        public string hastaSoyadi
        {
            get { return _hastaSoyadi; }
            set { _hastaSoyadi = value; }
        }
        public string hastaTC
        {
            get { return _hastaTC; }
            set { _hastaTC = value; }
        }
        public string hastaDG
        {
            get { return _hastaDG; }
            set { _hastaDG = value; }
        }
        public string hastaTel
        {
            get { return _hastaTel; }
            set { _hastaTel = value; }
        }
        public string hastaMeslek
        {
            get { return _hastaMeslek; }
            set { _hastaMeslek = value; }
        }
        public string hastaKan
        {
            get { return _hastaKan; }
            set { _hastaKan = value; }
        }
        public string hastaIl
        {
            get { return _hastaIl; }
            set { _hastaIl = value; }
        }
        public string hastaIlce
        {
            get { return _hastaIlce; }
            set { _hastaIlce = value; }
        }
        public string hastaMh
        {
            get { return _hastaMh; }
            set { _hastaMh = value; }
        }
        public string hastaCd
        {
            get { return _hastaCd; }
            set { _hastaCd = value; }
        }
        public string hastaBaba
        {
            get { return _hastaBaba; }
            set { _hastaBaba = value; }
        }
        public string hastaAnne
        {
            get { return _hastaAnne; }
            set { _hastaAnne = value; }
        }
        public string hastaAdres
        {
            get { return _hastaAdres; }
            set { _hastaAdres = value; }
        }
        public string hastaDGyeri
        {
            get { return _hastaDGyeri; }
            set { _hastaDGyeri = value; }
        }
        public string hastaCinsiyet
        {
            get { return _hastaCinsiyet; }
            set { _hastaCinsiyet = value; }
        }
        public string hastaBoy
        {
            get { return _hastaBoy; }
            set { _hastaBoy = value; }
        }
        public string hastaKilo
        {
            get { return _hastaKilo; }
            set { _hastaKilo = value; }
        }
        public string hastaMail
        {
            get { return _hastaMail; }
            set { _hastaMail = value; }
        }
        public string hastaKasa
        {
            get { return _hastaKasa; }
            set { _hastaKasa = value; }
        }
        #endregion Getset


        public bool hastaVarMi(string tlf)
        {
            bool sonuc = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "HastaVarMi";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@telefon", SqlDbType.VarChar).Value = tlf;
            cmd.Parameters.Add("@sonuc", SqlDbType.Int);
            cmd.Parameters["@sonuc"].Direction = ParameterDirection.Output;

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            try
            {
                cmd.ExecuteNonQuery();
                sonuc = Convert.ToBoolean(cmd.Parameters["@sonuc"].Value);

            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally
            {
                con.Close();
            }
            return sonuc;

        }
        
        public int hastaEkle(cHastalar h)
        {
            int sonuc = 0;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Insert Into hastalar (hastaAdi,hastaSoyadi,hastaTC,hastaTel,hastaBaba) values(@ad,@soyad,@tc,@telefon,@baba); select SCOPE_IDENTITY()", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@ad", SqlDbType.VarChar).Value = h._hastaAdi;
                cmd.Parameters.Add("@soyad", SqlDbType.VarChar).Value = h._hastaSoyadi;
                cmd.Parameters.Add("@tc", SqlDbType.VarChar).Value = h._hastaTC;
                cmd.Parameters.Add("@telefon", SqlDbType.VarChar).Value = h._hastaTel;
                cmd.Parameters.Add("@baba", SqlDbType.VarChar).Value = h._hastaBaba;
                sonuc = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally
            {
                con.Dispose();
                con.Close();
            }


            return sonuc;
        }


    }
}
