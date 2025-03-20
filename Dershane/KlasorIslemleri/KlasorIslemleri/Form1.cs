using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace KlasorIslemleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTN_KlasorOlustur_Click(object sender, EventArgs e)
        {
            // Directory d = new Directory();

            // Klasör İşlemleri İçin Directory Sınıfı Tercih Edilir

            //Directory.CreateDirectory("Program Tarafından Oluşturuldu");
            //LBL_Mesaj.Text = "Oluşturuldu";

            // Eğer Yol Tanımlaması Yapılmaz İse Klasör .exe Dosyasının Olduğu Yere Oluşturulur

            string Path = "C:/Users/User/OneDrive/Desktop/ProgramTarafındanOluşturuldu";
            // Windows Form Uygulamalarında Dosya Yolu Kullanımı Önerilmez Çünkü Her Makinanın Kullanıcı Adı Farklıdır
            if (!Directory.Exists(Path))
            {
                Directory.CreateDirectory(Path);
                LBL_Mesaj.Text = "Oluşturuldu";
            }
            else
            {
                DateTime OlusturmaZamani = Directory.GetCreationTime(Path);
                DateTime SonErisimZamani = Directory.GetLastAccessTime(Path);
                DateTime SonKayitTarihi = Directory.GetLastWriteTime(Path);
                LBL_Mesaj.Text = $"Klasör Zaten Oluşturulmuş\nOluşturulma Tarihi = {OlusturmaZamani}\nSon Erişim Tarihi = {SonErisimZamani}\nSon Kayıt Tarihi = {SonKayitTarihi}";
            }
        }

        private void BTN_KlasorSil_Click(object sender, EventArgs e)
        {
            string Path = "C:/Users/User/OneDrive/Desktop/ProgramTarafındanOluşturuldu";
            //Directory.Delete(Path);
            // Eğer Ki Klasör Boş İse Silme İşlemini Gerçekleştirir
            Directory.Delete(Path, true);
            // Klasörün İçindekiler Dahil Olmak Üzere Hepsini Siler
            LBL_Mesaj.Text = "Silindi";
        }

        private void BTN_KlaroTasi_Click(object sender, EventArgs e)
        {
            string Path = "C:/Users/User/OneDrive/Desktop/ProgramTarafındanOluşturuldu";
            string NewPath = "C:/Users/User/OneDrive/Desktop/BurayaTasındı/ProgramTarafındanOluşturuldu";

            Directory.Move(Path, NewPath);
            LBL_Mesaj.Text = "Taşındı";
        }

        private void BTN_KlasorleriGetir_Click(object sender, EventArgs e)
        {
            string Path = "C:/Users/User/OneDrive/Desktop/ProgramTarafındanOluşturuldu";
            string[] Klasorler = Directory.GetDirectories(Path);
            string Liste = "";

            for (int i = 0; i < Klasorler.Length; i++)
            {
                Liste += $"{Klasorler[i]}\n";
            }

            LBL_Mesaj.Text = Liste;
        }

        private void BTN_DosyalariGetir_Click(object sender, EventArgs e)
        {
            string Path = "C:/Users/User/OneDrive/Desktop/ProgramTarafındanOluşturuldu";
            string[] Dosyalar = Directory.GetFiles(Path);
            string Liste = "";

            for (int i = 0; i < Dosyalar.Length; i++)
            {
                Liste += $"{Dosyalar[i]}\n";
            }

            LBL_Mesaj.Text = Liste;
        }

        private void BTN_DIKlasorOlustur_Click(object sender, EventArgs e)
        {
            string Path = "C:/Users/User/OneDrive/Desktop/ProgramTarafındanOluşturuldu";
            DirectoryInfo DI = new DirectoryInfo(Path);

            if (DI.Exists)
            {
                DateTime OlusturmaZamani = DI.CreationTime;
                DateTime SonErisimZamani = DI.LastAccessTime;
                DateTime SonKayitTarihi = DI.LastWriteTime;
                LBL_Mesaj.Text = $"Klasör Zaten Oluşturulmuş\nOluşturulma Tarihi = {OlusturmaZamani}\nSon Erişim Tarihi = {SonErisimZamani}\nSon Kayıt Tarihi = {SonKayitTarihi}";
            }
            else
            {
                DI.Create();
                LBL_Mesaj.Text = "Oluşturuldu";
            }
        }

        private void BTN_DIKlasorSil_Click(object sender, EventArgs e)
        {
            string Path = "C:/Users/User/OneDrive/Desktop/ProgramTarafındanOluşturuldu";
            DirectoryInfo DI = new DirectoryInfo(Path);

            if (DI.Exists)
            {
                DI.Delete(true);
                LBL_Mesaj.Text = "Silindi";
            }
            else
            {
                LBL_Mesaj.Text = "Klasör Bulunamadı";
            }
        }

        private void BTN_DIKlasorTasi_Click(object sender, EventArgs e)
        {
            string Path = "C:/Users/User/OneDrive/Desktop/ProgramTarafındanOluşturuldu";
            string NewPath = "C:/Users/User/OneDrive/Desktop/BurayaTasındı/ProgramTarafındanOluşturuldu";
            DirectoryInfo DI = new DirectoryInfo(Path);

            if (DI.Exists)
            {
                DI.MoveTo(NewPath);
                LBL_Mesaj.Text = "Taşındı";
            }
            else
            {
                LBL_Mesaj.Text = "Klasör Bulumadı";
            }
        }
    }
}
