using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HtmlCssAspNET.AspKontrolleri
{
    public partial class OgrenciKayitSistemi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_gonder_Click(object sender, EventArgs e)
        {
            lbl_isim.Text = tb_isim.Text;
            lbl_soyisim.Text = tb_soyisim.Text;
            lbl_sinif.Text = tb_sinif.Text;
            lbl_sube.Text = tb_sube.Text;
        }
    }
}