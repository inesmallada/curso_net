<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication2.Default" %>


<!DOCTYPE html>
<html lang="es">
    <head>
        <meta charset="utf-8" />
        <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
        <meta name="description" content="" />
        <meta name="author" content="" />
        <title>Home</title>
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
                <div class="row gx-4 gx-lg-5 h-100 align-items-center justify-content-center text-center">
                    <div class="col-lg-8 align-self-end">
                        <h1 class="text-white font-weight-bold">Sonríe, Perlora te espera</h1>
                        <hr class="divider" />
                    </div>
                    <div class="col-lg-8 align-self-baseline">
                        <p class="text-white-75 mb-5">Ven a disfrutar, compartir y revivir buenos momentos. Te encontrarás grandes sorpresas</p>
                        <a class="btn btn-primary btn-xl" href="#about">[RE]descubre Perlora </a>
                    </div>
                </div>
            </div>
        </header>
        <!-- About-->
        <section class="page-section bg-primary" id="acceso">
            <div class="container px-4 px-lg-5">
                <div class="row gx-4 gx-lg-5 justify-content-center">
                    <div class="col-lg-8 text-center">
                        <h2 class="text-white mt-0">Únete a nuestra gran familia</h2>
                        <hr class="divider divider-light" />
                        <p class="text-white-75 mb-4">¿Tienes curiosidad? Te entendemos. Por eso te animamos a registrarte y comprobar de primera mano todo lo que "Sonrie en Perlora" te ofrece </p>
                        <div class="row">
                            <a class="col btn btn-light btn-xl" href="Admin.aspx">Acceso Administrador</a>
                            <a class="col btn btn-light btn-xl" href="Personal.aspx">Acceso Personal</a>
                             <a class="col btn btn-light btn-xl" href="Cliente.aspx">Acceso Cliente</a>
                            <a class="col btn btn-light btn-xl" href="#contactForm">Regístrate</a>
                        </div>
                    </div>
                </div>
            </div>
        </section>
        <!-- Services-->
        <section class="page-section" id="services">
            <div class="container px-4 px-lg-5">
                <h2 class="text-center mt-0">¿Qué te ofrecemos?</h2>
                <hr class="divider" />
                <div class="row gx-4 gx-lg-5">
                    <div class="col-lg-3 col-md-6 text-center">
                        <div class="mt-5">
                            <div class="mb-2"><i class="bi bi-house fs-1 text-primary"></i></div>
                            <h3 class="h4 mb-2">Alojamiento para todas</h3>
                            <p class="text-muted mb-0">Vuestras necesidades están cubiertas, sean las que sean.</p>
                        </div>
                    </div>
                    <div class="col-lg-3 col-md-6 text-center">
                        <div class="mt-5">
                            <div class="mb-2"><i class="bi bi-water bi-alarm bi-tree fs-1 text-primary"></i></div>
                            <h3 class="h4 mb-2">Playas y merenderos</h3>
                            <p class="text-muted mb-0">Todo disponible para exprimir al máximo la experiencia en Perlora.</p>
                        </div>
                    </div>
                    <div class="col-lg-3 col-md-6 text-center">
                        <div class="mt-5">
                            <div class="mb-2"><i class="bi bi-bicycle fs-1 text-primary"></i></div>
                            <h3 class="h4 mb-2">Explora</h3>
                            <p class="text-muted mb-0">Preciosas rutas por el concejo de Carreño al Cabu Peñes.</p>
                        </div>
                    </div>
                    <div class="col-lg-3 col-md-6 text-center">
                        <div class="mt-5">
                            <div class="mb-2"><i class="bi-heart fs-1 text-primary"></i></div>
                            <h3 class="h4 mb-2">Hecho con AMOR...</h3>
                            <p class="text-muted mb-0">A la naturaleza, a los animales y a grandes y peques.</p>
                        </div>
                    </div>
                </div>
            </div>
        </section>
        <!-- Portfolio    TODO: buscar fotos de Perlora, actividades y enlazarlas aquí-->
        <div id="portfolio">
            <div class="container-fluid p-0">
                <div class="row g-0">
                    <div class="col-lg-4 col-sm-6">
                        <a class="portfolio-box" href="assets/img/portfolio/fullsize/1.jpg" title="Menudo Público">
                            <img class="img-fluid" src="assets/img/portfolio/thumbnails/1.jpg" alt="zona de juegos infantiles" />
                            <div class="portfolio-box-caption">
                                <div class="project-category text-white-50">Categoría</div>
                                <div class="project-name">"Menudo" Público</div>
                            </div>
                        </a>
                    </div>
                    <div class="col-lg-4 col-sm-6">
                        <a class="portfolio-box" href="assets/img/portfolio/fullsize/2.jpg" title="[re]Descubriendo Perlora a pie o en bici">
                            <img class="img-fluid" src="assets/img/portfolio/thumbnails/2.jpg" alt="Rutas y Paseos por Perlora" />
                            <div class="portfolio-box-caption">
                                <div class="project-category text-white-50">Categoría</div>
                                <div class="project-name">[re]Descubriendo Perlora a pie o en bici</div>
                            </div>
                        </a>
                    </div>
                    <div class="col-lg-4 col-sm-6">
                        <a class="portfolio-box" href="assets/img/portfolio/fullsize/3.jpg" title="Merenderos públicos">
                            <img class="img-fluid" src="assets/img/portfolio/thumbnails/3.jpg" alt="Merenderos públicos con vistas al mar" />
                            <div class="portfolio-box-caption">
                                <div class="project-category text-white-50">Categoría</div>
                                <div class="project-name">Merenderos públicos</div>
                            </div>
                        </a>
                    </div>
                    <div class="col-lg-4 col-sm-6">
                        <a class="portfolio-box" href="assets/img/portfolio/fullsize/4.jpg" title="Alojamiento 3R">
                            <img class="img-fluid" src="assets/img/portfolio/thumbnails/4.jpg" alt="uno de los tipos de alojamiento en Perlora" />
                            <div class="portfolio-box-caption">
                                <div class="project-category text-white-50">Categoría</div>
                                <div class="project-name">Alojamiento 3R (Reducir, Reutilizar y Reciclar.)</div>
                            </div>
                        </a> 
                    </div>
                    <div class="col-lg-4 col-sm-6">
                        <a class="portfolio-box" href="assets/img/portfolio/fullsize/5.jpg" title="Playas inolvidables">
                            <img class="img-fluid" src="assets/img/portfolio/thumbnails/5.jpg" alt="playas paradisíacas" />
                            <div class="portfolio-box-caption">
                                <div class="project-category text-white-50">Categoría</div>
                                <div class="project-name">Playas inolvidables</div>
                            </div>
                        </a>
                    </div>
                    <div class="col-lg-4 col-sm-6">
                        <a class="portfolio-box" href="assets/img/portfolio/fullsize/6.jpg" title="Men sana y corpore sano">
                            <img class="img-fluid" src="assets/img/portfolio/thumbnails/6.jpg" alt="instalaciones deportivas" />
                            <div class="portfolio-box-caption p-3">
                                <div class="project-category text-white-50">Categoría</div>
                                <div class="project-name">Men sana y corpore sano</div>
                            </div>
                        </a>
                    </div>
                </div>
            </div>
        </div>
        <!-- Call to action-->
        <section class="page-section bg-dark text-white">
            <div class="container px-4 px-lg-5 text-center">
                <h2 class="mb-4">No dejes pasar la oportunidad</h2>
                <a class="btn btn-light btn-xl" href="#contact">¡Regístrate YA!</a>
            </div>
        </section>
        <!-- Contact-->
        <section class="page-section" id="contact">
            <div class="container px-4 px-lg-5">
                <div class="row gx-4 gx-lg-5 justify-content-center">
                    <div class="col-lg-8 col-xl-6 text-center">
                        <h2 class="mt-0">¡Vamos, ya casi lo tienes!</h2>
                        <hr class="divider" />
                        <p class="text-muted mb-5">[re]Inventa tus vacaciones con Sonríe en Perlora. Regístrate y comienza a planificar vacaciones en familia, con amigas y amigos, en campamentos para mayores y menores en un entorno inmejorable.</p>
                    </div>
                </div>
                <div class="row gx-4 gx-lg-5 justify-content-center mb-5">
                    <div class="col-lg-6">
                        <!-- * * * * * * * * * * * * * * *-->
                        <!-- * * SB Forms Contact Form * *-->
                        <!-- * * * * * * * * * * * * * * *-->
                        <!-- This form is pre-integrated with SB Forms.-->
                        <!-- To make this form functional, sign up at-->
                        <!-- https://startbootstrap.com/solution/contact-forms-->
                        <!-- to get an API token!-->
                        <form id="contactForm" data-sb-form-api-token="API_TOKEN">
                            <!-- Name input-->
                            <div class="form-floating mb-3">
                                <input class="form-control" id="name" type="text" placeholder="Introduce tu nombre y apellidos..." />
                                <label for="name">Nombre y Apellidos</label>
                               
                            </div>
                            <!-- Email address input-->
                            <div class="form-floating mb-3">
                                <input class="form-control" id="email" type="email" placeholder="name@example.com" />
                                <label for="email">Email</label>
                               
                            </div>
                            <!-- Phone number input-->
                            <div class="form-floating mb-3">
                                <input class="form-control" id="phone" type="tel" placeholder="000 000 000"/>
                                <label for="phone">Teléfono</label>
                                
                            </div>
                            <!-- Message input-->
                            <div class="form-floating mb-3">
                                <textarea class="form-control" id="message" type="text" placeholder="Escribe aquí tu mensaje..." style="height: 10rem"></textarea>
                                <label for="message">Mensaje</label>
                                
                            </div>
                            <!-- Submit success message-->
                            <!---->
                            <!-- This is what your users will see when the form-->
                            <!-- has successfully submitted-->
                            <div class="d-none" id="submitSuccessMessage">
                                <div class="text-center mb-3">
                                    <div class="fw-bolder">Formulario de registro hecho. </div>
                                   <p> Para continuar con la reserva, haz click en el botón</p>
                                    <button class="btn btn-primary btn-xl" type="submit" href="Admin.aspx"></button>
                                </div>
                            </div>
                            <!-- Submit error message-->
                            <!---->
                            <!-- This is what your users will see when there is-->
                            <!-- an error submitting the form-->
                            <div class="d-none" id="submitErrorMessage"><div class="text-center text-danger mb-3">¡Error enviando mensaje!</div></div>
                            <!-- Submit Button-->
                            <div class="d-grid"><button class="btn btn-primary btn-xl" id="submitButton" type="submit">Enviar</button></div>
                        </form>
                    </div>
                </div>
                <div class="row gx-4 gx-lg-5 justify-content-center">
                    <div class="col-lg-4 text-center mb-5 mb-lg-0">
                        <i class="bi-phone fs-2 mb-3 text-muted"></i>
                        <div>+34 (985) 123-4567</div>
                    </div>
                </div>
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
