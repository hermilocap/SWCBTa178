<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SitioWebCBTA.Login" %>


<!DOCTYPE html>
<html>
<head>
    <title>Centro de Bachillerato Tecnologico Agropecuario No 178</title>
    <%-- <link href="css/bootstrap.css" rel='stylesheet' type='text/css' />--%>

    <!-- Latest compiled and minified CSS -->
    <link rel="stylesheet" href="bootstrap/css/bootstrap.min.css">

    <!-- Optional theme -->
    <link rel="stylesheet" href="bootstrap/css/bootstrap-theme.min.css">

    <!-- Latest compiled and minified JavaScript -->
    <script src="bootstrap/js/bootstrap.min.js"></script>

    <link href="css/style.css" rel="stylesheet" type="text/css" media="all" />
    <link href='http://fonts.googleapis.com/css?family=Montserrat:400,700' rel='stylesheet' type='text/css'>
    <link href='http://fonts.googleapis.com/css?family=Raleway:400,100,300,500,600,700,800,900' rel='stylesheet' type='text/css'>

    <script type="application/x-javascript"> addEventListener("load", function() { setTimeout(hideURLbar, 0); }, false); function hideURLbar(){ window.scrollTo(0,1); } </script>
    <script src="js/jquery.min.js"></script>

    <script type="text/javascript" src="js/funciones.js"></script>

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
                    <img src="images/logo.png" width="100" height="130" title="CBTa N°178" /></a>
            </div>
            <div class="top-menu">
                <span class="menu"></span>
                <ul>
                    <li><a href="Default.aspx">INICIO</a></li>
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
    <!--banner/-->
    <div class="single">
        <div class="container">
             <div class="panel panel-primary">
                        <div class="panel-heading">

                            <h3 class="panel-title">Iniciar sesion</h3>

                        </div>
                        <div class="panel-body">
                <form class="form-horizontal" runat="server">

                    <div class="form-group">
                        <label for="inputName" class="control-label col-xs-2">Rol</label>
                        <div class="col-xs-3">
                            <asp:DropDownList ID="DropDownListRol" Width="300px" CssClass="form-control" runat="server">
                                <asp:ListItem>Seleccione una opcion...</asp:ListItem>
                                 <asp:ListItem>Administrador</asp:ListItem>
                                <asp:ListItem>Docente</asp:ListItem>
                                <asp:ListItem>Alumno</asp:ListItem>
                            </asp:DropDownList>

                        </div>
                    </div>

                    <div class="form-group">
                        <label for="inputPassword" class="control-label col-xs-2">Usuario:</label>
                        <div class="col-xs-3">

                            <asp:TextBox ID="TextBoxUsuario" Width="300px" TextMode="SingleLine" runat="server" CssClass="form-control"></asp:TextBox>
                                    </div>
                    </div>
                    <div class="form-group">
                        <label for="inputPassword" class="control-label col-xs-2">Password:</label>
                        <div class="col-xs-3">

                            <asp:TextBox ID="TextBoxPassword" Width="300px" CssClass="form-control" runat="server"  TextMode="Password" pattern="^[0-9]+"/>
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="col-xs-offset-2 col-xs-3">
                            <asp:Button ID="ButtonAceptar" runat="server" CssClass="btn btn-primary" Text="Aceptar" OnClick="ButtonAceptar_Click" />
                        </div>
                    </div>

                            <div class="alert-danger"><strong>
                                    <asp:Label ID="LabelError" Visible="false" runat="server" Text=""></asp:Label></strong>

                                </div>

                </form>
                        </div>
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
                <a class="scroll" href="#home">
                    <img src="images/top.png" alt="" /></a>
            </div>
	 </div>
    </div>
    <!---->
</body>
</html>
