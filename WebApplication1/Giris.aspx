<%@ Page Title="" Language="C#" MasterPageFile="~/MyMaster.Master" AutoEventWireup="true" CodeBehind="Giris.aspx.cs" Inherits="WebApplication1.Giris" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head"
    runat="server">
    <script src="zHospital/js/jquery.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid">

        <div class="row" style="width: 150%">

            <div class="col-md-4" style="width: 25%; opacity: 0.8; background-color: #05C0E4; border-radius: 40px; margin-top: 25px;">

                <h1 style="margin-left: 15%; opacity: 0.5">Giriş</h1>
                <form>
                    <asp:TextBox ID="txtTC" runat="server" Width="180px" Style="margin: 5px" CssClass="TextBox1" placeholder="TC Kimlik No..."></asp:TextBox>
                    <br />
                    <asp:TextBox ID="txtSifre" runat="server" Width="180px" Style="margin: 5px" CssClass="TextBox1" placeholder="Şifre(Opsiyonel)..."></asp:TextBox>
                    <asp:Button ID="Button1" runat="server" Text="Giriş" Height="30px" Width="180px" Style="margin: 20px" CssClass="SimpleButton1" OnClick="Button1_Click" />                    
                    <asp:ScriptManager ID="ScriptManager2" runat="server" EnablePageMethods="true"></asp:ScriptManager>
                </form>

            </div>
            <div class="col-md-6" style="width: 50%; opacity: 0.8; background-color: #05C0E4; border-radius: 40px; margin-left: 10%; margin-top: 25px;">
                <h1 style="text-align: center; margin-left: 30%; opacity: 0.5">Kayıt Ol</h1>
                <br />
                <asp:TextBox ID="txtAd" runat="server" Width="200px" Style="margin: 5px" CssClass="TextBox1" placeholder="Adınız..."></asp:TextBox>
                <asp:TextBox ID="txtSoyad" runat="server" Width="200px" Style="margin: 5px" CssClass="TextBox1" placeholder="Soyadınız..."></asp:TextBox>
                <br />
                <asp:TextBox ID="txtKayitTc" runat="server" Width="200px" MaxLength="11" Style="margin: 5px" CssClass="TextBox1" placeholder="TC Kimlik Numarası..."></asp:TextBox>
                <asp:TextBox ID="txtEMail" runat="server" Width="200px" Style="margin: 5px" CssClass="TextBox1" placeholder="E-Mailiniz..."></asp:TextBox>
                <br />                
                <asp:DropDownList ID="Gunler2" runat="server" Width="50px" Style="margin-left: 5px" CssClass="DropDrownList1">
                </asp:DropDownList>
                <asp:DropDownList ID="Aylar2" runat="server" Width="75px" CssClass="DropDrownList1">
                    <asp:ListItem Value="1">Ocak</asp:ListItem>
                    <asp:ListItem Value="2">Şubat</asp:ListItem>
                    <asp:ListItem Value="3">Mart</asp:ListItem>
                    <asp:ListItem Value="4">Nisan</asp:ListItem>
                    <asp:ListItem Value="5">Mayıs</asp:ListItem>
                    <asp:ListItem Value="6">Haziran</asp:ListItem>
                    <asp:ListItem Value="7">Temmuz</asp:ListItem>
                    <asp:ListItem Value="8">Ağustos</asp:ListItem>
                    <asp:ListItem Value="9">Eylül</asp:ListItem>
                    <asp:ListItem Value="10">Ekim</asp:ListItem>
                    <asp:ListItem Value="11">Kasım</asp:ListItem>
                    <asp:ListItem Value="12">Aralık</asp:ListItem>
                </asp:DropDownList>
                <asp:DropDownList ID="Yillar2" runat="server" Width="80px" CssClass="DropDrownList1">
                </asp:DropDownList>
                <asp:DropDownList ID="cbCinsiyet" runat="server" Width="200px" CssClass="DropDrownList1" Style="margin-left: 5px; margin-top: 5px;">
                    <asp:ListItem>Erkek</asp:ListItem>
                    <asp:ListItem>Kadın</asp:ListItem>
                </asp:DropDownList>
                <br />
                <asp:Button ID="btnUyeOl" runat="server" Text="Kayıt Ol" Height="30px" Width="180px" Style="margin-left: 30%; margin-top: 20px; margin-bottom: 20px" CssClass="SimpleButton1" OnClick="btnUyeOl_Click" />

            </div>
        </div>
    </div>
</asp:Content>
