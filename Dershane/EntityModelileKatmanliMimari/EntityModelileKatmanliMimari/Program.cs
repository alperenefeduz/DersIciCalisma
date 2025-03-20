using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using VeriErişimKatmani;

namespace EntityModelileKatmanliMimari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Tanımlama

            //Solution içerisinde ihtiyaç duyduğumuz projeleri tutan yapıdır.
            //Her proje farklı bir amaca hizmet edebiliri.
            //Biz şimdiye kadar her solution içerisinde bir proje tipini kullandık
            //Yani her açışımızda proje Console Uygulaması ise ise sadece Console, proje masaüstü uygulaması ise Winform proje tipini kullandık
            //Şimdi ise veritbanı işlemleri için ayrı bir proje oluşturacağız. Oluşturduğumuz proje tek başına çalışma özelliği olmayan amacı dll oluşturmak olan classlibrary projesi olacaktır.
            //Oluşturulan her dll aslında şimdiye kadar projelerimizde kullandığımız                      using System.Collections.Generic. gibi birer dll olacaktır. yani kendi kütüphanemizi oluşturacağız.
            //Veritabanı işlemlerini dil içerisinde yazmak CleanCode yaklaşımını uygun kod yazmamızı sağlar.
            //Ayrıca oluşan dll kodlarımızı şifrelediği için Ado Kodlarmızı ve veritabanımızın güvenliğini arttırmış olacağız.

            #endregion

            #region ClassLibrary ekleme ve kullanımü

            //1. öncelikle solution'a sağ tıklayıp add=> new project => ClassLibrary(.net Framework) yolunu izleyerek sınıf kütüphanemizi solution'a ekliyoruz
            
            VeriIslem vi = new VeriIslem();

            #region Tür Ekleme

            //Console.WriteLine("Tür adını yazınız");
            //string turisim = Console.ReadLine();

            //if (vi.TurEkle(turisim))
            //{
            //    Console.WriteLine("Tür başarı ile eklendi");
            //}
            //else
            //{
            //    Console.WriteLine("Tür Eklenirken bir hata oluştu");
            //}

            #endregion

            #region Tür Ekleme - Entity Model

            //Tur t = new Tur();
            //Console.WriteLine("Tür Adı Giriniz");
            //t.Isim  = Console.ReadLine();

            //if (vi.TurEkleEntity(t))
            //{
            //    Console.WriteLine("Tür Ekleme Başarılı");
            //}
            //else
            //{
            //    Console.WriteLine("Tür Eklenirken bir hats oluştu");
            //}

            #endregion

            #region yazar ekleme - Entity

            //Yazar yazar = new Yazar();
            //Console.WriteLine("Yazar Adı = ");
            //yazar.Isim = Console.ReadLine();
            //Console.WriteLine("Yazar Soyisim = ");
            //yazar.Soyisim = Console.ReadLine();

            //bool eklendimi = vi.YazarEkle(yazar);
            //if ( eklendimi )
            //{
            //    Console.WriteLine("Yazar başarı ile eklendi");
            //}
            //else
            //{
            //    Console.WriteLine("Yazar eklenirken bir hata oluştu");
            //} 

            #endregion

            #region Yazar Güncelleme

            List<Yazar> yazarlar = vi.YazarListele();
            Console.WriteLine("*-*-*-*-*-*-*Yazarlar-*-*-*-*-*-*");
            for (int i = 0; i < yazarlar.Count; i++)
            {
                Console.WriteLine($"{yazarlar[i].ID}) {yazarlar[i].Isim} {yazarlar[i].Soyisim}");
            }

            Console.WriteLine("Lütfen güncellemek istediğiniz yazarın numarasını giriniz");
            int yazarNo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Yazar Adı = ");
            string ad = Console.ReadLine();

            Console.Write("Yazar Soyadı = ");
            string soyad = Console.ReadLine();

            Yazar yaz = new Yazar();  
            yaz.ID = yazarNo;
            yaz.Isim = ad;
            yaz.Soyisim = soyad;

            if (vi.YazarGüncelle(yaz))
            {
                Console.WriteLine("Güncelleme Başarılı");
            }
            else
            {
                Console.WriteLine("Güncelleme Başarısız");
            }

            #endregion

            #endregion
        }
    }
}
