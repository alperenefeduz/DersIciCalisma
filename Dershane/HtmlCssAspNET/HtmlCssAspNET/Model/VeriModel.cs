using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace HtmlCssAspNET.Model
{
    public class VeriModel
    {
        SqlConnection baglanti;
        SqlCommand komut;
        public VeriModel()
        {
            baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=deneme;Integrated Security=True");
            komut = baglanti.CreateCommand();
        }

        public bool GirisKontrol(string kadi, string sifre)
        {
            try
            {
                komut.CommandText = "INSERT COUNT (*) FROM kullanicilar WHERE kullanicikullaniciAdi=@kadi and kullaniciSifre=@sfr";
                komut.Parameters.Clear();
                komut.Parameters.AddWithValue("@kadi", kadi);
                komut.Parameters.AddWithValue("@sfr", sifre);
                baglanti.Open();
                int sayi = Convert.ToInt32(komut.ExecuteScalar());
                if (sayi > 0)
                {
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
            finally
            {
                baglanti.Close();
            }
        }
        public bool KayıtKontrol(kayitSayfasi model)
        {
            try
            {
                komut.CommandText = "INSERT INTO kullanicilar (kullaniciIsim, kullaniciSoyisim, kullaniciKullaniciAdi, kullaniciSifre, kullaniciMail) VALUES(@isim,@soyisim,@username,@password,@mail)";
                komut.Parameters.Clear();
                komut.Parameters.AddWithValue("@isim", model.isim);
                komut.Parameters.AddWithValue("@soyisim", model.soyad);
                komut.Parameters.AddWithValue("@username", model.username);
                komut.Parameters.AddWithValue("password", model.password);
                komut.Parameters.AddWithValue("mail", model.mail);
                baglanti.Open();
                komut.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                baglanti.Close();
            }
        }
    }
}