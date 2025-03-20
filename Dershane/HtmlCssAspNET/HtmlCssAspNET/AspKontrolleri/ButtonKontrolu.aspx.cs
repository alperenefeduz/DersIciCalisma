using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HtmlCssAspNET.AspKontrolleri
{
    public partial class ButtonKontrolu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //sayfa yüklenmeden önce otomatik olarak çalışır
        }

        protected void btn_tikla_Click(object sender, EventArgs e)
        {
            //OnClick Event'i butona eklendikten sonra createNewEvent seçeneği ile bu fonskiyonun (btn_tıkla_Click) otomatik olarak oluşmasını sağladı
            btn_tikla.Text = "Evet Butona Tıkladınız";
        }
    }
}