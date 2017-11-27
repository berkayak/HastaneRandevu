<%@ Page Title="" Language="C#" MasterPageFile="~/MyMaster.Master" AutoEventWireup="true" CodeBehind="RandevuListele.aspx.cs" Inherits="WebApplication1.RandevuListele" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container-fluid">

        <div class="row" style="width: 150%;  height: 150%; background-color: #05C0E4; opacity: 0.8; border-radius: 40px; border-width: 3px; border-color: #05C0E4">
            <div class="col-md-10" style="text-align: center">
                <asp:GridView ID="GridView1" runat="server" CellPadding="3" BorderWidth="1px" style="margin:30px;" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None">
                    <FooterStyle BackColor="White" ForeColor="#000066" />
                    <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                    <RowStyle ForeColor="#000066" />
                    <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#007DBB" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#00547E" />
                </asp:GridView>
                <asp:TextBox ID="TextBox1" runat="server" BorderWidth="2" Height="30px" Placeholder="Aranacak TC..." Width="180px" CssClass="TextBox1"></asp:TextBox>
                <asp:Button ID="Button1" runat="server" OnClick="btnAra_Click" Text="Ara" Height="32px" Width="80px" CssClass="SimpleButton1" />
            </div>
        </div>
    </div>


</asp:Content>
