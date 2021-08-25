<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="PrimerASP.NET.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link  rel="stylesheet" href="css/estilos.css" type="text/css"/>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div> 
            
            <asp:Label ID="Label1" runat="server" Text="Ingrese primer valor:"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 19px" Width="124px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Ingrese segundo valor:"></asp:Label>
            
        &nbsp;
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
            <%--<asp:RadioButtonList ID="RadioButtonList1" runat="server">
                <asp:ListItem Value="1">Sumar</asp:ListItem>
                <asp:ListItem Value="2">Restar</asp:ListItem>
            </asp:RadioButtonList>--%>
            <asp:RadioButton ID="RadioButton1" GroupName="calculo" runat="server" Text="Sumar"/>
            <asp:RadioButton ID="RadioButton2" GroupName="calculo"  runat="server" Text="Restar"/>

            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="Resultado" />
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
            
        </div>

    </form>
</body>
</html>
