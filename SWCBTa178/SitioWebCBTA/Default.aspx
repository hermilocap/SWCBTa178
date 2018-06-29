<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SitioWebCBTA.Default" %>

<!DOCTYPE html>
<html>
<head>
    <title>CBTa N°178</title>

        <script src="http://html5shim.googlecode.com/svn/trunk/html5.js"></script>
    
      <%--  <link href="~/favicon.jpg" rel="shortcut icon" type="image/x-icon" />--%>
    <link href="css/bootstrap.css" rel='stylesheet' type='text/css' />
    <link href="css/style.css" rel="stylesheet" type="text/css" media="all" />
    <link href='http://fonts.googleapis.com/css?family=Source+Sans+Pro' rel='stylesheet' type='text/css'>
    <link href='http://fonts.googleapis.com/css?family=Montserrat:400,700' rel='stylesheet' type='text/css'>
    <link href='http://fonts.googleapis.com/css?family=Raleway:400,100,300,500,600,700,800,900' rel='stylesheet' type='text/css'>
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta name="keywords" content="cbta 178, CBTA, CBTA 178, CBTa 178, san luis acatlan, San luis Acatlan" />
    <meta name="description" content="Centro de bachillerato tecnologico Agropecuario No 178." />
    <meta name="author" content="Departamento de informatica" />
    <meta charset="utf-8">
    <script type="application/x-javascript"> addEventListener("load", function() { setTimeout(hideURLbar, 0); }, false); function hideURLbar(){ window.scrollTo(0,1); } </script>
    <script src="js/jquery.min.js"></script>
    <!---- start-smoth-scrolling---->
    <script type="text/javascript" src="js/move-top.js"></script>
    <script type="text/javascript" src="js/easing.js"></script>
    <script type="text/javascript">
        jQuery(document).ready(function ($) {
            $(".scroll").click(function (event) {
                event.preventDefault();
                $('html,body').animate({ scrollTop: $(this.hash).offset().top }, 900);
            });
        });
    </script>
    <!---- start-smoth-scrolling---->
