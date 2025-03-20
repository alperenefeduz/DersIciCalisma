using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriErişimKatmani
{
    public class Tur
    {
        //ENTITY MODEL YAKLAŞIMI
        //Veri tabanındakş tabloların içindeki satır verinin c# kısmında nesne olarak kullanılmasını sağlamak amacıyla her tablonun sınıf karşılığını oluşturuyoruz.
        //Veriler Dağınık bir şekilde değil Sınınf nesnesi olarak taşındığı için cleanCode yapısına uygun kodlama yapmış oluruz
        public int ID {  get; set; } //prop TAB yazarak kısayol olur.
        public string Isim { get; set; }
    }
}
