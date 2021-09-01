<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Modificacion.aspx.cs" Inherits="ASPNET_COMMAND_SQL.WEBFORMS.Modificacion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="height: 111px; margin-top: 48px">
    <form id="form1" runat="server">
        <div class="hyperLink">
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/WEBFORMS/Alta.aspx">ALTA DE USUARIO</asp:HyperLink>
            <br />
            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/WEBFORMS/Baja.aspx">BAJA DE USUARIO</asp:HyperLink>
            <br />
            <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/WEBFORMS/Consulta.aspx">CONSULTA DE USUARIO</asp:HyperLink>
            <br />
            <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/WEBFORMS/Modificacion.aspx">MODIFICACION DE USUARIO</asp:HyperLink>
       </div>
           
    </form>
</body>
</html>
