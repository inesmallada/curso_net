<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cliente.aspx.cs" Inherits="WebApplication2.Cliente" %>

<!DOCTYPE html>
<html lang="en">
    <head>
        <meta charset="utf-8" />
        <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
        <meta name="description" content="Reserva de vacaciones, habitaciones, campamentos en Perlora, Asturias" />
        <meta name="author" content="Ines Mallada" />
        <title>Reservas en Perlora</title>
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
    <body id="page-top">
        <!-- Navigation-->
        <nav class="navbar navbar-expand-lg navbar-light fixed-top py-3" id="mainNav">
            <div class="container px-4 px-lg-5">
                <a class="navbar-brand" href="#page-top">Sonríe en Perlora</a>
              <button class="navbar-toggler navbar-toggler-right" type="button" data-bs-toggle="collapse" data-bs-target="#navbarResponsive" aria-controls="navbarResponsive" aria-expanded="false" aria-label="Toggle navigation"><span class="navbar-toggler-icon"></span></button>
                <div class="collapse navbar-collapse" id="navbarResponsive">
                    <ul class="navbar-nav ms-auto my-2 my-lg-0">
                        <li class="nav-item"><a class="nav-link" href="Default.aspx#about">About</a></li>
                        <li class="nav-item"><a class="nav-link" href="Default.aspx#services">Servicios</a></li>
                        <li class="nav-item"><a class="nav-link" href="Default.aspx#portfolio">Portfolio</a></li>
                        <li class="nav-item"><a class="nav-link" href="Default.aspx#contact">Contacto</a></li>
                        <li class="nav-item"><a class="nav-link" href="Default.aspx#acceso">Acceso de Usuarios</a></li>
                    </ul>
                </div>
            </div>
        </nav>
        <!-- Masthead-->
        <header class="masthead">
            <div class="container px-4 px-lg-5 h-100">
               <form id="form1" runat="server">
                    <div class="form-datos"> <!--Primera columna-->
                            <div class="mb-2 orden col-3">
                                <asp:Label runat="server" Text="">ID Cliente:</asp:Label>
                                <asp:TextBox ID="txtID_Cliente" class="form-control" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Campo Obligatorio" ControlToValidate="txtID_Cliente" ForeColor="Red"></asp:RequiredFieldValidator>
                            </div>
                            <div  class="mb-2 orden col-3">
                                <asp:Label runat="server" Text="Label">Nombre:</asp:Label>
                                <asp:TextBox ID="txtNombreC" runat="server" class="form-control"></asp:TextBox>
                                  <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Campo Obligatorio" ControlToValidate="txtNombreC" ForeColor="Red"></asp:RequiredFieldValidator>
                            </div>
                             <div  class="mb-2 orden2 col-3">
                                <asp:Label runat="server" Text="Label">Apellidos:</asp:Label>
                                <asp:TextBox ID="txtApellidosC" runat="server" class="form-control"></asp:TextBox>
                                   <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Campo Obligatorio" ControlToValidate="txtApellidosC" ForeColor="Red"></asp:RequiredFieldValidator>
                            </div> 
                        <div  class="mb-2 orden col-3">
                                <asp:Label runat="server" Text="Label">DNI:</asp:Label> 
                                <asp:TextBox ID="txtDNIC" runat="server" class="form-control"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Campo Obligatorio" ControlToValidate="txtDNIC" ForeColor="Red"></asp:RequiredFieldValidator>
                            </div>
                           
                            <div class="mt-2 orden col-3 pb-3">
                                <div><asp:Label runat="server" Text="Género:"></asp:Label></div>
                                 <asp:RadioButton ID="rdMasculinoC" GroupName="genero" runat="server" Text="Masculino"/>
                                 <asp:RadioButton ID="rdFemeninoC"  GroupName="genero" runat="server" Text="Femenino" />
                                 <asp:RadioButton ID="rdOtroC" GroupName="genero"  runat="server" Text="Otro" />
                            </div>
                           
                            <div  class="mb-2 orden2 col-3">
                                <asp:Label runat="server" Text="Label">Localidad:</asp:Label>
                                <asp:TextBox ID="txtLocalidadC" runat="server" class="form-control"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Campo Obligatorio" ControlToValidate="txtLocalidadC" ForeColor="Red"></asp:RequiredFieldValidator>
                            </div>
                         <div class="mt-2 orden col-3 pb-3">
                                 <div><asp:Label runat="server" Text="Animales:"></asp:Label></div>
                                 <asp:RadioButton ID="rdSi" GroupName="animales" runat="server" Text="Sí"/>
                                 <asp:RadioButton ID="RdNo"  GroupName="animales" runat="server" Text="No" />
                            </div>
                         <div class="mt-2 orden col-3 pb-3">
                                <div><asp:Label runat="server" Text="Pack Camp:"></asp:Label></div>
                                 <asp:RadioButton ID="rdNun" GroupName="packCamp" runat="server" Text="No"/>
                               <asp:RadioButton ID="rdGrandes" GroupName="packCamp"  runat="server" Text="Grandes" />
                                 <asp:RadioButton ID="rdMayores"  GroupName="packCamp" runat="server" Text="Mayores" />
                                 <asp:RadioButton ID="rdMenores" GroupName="packCamp"  runat="server" Text="Menores" />
                            </div>
                            <div class="mb-2 orden2 col-3">
                                <asp:Label runat="server" Text="">Nº Personas:</asp:Label>
                                <asp:TextBox ID="txtNumPersonas" runat="server" class="form-control"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="Campo Obligatorio" ControlToValidate="txtNumPersonas" ForeColor="Red"></asp:RequiredFieldValidator>
                            </div>

                             <div class="mb-2 orden col-3">
                                 <asp:Label runat="server" Text="">Dieta:</asp:Label>
                                 <asp:DropDownList ID="DropDownList1" class="form-control" runat="server">
                                 <asp:ListItem Value="omnivoros">Omnívora</asp:ListItem>
                                 <asp:ListItem Value="ovolacteovegetariana">Ovolácteovegetariana</asp:ListItem>
                                 <asp:ListItem Value="vegetariana">Vegetariana</asp:ListItem>
                                  <asp:ListItem Value="vegana">Vegana</asp:ListItem>
                                  </asp:DropDownList>
                                  <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ErrorMessage="Campo Obligatorio" ControlToValidate="ddlDepartamento" ForeColor="Red"></asp:RequiredFieldValidator>
                                  </div>
                             <div class="mb-2 orden col-3">
                            <asp:Label runat="server" Text="">Alergias:</asp:Label>
                            <asp:DropDownList ID="DropDownList2" class="form-control" runat="server">
                                 <asp:ListItem Value="lactosa">Lactosa</asp:ListItem>
                                 <asp:ListItem Value="gluten">Glúten</asp:ListItem>
                                 <asp:ListItem Value="nueces">Cacahuetes y Nueces</asp:ListItem>
                                 <asp:ListItem Value="marisco">Marisco</asp:ListItem>
                             </asp:DropDownList>
                             <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ErrorMessage="Campo Obligatorio" ControlToValidate="ddlDepartamento" ForeColor="Red"></asp:RequiredFieldValidator>
                        </div>
                        <div class="mb-2 orden2 col-3">
                            <asp:Label runat="server" Text="">Diversidades:</asp:Label>
                            <asp:DropDownList ID="DropDownList3" class="form-control" runat="server">
                                 <asp:ListItem Value="lactosa"> Física o motriz</asp:ListItem>
                                 <asp:ListItem Value="gluten">Visual</asp:ListItem>
                                 <asp:ListItem Value="nueces">Auditiva</asp:ListItem>
                                 <asp:ListItem Value="marisco">Intelectual y psíquica</asp:ListItem>
                                 <asp:ListItem Value="marisco">Multisensorial</asp:ListItem>
                             </asp:DropDownList>
                             <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ErrorMessage="Campo Obligatorio" ControlToValidate="ddlDepartamento" ForeColor="Red"></asp:RequiredFieldValidator>
                        </div>
                    
                            <div class="mb-4 mt-2 orden col-11">
                                   <div><asp:Label runat="server" Text="Alojamiento:"></asp:Label></div>
                                    <div class=" orden col-2">
                                        <figure>
                                            <img class="img-fluid" src="assets/img/portfolio/thumbnails/7.jpg" alt="vivienda unifamiliar" />
                                             <figcaption><asp:RadioButton ID="rbv1" GroupName="alojamiento" runat="server" Text="Tipo 1, "/>
                                            <asp:Label ID="lblPrecio1" runat="server" Text="10 euros/noche"></asp:Label></figcaption>
                                       </figure>
                                    </div>
                                    <div  class="orden col-2">
                                         <figure>
                                            <img class="img-fluid" src="assets/img/portfolio/thumbnails/8.jpg" alt="vivienda unifamiliar" />
                                            <figcaption><asp:RadioButton ID="rbv2" GroupName="alojamiento" runat="server" Text="Tipo 2,"/>
                                             <asp:Label ID="lblPrecio2" runat="server" Text="15 euros/noche"></asp:Label></figcaption>
                                        </figure>
                                    </div>
                                    <div  class=" orden col-2">
                                        <figure>
                                        <img class="img-fluid" src="assets/img/portfolio/thumbnails/9.jpg" alt="vivienda unifamiliar" />
                                        <figcaption><asp:RadioButton ID="rbv3" GroupName="alojamiento" runat="server" Text="Tipo 3,"/>
                                        <asp:Label ID="lblPrecio3" runat="server" Text="20 euros/noche"></asp:Label></figcaption>
                                         </figure>
                                    </div>
                                    <div  class="orden col-2">
                                        <figure>
                                        <figcaption><img class="img-fluid" src="assets/img/portfolio/thumbnails/10.jpg" alt="vivienda unifamiliar" />
                                        <asp:RadioButton ID="rbv4" GroupName="alojamiento" runat="server" Text="Tipo 4,"/>
                                         <asp:Label ID="lblPrecio4" runat="server" Text="25 euros/noche"></asp:Label></figcaption></figure>
                                    </div>
                              </div>
                               <!--Fecha inicio y fin de la reserva-->
                          <div class="mb-4 mt-2 orden2 col-11">
                                <div  class="mb-2 orden col-3">
                                        <asp:Label runat="server" Text="">Año de nacimiento</asp:Label>
                                        <asp:Calendar ID="calAnio" class="form-control" runat="server"></asp:Calendar>
                                    </div>    
                                <div  class="mb-2 orden col-3">
                                        <asp:Label runat="server" Text="">Fecha Inicio</asp:Label>
                                        <asp:Calendar ID="calInicio" class="form-control" runat="server"></asp:Calendar>
                                    </div>
                                 <div  class="mb-2 orden2 col-3">
                                        <asp:Label runat="server" Text="">Fecha Fin</asp:Label>
                                        <asp:Calendar ID="calFin" class="form-control" runat="server"></asp:Calendar>
                                    </div>
                              </div>
                           <div class="mb-2 orden2 col-11">
                            <asp:Label runat="server" Text="Label">¿Te interesarían las siguientes actividades?</asp:Label>
                            <asp:DropDownList ID="ddlDepartamento" class="form-control" runat="server">
                                 <asp:ListItem Value="1">Deportes Acuáticos</asp:ListItem>
                                 <asp:ListItem Value="2">Senderismo</asp:ListItem>
                                 <asp:ListItem Value="3">Meditación</asp:ListItem>
                                 <asp:ListItem Value="4">Rutas en bici</asp:ListItem>
                                 <asp:ListItem Value="5">Expresión Corporal</asp:ListItem>
                                 <asp:ListItem Value="6">Arte efímero</asp:ListItem>
                             </asp:DropDownList>
                             <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ErrorMessage="Campo Obligatorio" ControlToValidate="ddlDepartamento" ForeColor="Red"></asp:RequiredFieldValidator>
                        </div>
                    </div>
            <!-- Submit Buttons-->
                <div class="d-grid">  
                    <asp:Button ID="btnReserva" value="Reserva" runat="server" class="btn btn-primary mb-3 mt-3 w-100" Text="Reserva"/>
                </div>
                       <asp:Label ID="lblConfirmacionC" runat="server" Text=""></asp:Label>
             </form>       
          </div>
        </header>
          <!-- About-->
        <section class="page-section bg-primary" id="acceso">
            <div class="container px-4 px-lg-5">
                 <asp:GridView ID="GridView3" class="orden2 mt-3" runat="server"></asp:GridView>
           </div>
          </section>
           <!-- Footer-->
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