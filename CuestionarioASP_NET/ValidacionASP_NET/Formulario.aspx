<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Formulario.aspx.cs" Inherits="ValidacionASP_NET.Formulario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Nombre de usuario"></asp:Label>
        &nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server" Width="277px"></asp:TextBox>
            <br />
            Clave&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server" Width="131px"></asp:TextBox>
            <br />
            Repita Clave&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox3" runat="server" Width="134px"></asp:TextBox>
            <br />
            Correo electrónico&nbsp;&nbsp;
            <asp:TextBox ID="TextBox4" runat="server" Width="277px"></asp:TextBox>
            <br />
            Apellido&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox5" runat="server" Width="277px"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Nombre"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            <asp:TextBox ID="TextBox6" runat="server" Width="277px"></asp:TextBox>
            <br />
            País de origen&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:ListBox ID="ListBox1" runat="server" Height="23px" Width="247px"></asp:ListBox>
            <br />
            Provincia&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox7" runat="server" Width="169px"></asp:TextBox>
            <br />
            Código Postal&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox8" runat="server" Width="104px"></asp:TextBox>
            <br />
            Género&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton1" runat="server"  />
        &nbsp;
            <asp:RadioButton ID="RadioButton2" runat="server"  />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Fecha de nacimiento"></asp:Label>
        &nbsp;(dd/mm/aaaa)<asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
            <br />
            Comentarios&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox9" runat="server" Height="212px" Width="413px"></asp:TextBox>
            <br />
            <br />
            Acepto los términos y condiciones&nbsp;&nbsp;
            <asp:CheckBox ID="CheckBox1" runat="server" Text="Acepto" />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Aceptar" />
        </div>
    </form>
</body>
</html>
