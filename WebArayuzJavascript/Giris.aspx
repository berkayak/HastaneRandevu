<%@ Page Title="" Language="C#" MasterPageFile="~/MainLayout.Master" AutoEventWireup="true" CodeBehind="Giris.aspx.cs" Inherits="WebArayuzJavascript.Giris" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="zHospital/js/jquery.min.js"></script>
    <style>
        td {
            padding: 5px;
        }

       .girisDiv{
            border-radius: 15px;
            padding: 10px;

        }

        h2 {
            color: #bde7ff;
            text-align: center;
            margin-top:10px;
        }
            h2:hover {
            cursor:pointer;
            }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="girisDiv" style="background-color: #0094ff; opacity: 0.7; float: left;">
        <h2>Giriş</h2>
        <table>
            <form>
                <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePageMethods="true"></asp:ScriptManager>
                <tr>
                    <td>
                        <input id="txtUserName" type="text" placeholder="TC giriniz..." class="TextBox1" required />
                    </td>
                </tr>
                <tr>
                    <td>
                        <input id="txtPassword" type="password" placeholder="Sifre Giriniz..." class="TextBox1" required />
                    </td>
                </tr>
                <tr>
                    <td>
                        <input id="btnLogin" type="submit" value="Giriş" class="SimpleButton1" />
                    </td>
                </tr>
            </form>
        </table>
    </div>
    <div class="girisDiv" style="background-color: #0094ff; opacity: 0.7; float: left; margin-left: 10%">
        <h2>Kayıt Ol</h2>
        <form>
            <table>
                <tr>
                    <td>
                        <input id="txtUyeAdi" type="text" placeholder="Adınız..." class="TextBox1" required />
                    </td>
                    <td>
                        <input id="txtUyeSoyadi" type="text" placeholder="Soyadınız..." class="TextBox1" required />
                    </td>
                </tr>
                <tr>
                    <td>
                        <input id="txtUyeTC" type="text" placeholder="TC no..." class="TextBox1" required />
                    </td>
                    <td>
                        <input id="txtUyeMail" type="text" placeholder="Mail..." class="TextBox1" required />
                    </td>
                </tr>
                <tr>
                    <td>
                        <input id="txtUyeSifre" type="password" placeholder="Sifre Giriniz..." class="TextBox1" required />
                    </td>
                    <td>
                        <input id="txtUyeDogum" type="date" class="TextBox1" style="width: 160px" required />
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <input id="btnKayitOl" type="submit" value="Kayıt Ol" class="SimpleButton1" />
                    </td>
                </tr>
            </table>
            <div id="bilgiKutusu" style="background-color: #0094ff; opacity: 0.7; padding: 5px; border-radius: 10px; width: 190px; float: left" hidden="hidden"></div>
        </form>
    </div>

    <script>
        $("#btnLogin").click(function () {
            var Username = $("#txtUserName").val();
            var Password = $("#txtPassword").val();
            PageMethods.GirisYap(Username, Password,
                function (val) {
                    if (val == true) {
                        window.location = 'RandevuAl.aspx';
                    }
                    else
                        sonucMesaji("Giris Yapılamadı");
                },
                function () {
                    sonucMesaji("Bir Hata Gerçekleiti");
                });
            //$.ajax({
            //    url: "Giris.aspx/GirisYap",
            //    method: "get",
            //    contentType: "application/json; charset=utf-8",
            //    async: true,
            //    data: "{\"Username\":\"55544433322\",\"Password\":123}",
            //    dataType: "json",
            //    succces: function (data) {
            //        if (data == true)
            //            alert("aferin");
            //    },
            //    error: function (err) {
            //        alert("Error");
            //    }
            //});
        });

        $("#btnKayitOl").click(function () {
            var Name = $("#txtUyeAdi").val();
            var Surname = $("#txtUyeSoyadi").val();
            var Tc = $("#txtUyeTC").val();
            var Mail = $("#txtUyeMail").val();
            var Password = $("#txtUyeSifre").val();
            var Birthday = $("#txtUyeDogum").val();
            PageMethods.KayitOl(Name, Surname, Tc, Mail, Birthday, Password,
                function (val) {
                    if (val == true) {
                        sonucMesaji("Kayıt İşlemi Başarılı");
                    }
                },
                function () {
                    sonucMesaji("Bir hata oluştu");
                });
        });

        function sonucMesaji(mesaj) {
            $("#bilgiKutusu").show();
            $("#bilgiKutusu").html(mesaj).delay(5000).slideUp(1000);
        }

    </script>

</asp:Content>
