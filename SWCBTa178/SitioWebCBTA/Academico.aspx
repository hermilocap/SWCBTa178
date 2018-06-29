<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Academico.aspx.cs" Inherits="SitioWebCBTA.Academico" %>


<!DOCTYPE html>
<html>
<head>
<title>Centro de Bachillerato Tecnologico Agropecuario No 178</title>

<link href="css/bootstrap.css" rel='stylesheet' type='text/css'/>
<link href="css/style.css" rel="stylesheet" type="text/css" media="all"/>

<link href='http://fonts.googleapis.com/css?family=Montserrat:400,700' rel='stylesheet' type='text/css'>
<link href='http://fonts.googleapis.com/css?family=Raleway:400,100,300,500,600,700,800,900' rel='stylesheet' type='text/css'>
<meta charset="utf-8">
<meta name="viewport" content="width=device-width, initial-scale=1">
<meta name="keywords" content="cbta 178, CBTA, CBTA 178, CBTa 178, san luis acatlan, San luis Acatlan"/>
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
			 <a href="Default.aspx"><img src="images/logo.png" width="100" height="130" title="CBTa N°178"/></a>
		 </div>			  
		 <div class="top-menu">
			 <span class="menu"></span> 					 
			 <ul>
				 <li ><a href="Default.aspx">INICIO</a></li>
				 <li><a  href="CBTA.aspx">CBTA 178</a></li>
				 <li><a  href="OfertaEducativa.aspx">OFERTA EDUCATIVA</a></li>
				 <li class="active"><a  href="Academico.aspx">ACADEMICO</a></li>	
				 <li><a  href="Administracion.aspx">ADMINISTRACION</a></li>	
				 <li><a  href="Documentos.aspx">DOCUMENTOS</a></li>					 
			  </ul>					 
		 </div>	
		 <div class="clearfix"> </div>	
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
<!--banner/-->
<div class="single">
	 <div class="container">
		 <h2>Academico.</h2>
		 <div class="single-section">
			 <div class="single-pic">
			 <img src="images/single.jpg" alt=""/>
			 </div>
             <h3>Requisitos para obtener ficha.</h3>
             <ul>
                 <li>Constancia de estudios de secundaria</li>
                 <li>Copia del acta de nacimiento</li>
                 <li>Copia de la curp</li>
                 <li>2 fotos  tamano infantil</li>
             </ul>
              <h3>Requisito para inscripcion </h3>
             <ul>
                 <li>Certificado de secundaria</li>
                 <li>Acta de nacimiento</li>
                 <li>Constancia de conducta</li>
                 <li>Curp</li>
                 <li>Cartilla nacional de vacunacion(Todo en original y tres copias)</li>
                 <li>2 fotografias tamaño infantil</li>
                 <li>1 folder tamaño oficio color beige</li>

             </ul>
			 		 <h3>Nota importante.</h3>
		    <p>Se aplicara un examen de seleccion de conocimientos basicos en las areas:</p>
             <ul>
                 <li>Matematicas</li>
                 <li>Fisica</li>
                 <li>Quimica</li>
                 <li>Biologia</li>
                 <li>Español</li>
             </ul>
             <p>Todo aspirante que apruebe el examen podra inscribirse</p>
             <p>Fecha de aplicacion de examen de seleccion 09 de junio a las <time>8:00 AM</time></p>
             	 </div>
	 </div>
</div>
<!---fotter-->
<!---->
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
			 <a class="scroll" href="#home"><img src="images/top.png" alt=""/></a>
		 </div>
	 </div>
</div>
<!---->
</body>
</html>

