using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace VeriErişimKatmani
{
    public class VeriIslem
    {
        #region Tanımlama

        //Tüm Veritabanı CRUD işlemleri bu sınıf tarafından gerçekliştirilecek
        // Bu sınıf Bağlantı nesnesi komut nesnesi ve bağlantı yolunun tekrar tekrar yazılmasına engel olacak
        //Bu işlemi yapıcı metotlar(Constructor) ile gerçekleştireceğiz.

        #endregion

        SqlConnection baglanti; SqlCommand komut;

        public VeriIslem()
        {
            //Constructor = sınıfın nesnesi oluştuğunda otomatik olarak çalışan metot 
            baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=KoMat_kutuphane_DB; Integrated Security=True");
            komut = baglanti.CreateCommand();
        }
        #region Tür Metotları
        ////Tür Eklemek
        public bool TurEkle(string TurIsim)
        {
            //Metoduma parametre olarak veritabanındaki turler tablosunun Isim Kolonuna Eklemek için Kullanacağım veri olan TurIsim'i tamamlaldım
            //Metot gelen veriyi veritabanına ekleyecek
            //veri eklenirken hata yakalama yapısını kullanacağız
            try
            {
                //bu yaşam alanı içerisindeki kodları çalıştırmayı dene
                //eğer hata olışırsa hata verme Catch kısmından devam et
                komut.CommandText = "INSERT INTO Turler(Isim) VALUES(@isim)";
                komut.Parameters.Clear();//Önceki sorgulardan kalan parametreleri temizle
                komut.Parameters.AddWithValue("@isim", TurIsim);
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                return true;//eğer kodlar buraya kadar sorunsuz çalışırsa hata vermez ise veri eklemiş demektir. bu sebeple TurEkle Metodun geriye Trye verisini döndürsün. 
                //yani ben bu veriyi ekledim desin
            }
            catch
            {
                //try kısmında hata oluşursa bu yaşam alanında devam et
                return false;
                //eğer catch çalışır ise ekleme işlemşş başarısızdır.dolayısıyla TurEkle metodumuzu geriye false verisini döndürecek
            }

        }

        public bool TurEkleEntity(Tur t)
        {
            try
            {
                komut.CommandText = "INSERT INTO Turler(Isim) VALUES(@i)";
                komut.Parameters.Clear();
                komut.Parameters.AddWithValue("@i", t.Isim);
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
                //Hata olsada olmasada her durumda çalışır
            }
        }

        public List<Tur> TurListele()
        {
            List<Tur> turlistesi = new List<Tur>();//Boş jenerik koleksiyon tanımladık
            try
            {
                komut.CommandText = "SELECT ID.Isim FROM Turler";
                komut.Parameters.Clear();
                baglanti.Open();
                SqlDataReader okuyucu = komut.ExecuteReader();
                while (okuyucu.Read())
                {
                    //Döngü her dönüşünde yeni bir satırı okuyoruz
                    //Bu yüzden her satır veriyi bir tür nesnesi olarak oluşturacağız
                    Tur t = new Tur();
                    t.ID = okuyucu.GetInt32(0);
                    t.Isim = okuyucu.GetString(1);
                    turlistesi.Add(t);
                    //oluşan her nesneyi turlistesi isiml, jenerik koleksiyonuma (jenerik dizi) ekliyorum
                }
                
            
        }
    }
        #endregion

        #region Yazar Metotları

        //public bool YazarEkle(Yazar y)
        //{
        //    try
        //    {
        //        komut.CommandText = "INSERT INTO Yazarlar(Isim,Soyisim) VALUES(@isim,@soyisim)";
        //        komut.Parameters.Clear();
        //        komut.Parameters.AddWithValue("@isim", y.Isim);
        //        komut.Parameters.AddWithValue("@soyisim", y.Soyisim);
        //        baglanti.Open();
        //        komut.ExecuteNonQuery();
        //        return true;
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //    finally
        //    {
        //        baglanti.Close();
        //    }
        //}
        //public List<Yazar> YazarListele()
        //{
        //    List<Yazar> yazarlar = new List<Yazar>();
        //    try
        //    {
        //        komut.CommandText = "SELECT ID, Isim, Soyisim FROM Yazarlar";
        //        komut.Parameters.Clear();
        //        baglanti.Open();
        //        SqlDataReader okuyucu = komut.ExecuteReader();
        //        while (okuyucu.Read())
        //        {
        //            Yazar y = new Yazar();
        //            y.ID = okuyucu.GetInt32(0);
        //            y.Isim = okuyucu.GetString(1);
        //            y.Soyisim = okuyucu.GetString(2);
        //            yazarlar.Add(y);
        //        }
        //        return yazarlar;
        //    }
        //    catch
        //    {
        //        return null;
        //    }
        //    finally
        //    {
        //        baglanti.Close();
        //    }
        //}

        //public bool YazarGüncelle(Yazar y)
        //{
        //    try
        //    {
        //        komut.CommandText = "UPDATE Yazarlar Set Isim=@i, Soyisim=@s WHERE ID=@murtaza";
        //        komut.Parameters.Clear();
        //        komut.Parameters.AddWithValue("@i", y.Isim);
        //        komut.Parameters.AddWithValue("@s", y.Soyisim);
        //        komut.Parameters.AddWithValue("@murtaza", y.ID);
        //        baglanti.Open();
        //        komut.ExecuteNonQuery();
        //        return true;
        //    }
        //    catch
        //    {
        //        return false;
        //    }

        //    finally
        //    {

        //    }




        //}

        //public bool YazarSilme(int id)
        //{
        //    try
        //    {
        //        komut.CommandText = "DELETE FROM Yazarlar WHERE ID=@id";
        //        komut.Parameters.Clear();
        //        komut.Parameters.AddWithValue("@id", id);
        //        baglanti.Open();
        //        komut.ExecuteNonQuery();
        //        return true;
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //    finally
        //    {
        //        baglanti.Close() ;
        //    }

        //}

        #endregion

    }
}