</head>
<body>
    <!--body-->
    <div id="home" class="top-header">
        <div class="container">
            <div class="logo">
                <a href="Default.aspx">
                    <img src="images/logo.png" width="100" height="130" title="CBTa N°178"/></a>
            </div>
            <div class="top-menu">
                <span class="menu"></span>
                <ul>
                    <li class="active"><a href="Default.aspx">INICIO</a></li>
                    <li><a href="CBTA.aspx">CBTA 178</a></li>
                    <li><a href="OfertaEducativa.aspx">OFERTA EDUCATIVA</a></li>
                    <li><a href="Academico.aspx">ACADEMICO</a></li>
                    <li><a href="Administracion.aspx">ADMINISTRACION</a></li>
                    <li><a href="Documentos.aspx">DOCUMENTOS</a></li>
                </ul>
            </div>
            <div class="clearfix"></div>
            <!-- script-for-menu -->
            <script>
                $("span.menu").click(function () {
                    $(".top-menu ul").slideToggle("slow", function () {
                    });
                });
            </script>
            <!-- script-for-menu -->

        </div>
    </div>
    <!---->

    <div class="banner">
        <div class="container">
            <div class="banner-info">
                
                <h1>CBTa N°178</h1>
                <a class="hvr-bounce-to-bottom" href="Login.aspx">INICIAR SESION</a>
            </div>
        </div>
    </div>

    <div id="news" class="news">
       <div class="news-info">
            <h3>BIENVENIDOS A NUESTRO SITIO WEB</h3>
            <p>Centro de Bachillerato Tecnologico Agropecuario N°178</p>
        </div>
        <div class="news-grids">
            <div class="col-md-4 news-grid">
                <img src="images/n1.jpg" alt="" />
                <div class="news-pic-info" style="height: 270px;">
                    <h3><a href="single.html">MISION</a></h3>
                    <p>Ofrecer una formación integral, social, humanista y tecnológica para formar técnicos comprometidos hacia el sector rural, que fortalezcan la pertinencia, fomenten la mentalidad emprendedora y de liderazgo.</p>

                    <div class="clearfix"></div>
                </div>
            </div>
            <div class="col-md-4 news-grid">
                <img src="images/n2.jpg" alt="" />
                <div class="news-pic-info">
                    <h3><a href="single.html">VISION</a></h3>
                    <p>Ofrecer a las zonas rurales una educación pertinente, incluyente, innovadora e integralmente formativa, que sea eje fundamental del desarrollo del campo, con los valores importantes, respetando los usos y costumbres que prevalecen en la región.</p>

                    <div class="clearfix"></div>
                </div>
            </div>
            <div class="col-md-4 news-grid">
                <img src="images/n3.jpg" alt="" />
                <div class="news-pic-info" style="height: 270px;">
                    <h3><a href="single.html">VALORES</a></h3>
                    <p>
                  •	Respeto
                  <br>•	Responsabilidad <br/>
                  •	Solidaridad
                  <br>•	Puntualidad <br/>
                  •	Tolerancia 
                  <br>•	Amistad <br/>
                  •	Verdad
                    </p>

                    <div class="clearfix"></div>
                </div>
            </div>
            <div class="clearfix"></div>
        </div>
    </div>

    <div id="portfolio" class="gallery" style="margin-bottom: 50px;">
        <div class="container">
            <div class="gallery-head">
                <h3>Centro de Bachillerato Tecnologico Agropecuario</h3>
                <p><a href="#" class="cbta" target="_blank"><b>CBTA</b></a> es el acrónimo de Centro de Bachillerato Tecnológico Agropecuario establecido en México a través de la 
                    <a href="http://dgeta.sems.gob.mx/" class="dgeta" target="_blank"><b>DGETA</b></a> (Dirección General de Educación Tecnológica Agropecuaria) la cual es dependiente adscrita de la 
                    <a href="http://www.sems.gob.mx/" class="sems" target="_blank"><b>SEMS</b></a> (Subsecretaría de Educación Media Superior), que a su vez depende de la <a href="http://www.sep.gob.mx/" class="sep" target="_blank"><b>SEP</b></a>
                    (Secretaría de Educación Pública). Existen 284 planteles de CBTA que cuentan con bachillerato 
                    además de 18 carreras técnicas distintas.</p>
            </div>
             <div class="gallery-head">
                <h3>Oferta Educativa en Carrera Técnica</h3>
                <h4>Técnico Agropecuario</h4>
                <p>La Carrera de Técnico Agropecuario, proporciona las herramientas necesarias para que el estudiante adquiera los conocimientos, 
                    desarrolle habilidades y destrezas, y asuma una actitud responsable con el medio. 
                    En este sentido aplicará los principios básicos de la agricultura aplicando técnicas agrícolas, pecuarias y agroindustriales 
                    con amplio conocimiento y actitud de liderazgo, contará con habilidad para establecer relaciones interpersonales y 
                    con el medio ambiente; esta orientación se dará a través de la trayectoria curricular del componente profesional. 
                    </p>
            </div>
            <div class="gallery-head">
                <h3>Bachillerato</h3>
                <h4>Físico-Matemático</h4>
                <p>El área de físico matemático como una materia dentro de un bachillerato tecnológico es una herramienta muy importante para 
                    los alumnos que reciben el curso, ya que en esta área se obtienen conocimientos que en un futuro pueden ser muy útiles para 
                    ingresar en un escuela de nivel superior e inclinarse por una carrara técnica; se imparten conocimientos de física, 
                    matemáticas y dibujo técnico.</p><br/>
                 <h4>Quimico-Biologo</h4>
                <p>El Bachillerato Tecnológico en el area Químico-Biológicas es una carrera de bachillerato que contiene muchos temas de interés para los alumnos
                   , se integran asignaturas de tronco común y asignaturas de la especialidad del área médica y de enfermería. 
                    Al egresar recibirán certificado de terminación de estudios en el área 
                    Quimico-Biologicas, lo que les permitirá continuar con sus estudios de nivel superior.
                </p>
            </div>
             <!---->	
