<%@ Page Title="" Language="C#" MasterPageFile="~/MyMaster.Master" AutoEventWireup="true" CodeBehind="DoktorEkle.aspx.cs" Inherits="WebApplication1.DoktorEkle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .td {
            text-align: left;
        }

        .Grid {
            border: solid 1px Tan;
        }

            .Grid td {
                border: solid 3px #FFFFFF;
                margin: 3px 3px 3px 3px;
                font-family: Arial;
                padding: 5px 5px 5px 5px;
                text-align: center;
            }

        .auto-style1 {
            width: 244px;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="">
        <asp:HiddenField ID="hfGizliAlan" runat="server" />
        <asp:HiddenField ID="hfGizliAlan2" runat="server" />

        <div class="container-fluid">

            <div class="row" style="width: 100%; height: 80%; background-color: #05C0E4; opacity: 0.8; border-radius: 40px; border-width: 3px; border-color: #05C0E4">
                <div class="col-md-10" style="text-align: center">
                    <h1 style="opacity: 0.5; font-size: 30px;">Doktor İşlemleri</h1>
                </div>
                <div class="col-md-5" style="margin-top: 20px; margin-left: 30px;">
                    <asp:DropDownList ID="cbIller" runat="server" AutoPostBack="True" Style="margin:5px" Width="180px" OnSelectedIndexChanged="cbIller_SelectedIndexChanged" CssClass="DropDrownList1">
                    </asp:DropDownList>

                    <asp:DropDownList ID="cbIlce" runat="server" AutoPostBack="True" Style="margin:5px" Width="180px" OnSelectedIndexChanged="cbIlce_SelectedIndexChanged" CssClass="DropDrownList1">
                    </asp:DropDownList>

                    <asp:DropDownList ID="cbHastaneler" runat="server" Width="180px" Style="margin:5px" AutoPostBack="True" OnSelectedIndexChanged="cbHastaneler_SelectedIndexChanged" CssClass="DropDrownList1">
                    </asp:DropDownList>

                    <asp:DropDownList ID="cbPoliklinikler" runat="server" OnSelectedIndexChanged="cbPoliklinikler_SelectedIndexChanged" Style="margin:5px" Width="180px" CssClass="DropDrownList1">
                    </asp:DropDownList>

                </div>
                <div class="col-md-5" style="margin-top: 25px">
                    <asp:TextBox ID="txtDoktorAd" runat="server" Placeholder="Doktor Adı..." Width="180px" Style="margin:5px" CssClass="TextBox1"></asp:TextBox>

                    <asp:TextBox ID="txtDoktorSoyad" runat="server" Placeholder="Doktor Soyadı..." Width="180px" Height="30px" Style="margin:5px" CssClass="TextBox1"></asp:TextBox>

                    <asp:Button ID="btnKaydet" runat="server" Text="Kaydet" Width="90px" OnClick="btnKaydet_Click" Style="margin:5px" Height="35px" CssClass="SimpleButton1" />

                    <asp:Button ID="btnGuncelle" runat="server" Text="Güncelle" Width="90px" OnClick="btnGuncelle_Click" Height="35px" CssClass="SimpleButton1" Style="margin:5px" />

                </div>

                <div class="col-md-10">
                    <asp:GridView ID="dgDoktorlar" runat="server" OnRowCommand="dgDoktorlar_RowCommand" Style="margin:30px" BackColor="White" BorderColor="#0066ff" BorderWidth="1px" CellPadding="3" OnDataBound="dgDoktorlar_DataBound" BorderStyle="Solid">
                        <Columns>
                            <asp:ButtonField ButtonType="Button" CommandName="sil" Text="Sil">
                                <ControlStyle CssClass="SimpleButton1" />
                            </asp:ButtonField>
                            <asp:ButtonField ButtonType="Button" CommandName="duzenle" Text="Düzenle">
                                <ControlStyle CssClass="SimpleButton1" />
                            </asp:ButtonField>
                        </Columns>
                        <FooterStyle BackColor="White" ForeColor="#000066" />
                        <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                        <RowStyle ForeColor="#000066" />
                        <SelectedRowStyle BackColor="#669999" ForeColor="White" Font-Bold="True" />
                        <SortedAscendingCellStyle BackColor="#F1F1F1" />
                        <SortedAscendingHeaderStyle BackColor="#007DBB" />
                        <SortedDescendingCellStyle BackColor="#CAC9C9" />
                        <SortedDescendingHeaderStyle BackColor="#00547E" />
                    </asp:GridView>
                </div>
            </div>
        </div>

        <br />
    </div>
</asp:Content>

