<%@ Page Title="" Language="C#" MasterPageFile="~/MainLayout.Master" AutoEventWireup="true" CodeBehind="Doktorlar.aspx.cs" Inherits="WebArayuzJavascript.Doktorlar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="zHospital/js/jquery.min.js"></script>
    <style type="text/css">
        #bilgiKutusu {
            font-family: 'Courier New';
            font-size: 16px;
            color: #a50000;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <form>
            <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePageMethods="true"></asp:ScriptManager>
            <table style="background-color: #0094ff; opacity: 0.7; padding: 20px; border-radius: 10px">
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
                        <select id="doktorlar" class="DropDrownList1" style="width: 180px">
                            <option value='" + -1 + "'>---Doktor Seçimi---</option>
                        </select>
                    </td>
                </tr>
                <tr>
                    <td>
                        <input id="txtDoktorAdi" type="text" name="txtDoktorAdi" placeholder="Doktor Adi..." class="TextBox1" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <input id="txtDoktorSoyadi" type="text" name="txtDoktorSoyadi" placeholder="Doktor Soyadi..." class="TextBox1" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <input id="btnKaydet" type="button" name="Kaydet" value="Kaydet" class="SimpleButton1" style="width: 180px;" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <input id="btnSil" type="button" name="Kaydet" value="Sil" class="SimpleButton1" style="width: 180px;" />
                    </td>
                </tr>
            </table>
            <div id="bilgiKutusu" style="background-color: #0094ff; opacity: 0.7; padding: 20px; border-radius: 10px; width:190px;" hidden="hidden"></div>
        </form>
        <br />
        
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
                sonucMesaji("iller Yüklenirken hata oluştu");
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
                sonucMesaji("ilceler Yüklenirken hata oluştu");
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
                sonucMesaji("hastaneler Yüklenirken hata oluştu");
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
                sonucMesaji("poliklinikler Yüklenirken hata oluştu");
            });
        });

        $("#poliklinikler").change(function () {
            $("#doktorlar").empty();
            $("#doktorlar").append("<option value='" + -1 + "'>---Doktor Seçimi---</option>");
            var poliklinikID = $("#poliklinikler").val();
            PageMethods.doktorGetir(poliklinikID, function (data) {
                var liste = JSON.parse(data);
                for (var i in liste)
                    $("#doktorlar").append("<option value='" + liste[i].ID + "'>" + liste[i].Ad + ' ' + liste[i].Soyad + "</option>");
            }, function () {
                sonucMesaji("doktorlar Yüklenirken hata oluştu");
            });
        });

        $("#btnKaydet").click(function () {
            PageMethods.doktorKaydet($("#txtDoktorAdi").val(), $("#txtDoktorSoyadi").val(), $("#poliklinikler").val(), $("#doktorlar").val(), function (data) {
                if (data == true) {
                    $("#txtDoktorAdi").val("");
                    $("#txtDoktorSoyadi").val("");
                    sonucMesaji("Bilgiler Kaydedildi");
                }
            }, function () {
                sonucMesaji("Hata!");
            });
        });

        function sonucMesaji(mesaj) {
            $("#bilgiKutusu").show();
            $("#bilgiKutusu").html(mesaj).delay(5000).slideUp(1000);
        }
    </script>
</asp:Content>
