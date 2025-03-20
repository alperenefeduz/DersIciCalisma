<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Uygulama.aspx.cs" Inherits="HtmlCssAspNET.AspKontrolleri.Uygulama" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Giriş Sayfası</title>
    <style>
        body {
            background-color: #efefef;
        }

        .matrax {
            width: 1000px;          
            background-color: white;
            margin-left: auto;
            margin-right: auto;
            margin-top: 150px;
        }

        .soltaraf {
            width: 460px;
            height: 410px;
            padding: 20px;
            float: left;
        }

        .soltaraf h1 {
            margin-left: 5px;
            margin-bottom: 30px;
        }

        .soltaraf label {
            font-weight: 700;
        }

        .sagtaraf {
            width: 460px;
            height: 410px;
            padding: 20px;
            background-color: midnightblue;
            float: left;
            text-align:center;
            color:white;
        }

        .satir {
            display: flex;
            justify-content: center;
            align-items: start;
            flex-direction: column;
            height: 100px;
            width: auto;
            
        }

        .satir label {
            margin-bottom: 10px;
        }

        .metinkutu {
            border-radius: 25px;
            width: 250px;
            height: 20px;
            border: 1px solid gray;
        }

        .GirisButon {
            width:75%;
            height:35px;
            background-color: midnightblue;
            color: white;
            font-size: 15pt;
            border: none;
            cursor: pointer;
            border-radius: 25px;
            margin-left:50px
        }

        .GirisButon:hover {
            background-color: lightslategrey;
        }
        .KayitOlButon {
           
           
            color: white;
            border:2px white solid;
            font-size: 15pt;
           padding:10px 45px;
           text-decoration:none;
            cursor: pointer;
            border-radius: 25px;

        }
    </style>
</head>
<body>
    <form id="form2" runat="server">
        <div class="matrax">
            <div class="soltaraf">
                <h1>Giriş Yap</h1>
                <div class="satir">
                    <label>Kullanıcı Adı</label>
                    <asp:TextBox ID="tb_isim" runat="server" class="metinkutu"></asp:TextBox>
                </div>
                <div class="satir">
                    <label>Şifre</label>
                    <asp:TextBox ID="tb_sifre" runat="server" class="metinkutu"></asp:TextBox>
                </div>
                                <asp:Label ID="lbl_bilgi" runat="server"></asp:Label>

                <div class="satir">
                    <asp:Button ID="btn_girisyap" runat="server" class="GirisButon" Text="Giriş Yap" OnClick="btn_girisyap_Click1"         />
            </div>
                            <div class="satir">

            </div>
            </div>
            <div class="sagtaraf">
                <h1 style="margin-top:120px">Giriş Sayfasına Hoşgeldiniz </h1>
                <h3>Hesabın yok mu?</h3>
                <asp:LinkButton ID="btn_kayitol" runat="server" class="KayitOlButon">Kayıt Ol</asp:LinkButton>
            </div>
            <div style="clear:both"></div>
        </div>
    </form>
</body>
</html>
