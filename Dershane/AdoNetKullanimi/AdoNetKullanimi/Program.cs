using System;
using System.Data.SqlClient;
using System.Xml;

namespace AdoNetKullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //veritabanı bağlantı ve komut  nesnelerini oluşturmak için
            //using System.Data.SqlClient; namespace' i eklemelidir

            //Northwind veritabanından 
            #region kategori sayısını çekelim

            ////1) Bağlantı  
            //SqlConnection baglanti = new SqlConnection();

            ////2) Bağlantı yolu
            //// bağlantı için hangi server içindeki, hangi veritabanına nasıl bağlanıyorum
            //// \'ın özel karakter  olma durumu string'in başına @ koyarak ortadan kaldırabiliriz
            //baglanti.ConnectionString = @"Data Source=AEDMONSTER26\SQLEXPRESS;Initial Catalog=NORTHWND; Integrated Security=True";

            ////3)Komut
            //SqlCommand komut = new SqlCommand();
            //komut.Connection = baglanti; //Komut yukarıda oluşturulan bağlantı nesnesi içinde tanımlanan bağlantı yoluna gönderilecek

            ////4) komut metni 
            //komut.CommandText = "SELECT COUNT (*) FROM Categories";
            ////5) bağlantı aç
            //baglanti.Open();

            ////6) Sorgu çalıştır 
            //int sayi = Convert.ToInt32(komut.ExecuteScalar());
            ////Eğer sorgudan geriye tek hücre dönecek ise ExecuteScalar kullanılır
            //Console.WriteLine("Kategori Sayısı = " + sayi);

            ////7) bağlantı kapat
            //baglanti.Close();

            #endregion

            #region Ürün sayısını çekelim

            //SqlConnection baglanti = new SqlConnection(@"Data Source=AEDMONSTER26\SQLEXPRESS;Initial Catalog=NORTHWND; Integrated Security=True");

            //SqlCommand komut = baglanti.CreateCommand();

            //komut.CommandText = "SELECT COUNT (*) FROM Products";
            //baglanti.Open();

            //int sayi = Convert.ToInt32(komut.ExecuteScalar());
            //Console.WriteLine("Kayıtlı ürün sayısı = " + sayi);
            //baglanti.Close();
            #endregion

            #region kayıtlı kategorileri listeleyelim

            //SqlConnection baglanti = new SqlConnection(@"Data Source=AEDMONSTER26\SQLEXPRESS;Initial Catalog=NORTHWND; Integrated Security=True");
            //SqlCommand komut = baglanti.CreateCommand();
            //komut.CommandText = "SELECT CategoryID, CategoryName, Description FROM categories";
            //baglanti.Open();

            ////Yukarıdaki sorgudan tablo gelmesi beklenir. tablolu veriler SqlDataReader ile karşılanabilir
            //SqlDataReader okuyucu = komut.ExecuteReader();
            ////Eğer sorgu tablo getirecekse sorguyu ExecuteReader ile çalıştırmalıyız.

            ////okuyucu.Read() = okunmamış satır var ise true döndürür.
            //while (okuyucu.Read())
            //{
            //    //okuma işlemi satır satır gerçekleşecek.
            //    //Her satırı kolon index numaraları ile okuyoruz.
            //    //ve sqldeki kolonun türüne göre c# türüne döndürüyoruz.
            //    //KOLON SIRALAMASI VERİTABANINDAKİNE GÖRE DEĞİL, SORGUDAKİ SIRAA GÖRE ALINIR 
            //    int id = okuyucu.GetInt32(0); //Veritabanında CategoryID'nin türü int o yüzden burada veriyi integar dönüştürüp alıyoruz.
            //    string isim = okuyucu.GetString(1);
            //    string aciklama = okuyucu.GetString(2);
            //    Console.WriteLine($"{id} - {isim} - {aciklama}");
            //}

            //baglanti.Close();
            #endregion

            #region Kategori Ekleyelim

            //Console.WriteLine("Kategori Adı Giriniz");
            //string katisim = Console.ReadLine();

            //Console.WriteLine("Kategori açıklaması giriniz= ");
            //string aciklama = Console.ReadLine();

            //SqlConnection baglanti = new SqlConnection(@"Data Source=AEDMONSTER26\SQLEXPRESS;Initial Catalog=NORTHWND; Integrated Security=True");
            //SqlCommand komut = baglanti.CreateCommand();

            //komut.CommandText = "INSERT INTO Categories(CategoryName,Description) VALUES ('" + katisim + "', '" + aciklama + "')";
            //baglanti.Open();
            //komut.ExecuteNonQuery();
            ////Eğer sorgudan geriye veri dönmeyecekse ExecuteNonQuery kullanılmalıdır.
            //baglanti.Close();

            #endregion

            #region Deniz Ürünleri kategorisindeki ürünleri listeleyelim

            //SqlConnection baglantı = new SqlConnection(@"Data Source=AEDMONSTER26\SQLEXPRESS;Initial Catalog=NORTHWND; Integrated Security=True");
            //SqlCommand komut = baglantı.CreateCommand();

            //Console.WriteLine("ürünleri listelenecek kategori ıd giriniz");
            //string id = Console.ReadLine();
            //komut.CommandText = "SELECT ProductID, ProductName , CategoryID, UnitPrice FROM Products WHERE CategoryID=" + id;

            //Eğer yukarıdaki sorguya '' OR 1=1 -- yazılırsa SQLINJECTION gerçekleşmiş olur

            //baglantı.Open();

            //SqlDataReader okuyucu = komut.ExecuteReader();

            //while(okuyucu.Read())
            //{
            //    int urunid = okuyucu.GetInt32(0);
            //    string urunisim = okuyucu.GetString(1);
            //    int katid = okuyucu.GetInt32(2);
            //    decimal fiyat = okuyucu.GetDecimal(3);
            //    Console.WriteLine($"{urunid} - {urunisim} - {katid} - {fiyat} TL");
            //}
            //baglantı.Close();
            //// ' ' OR 1=1 
            #endregion

            //SQL INJECTION 'dan korunmak için;
            //MUTLAKA Parametreli sorgu kullanılmalıdır

            #region Parametreli sorgular (Bundan sonra hep  bu kullanılacak)

            //Console.WriteLine("Ürünleri listelenecek kategori ID giriniz");
            //int kid = Convert.ToInt32(Console.ReadLine());
            ////string kid = Console.ReadLine();

            //SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=NORTHWND; Integrated Security=True");
            //SqlCommand komut = baglanti.CreateCommand();
            //komut.CommandText = "SELECT ProductID, ProductName,UnitPrice FROM Products WHERE CategoryID=@murtaza";
            //komut.Parameters.AddWithValue("@murtaza", kid);
            ////parametre eklemenin amacı SQL INJECTION'a karşı korumaktır

            //baglanti.Open();
            //SqlDataReader okuyucu = komut.ExecuteReader();
            //while(okuyucu.Read())
            //{
            //    int p_id = okuyucu.GetInt32(0);
            //    string p_isim = okuyucu.GetString(1);
            //    decimal p_fiyat = okuyucu.GetDecimal(2);
            //    Console.WriteLine($"{p_id}) {p_isim} - {p_fiyat} TL");
            //}
            //baglanti.Close();

            #endregion

            #region Kategori Güncelleyelim

            ////Öncelikle kategorileri listeleyelim ki  kullanıcı güncellemek istediği kategoriyi seçebilsin

            //SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=NORTHWND; Integrated Security=True");
            //SqlCommand komut =  baglanti.CreateCommand();
            //komut.CommandText = "SELECT CategoryID, CategoryName, Description FROM Categories";
            //baglanti.Open();
            //SqlDataReader okuyucu = komut.ExecuteReader();
            //while (okuyucu.Read())
            //{
            //    int kategroiID = okuyucu.GetInt32(0);
            //    string kategoriIsim = okuyucu.GetString(1);
            //    string kategoriAciklama = okuyucu.GetString(2);
            //    Console.WriteLine($"{kategroiID}) {kategoriIsim} - {kategoriAciklama}");
            //}
            //okuyucu.Close();
            //Console.WriteLine("Bilgilerini güncellemek istediğiniz kategorinin numarasını giriniz");
            //int katno = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Kategori adı giriniz");
            //string k_adi = Console.ReadLine();

            //Console.WriteLine("Açıklama");
            //string k_aciklama = Console.ReadLine();

            //komut.CommandText = "UPDATE Categories SET CategoryName=@cn, Description=@d WHERE CategoryID=@id";
            //komut.Parameters.AddWithValue("@id", katno);
            //komut.Parameters.AddWithValue("@cn" , k_adi);
            //komut.Parameters.AddWithValue("@d" , k_aciklama);
            ////Açık oolan bağlantıyı tekrardan açıyoruz

            //komut.ExecuteNonQuery();
            //Console.WriteLine("Kategori Başarıyla Güncellendi");
            //baglanti.Close();



            //baglanti.Close();

            #endregion

            #region ödev 21.11.2024

            //SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=NORTHWND; Integrated Security=True");

            //SqlCommand komut = baglanti.CreateCommand();

            //komut.CommandText = "SELECT P.ProductID, P.ProductName, C.CategoryName, S.CompanyName, S.ContactTitle, S.ContactName, P.UnitPrice, P.UnitsInStock FROM Products AS P JOIN Suppliers AS S ON P.SupplierID = S.SupplierID JOIN Categories AS C ON P.CategoryID = C.CategoryID";

            //baglanti.Open();

            //SqlDataReader okuyucu = komut.ExecuteReader();

            //while (okuyucu.Read())
            //{
            //    int p_id = okuyucu.GetInt32(0);
            //    string p_isim = okuyucu.GetString(1);
            //    string cat_isim = okuyucu.GetString(2);
            //    string comp_isim = okuyucu.GetString(3);
            //    string cnt_title = okuyucu.GetString(4);
            //    string cnt_isim = okuyucu.GetString(5);
            //    decimal unit_fiyat = okuyucu.GetDecimal(6);
            //    int uInStock = okuyucu.GetInt16(7);
            //    Console.WriteLine($"{p_id}) {p_isim}, {cat_isim}, {comp_isim}, {cnt_title} {cnt_isim}, {unit_fiyat} TL, {uInStock} Stokta");
            //}

            //baglanti.Close();
            #endregion

            #region Ürün Listeleme - JOIN yok

            //SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=NORTHWND; Integrated Security=True");
            //SqlCommand komut = baglanti.CreateCommand();

            //komut.CommandText = "SELECT ProductID, ProductName, CategoryID, SupplierID, UnitsInStock, UnitPrice FROM Products";

            //baglanti.Open();
            //SqlDataReader okuyucu = komut.ExecuteReader();

            //while (okuyucu.Read())
            //{
            //    int ID = okuyucu.GetInt32(0);
            //    string urunisim = okuyucu.GetString(1);
            //    int KategoriID = okuyucu.GetInt32(2);
            //    int TedarikciID = okuyucu.GetInt32(3);
            //    short StokMiktari = okuyucu.GetInt16(4);
            //    decimal UrunFiyat = okuyucu.GetDecimal(5);
            //    Console.WriteLine("*-*-*-*-*-*-*-*");
            //    Console.WriteLine("No = " + ID);
            //    Console.WriteLine("İsim = " + urunisim );
            //    Console.WriteLine("Kategori = " + KategoriID);
            //    Console.WriteLine("Tedarikçi = " + TedarikciID);
            //    Console.WriteLine("Stok Miktarı = " + StokMiktari);
            //    Console.WriteLine("Fiyat = " + UrunFiyat +  " TL ");
            //    Console.WriteLine("");
            //}
            //baglanti.Close();
            #endregion

            #region Ürün Listeleme JOIN VAR

            


            #endregion
        }
    }
}