<div id="services" class="services" style="padding-bottom: 20px;">
	 <div class="container">
		 <div class="service-info">
		 <h3>SERVICIOS</h3>
		 
		 </div>
		 <div class="service-grids">
			 <div class="col-md-4 service-grid">
				 <div class="service-grid-path">
					 <div class="service-path">
						 <h3>Servicio Medico</h3>
						 <p>Todos los estudiantes inscritos recibirá la atención médico-hospitalaria 
                             que llegara a requerir por motivo de accidente o lesión deportiva.</p>
					 </div>
					 <div class="service-path-pic">
						 <img src="images/p1.png" alt=""/>
					 </div>
					 <div class="clearfix"></div>
				 </div>
				 <div class="service-grid-path">
					 <div class="service-path">
						 <h3>Seguro de Vida</h3>
						 <p>La Institucion otorgar a los alumnos una póliza de seguro de vida en caso de fallesimiento.</p>
					 </div>
					 <div class="service-path-pic">
						 <img src="images/p2.png" alt=""/>
					 </div>
					 <div class="clearfix"></div>
				 </div>
				 <div class="clearfix"></div>
			 </div>
			 <div class="col-md-4 phone">
				 <img src="images/phone.png" alt=""/>
			 </div>
			 
			 <div class="col-md-4 service-grid2">
				 <div class="service-grid-path">					 
					 <div class="service-path-pic">
						 <img src="images/p3.png" alt=""/>
					 </div>
					 <div class="service-path2">
						 <h3>Seguro Facultativo</h3>
						 <p>El Seguro de Salud para estudiantes es un aseguramiento médico que otorga el IMSS, 
                           de forma gratuita, a los estudiantes inscritos en instituciones públicas de nivel media superior.</p>
					 </div>
					 <div class="clearfix"></div>
				 </div>
				 <div class="service-grid-path">					 
					 <div class="service-path-pic">
						 <img src="images/p4.jpg" alt=""/>
					 </div>
					 <div class="service-path2">
						 <h3>Becas</h3>
						 <ul>
                             <li><a href="http://www.becasmediasuperior.sep.gob.mx/" target="_blank">Becas Federales</a></li>
                             <li><a href="http://www.becasmediasuperior.sep.gob.mx/" target="_blank">Excelencia</a></li>
                             <li><a href="#">Oportunidades</a></li>
                             <li><a href="http://www.becasmediasuperior.sep.gob.mx/" target="_blank">No Avandono</a></li>
						 </ul>
					 </div>
					 <div class="clearfix"></div>
				 </div>
				 <div class="clearfix"></div>
			 </div>
			 <div class="clearfix"></div>
		 </div>
	 </div>
