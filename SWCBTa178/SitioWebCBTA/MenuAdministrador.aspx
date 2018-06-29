<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MenuAdministrador.aspx.cs" Inherits="SitioWebCBTA.MenuAdministrador" %>

<!DOCTYPE html>
<html>
<head>
    <title>Centro de Bachillerato Tecnologico Agropecuario No 178</title>
    

    <!-- Latest compiled and minified CSS -->
    <link rel="stylesheet" href="bootstrap/css/bootstrap.min.css">

    <!-- Optional theme -->
    <link rel="stylesheet" href="bootstrap/css/bootstrap-theme.min.css">

    <!-- Latest compiled and minified JavaScript -->
    <script src="bootstrap/js/bootstrap.min.js"></script>

    <link href="css/style.css" rel="stylesheet" type="text/css" media="all" />
    <link href='http://fonts.googleapis.com/css?family=Montserrat:400,700' rel='stylesheet' type='text/css'>
    <link href='http://fonts.googleapis.com/css?family=Raleway:400,100,300,500,600,700,800,900' rel='stylesheet' type='text/css'>
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <script type="application/x-javascript"> addEventListener("load", function() { setTimeout(hideURLbar, 0); }, false); function hideURLbar(){ window.scrollTo(0,1); } </script>
    <script src="js/jquery.min.js"></script>
    <script src="js/jquery.js"></script>
    <script src="js/tab.js"></script>
    <script src="js/tooltip.js"></script>
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
</head>
<body>
    <div class="page-header">
        <div class="container">
        <div class="row">
            <div class="col-xs-2">
                <div class="logo">
                    <img  src="images/logo.png" width="100" height="130" title="CBTa N°178" />
                </div>
            </div>
            <div class="col-xs-9">
        <h1><small>Centro de Bachillerato Tecnologico Agropecuario 178</small></h1>
                 <h2><small>SISTEMA DE CONTROL ESCOLAR</small></h2>
            </div> 
            </div>
            </div>
    </div>
    <div class="container">
        <div class="row">

            <ul class="nav nav-tabs">
                <li><a href="MenuAdministrador.aspx" >Alumnos</a></li>
                <li><a href="MenuDocenteAdmin.aspx" >Docentes</a></li>
                <li><a href="MateriasAdmin.aspx" >Materias</a></li>
                <li><a href="MenuHorariosAdmin.aspx" >Horarios</a></li>
                <li><a href="MenuCalificacionAdmin.aspx" >Calificaciones</a></li>
            </ul>

            <div class="tab-content">
                <div class="tab-pane active" id="tab1">
                    <div class="panel panel-primary">
                        <div class="panel-heading">

                            <h3 class="panel-title">Alumnos</h3>
                             <asp:Label ID="Label1" runat="server">Usuario:</asp:Label>
                            <asp:Label ID="LabelUsurio" runat="server" Visible="false"></asp:Label>
                            
                        </div>
                        
                        <div class="panel-body">
                            <form class="form-horizontal" runat="server">
                                <div class="form-group">
                                    <div class="col-xs-offset-3 col-xs-9">
                                        <asp:Button ID="ButtonCerrarsesion" runat="server"  CssClass="btn btn-primary" Text="Cerrar sesion" OnClick="ButtonCerrarsesion_Click"/>
                                        <asp:Button ID="ButtonGuardarAlumno" runat="server" CssClass="btn btn-primary" Text="Guardar" OnClick="ButtonGuardarAlumno_Click" />
                                        <asp:Button ID="ButtonNuevoAlumno" runat="server" CssClass="btn btn-default" Text="Nuevo" OnClick="ButtonNuevoAlumno_Click" />
                                        <asp:Button ID="ButtonBuscarAlumno" runat="server" CssClass="btn btn-success" Text="Buscar" OnClick="ButtonBuscarAlumno_Click"/>
                                        <asp:Button ID="ButtonEliminarAlumno" runat="server" CssClass="btn btn-warning" Text="Eliminar" OnClick="ButtonEliminarAlumno_Click"/>
                                         <asp:Button ID="ButtonModificarAlumno" runat="server" CssClass="btn btn-danger" Text="Modificar" OnClick="ButtonModificarAlumno_Click"/>
                                         <asp:Button ID="ButtonConsultarAlumno" runat="server" CssClass="btn btn-info" Text="Consultar" OnClick="ButtonConsultarAlumno_Click"/>

                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-xs-3">Matricula:</label>
                                    <div class="col-xs-4">
                                        <asp:TextBox ID="TextBoxMatriculaAlumno" CssClass="form-control" TextMode="SingleLine"   runat="server" pattern="^[0-9]+" ></asp:TextBox>
                                                </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-xs-3">Usuario:</label>
                                    <div class="col-xs-9">
                                        <asp:TextBox ID="TextBoxUsuarioAlumno" CssClass="form-control" TextMode="SingleLine" runat="server" pattern="^[A-Za-z ÑñáéíóúÁÉÍÓÚ]*$"></asp:TextBox>
                                        
                                    </div>

                                </div>

                                <div class="form-group">
                                    <label class="control-label col-xs-3">Password:</label>
                                    <div class="col-xs-9">
                                        <asp:TextBox ID="TextBoxPasswordAlumno" CssClass="form-control"  runat="server" pattern="^[0-9]+"></asp:TextBox>
                                        
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-xs-3">Nombre:</label>
                                    <div class="col-xs-9">
                                        <asp:TextBox ID="TextBoxNombreAlumno" CssClass="form-control" TextMode="SingleLine" runat="server" pattern="^[A-Za-z ÑñáéíóúÁÉÍÓÚ]*$"></asp:TextBox>
                                        
                                    </div>
                                </div>

                                <div class="form-group">
                                    <label class="control-label col-xs-3">Apellidos:</label>
                                    <div class="col-xs-9">
                                        <asp:TextBox ID="TextBoxApellidoAlumno" CssClass="form-control" TextMode="SingleLine" runat="server" pattern="^[A-Za-z ÑñáéíóúÁÉÍÓÚ]*$"></asp:TextBox>
                                        
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-xs-3">Sexo:</label>
                                    <div class="col-xs-2">
                                        <label class="radio-inline">
                                            <asp:RadioButton ID="RadioButtonMasculinoAlumno" runat="server" OnCheckedChanged="RadioButtonMasculinoAlumno_CheckedChanged" AutoPostBack="True" />Maculino
                                        </label>
                                    </div>
                                    <div class="col-xs-2">
                                        <label class="radio-inline">
                                            <asp:RadioButton ID="RadioButtonFemeninoAlumno" runat="server" OnCheckedChanged="RadioButtonFemeninoAlumno_CheckedChanged" AutoPostBack="True" />Femenino
                                        </label>
                                    </div>
                                </div>

                                <div class="form-group">
                                    <label class="control-label col-xs-3">Edad:</label>
                                    <div class="col-xs-9">
                                        <asp:TextBox ID="TextBoxEdadAlumno" CssClass="form-control" runat="server" pattern="^[0-9]+" TextMode="Number"></asp:TextBox>
                                        
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-xs-3">Municipio:</label>
                                    <div class="col-xs-9">
                                        <asp:TextBox ID="TextBoxMuncipioAlumno" CssClass="form-control" TextMode="SingleLine" runat="server" pattern="^[A-Za-z ÑñáéíóúÁÉÍÓÚ]*$"></asp:TextBox>
                                        
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-xs-3">Localidad:</label>
                                    <div class="col-xs-9">
                                        <asp:TextBox ID="TextBoxLocalidadAlumno" CssClass="form-control" TextMode="SingleLine" runat="server" pattern="^[A-Za-z ÑñáéíóúÁÉÍÓÚ]*$"></asp:TextBox>
                                        
                                    </div>
                                </div>

                                <div class="form-group">
                                    <label class="control-label col-xs-3">Dirección:</label>
                                    <div class="col-xs-9">
                                        <asp:TextBox ID="TextBoxDireccionAlumno" CssClass="form-control" TextMode="SingleLine" runat="server"></asp:TextBox>
                                        
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-xs-3">Codigo Postal:</label>
                                    <div class="col-xs-9">
                                        <asp:TextBox ID="TextBoxCodigoPostalAlumno" CssClass="form-control" runat="server" pattern="^[0-9]+"></asp:TextBox>
                                        
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-xs-3">Email:</label>
                                    <div class="col-xs-9">
                                        <asp:TextBox ID="TextBoxEmailAlumno" CssClass="form-control" TextMode="Email" runat="server" pattern="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:TextBox>
                                        
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-xs-3">Foto:</label>
                                    <div class="col-xs-9">
                                        <asp:Image ID="ImageAlumno" Width="90" Height="100" runat="server" />
                                        <asp:FileUpload ID="FileUploadAlumno" CssClass="form-control" runat="server" />
                                        <asp:Button ID="ButtonCargarImagenAlumno" runat="server" CssClass="btn btn-primary" Text="Cargar" OnClick="ButtonCargarImagenAlumno_Click" />

                                    </div>

                                </div>
                                <div class="form-group">
                                    <label class="control-label col-xs-3">Semestre:</label>
                                    <div class="col-xs-9">
                                        <asp:DropDownList CssClass="form-control" ID="DropDownListSemestre" runat="server">

                                             <asp:ListItem>Primer Semestre</asp:ListItem>
                                            <asp:ListItem>Segundo Semestre</asp:ListItem>
                                            <asp:ListItem>Tercer Semestre</asp:ListItem>
                                            <asp:ListItem>Cuarto Semestre</asp:ListItem>
                                            <asp:ListItem>Quinto Semestre</asp:ListItem>
                                            <asp:ListItem>Sexto Semestre</asp:ListItem> 
                                        </asp:DropDownList>
                                        
                                    </div>
                                </div>
                               
                                <div class=" alert-success">
                                    <strong>
                                        <asp:Label ID="LabelMensajeAlumno" Visible="false" runat="server" Text=""></asp:Label></strong>
                                </div>
                                <div class="alert-danger"><strong>
                                    <asp:Label ID="LabelError" Visible="false" runat="server" Text=""></asp:Label></strong></div>
                                <div class="alert-warning"><strong>
                                    <asp:Label ID="LabelAdvertencia" Visible="false" runat="server" Text=""></asp:Label></strong></div>

                            </form>
                        </div>
                    </div>
                </div>
               

        </div>
        </div>


    </div>
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

