<%@ Page Title="" Language="C#" MasterPageFile="~/MyMaster.Master" AutoEventWireup="true" CodeBehind="RandevuAl.aspx.cs" Inherits="WebApplication1.RandevuAl" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
    <br />
    <br />

    <div class="container-fluid">

        <div class="row" style="width:40%; height: 350px; background-color: #05C0E4; opacity: 0.8; border-radius:40px; border-width:3px; border-color:#05C0E4">
            <div class="col-md-12" style=" text-align:center">
                
            </div>
        <!--    <div class="col-md-5" style="margin-top: 25px; margin-left: 30px;">
                <asp:TextBox ID="txtAd" runat="server" Width="180px" Style="margin: 5px" CssClass="TextBox1" placeholder="Adınız..."></asp:TextBox>

                <asp:TextBox ID="txtSoyad" runat="server" Width="180px" Style="margin: 5px" CssClass="TextBox1" placeholder="Soyadınız..."></asp:TextBox>

                <asp:TextBox ID="txtTC" runat="server" Width="180px" MaxLength="11" Style="margin: 5px" CssClass="TextBox1" placeholder="TC Kimlik Numarası..."></asp:TextBox>

                <asp:TextBox ID="txtEMail" runat="server" Width="180px" Style="margin: 5px" CssClass="TextBox1" placeholder="E-Mailiniz..."></asp:TextBox>

                <asp:DropDownList ID="DropDownList1" runat="server" Width="40px" Style="margin-left: 5px" CssClass="DropDrownList1">
                </asp:DropDownList>

                <asp:DropDownList ID="DropDownList2" runat="server" Width="65px" CssClass="DropDrownList1">
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

                <asp:DropDownList ID="DropDownList3" runat="server" Width="55px" CssClass="DropDrownList1">
                </asp:DropDownList>

                <asp:DropDownList ID="cbCinsiyet" runat="server" Width="180px" CssClass="DropDrownList1" Style="margin-left: 5px; margin-top: 5px;">
                    <asp:ListItem>Erkek</asp:ListItem>
                    <asp:ListItem>Kadın</asp:ListItem>
                </asp:DropDownList>

            </div>
-->
            <div class="col-md-5" style="margin-left:10%; margin-top:7.15%">
                <h2 style="opacity: 0.5; ruby-align:center; text-align:center">Poliklinik Seçimi</h2>
                <asp:DropDownList ID="cbIl" runat="server" Style="margin: 5px;" CssClass="DropDrownList1" OnSelectedIndexChanged="cbIl_SelectedIndexChanged" Width="180px" AutoPostBack="True">
                </asp:DropDownList>

                <asp:DropDownList ID="cbIlce" runat="server" Style="margin: 5px;" CssClass="DropDrownList1" OnSelectedIndexChanged="cbIlce_SelectedIndexChanged" Width="180px" AutoPostBack="True">
                </asp:DropDownList>

                <asp:DropDownList ID="cbHastane" runat="server" Style="margin: 5px;" CssClass="DropDrownList1" OnSelectedIndexChanged="cbHastane_SelectedIndexChanged" Width="180px" AutoPostBack="True">
                </asp:DropDownList>

                <asp:DropDownList ID="cbPoliklinik" runat="server" Style="margin: 5px;" CssClass="DropDrownList1" OnSelectedIndexChanged="cbPoliklinik_SelectedIndexChanged" Width="180px" AutoPostBack="True">
                </asp:DropDownList>

                <asp:DropDownList ID="cbRandevuSaati" runat="server" Style="margin: 5px;" Width="180px" AutoPostBack="True" CssClass="DropDrownList1">
                </asp:DropDownList>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Kaydet" Width="185px" Height="35px" Style="margin: 5px; opacity:1" CssClass="SimpleButton1" />
            </div>
        </div>
    </div>

</asp:Content>

