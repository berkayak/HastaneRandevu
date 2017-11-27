<%@ Page Title="" Language="C#" MasterPageFile="~/MyMaster.Master" AutoEventWireup="true" CodeBehind="HastaneEkle.aspx.cs" Inherits="WebApplication1.HastaneEkle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .td {
            text-align: left;
        }

        .auto-style1 {
            width: 247px;
        }


        .auto-style2 {
            text-align: left;
            width: 232px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />

    <div class="container-fluid">

        <div class="row" style="width: 83%; height:110%; background-color: #05C0E4; opacity: 0.8; border-radius: 40px; border-width: 3px; border-color: #05C0E4">
            <div class="col-md-10" style="text-align: center">
                <h1 style="opacity: 0.5">Hastane İşlemleri</h1>
            </div>

            <div class="col-md-5" style="margin-top: 25px; margin-left: 30px;">
                <asp:DropDownList ID="cbIller" runat="server" OnSelectedIndexChanged="cbIller_SelectedIndexChanged" AutoPostBack="True" Height="30px" Style="margin: 5px" Width="180px" CssClass="DropDrownList1">
                </asp:DropDownList>

                <asp:DropDownList ID="cbIlce" runat="server" AutoPostBack="True" Height="30px" OnSelectedIndexChanged="cbIlce_SelectedIndexChanged" Style="margin: 5px" Width="180px" CssClass="DropDrownList1">
                </asp:DropDownList>

                <asp:TextBox ID="txtHastane" runat="server" Width="160px" CssClass="TextBox1" Style="margin: 5px" Placeholder="Hastane Adı..." Height="30px"></asp:TextBox>

                <asp:Button ID="btnKaydet" runat="server" OnClick="btnKaydet_Click" Text="Kaydet" Width="180px" Style="margin:5px; margin-bottom:15px" CssClass="SimpleButton1" Height="35px" />
                
                
            </div>
            <div class="col-md-5" style="margin-top:25px">
                <asp:ListBox ID="lbHastaneler" runat="server" AutoPostBack="True" Height="101px" OnSelectedIndexChanged="lbHastaneler_SelectedIndexChanged" Width="200px" Style="margin:5px" CssClass="ListBox1"></asp:ListBox>
                
                <asp:Button ID="btnSil" runat="server" OnClick="btnSil_Click" Text="Sil" Width="60px" CssClass="SimpleButton1" Style="margin:5px; margin-left:15px;" Height="30px" />
                
                <asp:Button ID="btnGuncelle" runat="server" OnClick="btnGuncelle_Click" Text="Güncelle" Width="110px" Style="margin:5px;" Height="30px" CssClass="SimpleButton1" />

            </div>


        </div>
    </div>

</asp:Content>
