<%@ Page Language="C#" AutoEventWireup="true"  CodeBehind="MenuAlumnos.aspx.cs" Inherits="SitioWebCBTA.MenuAlumnos" %>

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
                
                <li><a href="#tab1" data-toggle="tab">Semestre Actual</a></li>
                <li><a href="#tab2" data-toggle="tab">Datos del Alumno</a></li>
                <li><a href="#tab3" data-toggle="tab">Horario</a></li>
                <li><a href="#tab4" data-toggle="tab">Calificacion Parcial</a></li>
                <li><a href="#tab5" data-toggle="tab">Calificacion Final</a></li>
                <li><a href="#tab6" data-toggle="tab">Kardex</a></li>
                <li><a href="#tab7" data-toggle="tab">Mensaje</a></li>
            </ul>
            <form id="Form2" class="form-horizontal" runat="server">
                <asp:Button ID="ButtonCerrarsesion" runat="server" CssClass="btn btn-primary" Text="Cerrar sesion" OnClick="ButtonCerrarsesion_Click" />
                                     
                <div class="tab-content">
                    <div class="tab-pane" id="tab1">
                        <div class="panel panel-primary">
                            <div class="panel-heading">

                                <h3 class="panel-title">Semestre Actual</h3>
                               
                            </div>
                            <div class="panel-body">
                                <%--<div class="alert alert-info"><strong>
                              <asp:Label ID="Label1" runat="server" Text="">Por favor rellene todos los campos que se solicitan a continuacion..</asp:Label></strong>

                          </div>--%>
                                <div class=" alert-success">
                                    <strong>
                                        <asp:Label ID="Label27" runat="server">
                                            Bienbenido al sistema de control escolar....
                                        </asp:Label></strong>

                                </div>



                            </div>
                        </div>
                    </div>


                    <div class="tab-pane active" id="tab2">

                        <div class="panel panel-primary">
                            <div class="panel-heading">

                                <h3 class="panel-title">Datos del alumno</h3>
                                
                            </div>
                            <div class="panel-body">
                                
                                <div class="form-group">
                                    <div class="col-xs-offset-3 col-xs-9">
                                           <asp:Button ID="ButtonModificarAlumno" runat="server" CssClass="btn btn-danger" Text="Modificar" />
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-xs-3">Matricula:</label>
                                    <div class="col-xs-4">
                                        <asp:TextBox ID="TextBoxMatriculaAlumno" CssClass="form-control" Enabled="false" TextMode="SingleLine" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-xs-3">Usuario:</label>
                                    <div class="col-xs-9">
                                        <asp:TextBox ID="TextBoxUsuarioAlumno" CssClass="form-control" TextMode="SingleLine" runat="server"></asp:TextBox>
                                    </div>

                                </div>

                                <div class="form-group">
                                    <label class="control-label col-xs-3">Password:</label>
                                    <div class="col-xs-9">
                                        <asp:TextBox ID="TextBoxPasswordAlumno" CssClass="form-control" TextMode="Password" runat="server"></asp:TextBox>

                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-xs-3">Nombre:</label>
                                    <div class="col-xs-9">
                                        <asp:TextBox ID="TextBoxNombreAlumno" CssClass="form-control" TextMode="SingleLine" runat="server"></asp:TextBox>
                                    </div>
                                </div>

                                <div class="form-group">
                                    <label class="control-label col-xs-3">Apellidos:</label>
                                    <div class="col-xs-9">
                                        <asp:TextBox ID="TextBoxApellidoAlumno" CssClass="form-control" TextMode="SingleLine" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-xs-3">Sexo:</label>
                                    <div class="col-xs-2">
                                        <label class="radio-inline">
                                            <asp:RadioButton ID="RadioButtonMasculinoAlumno" runat="server" AutoPostBack="True" />Maculino
                                        </label>
                                    </div>
                                    <div class="col-xs-2">
                                        <label class="radio-inline">
                                            <asp:RadioButton ID="RadioButtonFemeninoAlumno" runat="server" AutoPostBack="True" />Femenino
                                        </label>
                                    </div>
                                </div>

                                <div class="form-group">
                                    <label class="control-label col-xs-3">Edad:</label>
                                    <div class="col-xs-9">
                                        <asp:TextBox ID="TextBoxEdadAlumno" CssClass="form-control" runat="server" TextMode="Number"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-xs-3">Municipio:</label>
                                    <div class="col-xs-9">
                                        <asp:TextBox ID="TextBoxMuncipioAlumno" CssClass="form-control" TextMode="SingleLine" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-xs-3">Localidad:</label>
                                    <div class="col-xs-9">
                                        <asp:TextBox ID="TextBoxLocalidadAlumno" CssClass="form-control" TextMode="SingleLine" runat="server"></asp:TextBox>
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
                                        <asp:TextBox ID="TextBoxCodigoPostalAlumno" CssClass="form-control" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-xs-3">Email:</label>
                                    <div class="col-xs-9">
                                        <asp:TextBox ID="TextBoxEmailAlumno" CssClass="form-control" TextMode="Email" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-xs-3">Foto:</label>
                                    <div class="col-xs-9">
                                        <asp:Image ID="ImageAlumno" Width="100" Height="100" runat="server" />
                                        <asp:FileUpload ID="FileUploadAlumno" CssClass="form-control" runat="server" />
                                        <asp:Button ID="ButtonCargarImagenAlumno" runat="server" CssClass="btn btn-primary" Text="Cargar" OnClick="ButtonCargarImagenAlumno_Click" />

                                    </div>

                                </div>
                                <div class="form-group">
                                    <label class="control-label col-xs-3">Semestre:</label>
                                    <div class="col-xs-9">
                                        <asp:TextBox ID="TextBoxSemestre"  Enabled="false" CssClass="form-control" runat="server"></asp:TextBox>
                                    </div>
                                </div>

                                <div class=" alert-success">
                                    <strong>
                                        <asp:Label ID="LabelMensajeAlumno" Visible="false" runat="server" Text=""></asp:Label></strong>
                                </div>
                                <div class="alert-danger">
                                    <strong>
                                        <asp:Label ID="LabelError" Visible="false" runat="server" Text=""></asp:Label></strong>
                                </div>
                                <div class="alert-warning">
                                    <strong>
                                        <asp:Label ID="LabelAdvertencia" Visible="false" runat="server" Text=""></asp:Label></strong>
                                </div>


                            </div>
                        </div>
                    </div>
                    <%-- fin tab1
                tab2--%>

                    <div class="tab-pane" id="tab3">
                        <div class="panel panel-primary">
                            <div class="panel-heading">

                                <h3 class="panel-title">Horario de clases</h3>
                               </div>
                            <div class="panel-body">
                                
                                <div class="form-group">
                                    <div class="col-xs-9">
                                        <asp:GridView ID="GridViewHorario" EmptyDataText="No hay horarios para mostrar" runat="server" AutoGenerateColumns="False" CssClass="table">
                                            <Columns>
                                                <asp:BoundField DataField="NombreProfesor" HeaderText="NombreProfesor" SortExpression="NombreProfesor" />
                                                <asp:BoundField DataField="NombreMateria" HeaderText="NombreMateria" SortExpression="NombreMateria" />
                                                <asp:BoundField DataField="Aula" HeaderText="Aula" SortExpression="Aula" /> 
                                                <asp:BoundField DataField="Dias" HeaderText="Dias" SortExpression="Dias" />
                                               
                                                <asp:BoundField DataField="Grupo" HeaderText="Grupo" SortExpression="Grupo" />
                                                
                                                <asp:BoundField DataField="HoraEntrada" HeaderText="HoraEntrada" SortExpression="HoraEntrada" />
                                                <asp:BoundField DataField="HoraSalida" HeaderText="HoraSalida" SortExpression="HoraSalida" />
                                               
                                            </Columns>

                                        </asp:GridView>

                                    </div>
                                </div>

                                <div class=" alert-success">
                                    <strong>
                                        <asp:Label ID="Label4" Visible="false" runat="server" Text=""></asp:Label></strong>
                                </div>
                                <div class="alert-danger">
                                    <strong>
                                        <asp:Label ID="Label5" Visible="false" runat="server" Text=""></asp:Label></strong>
                                </div>
                                <div class="alert-warning">
                                    <strong>
                                        <asp:Label ID="Label6" Visible="false" runat="server" Text=""></asp:Label></strong>
                                </div>


                            </div>
                        </div>

                    </div>



                    <div class="tab-pane" id="tab4">
                        <div class="panel panel-primary">
                            <div class="panel-heading">

                                <h3 class="panel-title">Calificacion Parcial</h3>
                            </div>
                            <div class="panel-body">

                                <div class="form-group">
                                    <div class="col-xs-9">
                                        <asp:GridView ID="GridViewCalificacionParcial" EmptyDataText="No hay horarios para mostrar" runat="server" AutoGenerateColumns="False" CssClass="table">
                                            <Columns>

                                                <asp:BoundField DataField="NombreMateria" HeaderText="NombreMateria" SortExpression="NombreMateria" />
                                                <asp:BoundField DataField="CalParcial1" HeaderText="CalParcial1" SortExpression="CalParcial1" />
                                                <asp:BoundField DataField="CalParcial2" HeaderText="CalParcial2" SortExpression="CalParcial2" />
                                                <asp:BoundField DataField="CalParcial3" HeaderText="CalParcial3" SortExpression="CalParcial3" />

                                            </Columns>

                                        </asp:GridView>

                                    </div>
                                </div>

                                <div class=" alert-success">
                                    <strong>
                                        <asp:Label ID="Label9" Visible="false" runat="server" Text=""></asp:Label></strong>
                                </div>
                                <div class="alert-danger">
                                    <strong>
                                        <asp:Label ID="Label10" Visible="false" runat="server" Text=""></asp:Label></strong>
                                </div>
                                <div class="alert-warning">
                                    <strong>
                                        <asp:Label ID="Label11" Visible="false" runat="server" Text=""></asp:Label></strong>
                                </div>


                            </div>
                        </div>
                    </div>


                    <div class="tab-pane" id="tab5">
                        <div class="panel panel-primary">
                            <div class="panel-heading">

                                <h3 class="panel-title">Calificacion Final</h3>

                            </div>
                            <div class="panel-body">
                                <div class="form-group">
                                    <div class="col-xs-9">
                                        <asp:GridView ID="GridViewCalificacionFinal" EmptyDataText="No hay horarios para mostrar" runat="server" AutoGenerateColumns="False" CssClass="table">
                                            <Columns>
                                                <asp:BoundField DataField="NombreMateria" HeaderText="NombreMateria" SortExpression="NombreMateria" />
                                                <asp:BoundField DataField="CalFinal" HeaderText="CalFinal" SortExpression="CalFinal" />

                                            </Columns>

                                        </asp:GridView>

                                    </div>
                                </div>

                                <div class=" alert-success">
                                    <strong>
                                        <asp:Label ID="Label14" Visible="false" runat="server" Text=""></asp:Label></strong>
                                </div>
                                <div class="alert-danger">
                                    <strong>
                                        <asp:Label ID="Label15" Visible="false" runat="server" Text=""></asp:Label></strong>
                                </div>
                                <div class="alert-warning">
                                    <strong>
                                        <asp:Label ID="Label16" Visible="false" runat="server" Text=""></asp:Label></strong>
                                </div>


                            </div>
                        </div>
                    </div>



                    <div class="tab-pane" id="tab6">
                        <div class="panel panel-primary">
                            <div class="panel-heading">

                                <h3 class="panel-title">Kardex de Calificaciones</h3>
                                
                            </div>
                            <div class="panel-body">
                                

                                <div class="form-group">
                                    <div class="col-xs-9">
                                        <asp:GridView ID="GridViewKardex" EmptyDataText="No hay calificaciones para mostrar" runat="server" AutoGenerateColumns="False" CssClass="table">
                                            <Columns>
                                                <asp:BoundField DataField="NombreMateria" HeaderText="NombreMateria" SortExpression="NombreMateria" />
                                                <asp:BoundField DataField="CalFinal" HeaderText="CalFinal" SortExpression="CalFinal" />

                                            </Columns>

                                        </asp:GridView>

                                    </div>
                                </div>

                                <div class=" alert-success">
                                    <strong>
                                        <asp:Label ID="Label19" Visible="false" runat="server" Text=""></asp:Label></strong>
                                </div>
                                <div class="alert-danger">
                                    <strong>
                                        <asp:Label ID="Label20" Visible="false" runat="server" Text=""></asp:Label></strong>
                                </div>
                                <div class="alert-warning">
                                    <strong>
                                        <asp:Label ID="Label21" Visible="false" runat="server" Text=""></asp:Label></strong>
                                </div>


                            </div>
                        </div>
                    </div>


                    <div class="tab-pane" id="tab7">
                        <div class="panel panel-primary">
                            <div class="panel-heading">

                                <h3 class="panel-title">Mensajes del Sistema</h3>
                            </div>
                            <div class="panel-body">
                                <div class=" alert-success">
                                    <strong>
                                        <asp:Label ID="Label24"  runat="server">
                                            Mensaje del sistema de control escolar....
                                        </asp:Label></strong>
                                </div>






                            </div>
                        </div>
                    </div>



                </div>
            </form>




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



