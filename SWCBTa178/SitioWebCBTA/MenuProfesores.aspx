<%@ Page Language="C#" AutoEventWireup="true"   CodeBehind="MenuProfesores.aspx.cs" Inherits="SitioWebCBTA.MenuProfesores" %>
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
                  <img src="images/logo.png" width="100" height="130" title="CBTa N°178" />
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

            <li><a href="#tab1" data-toggle="tab">Datos Personales</a></li>

            <li><a href="#tab2" data-toggle="tab">Horario de Clases</a></li>

            <li><a href="#tab3" data-toggle="tab">Registrar Calificaciones</a></li>

    </ul>
             <form id="Form2" class="form-horizontal" runat="server"> 
                 <asp:Button ID="ButtonCerrarsesion" runat="server"  CssClass="btn btn-primary" Text="Cerrar sesion" OnClick="ButtonCerrarsesion_Click"/>
                              
                <div class="tab-content">
            <div class="tab-pane active" id="tab1">
                
                    <div class="panel panel-primary">
                        <div class="panel-heading">

                            <h3 class="panel-title">Datos personales</h3>
<asp:Label ID="Label1" runat="server">Usuario:</asp:Label>
                            <asp:Label ID="LabelUsurio" runat="server" Visible="false"></asp:Label>
                                      
                        </div>
                        <div class="panel-body">
                           
                                <div class="form-group">
                                    <div class="col-xs-offset-3 col-xs-9">
                                       
                                         <asp:Button ID="ButtonModificarDocente" runat="server" CssClass="btn btn-danger" Text="Modificar" OnClick="ButtonModificarDocente_Click"/>
                                         <asp:Button ID="ButtonConsultarDocente" runat="server" CssClass="btn btn-info" Text="Consultar"/>

                                    </div>
                                </div>

                                <div class="form-group">
                                    <label class="control-label col-xs-3">Id Docente:</label>
                                    <div class="col-xs-3">
                                        <asp:TextBox ID="TextBoxIdDocente" Enabled="false" CssClass="form-control" TextMode="SingleLine" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-xs-3">Usuario:</label>
                                    <div class="col-xs-9">
                                        <asp:TextBox ID="TextBoxUsuarioDocente" CssClass="form-control" TextMode="SingleLine" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                             

                                <div class="form-group">
                                    <label class="control-label col-xs-3">Password:</label>
                                    <div class="col-xs-9">
                                        <asp:TextBox ID="TextBoxPassworDocente" CssClass="form-control"  TextMode="Password" runat="server"></asp:TextBox>

                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-xs-3">Nombre:</label>
                                    <div class="col-xs-9">
                                        <asp:TextBox ID="TextBoxNombreDocente" CssClass="form-control" TextMode="SingleLine" runat="server"></asp:TextBox>
                                    </div>
                                </div>

                                <div class="form-group">
                                    <label class="control-label col-xs-3">Apellidos:</label>
                                    <div class="col-xs-9">
                                        <asp:TextBox ID="TextBoxApellidoDocente" CssClass="form-control" TextMode="SingleLine" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-xs-3">Sexo:</label>
                                 <div class="col-xs-9">
                                 <asp:DropDownList CssClass="form-control" ID="DropDownListSexo" runat="server">
                                     <asp:ListItem>F</asp:ListItem>
                                     <asp:ListItem>M</asp:ListItem>
                                 </asp:DropDownList>
                                </div>
                                    </div>

                                <div class="form-group">
                                    <label class="control-label col-xs-3">Edad:</label>
                                    <div class="col-xs-9">
                                        <asp:TextBox ID="TextBoxEdadDocente" CssClass="form-control" runat="server" TextMode="Number"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-xs-3">Municipio:</label>
                                    <div class="col-xs-9">
                                        <asp:TextBox ID="TextBoxMuncipioDocente" CssClass="form-control" TextMode="SingleLine" runat="server"></asp:TextBox>
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
                                        <asp:TextBox ID="TextBoxDireccionDocente" CssClass="form-control" TextMode="SingleLine" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-xs-3">Codigo Postal:</label>
                                    <div class="col-xs-9">
                                        <asp:TextBox ID="TextBoxCodigoPostalDocente" CssClass="form-control" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-xs-3">Email:</label>
                                    <div class="col-xs-9">
                                        <asp:TextBox ID="TextBoxEmailDocente" CssClass="form-control" TextMode="Email" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-xs-3">Foto:</label>
                                    <div class="col-xs-9">
                                        <asp:Image ID="ImageDocente" Width="100" Height="100" runat="server" />
                                        <asp:FileUpload ID="FileUploadDocente" CssClass="form-control" runat="server" />
                                        <asp:Button ID="ButtonCargarImagenDocente" runat="server" CssClass="btn btn-primary" Text="Cargar" OnClick="ButtonCargarImagenDocente_Click"/>

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
                        </div>
                    </div>

            </div>
            <div class="tab-pane" id="tab2">
                 <div class="panel panel-primary">
                        <div class="panel-heading">

                            <h3 class="panel-title">Horario de Clases</h3>
                        </div>
                        <div class="panel-body">
                           <div class="form-group">
                                    <div class="col-xs-9">
                                        <asp:GridView ID="GridViewHorarioDocente" EmptyDataText="No hay horarios para mostrar" runat="server" AutoGenerateColumns="False"  CssClass="table">
                                            <Columns>
                                                <asp:BoundField DataField="NombreMateria" HeaderText="NombreMateria" SortExpression="NombreMateria" />
                                                 <asp:BoundField DataField="Aula" HeaderText="Aula" SortExpression="Aula" />
                                                <asp:BoundField DataField="Grupo" HeaderText="Grupo" SortExpression="Grupo" />
                                                <asp:BoundField DataField="Dias" HeaderText="Dias" SortExpression="Dias" />
                                                <asp:BoundField DataField="HoraEntrada" HeaderText="HoraEntrada" SortExpression="HoraEntrada" />
                                                <asp:BoundField DataField="HoraSalida" HeaderText="HoraSalida" SortExpression="HoraSalida" />
                                                
                                            </Columns>

                                        </asp:GridView>
                                    
                                        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:conn %>" SelectCommand="SELECT [IdHorarioClase], [IdProfesor], [NombreMateria], [CicloEscolar], [Aula], [Grupo], [HoraEntrada], [HoraSalida] FROM [HorarioClase]"></asp:SqlDataSource>
                                    
                                    </div>
                                </div>
                               
                               
                        </div>
                    </div>

            </div>
            <div class="tab-pane" id="tab3">
                 <div class="panel panel-primary">
                        <div class="panel-heading">

                            <h3 class="panel-title">Calificaciones</h3>
                        </div>
                        <div class="panel-body">
                         
                             <div class="form-group">
                                    <div class="col-xs-offset-3 col-xs-9">
                                       <asp:Button ID="ButtonBuscarHorario" runat="server" CssClass="btn btn-success" Text="BuscarHorario" OnClick="ButtonBuscarHorario_Click" />
                                         <asp:Button ID="ButtonBuscarCalificacion" runat="server" CssClass="btn btn-success" Text="BuscarCaificacion" OnClick="ButtonBuscarCalificacion_Click"/>
                                         <asp:Button ID="ButtonGuardarCalificacion" runat="server" CssClass="btn btn-primary" Text="Guardar" OnClick="ButtonGuardarCalificacion_Click" />
                                        <asp:Button ID="ButtonNuevoCaificacion" runat="server" CssClass="btn btn-default" Text="Nuevo" OnClick="ButtonNuevoCaificacion_Click" />
                                     <asp:Button ID="ButtonEliminarCaificaciom" runat="server" CssClass="btn btn-warning" Text="Eliminar" OnClick="ButtonEliminarCaificaciom_Click" />
                                    
                                              <asp:Button ID="ButtonModificarCaificacion" runat="server" CssClass="btn btn-danger" Text="Modificar" OnClick="ButtonModificarCaificacion_Click" />
                                         <asp:Button ID="ButtonConsultarCaificacion" runat="server" CssClass="btn btn-info" Text="Consultar"/>

                                    </div>
                                </div>

                             
                                <div class="form-group">
                                    <label class="control-label col-xs-3">Matricula Alumno:</label>
                                    <div class="col-xs-3">
                                        <asp:TextBox ID="TextBoxIdAlumno" CssClass="form-control" TextMode="SingleLine" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                 <div class="form-group">
                                    <label class="control-label col-xs-3">Materia:</label>
                                    <div class="col-xs-9">
                                        <asp:TextBox ID="TextBoxNombreMateria" CssClass="form-control"  Enabled="false" TextMode="SingleLine" runat="server" style="width: 226px;"></asp:TextBox>
                                    </div>
                                </div>
                               <div class="form-group">
                                    <label class="control-label col-xs-3">Parcial1:</label>
                                    <div class="col-xs-3">
                                        <asp:TextBox ID="TextBoxCalParcial1" CssClass="form-control" TextMode="SingleLine" Text="0" runat="server"></asp:TextBox>
                                    </div>
                                </div>

                                <div class="form-group">
                                    <label class="control-label col-xs-3">Parcial2:</label>
                                    <div class="col-xs-3">
                                        <asp:TextBox ID="TextBoxCalParcial2" CssClass="form-control" TextMode="SingleLine" Text="0" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-xs-3">Parcial3:</label>
                                    <div class="col-xs-3">
                                        <asp:TextBox ID="TextBoxCalParcial3" CssClass="form-control" TextMode="SingleLine"  Text="0" runat="server"></asp:TextBox>
                                    </div>
                                </div>

                               
                                 <div class="form-group">
                                    <label class="control-label col-xs-3">Cal Final:</label>
                                    <div class="col-xs-3">
                                        <asp:TextBox ID="TextBoxCalFinal" CssClass="form-control" TextMode="SingleLine" Text="0" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <div class="col-xs-9">
                                        <asp:GridView ID="GridViewHorario" EmptyDataText="No hay horarios para mostrar" runat="server" AutoGenerateColumns="False"  CssClass="table" DataKeyNames="IdHorarioClase" OnSelectedIndexChanging="GridViewHorario_SelectedIndexChanging">
                                            <Columns>
                                                <asp:BoundField DataField="IdHorarioClase" HeaderText="IdHorarioClase" ReadOnly="True" SortExpression="IdHorarioClase" />
                                                <asp:BoundField DataField="NombreProfesor" HeaderText="NombreProfesor" SortExpression="NombreProfesor" />
                                                <asp:BoundField DataField="NombreMateria" HeaderText="NombreMateria" SortExpression="NombreMateria" />
                                                 <asp:BoundField DataField="Aula" HeaderText="Aula" SortExpression="Aula" />
                                                <asp:BoundField DataField="Grupo" HeaderText="Grupo" SortExpression="Grupo" />
                                                <asp:BoundField DataField="HoraEntrada" HeaderText="HoraEntrada" SortExpression="HoraEntrada" />
                                                <asp:BoundField DataField="HoraSalida" HeaderText="HoraSalida" SortExpression="HoraSalida" />
                                                <asp:CommandField ShowSelectButton="True" />
                                            </Columns>

                                        </asp:GridView>
                                    
                                    </div>
                                </div>
                               
                               
                               
                                <div class=" alert-success">
                                    <strong>
                                        <asp:Label ID="Label6" Visible="false" runat="server" Text=""></asp:Label></strong>
                                </div>
                                <div class="alert-danger"><strong>
                                    <asp:Label ID="Label7" Visible="false" runat="server" Text=""></asp:Label></strong></div>
                                <div class="alert-warning"><strong>
                                    <asp:Label ID="Label8" Visible="false" runat="server" Text=""></asp:Label></strong></div>

                           
                               
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



