<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Nomina.aspx.cs" Inherits="WebApplication2.Nomina" %>

<!DOCTYPE html>
<html lang="en">
    <head>
        <meta charset="utf-8" />
        <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
        <meta name="description" content="" />
        <meta name="author" content="" />
        <title>Administrador de Nóminas y personal laboral</title>
        <!-- Favicon-->
        <link rel="icon" type="image/x-icon" href="assets/favicon.ico" />
        <!-- Bootstrap Icons-->
        <link href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.5.0/font/bootstrap-icons.css" rel="stylesheet" />
        <!-- Google fonts-->
        <link href="https://fonts.googleapis.com/css?family=Merriweather+Sans:400,700" rel="stylesheet" />
        <link href="https://fonts.googleapis.com/css?family=Merriweather:400,300,300italic,400italic,700,700italic" rel="stylesheet" type="text/css" />
        <!-- SimpleLightbox plugin CSS-->
        <link href="https://cdnjs.cloudflare.com/ajax/libs/SimpleLightbox/2.1.0/simpleLightbox.min.css" rel="stylesheet" />
        <!-- Core theme CSS (includes Bootstrap)-->
        <link href="css/styles.css" rel="stylesheet" />
    </head>
    <body id="page-top" class="p-admin">
        <!-- Navigation-->
        <nav class="navbar navbar-expand-lg navbar-light fixed-top py-3" id="mainNav">
            <div class="container px-4 px-lg-5">
                <a class="navbar-brand" href="#page-top">Sonríe en Perlora</a>
                <button class="navbar-toggler navbar-toggler-right" type="button" data-bs-toggle="collapse" data-bs-target="#navbarResponsive" aria-controls="navbarResponsive" aria-expanded="false" aria-label="Toggle navigation"><span class="navbar-toggler-icon"></span></button>
                <div class="collapse navbar-collapse" id="navbarResponsive">
                    <ul class="navbar-nav ms-auto my-2 my-lg-0">
                        <li class="nav-item"><a class="nav-link" href="#about">About</a></li>
                        <li class="nav-item"><a class="nav-link" href="#services">Servicios</a></li>
                        <li class="nav-item"><a class="nav-link" href="#portfolio">Portfolio</a></li>
                        <li class="nav-item"><a class="nav-link" href="#contact">Contacto</a></li>
                        <li class="nav-item"><a class="nav-link" href="#acceso">Acceso de Usuarios</a></li>
                    </ul>
                </div>
              
            </div>
        </nav>
    <form id="form1" runat="server">
         <!--Los datos de la empresa quizás ponerlos en la parte inicial de la página-->  
                        <div>
                            <asp:Label runat="server" Text="Label">Direccion de la empresa:</asp:Label>
                            <asp:Label runat="server" Text="Label">Código de cuenta:</asp:Label>
                        </div>
          <div>
                    <div class="w-40"> <!--Primera columna-->
                        <div class="mb-2">
                            <asp:Label runat="server" Text="Label">ID Personal:</asp:Label>
                            <asp:TextBox ID="txtID" runat="server" Width="150px"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Campo Obligatorio" ControlToValidate="txtID" ForeColor="Red"></asp:RequiredFieldValidator>
                        </div>
                        <div  class="mb-2">
                            <asp:Label runat="server" Text="Label">Nombre:</asp:Label>
                            <asp:TextBox ID="txtNombre" runat="server" Width="150px"></asp:TextBox>
                              <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Campo Obligatorio" ControlToValidate="txtNombre" ForeColor="Red"></asp:RequiredFieldValidator>
                        </div>
                         <div  class="mb-2">
                            <asp:Label runat="server" Text="Label">Apellidos:</asp:Label>
                            <asp:TextBox ID="txtApellidos" runat="server" Width="150px"></asp:TextBox>
                               <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Campo Obligatorio" ControlToValidate="txtApellidos" ForeColor="Red"></asp:RequiredFieldValidator>
                        </div>
                        <div>
                            <asp:Label runat="server" Text="Género"></asp:Label>
                            <asp:RadioButtonList ID="rdGenero" runat="server"> 
                                <asp:ListItem Value="Masculino">Masculino</asp:ListItem>
                                <asp:ListItem Value="Femenino">Femenino</asp:ListItem>
                                <asp:ListItem Value="Otro">Otro</asp:ListItem>
                            </asp:RadioButtonList>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ErrorMessage="Campo Obligatorio" ControlToValidate="rdGenero" ForeColor="Red"></asp:RequiredFieldValidator>
                        </div>
                        <div  class="mb-2">
                            <asp:Label runat="server" Text="Label">DNI:</asp:Label> 
                            <asp:TextBox ID="txtDNI" runat="server" Width="150px"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Campo Obligatorio" ControlToValidate="txtDNI" ForeColor="Red"></asp:RequiredFieldValidator>
                        </div>
                        <div  class="mb-2">
                            <asp:Label runat="server" Text="Label">Número Seguridad Social:</asp:Label>
                            <asp:TextBox ID="txtNSS" runat="server" Width="150px"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="Campo Obligatorio" ControlToValidate="txtNSS" ForeColor="Red"></asp:RequiredFieldValidator>
                        </div>
                        <div  class="mb-2">
                            <asp:Label runat="server" Text="Label">Localidad:</asp:Label>
                            <asp:TextBox ID="txtLocalidad" runat="server" Width="150px"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ErrorMessage="Campo Obligatorio" ControlToValidate="txtLocalidad" ForeColor="Red"></asp:RequiredFieldValidator>
                        </div>
                         <div  class="mb-2">
                            <asp:Label runat="server" Text="Label">Código Postal:</asp:Label>
                            <asp:TextBox ID="txtCpostal" runat="server" Width="150px"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ErrorMessage="Campo Obligatorio" ControlToValidate="txtCpostal" ForeColor="Red"></asp:RequiredFieldValidator>
                        </div>
                         <div class="mb-2" >
                            <asp:Label runat="server" Text="Label">ID Departamento:</asp:Label>
                            <asp:TextBox ID="txtID_Departamento" runat="server" Width="150px"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ErrorMessage="Campo Obligatorio" ControlToValidate="txtID_Departamento" ForeColor="Red"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                    <div class="w-40 float-end"> <!--Segunda columna-->
                         <div class="mb-2">
                            <asp:Label runat="server" Text="Label">Tipo de contrato:</asp:Label>
                            <asp:TextBox ID="txtContrato" runat="server" Width="150px"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ErrorMessage="Campo Obligatorio" ControlToValidate="txtContrato" ForeColor="Red"></asp:RequiredFieldValidator>
                        </div>
                         <div class="mb-2">
                            <asp:Label runat="server" Text="Label">Puesto:</asp:Label>
                            <asp:DropDownList ID="ddlPuesto" runat="server">
                                 <asp:ListItem Value="Direccion">Direccion</asp:ListItem>
                                 <asp:ListItem Value="Gerente">Gerente</asp:ListItem>
                                 <asp:ListItem Value="Monitoras">Monitoras</asp:ListItem>
                                 <asp:ListItem Value="Chef">Chef</asp:ListItem>
                                 <asp:ListItem Value="Restauracion">Servicio restauracion</asp:ListItem>
                                 <asp:ListItem Value="Mantenimiento">Mantenimiento</asp:ListItem>
                                 <asp:ListItem Value="Guia">Guia</asp:ListItem>
                             </asp:DropDownList>
                             <asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" ErrorMessage="Campo Obligatorio" ControlToValidate="ddlPuesto" ForeColor="Red"></asp:RequiredFieldValidator>
                        </div>
                         <div class="mb-2">
                            <asp:Label runat="server" Text="Label">Tipo de jornada:</asp:Label>
                             <asp:DropDownList ID="ddlJornada" runat="server">
                                 <asp:ListItem>Completa</asp:ListItem>
                                 <asp:ListItem>Media Jornada</asp:ListItem>
                                 <asp:ListItem>Reducida</asp:ListItem>
                             </asp:DropDownList>
                            <asp:TextBox ID="txtJornada" runat="server" Width="150px"></asp:TextBox>
                        </div>
                         <div class="mb-2">
                            <asp:Label runat="server" Text="Label">Salario Bruto:</asp:Label>
                            <asp:TextBox ID="txtSalarioB" runat="server" Width="150px"></asp:TextBox>
                        </div>
                         <div class="mb-2">
                            <asp:Label runat="server" Text="Label">Salario Neto:</asp:Label>
                            <asp:TextBox ID="txtSalarioN" runat="server" Width="150px"></asp:TextBox>
                        </div>
                          <div class="mb-2">
                            <asp:Label runat="server" Text="Label">ID Nominas:</asp:Label>
                            <asp:TextBox ID="txtIDNominas" runat="server" Width="150px"></asp:TextBox>
                        </div>
                          <div class="mb-2">
                            <asp:Label runat="server" Text="Label">Vacaciones:</asp:Label>
                            <asp:TextBox ID="txtvacaciones" runat="server" Width="150px"></asp:TextBox>
                        </div>
                          <div class="mb-2">
                            <asp:Label runat="server" Text="Label">Bajas:</asp:Label>
                            <asp:TextBox ID="bajas" runat="server" Width="204px"></asp:TextBox>
                        </div>
                          <div class="mb-2">
                            <asp:Label runat="server" Text="Label">Precio de la hora trabajada:</asp:Label>
                            <asp:TextBox ID="txtPhora" runat="server" Width="150px"></asp:TextBox>
                        </div>

                        <div class="w-50 float-end"> <!--Tercer bloque-->
                          <div class="mb-2">
                            <asp:Label runat="server" Text="Label">Horas Extras:</asp:Label>
                            <asp:TextBox ID="txthorasExtras" runat="server" Width="150px"></asp:TextBox>
                        </div>
                          <div class="mb-2">
                            <asp:Label runat="server" Text="Label">IRPF:</asp:Label>
                            <asp:TextBox ID="txtIRPF" runat="server" Width="150px"></asp:TextBox>
                        </div>
                          <%--<div class="mb-2">
                            <asp:Label runat="server" Text="Label">Periodo de Liquidación:</asp:Label>
                              <asp:Calendar ID="Calendar1" runat="server" Height="16px" Width="66px"></asp:Calendar>
                        </div>--%>
                      </div>
                          <div class="mb-2">
                            <asp:Label runat="server" Text="Label">Precio de la hora Extra:</asp:Label>
                             <asp:TextBox ID="txtPhoraExtra" runat="server" Width="150px"></asp:TextBox>
                        </div>
                          <div class="mb-2">
                            <asp:Label runat="server" Text="Label">Horas Trabajadas:</asp:Label>
                            <asp:TextBox ID="txthorasTrabajadas" runat="server" Width="150px"></asp:TextBox>
                        </div>
                        <!-- Submit Button-->
                            <div class="d-grid"><button class="btn btn-primary btn-xl" value="RegistroPersonal" id="btnRegistro" type="submit">Enviar</button></div>
                        </div>
                       </div>
     
    </form>
</body>
</html>
