<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ButtonKontrolu.aspx.cs" 
    Inherits="HtmlCssAspNET.AspKontrolleri.ButtonKontrolu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Button Kontrolü</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Asp Nedir Nasıl Kullanılır</h1>
            <p>Asp(Active Server Page) Browser tabanlı yazılanlar üretmek için kullanılan server side yazılım yapısıdır. kodların tamamı sunucuda derlenip, HTML formatında istemci bilgisayara (Client) gönderilir. Button gibi kontroller ile etkileşime girmeye <b>POST</b>. Verilerin sunucudan istemciye dönmesine (GET/BACK) denir. POST-BACK yapısıyla çalışır. Asp sayfamızı çalıştırdığımızda local bilgisayarımızda localhost isminde ISS(Internet Inforöation Services) yapısı çalışır</p>
            <p>Asp sayfaları .aspx ve .aspx.cs olmak üzere 2 kısımdan oluşur. .aspx html css asp kodlarını barındırıp satfada görsel öğelerin hazırlanmasını sağlar. .aspx.cs ise adından da anlaşılacağı gibi bir c# sınıfıdır. ve c# kodlarını bu alanda barındırır. </p>
            <p> ASP kontrollerini başında asp: belirteci bulunur. <b> Tüm ASP kontrolleri runat="server" attributuna sahip olmak zorundadır. run-at=Server yani sunucuda çalıştır şeklinde yorumlanabilir. ID tanımlaması da zorunludur. ID tanımlanan kontrolün adını belirler böylece CodeBehind(aspx.cs) kısmında kontrole ID'si ile erişilebilir</b></p>

            <asp:Button ID="btn_tikla" runat="server" Text="Tikla" OnClick="btn_tikla_Click" />
            <p> Butona tıklanınca yapılacak olan işlemler OnClick event'i ile tanımlanır. OnClick event'i tanımlanınca event adını kendimiz yazmıyoruz asp bunu otomatik olarak oluşturur.
            </p>
        </div>
    </form>
</body>
</html>
