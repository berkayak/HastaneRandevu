<%@ Page Title="" Language="C#" MasterPageFile="~/MyMaster.Master" AutoEventWireup="true" CodeBehind="UyelikBilgileri.aspx.cs" Inherits="WebApplication1.UyelikBilgileri" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row" style="text-align: center">
        <div class="col-md-6" style="width: 50%; opacity: 0.8; background-color: #05C0E4; border-radius: 40px; margin-top: 25px;">
            <h1 style="text-align: center; opacity: 0.5">Bilgileriniz</h1>

            <asp:TextBox ID="txtAd" runat="server" Width="200px" Style="margin: 5px" CssClass="TextBox1" placeholder="Adınız..."></asp:TextBox>
            <asp:TextBox ID="txtSoyad" runat="server" Width="200px" Style="margin: 5px" CssClass="TextBox1" placeholder="Soyadınız..."></asp:TextBox>

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
            <asp:Button ID="btnKaydet" runat="server" Text="Kaydet" style="margin:10px;" CssClass="SimpleButton1" Width="180px" />
        </div>
    </div>

</asp:Content>
