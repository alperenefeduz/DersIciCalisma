using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace NORTHWNDileWINforms
{
    public partial class KategoriIslemleri : Form
    {
        public KategoriIslemleri()
        {
            InitializeComponent();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            //tb_isim isimli textbox'ın text kısmı boş değil ise
            //Kategori adı NULL veri kabul etmediği için boş olup olmadığını kontrol ettik
            if (!string.IsNullOrEmpty(tb_isim.Text))
            {
                SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=NORTHWND; Integrated Security=True");
                SqlCommand komut = new SqlCommand();
                komut.CommandText = "";
            }
            else
            {
                MessageBox.Show("Kategori Adı Boş Bırakılamaz ", "Boş Veri Algılandı");
            }
        }
    }
}
