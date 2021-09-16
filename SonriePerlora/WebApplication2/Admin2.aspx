<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin2.aspx.cs" Inherits="WebApplication2.Admin" %>

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
        <!-- Masthead-->
        <header class="masthead">
            <div class="container px-4 px-lg-5 h-100">
                            <!-- Usuario input-->
                            <div class="form-floating mb-3">
                                <input class="form-control" id="usuario" type="text" placeholder="Introduce usuario..." data-sb-validations="required" />
                                <label for="name">Usuario</label>
                                <div class="invalid-feedback" data-sb-feedback="name:required">*El usuario es obligatorio</div>
                            </div>
                            <!-- Password input-->
                            <div class="form-floating mb-3">
                                <input class="form-control" id="pass" type="password" placeholder="Contraseña" data-sb-validations="required,password" />
                                <label for="email">Contraseña</label>
                                <div class="invalid-feedback" data-sb-feedback="password:required">*La contraseña es obligatoria</div>
                            </div>
                      <button class="btn btn-primary btn-xl disabled" id="btnAdmin" OnClick="btnAdmin_Click">Enviar</button>
                  <!--Los datos de ma empresa quizás ponerlos en la parte inicial de la página-->  
                        <div>
                            <asp:Label runat="server" Text="Label">Direccion de la empresa:</asp:Label>
                            <asp:Label runat="server" Text="Label">Código de cuenta:</asp:Label>
                        </div>
                <div>
                   <form runat="server" id="datosPersonal" server="perlora.database.windows.net">
                    <div>
                    <div class="w-50 float-start">
                        <div class="mb-2">
                            <asp:Label runat="server" Text="Label">ID Personal:</asp:Label>
                           
                            <asp:TextBox ID="ID" runat="server" Width="150px"></asp:TextBox>
                        </div>
                        <div  class="mb-2">
                            <asp:Label runat="server" Text="Label">Nombre:</asp:Label>
                           
                            <asp:TextBox ID="Nombre" runat="server" Width="150px"></asp:TextBox>
                        </div>
                         <div  class="mb-2">
                            <asp:Label runat="server" Text="Label">Apellidos:</asp:Label>
                            
                            <asp:TextBox ID="Apellidos" runat="server" Width="150px"></asp:TextBox>
                        </div>
                       <div>
                           <asp:Label ID="genero" runat="server" Text="Género:"></asp:Label>
                           <asp:Label runat="server" Text="Masculino"></asp:Label>
                           <asp:RadioButton ID="masc" name="genero" runat="server" />
                            <asp:Label runat="server" Text="Femenino"></asp:Label>
                           <asp:RadioButton ID="fem" name="genero" runat="server" />
                            <asp:Label runat="server" Text="Otro"></asp:Label>
                           <asp:RadioButton ID="otro" name="genero" runat="server" />
                        </div>
                        <div  class="mb-2">
                            <asp:Label runat="server" Text="Label">DNI:</asp:Label>
                            
                            <asp:TextBox ID="DNI" runat="server" Width="150px"></asp:TextBox>
                        </div>
                      </div>
                    <div class="w-50 float-start">
                        <div  class="mb-2">
                            <asp:Label runat="server" Text="Label">Número Seguridad Social:</asp:Label>
                            
                            <asp:TextBox ID="NSS" runat="server" Width="150px"></asp:TextBox>
                        </div>
                        <div  class="mb-2">
                            <asp:Label runat="server" Text="Label">Localidad:</asp:Label>
                           
                            <asp:TextBox ID="Localidad" runat="server" Width="150px"></asp:TextBox>
                        </div>
                         <div  class="mb-2">
                            <asp:Label runat="server" Text="Label">Código Postal:</asp:Label>
                            
                            <asp:TextBox ID="Cpostal" runat="server" Width="150px"></asp:TextBox>
                        </div>
                         <div class="mb-2" >
                            <asp:Label runat="server" Text="Label">ID Departamento:</asp:Label>
                           
                            <asp:TextBox ID="ID_Departamento" runat="server" Width="150px"></asp:TextBox>
                        </div>
                        </div>
                    <div class="w-50 float-end"> 
                         <div class="mb-2">
                            <asp:Label runat="server" Text="Label">Tipo de contrato:</asp:Label>
                            &nbsp;
                            <asp:TextBox ID="Contrato" runat="server" Width="150px"></asp:TextBox>
                        </div>
                         <div class="mb-2">
                            <asp:Label runat="server" Text="Label">Puesto:</asp:Label>
                           
                             <asp:DropDownList ID="DropDownListPuesto" runat="server">

                                 <asp:ListItem>Direccion</asp:ListItem>
                                 <asp:ListItem>Gerente</asp:ListItem>
                                 <asp:ListItem>Monitoras</asp:ListItem>
                                 <asp:ListItem>Chef</asp:ListItem>
                                 <asp:ListItem>Servicio restauracion</asp:ListItem>
                                 <asp:ListItem>Mantenimiento</asp:ListItem>
                                 <asp:ListItem>Guia</asp:ListItem>
                             </asp:DropDownList>
                        </div>
                         <div class="mb-2">
                            <asp:Label runat="server" Text="Label">Tipo de jornada:</asp:Label>
                             <asp:DropDownList ID="DropDownListJornada" runat="server">
                                 <asp:ListItem>Completa</asp:ListItem>
                                 <asp:ListItem>Media Jornada</asp:ListItem>
                                 <asp:ListItem>Reducida</asp:ListItem>
                             </asp:DropDownList>
                           
                            <asp:TextBox ID="Jornada" runat="server" Width="150px"></asp:TextBox>
                        </div>
                         <div class="mb-2">
                            <asp:Label runat="server" Text="Label">Salario Bruto:</asp:Label>
                            
                            <asp:TextBox ID="SalarioB" runat="server" Width="150px"></asp:TextBox>
                        </div>
                      
                         </div>
                        </div>
                    <div>
                      
                        <div class="w-50 ">
                         <div class="mb-2">
                            <asp:Label runat="server" Text="Label">Salario Neto:</asp:Label>
                           
                            <asp:TextBox ID="SalarioN" runat="server" Width="150px"></asp:TextBox>
                        </div>
                          <div class="mb-2">
                            <asp:Label runat="server" Text="Label">ID Nominas:</asp:Label>
                           
                            <asp:TextBox ID="IDNominas" runat="server" Width="150px"></asp:TextBox>
                        </div>
                          <div class="mb-2">
                            <asp:Label runat="server" Text="Label">Vacaciones:</asp:Label>
                           
                            <asp:TextBox ID="vacaciones" runat="server" Width="150px"></asp:TextBox>
                        </div>
                          <div class="mb-2">
                            <asp:Label runat="server" Text="Label">Bajas:</asp:Label>
                           
                            <asp:TextBox ID="bajas" runat="server" Width="204px"></asp:TextBox>
                        </div>
                      </div>
                          <div class="mb-2">
                            <asp:Label runat="server" Text="Label">Precio de la hora trabajada:</asp:Label>
                           
                            <asp:TextBox ID="Phora" runat="server" Width="150px"></asp:TextBox>
                        </div>
                        <div class="w-50 float-end">
                          <div class="mb-2">
                            <asp:Label runat="server" Text="Label">Horas Extras:</asp:Label>
                           
                            <asp:TextBox ID="horasExtras" runat="server" Width="150px"></asp:TextBox>
                        </div>
                          <div class="mb-2">
                            <asp:Label runat="server" Text="Label">IRPF:</asp:Label>
                           
                            <asp:TextBox ID="IRPF" runat="server" Width="150px"></asp:TextBox>
                        </div>
                          <div class="mb-2">
                            <asp:Label runat="server" Text="Label">Periodo de Liquidación:</asp:Label>
                              <asp:Calendar ID="Calendar1" runat="server" Height="16px" Width="66px"></asp:Calendar>
                            
                        </div>
                        </div>
                      
                        <div class="w-50 float-end">
                          <div class="mb-2">
                            <asp:Label runat="server" Text="Label">Precio de la hora Extra:</asp:Label>
                          
                            <asp:TextBox ID="PhoraExtra" runat="server" Width="150px"></asp:TextBox>
                        </div>
                          <div class="mb-2">
                            <asp:Label runat="server" Text="Label">Horas Trabajadas:</asp:Label>
                          
                            <asp:TextBox ID="horasTrabajadas" runat="server" Width="150px"></asp:TextBox>
                        </div>
                        <!-- Submit Button-->
                            <div class="d-grid"><button class="btn btn-primary btn-xl disabled" id="submitButton" type="submit">Enviar</button></div>
                        </div>
                       </div>
                   </form>
                </div>
        </header>
        <!-- Nominas-->
        <section class="page-section bg-primary" id="#controlPersonoal">
            <div class="container px-4 px-lg-5">
               

            </div>
        </section>
        <!--Footer-->
        <footer class="bg-light py-5">
            <div class="container px-4 px-lg-5"><div class="small text-center text-muted">Copyright &copy; 2021 - Sonríe en Perlora</div></div>
        </footer>
        <!-- Bootstrap core JS-->
        <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.0/dist/js/bootstrap.bundle.min.js"></script>
        <!-- SimpleLightbox plugin JS-->
        <script src="https://cdnjs.cloudflare.com/ajax/libs/SimpleLightbox/2.1.0/simpleLightbox.min.js"></script>
        <!-- Core theme JS-->
        <script src="js/scripts.js"></script>
        <!-- * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *-->
        <!-- * *                               SB Forms JS                               * *-->
        <!-- * * Activate your form at https://startbootstrap.com/solution/contact-forms * *-->
        <!-- * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *-->
        <script src="https://cdn.startbootstrap.com/sb-forms-latest.js"></script>
    </body>
</html>
