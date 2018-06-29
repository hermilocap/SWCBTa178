<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MenuHorariosAdmin.aspx.cs" Inherits="SitioWebCBTA.MenuHorariosAdmin" %>

<!DOCTYPE html>
<html>
<head>
    <title>Centro de Bachillerato Tecnologico Agropecuario No 178</title>
    <%--<link href="css/bootstrap.css" rel='stylesheet' type='text/css'/>--%>

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
                  <img src="images/logo.png" width="100" height="130" title="CBTa N°178"  />
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

                            <h3 class="panel-title">Horarios</h3>
<asp:Label ID="Label1" runat="server">Usuario:</asp:Label>
           <asp:Label ID="LabelUsurio" runat="server" Visible="false"></asp:Label>
                        </div>
                        <div class="panel-body">
    
                            <form id="Form1" class="form-horizontal" runat="server">
                                <div class="form-group">
                                    <div class="col-xs-offset-3 col-xs-9">

                                         <asp:Button ID="ButtonCerrarsesion" runat="server"  CssClass="btn btn-primary" Text="Cerrar sesion" OnClick="ButtonCerrarsesion_Click"/>
                                       
                                        <asp:Button ID="ButtonGuardarHorario" runat="server" CssClass="btn btn-primary" Text="Guardar" OnClick="ButtonGuardarHorario_Click" />
                                        <asp:Button ID="ButtonNuevoHorario" runat="server" CssClass="btn btn-default" Text="Nuevo" OnClick="ButtonNuevoHorario_Click" />
                                         <asp:Button ID="ButtonBuscarHorario" runat="server" CssClass="btn btn-success" Text="Buscar" OnClick="ButtonBuscarHorario_Click"/>  
                                         <asp:Button ID="ButtonEliminarDocente" runat="server" CssClass="btn btn-warning" Text="Eliminar" OnClick="ButtonEliminarDocente_Click"/>
                                        <asp:Button ID="ButtonModificarHorario" runat="server" CssClass="btn btn-danger" Text="Modificar" OnClick="ButtonModificarHorario_Click"/>
                                        
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-xs-3">Buscar por:</label>
                                    <div class="col-xs-3">
                                         <asp:DropDownList CssClass="form-control" ID="DropDownListTipoBusqueda" runat="server">
                                              <asp:ListItem>Seleccione una opcion</asp:ListItem>
                                            <asp:ListItem>Horario alumno</asp:ListItem>
                                            <asp:ListItem>Horario docente</asp:ListItem>
                                         </asp:DropDownList>
                                                 </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-xs-3">Id Docente:</label>
                                    <div class="col-xs-3">
                                        <asp:TextBox ID="TextBoxIdDocente" CssClass="form-control" TextMode="SingleLine" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-xs-3">Matricula Alumno:</label>
                                    <div class="col-xs-9">
                                        <asp:TextBox ID="TextBoxIdAlumno" CssClass="form-control" TextMode="SingleLine" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                               
                                   <div class="form-group">
                                    <label class="control-label col-xs-3">Semestre:</label>
                                    <div class="col-xs-9">
                                        <asp:DropDownList CssClass="form-control" ID="DropDownListSemestre" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownListSemestre_SelectedIndexChanged" >
                                            <asp:ListItem>Primer Semestre</asp:ListItem>
                                            <asp:ListItem>Segundo Semestre</asp:ListItem>
                                            <asp:ListItem>Tercer Semestre</asp:ListItem>
                                            <asp:ListItem>Cuarto Semestre</asp:ListItem>
                                            <asp:ListItem>Quinto Semestre</asp:ListItem>
                                            <asp:ListItem>Sexto Semestre</asp:ListItem> 

                                        </asp:DropDownList>
                                          
                                      
                                        
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-xs-3">Materia:</label>
                                    <div class="col-xs-9">
                                        <asp:DropDownList CssClass="form-control" ID="DropDownListMateria" runat="server" >

                                        </asp:DropDownList>
                                           <asp:TextBox ID="TextBoxNombreMateria"  Visible="false" CssClass="form-control" TextMode="SingleLine" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                              
                                <div class="form-group">
                                    <label class="control-label col-xs-3">Ciclo Escolar:</label>
                                 <div class="col-xs-9">
                                 <asp:DropDownList CssClass="form-control" ID="DropDownListCicloEscolar" runat="server">
                                     <asp:ListItem>Seleccione una opcion</asp:ListItem>
                                     <asp:ListItem>Enero 2015-Julio 1015</asp:ListItem>
                                     <asp:ListItem>Agosto 2015-Diciembre 2015</asp:ListItem>
                                 </asp:DropDownList>
                                </div>
                                    </div>
                                 <div class="form-group">
                                    <label class="control-label col-xs-3">Grupo:</label>
                                 <div class="col-xs-9">
                                 <asp:DropDownList CssClass="form-control" ID="DropDownListGrupo" runat="server">
                                     <asp:ListItem>Seleccione una opcion</asp:ListItem>
                                     <asp:ListItem>A</asp:ListItem>
                                     <asp:ListItem>B</asp:ListItem>
                                     <asp:ListItem>C</asp:ListItem>
                                     <asp:ListItem>D</asp:ListItem>
                                 </asp:DropDownList>
                                </div>
                                </div>

                                 <div class="form-group">
                                    <label class="control-label col-xs-3">Aula:</label>
                                 <div class="col-xs-9">
                                <asp:TextBox ID="TextBoxAula" CssClass="form-control" TextMode="SingleLine" runat="server"></asp:TextBox>
                                 
                                       </div>
                                    </div>

                                 <div class="form-group">
                                    <label class="control-label col-xs-3">Hora Entrada:</label>
                                 <div class="col-xs-9">
                                <asp:TextBox ID="TextBoxHoraEntrada" CssClass="form-control" TextMode="SingleLine" runat="server"></asp:TextBox>
                                 
                                       </div>
                                    </div>
                                <div class="form-group">
                                    <label class="control-label col-xs-3">Hora Salida:</label>
                                 <div class="col-xs-9">
                                <asp:TextBox ID="TextBoxHoraSalida" CssClass="form-control" TextMode="SingleLine" runat="server"></asp:TextBox>
                                 
                                       </div>
                                    </div>
                                <div class="form-group">
                                    <label class="control-label col-xs-3">Dias:</label>
                                 <div class="col-xs-9">
                                 <asp:DropDownList CssClass="form-control" ID="DropDownListDias" runat="server">
                                     <asp:ListItem>Seleccione una opcion</asp:ListItem>
                                     <asp:ListItem>L-M</asp:ListItem>
                                     <asp:ListItem>L-M-MM</asp:ListItem>
                                     <asp:ListItem>L-V</asp:ListItem>
                                     <asp:ListItem>L-J</asp:ListItem>
                                     <asp:ListItem>M-MM-J</asp:ListItem>
                                     <asp:ListItem>J-V</asp:ListItem>
                                 </asp:DropDownList>
                                </div>
                                </div>

                                <div class=" alert-success">
                                    <strong>
                                        <asp:Label ID="LabelMensaje" Visible="false" runat="server" Text=""></asp:Label></strong>
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


