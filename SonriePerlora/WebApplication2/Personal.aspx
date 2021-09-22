<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Personal.aspx.cs" Inherits="WebApplication2.Personal" %>

<!DOCTYPE html>
<html lang="en">
    <head>
        <meta charset="utf-8" />
        <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
        <meta name="description" content="Gestion de las reservas y los clientes de Sonrie en Perlora, Asturias" />
        <meta name="author" content="Ines Mallada" />
        <title>Gestion del Personal</title>
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
               <form id="form2" runat="server">
                 <div class="form-datos"> <!--Primera columna-->
                    <div class="row">
                      <div class="mb-2 orden col-sm-5 col-10">
                            <asp:Label runat="server" Text="">Perlora 33491, Asturias</asp:Label>
                            <asp:Label runat="server" Text="">CCC:33 123456789</asp:Label>
                      </div>
                      <div class="mb-2 orden2 col-sm-5 col-10">
                          <asp:DropDownList ID="ddlConsultaC" runat="server" DataSourceID="SqlDataSource3" DataTextField="Nombre" DataValueField="Nombre"></asp:DropDownList>
                          <asp:SqlDataSource runat="server" ID="SqlDataSource3" ConnectionString='<%$ ConnectionStrings:SonriePerloraConnectionString1 %>' SelectCommand="SELECT [Nombre] FROM [Cliente]"></asp:SqlDataSource>
                      </div>
                        </div>
                        <div class="row">
                            <div class="mb-2 orden col-sm-5 col-10">
                                <asp:Label runat="server" Text="Label">ID Cliente:</asp:Label>
                                <asp:TextBox ID="txtID_Cliente" class="form-control" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator14" runat="server" ErrorMessage="Campo Obligatorio" ControlToValidate="txtID_Cliente" ForeColor="Red"></asp:RequiredFieldValidator>
                            </div>
                        <div class="mb-2 orden2 col-sm-5 col-10">
                            <asp:Label runat="server" Text="">Nombre:</asp:Label>
                            <asp:TextBox ID="txtNombreC" runat="server" class="form-control"></asp:TextBox>
                              <asp:RequiredFieldValidator ID="RequiredFieldValidator15" runat="server" ErrorMessage="Campo Obligatorio" ControlToValidate="txtNombreC" ForeColor="Red"></asp:RequiredFieldValidator>
                        </div>
                        </div>
                        <div class="row">
                         <div class="mb-2 orden col-sm-5 col-10">
                            <asp:Label runat="server" Text="">Apellidos:</asp:Label>
                            <asp:TextBox ID="txtApellidosC" runat="server" class="form-control"></asp:TextBox>
                               <asp:RequiredFieldValidator ID="RequiredFieldValidator16" runat="server" ErrorMessage="Campo Obligatorio" ControlToValidate="txtApellidosC" ForeColor="Red"></asp:RequiredFieldValidator>
                        </div>
                        <div class="mb-4 mt-2 orden2 col-sm-5 col-10 pb-3">
                            <div><asp:Label runat="server" Text="Género:"></asp:Label></div>
                             <asp:RadioButton ID="rdMasculinoC" GroupName="genero" runat="server" Text="Masculino"/>
                             <asp:RadioButton ID="rdFemeninoC"  GroupName="genero" runat="server" Text="Femenino" />
                             <asp:RadioButton ID="rdOtroC" GroupName="genero"  runat="server" Text="Otro" />
                        </div>
                        </div>
                        <div class="row">
                        <div  class="mb-2 orden col-sm-5 col-10">
                            <asp:Label runat="server" Text="">DNI:</asp:Label> 
                            <asp:TextBox ID="txtDNIC" runat="server" class="form-control"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator17" runat="server" ErrorMessage="Campo Obligatorio" ControlToValidate="txtDNIC" ForeColor="Red"></asp:RequiredFieldValidator>
                        </div>
                            <div  class="mb-2 orden2 col-sm-5 col-10">
                                <asp:Label runat="server" Text="">Localidad:</asp:Label>
                                <asp:TextBox ID="txtLocalidadC" runat="server" class="form-control"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator18" runat="server" ErrorMessage="Campo Obligatorio" ControlToValidate="txtLocalidadC" ForeColor="Red"></asp:RequiredFieldValidator>
                            </div>
                        </div>
                        <div class="row">                             
                            <div  class="mb-2 orden col-sm-5 col-10">
                                <asp:Label runat="server" Text="">Código Postal:</asp:Label>
                                <asp:TextBox ID="txtCpostalC" runat="server" class="form-control"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator19" runat="server" ErrorMessage="Campo Obligatorio" ControlToValidate="txtCpostalC" ForeColor="Red"></asp:RequiredFieldValidator>
                        </div>
                        <div class="mb-2 orden2 col-sm-5 col-10" >
                           <div class="mb-2 orden2 col-5">
                               <asp:Label runat="server" Text="">Actividades:</asp:Label>
                               <asp:CheckBoxList ID="cblActividades" runat="server">
                                     <asp:ListItem Value="1">Deportes Acuáticos</asp:ListItem>
                                     <asp:ListItem Value="2">Senderismo</asp:ListItem>
                                     <asp:ListItem Value="3">Relajación</asp:ListItem>
                                     <asp:ListItem Value="4">Rutas en bici</asp:ListItem>
                                     <asp:ListItem Value="5">Expresión Corporal</asp:ListItem>
                                     <asp:ListItem Value="6">Arte efímero</asp:ListItem>
                               </asp:CheckBoxList>
                        </div>
                            </div> 
                            </div>
                            <div class="row">
                                <div  class="mb-2 orden col-sm-5 col-10">
                                        <asp:Label runat="server" Text="">Usuario:</asp:Label>
                                        <asp:TextBox ID="txtUsuarioC" runat="server" class="form-control"></asp:TextBox>
                                 </div>
                                 <div  class="mb-2 orden2 col-sm-5 col-10">
                                        <asp:Label runat="server" Text="">Contraseña:</asp:Label>
                                        <asp:TextBox ID="txtPassC" runat="server" class="form-control"></asp:TextBox>
                                 </div>
                             </div>
                    </div>
            <!-- Submit Buttons-->
                <div class="d-grid mybtn">
                                  <asp:LinkButton ID="btnAltaC" runat="server" class="btn btn-primary orden mybtn mb-2" Text="" OnClick="btnAltaC_Click"> <i class="bi bi-person-plus">Alta</i> </asp:LinkButton>
                                  <asp:LinkButton ID="btnBajaC" runat="server" class="btn btn-primary orden mybtn mb-2" Text="" OnClick="btnBajaC_Click"><i class="bi bi-trash"> Baja</i></asp:LinkButton>
                                  <asp:LinkButton ID="btnModiC" runat="server" class="btn btn-primary orden mybtn mb-2" Text="" OnClick="btnModiC_Click"><i class="bi bi-tools">Modificación</i></asp:LinkButton> 
                                  <asp:LinkButton ID="btnConsultaC" runat="server" class="btn btn-primary orden mybtn mb-2" Text="" OnClick="btnConsultaC_Click"><i class="bi bi-search">Consulta</i></asp:LinkButton>
                              </div>
                       <asp:Label ID="lblConfirmacionC" runat="server" Text=""></asp:Label>
                   <asp:GridView ID="GridView2" class="orden2" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" DataKeyNames="ID_Cliente">
                       <Columns>
                           <asp:BoundField DataField="ID_Cliente" HeaderText="ID_Cliente" ReadOnly="True" SortExpression="ID_Cliente"></asp:BoundField>
                           <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre"></asp:BoundField>
                           <asp:BoundField DataField="Apellidos" HeaderText="Apellidos" SortExpression="Apellidos"></asp:BoundField>
                           <asp:BoundField DataField="Genero" HeaderText="Genero" SortExpression="Genero"></asp:BoundField>
                           <asp:BoundField DataField="DNI" HeaderText="DNI" SortExpression="DNI"></asp:BoundField>
                           <asp:BoundField DataField="Edad" HeaderText="Edad" SortExpression="Edad"></asp:BoundField>
                           <asp:BoundField DataField="Localidad" HeaderText="Localidad" SortExpression="Localidad"></asp:BoundField>
                           <asp:BoundField DataField="NumPersonas" HeaderText="NumPersonas" SortExpression="NumPersonas"></asp:BoundField>
                           <asp:BoundField DataField="Animales" HeaderText="Animales" SortExpression="Animales"></asp:BoundField>
                           <asp:BoundField DataField="Habitacion" HeaderText="Habitacion" SortExpression="Habitacion"></asp:BoundField>
                           <asp:BoundField DataField="Precio" HeaderText="Precio" SortExpression="Precio"></asp:BoundField>
                           <asp:BoundField DataField="FechaInicio" HeaderText="FechaInicio" SortExpression="FechaInicio"></asp:BoundField>
                           <asp:BoundField DataField="FechaFin" HeaderText="FechaFin" SortExpression="FechaFin"></asp:BoundField>
                           <asp:BoundField DataField="PackCamp" HeaderText="PackCamp" SortExpression="PackCamp"></asp:BoundField>
                           <asp:BoundField DataField="Dieta" HeaderText="Dieta" SortExpression="Dieta"></asp:BoundField>
                           <asp:BoundField DataField="Alergias" HeaderText="Alergias" SortExpression="Alergias"></asp:BoundField>
                           <asp:BoundField DataField="DiversidadFuncional" HeaderText="DiversidadFuncional" SortExpression="DiversidadFuncional"></asp:BoundField>
                           <asp:BoundField DataField="ID_Departamento" HeaderText="ID_Departamento" SortExpression="ID_Departamento"></asp:BoundField>
                       </Columns>
                   </asp:GridView>

                   <asp:SqlDataSource runat="server" ID="SqlDataSource1" ConnectionString='<%$ ConnectionStrings:SonriePerloraConnectionString1 %>' SelectCommand="SELECT * FROM [Cliente]"></asp:SqlDataSource>
               </form>
          </div>
        </header>
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