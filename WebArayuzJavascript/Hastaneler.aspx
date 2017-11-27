<%@ Page Title="" Language="C#" MasterPageFile="~/MainLayout.Master" AutoEventWireup="true" CodeBehind="Hastaneler.aspx.cs" Inherits="WebArayuzJavascript.Hastaneler" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="zHospital/js/jquery.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <form>
            <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePageMethods="true"></asp:ScriptManager>
            <table style="background-color: #0094ff; opacity: 0.7; float: left; padding: 20px; border-radius: 10px">
                <tr>
                    <td>
                        <select id="iller" class="DropDrownList1" style="width: 180px">
                            <option value='" + -1 + "'>---İl Seçimi---</option>
                        </select>
                    </td>
                </tr>
                <tr>
                    <td>
                        <select id="ilceler" class="DropDrownList1" style="width: 180px">
                            <option value='" + -1 + "'>---İlçe Seçimi---</option>
                        </select>
                    </td>
                </tr>
                <tr>
                    <td>
                        <select id="hastaneler" class="DropDrownList1" style="width: 180px">
                            <option value='" + -1 + "'>---Hastane Seçimi---</option>
                        </select>
                    </td>
                </tr>
                <tr>
                    <td>
                        <input id="txtHastaneAdi" type="text" name="txtHastaneAdi" placeholder="Hastane Adi..." class="TextBox1" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <input id="btnKaydet" type="button" name="randevuKaydet" value="Kaydet" class="SimpleButton1" style="width: 180px;" />
                    </td>
                </tr>
            </table>
        </form>
    </div>

    <script>

        $(document).ready(function () {
            $("#iller").empty();
            $("#iller").append("<option value='" + -1 + "'>---İl Seçimi---</option>");
            PageMethods.ilGetir(function (data) {
                var liste = JSON.parse(data);
                for (var i in liste)
                    $("#iller").append("<option value='" + liste[i].ID + "'>" + liste[i].Adi + "</option>");
            }, function () {
                alert("İller yüklernirken hata oluştu");
            });
        });

        $("#iller").change(function () {
            $("#ilceler").empty();
            $("#ilceler").append("<option value='" + -1 + "'>---İlce Seçimi---</option>");
            var ilID = $("#iller").val();
            PageMethods.ilceGetir(ilID, function (data) {
                var liste = JSON.parse(data);
                for (var i in liste)
                    $("#ilceler").append("<option value='" + liste[i].ID + "'>" + liste[i].Adi + "</option>");
            }, function () {
                alert("ilceler yüklenirken bir hata oluştu");
            });
        });

        $("#ilceler").change(function () {
            $("#hastaneler").empty();
            $("#hastaneler").append("<option value='" + -1 + "'>---Hastane Seçimi---</option>");
            var ilceID = $("#ilceler").val();
            PageMethods.hastaneGetir(ilceID, function (data) {
                var liste = JSON.parse(data);
                for (var i in liste)
                    $("#hastaneler").append("<option value='" + liste[i].ID + "'>" + liste[i].Adi + "</option>");
            }, function () {
                alert("hastaneler yüklenirken bir hata oluştu");
            });
        });

        $("#btnKaydet").click(function () {
            PageMethods.hastaneKaydet($("#txtHastaneAdi").val(), $("#iller").val(), $("#ilceler").val(), $("#hastaneler").val(), function() {
                alert("Bilgiler Kaydedildi");
                $("#txtHastaneAdi").val("");
            }, function () {
                alert("Hata Oluştu");
            });
        });
    </script>
</asp:Content>
