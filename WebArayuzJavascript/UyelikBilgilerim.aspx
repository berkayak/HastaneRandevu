<%@ Page Title="" Language="C#" MasterPageFile="~/MainLayout.Master" AutoEventWireup="true" CodeBehind="UyelikBilgilerim.aspx.cs" Inherits="WebArayuzJavascript.UyelikBilgilerim" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="zHospital/js/jquery.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <table style="background-color: #0094ff; opacity: 0.7; float: left">
            <tr>
                <td>
                    <input id="txtUyeAdi" type="text" placeholder="Adını..." class="TextBox1" />
                </td>
                <td>
                    <input id="txtUyeSoyadi" type="text" placeholder="Soyadınız..." class="TextBox1" />
                </td>
            </tr>
            <tr>
                <td>
                    <input id="txtUyeTC" type="text" placeholder="TC no..." class="TextBox1" />
                </td>
                <td>
                    <input id="txtUyeMail" type="text" placeholder="Mail..." class="TextBox1" />
                </td>
            </tr>
            <tr>
                <td>
                    <input id="txtUyeSifre" type="text" placeholder="Sifre Giriniz..." class="TextBox1" />
                </td>
                <td>
                    <input id="txtUyeDogum" type="date" class="TextBox1" style="width: 160px" />
                </td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <input id="btnKayitOl" type="button" value="Kayıt Ol" class="SimpleButton1" />
                </td>
            </tr>
        </table>
    </div>
    <script>
        $(document).ready(function () {
            
        });
    </script>
</asp:Content>
