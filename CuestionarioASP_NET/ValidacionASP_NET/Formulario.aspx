<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Formulario.aspx.cs" Inherits="ValidacionASP_NET.Formulario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link href="css/estilo.css" rel="stylesheet" />
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Formulario Validación</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="conte">
                <div class="cont_label">
                    <asp:Label ID="Label1" runat="server" Text="Nombre de usuario"></asp:Label>
                </div>
                    <div class="left">
                    <asp:TextBox ID="TextBox1" runat="server" Width="277px"></asp:TextBox>
                </div>
           </div>
            <div class="conte">
                <div class="cont_label">
                    <asp:Label ID="Label4" runat="server" Text="Clave"></asp:Label>
                </div>
                <div class="left">
                    <asp:TextBox ID="TextBox2" runat="server" Width="131px"></asp:TextBox>
                </div>
            </div>
            <div class="conte">
                <div class="cont_label">
                    <asp:Label ID="Label5" runat="server" Text="Repita Clave"></asp:Label>
                </div>
                <div class="left">
                    <asp:TextBox ID="TextBox3" runat="server" Width="134px"></asp:TextBox>
                </div>
            </div>
            <div class="conte">
                <div class="cont_label">
                    <asp:Label ID="Label6" runat="server" Text="Correo electrónico"></asp:Label>
                </div>
                <div class="left">
                    <asp:TextBox ID="TextBox4" runat="server" Width="277px"></asp:TextBox>
                </div>
            </div>
             <div class="conte">
                 <div class="cont_label">
                    <asp:Label ID="Label7" runat="server" Text="Apellido"></asp:Label>
                </div>
                 <div class="left">
                    <asp:TextBox ID="TextBox5" runat="server" Width="277px"></asp:TextBox>
                </div>
            </div>
            <div class="conte">
                <div class="cont_label">
                    <asp:Label ID="Label2" runat="server" Text="Nombre"></asp:Label>
                </div>
                <div class="left">
                    <asp:TextBox ID="TextBox6" runat="server" Width="277px"></asp:TextBox>
                </div>
            </div>
            <div class="conte">
                <div class="cont_label">
                    <asp:Label ID="Label8" runat="server" Text="País de origen"></asp:Label>
                </div>
                <div class="left">
                    <asp:ListBox ID="ListBox1" runat="server" Height="23px" Width="247px">
                        <asp:ListItem>España</asp:ListItem>
                        <asp:ListItem>Francia</asp:ListItem>
                        <asp:ListItem>Portugal</asp:ListItem>
                        <asp:ListItem>Italia</asp:ListItem>
                     </asp:ListBox>
                 </div>
            </div>
            <div class="conte">
                <div class="cont_label">
                    <asp:Label ID="Label9" runat="server" Text="Provincia"></asp:Label>
                </div>
                <div class="left">
                    <asp:TextBox ID="TextBox7" runat="server" Width="169px"></asp:TextBox>
                </div>
             </div>
            <div class="conte">
                <div class="cont_label">
                    <asp:Label ID="Label10" runat="server" Text="Código Postal"></asp:Label>
                </div>
                <div class="left">
                    <asp:TextBox ID="TextBox8" runat="server" Width="104px"></asp:TextBox>
                </div>
            </div>
            <div class="conte">
                <div class="cont_label">
                    <asp:Label ID="Label11" runat="server" Text="Género"></asp:Label> 
                </div>
                <div class="left">
                    <asp:RadioButton ID="RadioButton1" GroupName="genero" runat="server" Text="Hombre"  />
                    <asp:RadioButton ID="RadioButton2" GroupName="genero" runat="server" Text="Mujer"  />
                    <asp:RadioButton ID="RadioButton3" GroupName="genero" runat="server" Text="Otres" />
                </div>
            </div>
            <div class="conte">
                <div class="cont_label">
                    <asp:Label ID="Label3" runat="server" Text="Fecha de nacimiento">(dd/mm/aaaa)</asp:Label>
                </div>
                <div class="left">
                    <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
                </div>
            </div>
            <div class="conte">
                <div class="cont_label">
                    <asp:Label ID="Label12" runat="server" Text="Comentarios"></asp:Label>
                </div>
                <div class="left">
                    <asp:TextBox ID="TextBox9" runat="server" Height="212px" Width="413px"></asp:TextBox>
                </div>
            </div>
            <div class="conte">
                    <div class="cont_label">
                        <asp:Label ID="Label13" runat="server" Text="Acepto los términos y condiciones"></asp:Label>
                   </div>
                    <div class="left">
                        <asp:CheckBox ID="CheckBox1" runat="server" Text="Acepto" />
                    </div>
            </div>
            
            <asp:Button ID="Button1" runat="server" Text="Aceptar" />
        </div>
    </form>
</body>
</html>
