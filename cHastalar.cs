using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
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
            SqlCommand cmd = new SqlCommand("Insert Into hastalar (hastaAdi,hastaSoyadi,hastaTC,hastaDG,hastaMeslek,hastaKan,hastaTel,hastaIl,hastaIlce,hastaMh,hastaCd,hastaAdres,hastaBaba,hastaAnne,hastaDGyeri,hastaCinsiyet,hastaBoy,hastaKilo,hastaMail,hastaKasa) values(@ad,@soyad,@tc,@dg,@meslek,@kan,@telefon,@il,@ilce,@mh,@cd,@adres,@baba,@anne,@dgyeri,@cinsiyet,@boy,@kilo,@mail,@kasa); select SCOPE_IDENTITY()", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@ad", SqlDbType.VarChar).Value = h._hastaAdi;
                cmd.Parameters.Add("@soyad", SqlDbType.VarChar).Value = h._hastaSoyadi;
                cmd.Parameters.Add("@tc", SqlDbType.VarChar).Value = h._hastaTC;
                cmd.Parameters.Add("@dg", SqlDbType.VarChar).Value = h._hastaDG;
                cmd.Parameters.Add("@meslek", SqlDbType.VarChar).Value = h._hastaMeslek;
                cmd.Parameters.Add("@kan", SqlDbType.VarChar).Value = h._hastaKan;
                cmd.Parameters.Add("@telefon", SqlDbType.VarChar).Value = h._hastaTel;
                cmd.Parameters.Add("@il", SqlDbType.VarChar).Value = h._hastaIl;
                cmd.Parameters.Add("@ilce", SqlDbType.VarChar).Value = h._hastaIlce;
                cmd.Parameters.Add("@mh", SqlDbType.VarChar).Value = h._hastaMh;
                cmd.Parameters.Add("@cd", SqlDbType.VarChar).Value = h._hastaCd;
                cmd.Parameters.Add("@adres", SqlDbType.VarChar).Value = h._hastaAdres;
                cmd.Parameters.Add("@baba", SqlDbType.VarChar).Value = h._hastaBaba;
                cmd.Parameters.Add("@anne", SqlDbType.VarChar).Value = h._hastaAnne;
                cmd.Parameters.Add("@dgyeri", SqlDbType.VarChar).Value = h._hastaDGyeri;
                cmd.Parameters.Add("@cinsiyet", SqlDbType.VarChar).Value = h._hastaCinsiyet;
                cmd.Parameters.Add("@boy", SqlDbType.VarChar).Value = h._hastaBoy;
                cmd.Parameters.Add("@kilo", SqlDbType.VarChar).Value = h._hastaKilo;
                cmd.Parameters.Add("@mail", SqlDbType.VarChar).Value = h._hastaMail;
                cmd.Parameters.Add("@kasa", SqlDbType.VarChar).Value = h._hastaKasa;
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

        public bool hastaBilgileriGuncelle(cHastalar h)
        {


            bool sonuc = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Update hastalar set hastaAdi=@ad,hastaSoyadi=@soyad,hastaTC=@tc,hastaDG=@dg,hastaMeslek=@meslek,hastaKan=@kan,hastaTel=@tel,hastaIl=@il,hastaIlce=@ilce,hastaMh=@mh,hastaCd=@cd,hastaAdres=@adres,hastaBaba=@baba,hastaAnne=@anne,hastaDGyeri=@dgyeri,hastaCinsiyet=@cinsiyet,hastaBoy=@boy,hastaKilo=@kilo,hastaMail=@mail,hastaKasa=@kasa where hastaID = @id ", con);

            
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();

                  

                
                }
                cmd.Parameters.Add("@ad", SqlDbType.VarChar).Value = h._hastaAdi;
                cmd.Parameters.Add("@soyad", SqlDbType.VarChar).Value = h._hastaSoyadi;
                cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = h._hastaId;
                cmd.Parameters.Add("@tc", SqlDbType.VarChar).Value = h._hastaTC;
                cmd.Parameters.Add("@dg", SqlDbType.VarChar).Value = h._hastaDG;
                cmd.Parameters.Add("@meslek", SqlDbType.VarChar).Value = h._hastaMeslek;
                cmd.Parameters.Add("@kan", SqlDbType.VarChar).Value = h._hastaKan;
                cmd.Parameters.Add("@tel", SqlDbType.VarChar).Value = h._hastaTel;
                cmd.Parameters.Add("@il", SqlDbType.VarChar).Value = h._hastaIl;
                cmd.Parameters.Add("@ilce", SqlDbType.VarChar).Value = h._hastaIlce;
                cmd.Parameters.Add("@mh", SqlDbType.VarChar).Value = h._hastaMh;
                cmd.Parameters.Add("@cd", SqlDbType.VarChar).Value = h._hastaCd;
                cmd.Parameters.Add("@adres", SqlDbType.VarChar).Value = h._hastaAdres;
                cmd.Parameters.Add("@baba", SqlDbType.VarChar).Value = h._hastaBaba;
                cmd.Parameters.Add("@anne", SqlDbType.VarChar).Value = h._hastaAnne;
                cmd.Parameters.Add("@dgyeri", SqlDbType.VarChar).Value = h._hastaDGyeri;
                cmd.Parameters.Add("@cinsiyet", SqlDbType.VarChar).Value = h._hastaCinsiyet;
                cmd.Parameters.Add("@boy", SqlDbType.VarChar).Value = h._hastaBoy;
                cmd.Parameters.Add("@kilo", SqlDbType.VarChar).Value = h._hastaKilo;
                cmd.Parameters.Add("@mail", SqlDbType.VarChar).Value = h._hastaMail;
                cmd.Parameters.Add("@kasa", SqlDbType.VarChar).Value = h._hastaKasa;

                sonuc = Convert.ToBoolean(cmd.ExecuteNonQuery());

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
        public void hastalariGetir(ListView lv)
        {
            lv.Items.Clear();

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM hastalar", con);

            SqlDataReader dr = null;

           
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();

                    dr = cmd.ExecuteReader()
;
                    int sayac = 0;

                    while (dr.Read())
                    {
                        lv.Items.Add(dr["hastaID"].ToString());
                        lv.Items[sayac].SubItems.Add(dr["hastaTC"].ToString());
                        lv.Items[sayac].SubItems.Add(dr["hastaAdi"].ToString());
                        lv.Items[sayac].SubItems.Add(dr["hastaSoyadi"].ToString());
                        lv.Items[sayac].SubItems.Add(dr["hastaDG"].ToString());
                        lv.Items[sayac].SubItems.Add(dr["hastaTel"].ToString());
                        lv.Items[sayac].SubItems.Add(dr["hastaKasa"].ToString());
                        sayac++;
                    }
                }
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally
            {
                dr.Close();
                con.Dispose();
                con.Close();
            }
           
        }
    
    // Müşterileri ID'ye göre getir
        public void hastalariGetirID(int hastaId, TextBox ad,TextBox soyad, TextBox tc,MaskedTextBox dg, TextBox meslek, ComboBox kan,TextBox tel,TextBox il,TextBox ilce,TextBox mh,TextBox cd,TextBox adres,TextBox baba,TextBox anne,TextBox dgyeri,ComboBox cinsiyet,TextBox boy, TextBox kilo, TextBox mail,TextBox kasa)
        {

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM hastalar where hastaID = @hastaID", con);

            SqlDataReader dr = null;
            cmd.Parameters.Add("hastaID", SqlDbType.Int).Value = hastaId;
           try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();

                    dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        ad.Text = dr["hastaAdi"].ToString();
                        soyad.Text = dr["hastaSoyadi"].ToString();
                        tc.Text = dr["hastaTC"].ToString();
                        dg.Text = dr["hastaDg"].ToString();
                        meslek.Text = dr["hastaMeslek"].ToString();
                        kan.Text = dr["hastaKan"].ToString();
                        tel.Text = dr["hastaTel"].ToString();
                        il.Text = dr["hastaIl"].ToString();
                        ilce.Text = dr["hastaIlce"].ToString();
                        mh.Text = dr["hastaMh"].ToString();
                        cd.Text = dr["hastaCd"].ToString();
                        adres.Text = dr["hastaAdres"].ToString();
                        baba.Text = dr["hastaBaba"].ToString();
                        anne.Text = dr["hastaAnne"].ToString();
                        dgyeri.Text = dr["hastaDGyeri"].ToString();
                        cinsiyet.Text = dr["hastaCinsiyet"].ToString();
                        boy.Text = dr["hastaBoy"].ToString();
                        kilo.Text = dr["hastaKilo"].ToString();
                        mail.Text = dr["hastaMail"].ToString();
                        kasa.Text = dr["hastaKasa"].ToString();


                    }
                }

            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                
            }
            dr.Close();
            con.Dispose();
            con.Close();

        }
    }

}