</div>
<!---->	
            <div class="gallery-head">
                <h3>NUESTRA GALERIA FOTOGRAFICA</h3>
            </div>
        </div>
        <ul id="filters" class="clearfix">
            <li><span class="filter active" data-filter="app card icon logos web">Todos</span></li>
            <li><span class="filter" data-filter="app">Jardines</span></li>
            <li><span class="filter" data-filter="card">XXX Aniversario</span></li>
            <li><span class="filter" data-filter="icon">Eventos Deportivos</span></li>
            <li><span class="filter" data-filter="logos">Aulas</span></li>
        </ul>
        <div id="portfoliolist" class="more">
            <div class="portfolio card mix_all  wow bounceIn" data-wow-delay="0.4s" data-cat="card" style="display: inline-block; opacity: 1;">
                <div class="portfolio-wrapper grid_box">
                    <a href="images/pf1.jpg" class="swipebox" title="Image Title" target="_blank">
                        <img src="images/pf1.jpg" class="img-responsive">
                        <div class="caption">
                            <h4>XXX Aniversario</h4>
                            <p></p>
                        </div>
                    </a>
                </div>
            </div>
            <div class="portfolio app mix_all  wow bounceIn" data-wow-delay="0.4s" data-cat="app" style="display: inline-block; opacity: 1;">
                <div class="portfolio-wrapper grid_box">
                    <a href="images/pf2.jpg" class="swipebox" title="Image Title" target="_blank">
                        <img src="images/pf2.jpg" class="img-responsive" alt="">
                        <div class="caption">
                            <h4>Jardin</h4>
                            <p></p>
                        </div>
                    </a>
                </div>
            </div>
            <div class="portfolio icon mix_all  wow bounceIn" data-wow-delay="0.4s" data-cat="icon" style="display: inline-block; opacity: 1;">
                <div class="portfolio-wrapper grid_box">
                    <a href="images/pf3.jpg" class="swipebox" title="Image Title" target="_blank">
                        <img src="images/pf3.jpg" class="img-responsive" alt="">
                        <div class="caption">
                            <h4>Equipo de Futbol</h4>
                            <p></p>
                        </div>
                    </a>
                </div>

            </div>
            <div class="portfolio app mix_all  wow bounceIn" data-wow-delay="0.4s" data-cat="app" style="display: inline-block; opacity: 1;">
                <div class="portfolio-wrapper grid_box">
                    <a href="images/pf4.jpg" class="swipebox" title="Image Title" target="_blank">
                        <img src="images/pf4.jpg" class="img-responsive" alt="">
                        <div class="caption">
                            <h4>Jardin</h4>
                            <p></p>
                        </div>
                    </a>
                </div>
            </div>
            <div class="portfolio card mix_all  wow bounceIn" data-wow-delay="0.4s" data-cat="card" style="display: inline-block; opacity: 1;">
                <div class="portfolio-wrapper grid_box">
                    <a href="images/pf5.jpg" class="swipebox" title="Image Title" target="_blank">
                        <img src="images/pf5.jpg" class="img-responsive" alt="">
                        <div class="caption">
                            <h4>XXX Aniversario</h4>
                            <p></p>
                        </div>
                    </a>
                </div>
            </div>
            <div class="portfolio card mix_all  wow bounceIn" data-wow-delay="0.4s" data-cat="card" style="display: inline-block; opacity: 1;">
                <div class="portfolio-wrapper grid_box">
                    <a href="images/pf6.jpg" class="swipebox" title="Image Title" target="_blank">
                        <img src="images/pf6.jpg" class="img-responsive" alt="">
                        <div class="caption">
                            <h4>XXX Aniversario</h4>
                            <p></p>
                        </div>
                    </a>
                </div>
            </div>
            <div class="portfolio icon mix_all  wow bounceIn" data-wow-delay="0.4s" data-cat="icon" style="display: inline-block; opacity: 1;">
                <div class="portfolio-wrapper grid_box">
                    <a href="images/pf7.jpg" class="swipebox" title="Image Title" target="_blank">
                        <img src="images/pf7.jpg" class="img-responsive" alt="">
                        <div class="caption">
                            <h4>Equipo de Basquetbol</h4>
                            <p></p>
                        </div>
                    </a>
                </div>
            </div>
            <div class="portfolio logos mix_all wow bounceIn" data-wow-delay="0.4s" data-cat="logos" style="display: inline-block; opacity: 1;">
                <div class="portfolio-wrapper grid_box">
                    <a href="images/pf8.jpg" class="swipebox" title="Image Title" target="_blank">
                        <img src="images/pf8.jpg" class="img-responsive" alt="">
                        <div class="caption">
                            <h4>Aulas</h4>
                            <p></p>
                        </div>
                    </a>
                </div>
            </div>
        </div>
        <div class="clearfix"></div>
       <!--<div class="more">
            <h3>VER GALERIA COMPLETA</h3>
            <a class="plus" href="portfolio.html">
                <img src="images/more.jpg" alt="" /></a>
        </div> -->
    </div>
    <!-- Script for gallery Here -->
    <script type="text/javascript" src="js/jquery.mixitup.min.js"></script>
    <script type="text/javascript">
        $(function () {

            var filterList = {

                init: function () {

                    // MixItUp plugin
                    // http://mixitup.io
                    $('#portfoliolist').mixitup({
                        targetSelector: '.portfolio',
                        filterSelector: '.filter',
                        effects: ['fade'],
                        easing: 'snap',
                        // call the hover effect
                        onMixEnd: filterList.hoverEffect()
                    });

                },

                hoverEffect: function () {

                    // Simple parallax effect
                    $('#portfoliolist .portfolio').hover(
                        function () {
                            $(this).find('.label').stop().animate({ bottom: 0 }, 200, 'easeOutQuad');
                            $(this).find('img').stop().animate({ top: -30 }, 500, 'easeOutQuad');
                        },
                        function () {
                            $(this).find('.label').stop().animate({ bottom: -40 }, 200, 'easeInQuad');
                            $(this).find('img').stop().animate({ top: 0 }, 300, 'easeOutQuad');
                        }
                    );

                }

            };

            // Run the show!
            filterList.init();


        });
    </script>

    <div class="footer">
        <div class="container">
            <p>Todos los Derechos Reservados | Centro de Bachillerato Tecnologico Agropecuario N° 178<a href="#"></a></p>
            <p>Carretera San Luis Acatlan-Horcasitas Km 5, Playa Larga S/N, CP: 41603, San Luis Acatlán, Gro.</p>
            <p>Tel: 01 741-414-3145 - E-mail:
             <a href="https://login.live.com/login.srf?wa=wsignin1.0&rpsnv=12&ct=1429683303&rver=6.4.6456.0&wp=MBI_SSL_SHARED&wreply=https:%2F%2Fsnt152.mail.live.com%2Fdefault.aspx%3Fmkt%3Des-us%26rru%3Dinbox&lc=2058&id=64855&mkt=es-us&cbcxt=mai" target="_blank">
             cbta178@hotmail.com</a></p>
            <div class="social">
                <a href="https://es-es.facebook.com/pages/CBTA-178/101246509984372" target="_blank"><i class="facebook" title="facebook"></i></a>
                <a href="#"><i class="twitter"></i></a>
                
                <a href="https://plus.google.com/100403597256657228138/about?gl=mx&hl=es-419" target="_blank"><i class="google" title="google+"></i></a>
                <a href="https://www.youtube.com/results?search_query=cbta+178" target="_blank"><i class="youtube" title="youtube"></i></a>
            </div>
            <div class="arrow">
                <a class="scroll" href="#home">
                    <img src="images/top.png" alt="" /></a>
            </div>
        </div>
    </div>


</body>
</html>
