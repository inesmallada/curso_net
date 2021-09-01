<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CuestionarioASP_NET.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="css/estilos.css"/>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Cuestionario</h1>
            <div>
                <h2>¿Qué lleva el pote berzas?</h2>
                <asp:RadioButton ID="pimiento" GroupName="berzas" runat="server" text="Pimiento"/>
                <br />
                <asp:RadioButton ID="calabaza" GroupName="berzas" runat="server" text="Calabaza" />
                <br />
                <asp:RadioButton ID="berza" GroupName="berzas" runat="server" text="Berzas"/>
            </div>
            <div>
                <h2>¿Qué lleva el arroz con leche?</h2>
                <asp:RadioButton ID="coco" GroupName="arroz" runat="server" text="Coco"/>
                <br />
                <asp:RadioButton ID="arroz" GroupName="arroz" runat="server" text="Arroz" />
                <br />
                <asp:RadioButton ID="huevo" GroupName="arroz" runat="server" text="Huevo"/>
            </div>
            <div>
                <h2>¿Qué lleva el cachopo?</h2>
                <asp:RadioButton ID="ternera" GroupName="cachopo" runat="server" text="Ternera"/>
                <br />
                <asp:RadioButton ID="sopa" GroupName="cachopo" runat="server" text="Sopa" />
                <br />
                <asp:RadioButton ID="macarrones" GroupName="cachopo" runat="server" text="Macarrones"/>
                <br />
                <asp:RadioButton ID="RadioButton1" GroupName="cachopo" runat="server" text=""/> <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="*Campo necesario" Font-Size="10px" ForeColor="Maroon">*Deberias introducir la canción</asp:RequiredFieldValidator>
                <br />
                <br />
                <p>Introduce el rango adecuado entre 10 y 20&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
&nbsp;
                    <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TextBox2" ErrorMessage="ERROR de RANGO" Font-Size="10px" ForeColor="Maroon" MaximumValue="20" MinimumValue="10">*El valor no está en el rango permitido</asp:RangeValidator>
                </p>
                Contraseña&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
&nbsp;
                <br />
                Comprueba Contraseña <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                <br />
                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox3" ControlToValidate="TextBox4" ErrorMessage="*Las contraseñas no coinciden" Font-Size="10px" ForeColor="Maroon"></asp:CompareValidator>
                <br />
            </div>
               <div class="imagenes">
                <img src="img/arroz-leche.jpg"  />
                <img src="img/pote-berzas.jpg" />
                <img src="img/cachopo-asturiano.jpg" /><br />
            </div>
            <div>
                <br />
                <br />
                <asp:Button ID="Button1" runat="server" Text="Resultado" OnClick="Button1_Click" />
            </div>


            <%--<br />
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="*El correo no es correcto" Font-Size="10px" ForeColor="Maroon" ValidationExpression="^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"></asp:RegularExpressionValidator>
            <br />--%>
         
        </div>
    </form>
</body>
</html>
