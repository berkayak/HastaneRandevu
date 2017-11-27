<%@ Page Title="" Language="C#" MasterPageFile="~/MyMaster.Master" AutoEventWireup="true" CodeBehind="PoliklinikEkle.aspx.cs" Inherits="WebApplication1.PoliklinikEkle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style5 {
            width: 364px;
        }

        .td {
            text-align: left;
        }

        .auto-style6 {
            text-align: left;
            width: 206px;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />

    <div class="container-fluid">

        <div class="row" style="width: 80%; height: 110%; background-color: #05C0E4; opacity: 0.8; border-radius: 40px; border-width: 3px; border-color: #05C0E4">
            <div class="col-md-10" style="text-align: center">
                <h1 style="opacity: 0.5; font-size: 30px;">Poliklinik İşlemleri</h1>
            </div>
            <div class="col-md-5" style="margin-top: 20px; margin-left: 30px;">
                <asp:DropDownList ID="cbIller" runat="server" AutoPostBack="True" Height="30px" Style="margin: 5px;" Width="180px" OnSelectedIndexChanged="cbIller_SelectedIndexChanged" CssClass="DropDrownList1">
                </asp:DropDownList>

                <asp:DropDownList ID="cbIlce" runat="server" AutoPostBack="True" Height="30px" Style="margin: 5px;" Width="180px" OnSelectedIndexChanged="cbIlce_SelectedIndexChanged" CssClass="DropDrownList1">
                </asp:DropDownList>

                <asp:DropDownList ID="cbHastaneler" runat="server" Height="30px" Width="180px" Style="margin: 5px;" AutoPostBack="True" OnSelectedIndexChanged="cbHastaneler_SelectedIndexChanged" CssClass="DropDrownList1">
                </asp:DropDownList>

                <asp:TextBox ID="txtPoliklinik" runat="server" Width="180px" Height="30px" Style="margin: 5px;" PlaceHolder="Poliklinik Adı..." CssClass="TextBox1"></asp:TextBox>

                <asp:Button ID="btnKaydet" runat="server" OnClick="btnKaydet_Click" Text="Kaydet" Width="180px" Style="margin: 5px; margin-bottom: 20px" CssClass="SimpleButton1" Height="35px" />


            </div>
            <div class="col-md-5" style="margin-top: 25px">
                <asp:ListBox ID="lbPoliklinikler" runat="server" AutoPostBack="True" Width="180px" OnSelectedIndexChanged="lbPoliklinikler_SelectedIndexChanged" Style="margin: 5px;" CssClass="ListBox1"></asp:ListBox>
                <asp:Button ID="btnSil" runat="server" Text="Sil" Width="60px" OnClick="btnSil_Click" CssClass="SimpleButton1" Style="margin: 5px;" />
                <asp:Button ID="btnGuncelle" runat="server" Text="Güncelle" Width="120px" OnClick="btnGuncelle_Click" Style="margin: 5px;" CssClass="SimpleButton1" />
            </div>
        </div>
    </div>
</asp:Content>
