using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace VeriErisimKatmani
{
    public class VeriModel
    {
        SqlConnection con; SqlCommand cmd;
        public VeriModel() 
        {
            con = new SqlConnection(@"Data Source=AEDMONSTER26\\SQLEXPRESS; initial Catalog=ToplantiDB; Integrated Security = True");
            cmd = con.CreateCommand();
        }  
        public bool KatilimciEkle (Katilimci model)
        {
            try
            {
                cmd.CommandText = "INSERT INTO Katilimciler (Isim,Soyisim,Telefon,Yas) VALUES(@Isim,@Soyisim,@Telefon,@Yas)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@isim", model.Isim);
                cmd.Parameters.AddWithValue("@soyisim", model.Soyisim);
                cmd.Parameters.AddWithValue("@telefon", model.Telefon);
                cmd.Parameters.AddWithValue("@yas", model.Yas);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch 
            {

                return false;
            }
            finally 
            { 
                con.Close(); 
            }
        }
    }
}
