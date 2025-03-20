using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HtmlCssAspNET.AspKontrolleri
{
    public partial class TextBoxKontrolleri : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_gonder_Click(object sender, EventArgs e)
        {
            //Textboxa yazılan metni (tb_isim.Text) Label'in metnin kısmına (lbl_isim.text)atadık
            lbl_isim.Text = "Merhaba " + tb_isim.Text;
        }

        protected void btn_topla_Click(object sender, EventArgs e)
        {
            int s1 = Convert.ToInt32(tb_sayi1.Text);
            int s2 = Convert.ToInt32(tb_sayi2.Text);

            int toplam = s1 + s2;

            tb_sonuc.Text = Convert.ToString(toplam);
        }
    }
}