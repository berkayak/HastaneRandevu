<%@ Page Title="" Language="C#" MasterPageFile="~/MainLayout.Master" AutoEventWireup="true" CodeBehind="Poliklinikler.aspx.cs" Inherits="WebArayuzJavascript.Poliklinikler" %>

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
                        <select id="poliklinikler" class="DropDrownList1" style="width: 180px">
                            <option value='" + -1 + "'>---Poliklinik Seçimi---</option>
                        </select>
                    </td>
                </tr>
                <tr>
                    <td>
                        <input id="txtPoliklinikAdi" type="text" name="txtHastaneAdi" placeholder="Poliklinik Adi..." class="TextBox1" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <input id="btnKaydet" type="button" name="Kaydet" value="Kaydet" class="SimpleButton1" style="width: 180px;" />
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

        $("#hastaneler").change(function () {
            $("#poliklinikler").empty();
            $("#poliklinikler").append("<option value='" + -1 + "'>---Poliklinik Seçimi---</option>");
            var hastaneID = $("#hastaneler").val();
            PageMethods.poliklinikGetir(hastaneID, function (data) {
                var liste = JSON.parse(data);
                for (var i in liste)
                    $("#poliklinikler").append("<option value='" + liste[i].ID + "'>" + liste[i].Adi + "</option>");
            }, function () {
                alert("poliklinikler yüklenirken hata oluştu");
            });
        });

        $("#btnKaydet").click(function () {
            PageMethods.poliklinikKaydet($("#txtPoliklinikAdi").val(), $("#hastaneler").val(), $("#poliklinikler").val(), function () {
                alert("Bilgiler Kaydedildi");
                $("#txtPoliklinikAdi").val("");
            }, function () {
                alert("Hata Oluştu");
            });
        });
    </script>
</asp:Content>
