<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OgrenciKayitSistemi.aspx.cs" Inherits="HtmlCssAspNET.AspKontrolleri.OgrenciKayitSistemi" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> Öğrenci Kayıt Sistemi </title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <label>Öğrenci İsim= </label>
            <asp:TextBox ID ="tb_isim" runat="server"></asp:TextBox><br />

            <label>Öğrenci Soyisim= </label>
            <asp:TextBox ID ="tb_soyisim" runat="server"></asp:TextBox><br />

            <label>Sınıf= </label>
            <asp:TextBox ID ="tb_sinif" runat="server"></asp:TextBox><br />

            <label>Şube= </label>
            <asp:TextBox ID ="tb_sube" runat="server"></asp:TextBox><br />

            <asp:Label ID="lbl_isim" runat="server"></asp:Label><br />
            <asp:Label ID="lbl_soyisim" runat="server"></asp:Label><br />
            <asp:Label ID="lbl_sinif" runat="server"></asp:Label><br />
            <asp:Label ID="lbl_sube" runat="server"></asp:Label><br />

            <asp:Button ID="btn_gonder" runat="server" Text="Gönder" OnClick="btn_gonder_Click" />
        </div>
    </form>
</body>
</html>
