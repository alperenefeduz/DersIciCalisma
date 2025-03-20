using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HtmlCssAspNET.AspKontrolleri
{
    public partial class Uygulama : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            VeriModel db = new VeriModel();
            protected void Page_Load(object sender, EventArgs e)

        }

        protected void btn_girisyap_Click(object sender, EventArgs e)
        {
            {

                string isim = tb_isim.Text;
                string sifre = tb_sifre.Text;

                if (db.GirisKontrol(isim, sifre))
                {
                    lbl_bilgi.Text = "Giriş Başarılı";
                }
                else
                {
                    lbl_bilgi.Text = "Giriş Başarısız";
                }

            }
        }
}