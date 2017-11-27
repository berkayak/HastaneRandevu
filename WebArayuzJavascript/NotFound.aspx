<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NotFound.aspx.cs" Inherits="WebArayuzJavascript.NotFound" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sayfa Bulunamadı</title>
    <script src="zHospital/js/jquery.min.js"></script>
</head>
<body style="text-align: center">
    <form id="form1" runat="server">
        <div>

            <img src="zHospital/images/notfound.png" style="width: 50%; height: 50%" />
            <h1 style="font-family: Verdana; color: #808080">Aradğınız Sayfayı Bulamadık</h1>
        </div>
    </form>
    <script>
        $(document).ready(function () {
            window.setTimeout(function () {
                window.location.href = 'Giris.aspx';
            }, 5000);
        });
    </script>
</body>
</html>
