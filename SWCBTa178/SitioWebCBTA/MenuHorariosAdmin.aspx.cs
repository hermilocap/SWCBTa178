using SitioWebCBTA.BD;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SitioWebCBTA
{
    public partial class MenuHorariosAdmin : System.Web.UI.Page
    {
        BDHorarios BDhorario = new BDHorarios();
        Horarios horario;
        Horarios horarioAux;
        static string usuario;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["admin"] != null)
            {

                usuario = Session["admin"].ToString();
                LabelUsurio.Visible = true;
                LabelUsurio.ForeColor = Color.White;
                LabelUsurio.Text = usuario;

            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }
        public bool validar()
        {
            bool vacio = false;
            if (TextBoxIdDocente.Text == "")
            {
                vacio = true;
            }
            else
            {
                if (TextBoxIdAlumno.Text == "")
                {
                    vacio = true;
                }
                else
                {
                    if (DropDownListMateria.SelectedValue == null)
                    {
                        vacio = true;

                    }
                    else
                    {
                        if (TextBoxHoraEntrada.Text == "")
                        {
                            vacio = true;
                        }
                        else
                        {
                            if (TextBoxHoraSalida.Text == "")
                            {
                                vacio = true;
                            }
                            else
                            {
                                if (TextBoxAula.Text == "")
                                {
                                    vacio = true;
                                }
                                else
                                {
                                    if (DropDownListCicloEscolar.SelectedValue == "Seleccione una opcion")
                                    {
                                        vacio = true;
                                    }
                                    else
                                    {
                                        if (DropDownListGrupo.SelectedValue == "Seleccione una opcion")
                                        {
                                            vacio = true;
                                        }
                                        else
                                        {
                                            if (DropDownListSemestre.SelectedValue == null)
                                            {
                                                vacio = true;
                                            }

                                            else
                                            {
                                                if (DropDownListDias.SelectedValue == "Seleccione una opcion")
                                                {
                                                    vacio = true;
                                                }
                                            }
                                        }
                                    
                                    }
                                }
                            }
                        }
                    }
                }
            }

            return vacio;
        }

        static int valorsemestre=0;
        public int obtenerNumeroSeemstre()
        {
            if (valorsemestre == 1)
            {
                DropDownListSemestre.SelectedValue = "Primer Semestre";
            }
            else
            {
                if (valorsemestre == 2)
                {
                    DropDownListSemestre.SelectedValue = "Segundo Semestre";
                }
                else
                {
                    if (valorsemestre == 3)
                    {
                        DropDownListSemestre.SelectedValue = "Tercer Semestre";
                    }
                    else
                    {
                        if (valorsemestre == 4)
                        {
                            DropDownListSemestre.SelectedValue = "Cuarto Semestre";
                        }
                        else
                        {
                            if (valorsemestre == 5)
                            {
                                DropDownListSemestre.SelectedValue = "Quinto Semestre";
                            }
                            else
                            {
                                if (valorsemestre == 6)
                                {
                                    DropDownListSemestre.SelectedValue ="Sexto Semestre";
                                }
                            }
                        }
                    }
                }
            }

            return valorsemestre;
        }


        static int semestre;
        public int obtenerValorDropSemestre()
        {

            if (DropDownListSemestre.SelectedValue == "Primer Semestre")
            {
                semestre = 1;
            }
            else
            {
                if (DropDownListSemestre.SelectedValue == "Segundo Semestre")
                {
                    semestre = 2;
                }
                else
                {
                    if (DropDownListSemestre.SelectedValue == "Tercer Semestre")
                    {
                        semestre = 3;
                    }
                    else
                    {
                        if (DropDownListSemestre.SelectedValue == "Cuarto Semestre")
                        {
                            semestre = 4;
                        }
                        else
                        {
                            if (DropDownListSemestre.SelectedValue == "Quinto Semestre")
                            {
                                semestre = 5;
                            }
                            else
                            {
                                if (DropDownListSemestre.SelectedValue == "Sexto Semestre")
                                {
                                    semestre = 6;
                                }
                            }
                        }
                    }
                }
            }

            return semestre;

        }

        protected void ButtonGuardarHorario_Click(object sender, EventArgs e)
        {
            bool vacio = validar();

            if (vacio == true)
            {
                LabelError.Visible = true;
                LabelError.Text = "Todos los campos son obligatorios....";
            }
            else
            {
                int id = BDhorario.EstablecerId();


                horario = new Horarios();
                horario.IdHorarioClase = id;
                horario.IdProfesor = int.Parse(TextBoxIdDocente.Text);

                int idAlumno = BDhorario.LeerMatricula(TextBoxIdAlumno.Text);
                horario.IdAlumno = idAlumno;
                horario.IdSeemstre = Convert.ToInt32(obtenerValorDropSemestre());
                int nosemestre = Convert.ToInt32(horario.IdSeemstre);
               
                    if (!BDhorario.ExisteHorario( Convert.ToInt32(nosemestre),Convert.ToInt32(DropDownListMateria.SelectedValue),DropDownListCicloEscolar.SelectedValue,DropDownListGrupo.SelectedValue,TextBoxHoraEntrada.Text,TextBoxHoraSalida.Text,DropDownListDias.SelectedValue))
                    {
                  horario.IdMateria =int.Parse(DropDownListMateria.SelectedValue);
                horario.IdSeemstre =nosemestre;
                horario.CicloEscolar = DropDownListCicloEscolar.SelectedValue;
                horario.Grupo = DropDownListGrupo.SelectedValue;
                horario.Aula = TextBoxAula.Text;
                horario.HoraEntrada = TextBoxHoraEntrada.Text;
                horario.HoraSalida = TextBoxHoraSalida.Text;
                horario.Dias = DropDownListDias.SelectedValue;

                        BDhorario.registrarHorario(horario);

                        LabelMensaje.Visible = true;
                        LabelMensaje.Text = "Horario Guardado Correctamente...";
                    }
                    else
                    {
                        LabelError.Visible = true;
                        LabelError.Text = " No se puede registrar el horario...Por favor registre un horario diferente..";

                    }
                }
        }
        BDMaterias bdmateria=new BDMaterias();
        protected void ButtonBuscarHorario_Click(object sender, EventArgs e)
        {
            if (DropDownListTipoBusqueda.SelectedValue == "Seleccione una opcion")
            {
                Response.Write("<script> window.alert('Seleccione tipo de busqueda') </script>");
            }
            else
            {
                if (DropDownListTipoBusqueda.SelectedValue == "Horario alumno")
                {
                    if (TextBoxIdAlumno.Text == "")
                    {
                        Response.Write("<script> window.alert('Campo matricula obligatorio') </script>");
                    }
                    else
                    {

                        int idAlumno = BDhorario.LeerMatricula(TextBoxIdAlumno.Text);
                        if (BDhorario.buscarHorarioAlumno(idAlumno, Convert.ToInt32(DropDownListMateria.SelectedValue)))
                        {
                            horario = new Horarios();
                            horario = BDhorario.ReornarHorario();

                            TextBoxIdDocente.Text = Convert.ToString(horario.IdProfesor);
                            DropDownListMateria.Visible = false;
                            TextBoxNombreMateria.Visible = true;
                            TextBoxNombreMateria.Text = bdmateria.LeerNombreMateria(horario.IdMateria);
                            //   int numerosemestre = obtenerNumeroSeemstre();
                            // numerosemestre = horario.IdMateria;
                            DropDownListCicloEscolar.SelectedValue = horario.CicloEscolar;
                            DropDownListGrupo.SelectedValue = horario.Grupo;
                            TextBoxAula.Text = horario.Aula;
                            TextBoxHoraEntrada.Text = horario.HoraEntrada;
                            TextBoxHoraSalida.Text = horario.HoraSalida;
                            DropDownListDias.SelectedValue = horario.Dias;
                        }
                    }
                }
                else
                {
                    if (DropDownListTipoBusqueda.SelectedValue == "Horario docente")
                    {

                        if (TextBoxIdDocente.Text == "")
                        {
                            Response.Write("<script> window.alert('Campo id profesor es obligatorio') </script>");
                        }
                        else
                        {
                            if (BDhorario.buscarHorarioDocente(Convert.ToInt32(TextBoxIdDocente.Text), Convert.ToInt32(DropDownListMateria.SelectedValue)))
                            {
                                horario = new Horarios();
                                horario = BDhorario.ReornarHorario();

                                TextBoxIdAlumno.Text = Convert.ToString(horario.IdAlumno);
                                DropDownListMateria.Visible = false;
                                TextBoxNombreMateria.Visible = true;
                                TextBoxNombreMateria.Text = bdmateria.LeerNombreMateria(horario.IdMateria);
                                //   int numerosemestre = obtenerNumeroSeemstre();
                                // numerosemestre = horario.IdMateria;
                                DropDownListCicloEscolar.SelectedValue = horario.CicloEscolar;
                                DropDownListGrupo.SelectedValue = Convert.ToString(horario.Grupo);
                                TextBoxAula.Text = horario.Aula;
                                TextBoxHoraEntrada.Text = horario.HoraEntrada;
                                TextBoxHoraSalida.Text = horario.HoraSalida;
                                DropDownListDias.SelectedValue = horario.Dias;

                            }
                        }
                    }
                }
            }
        }
            //catch (Exception)
            //{
            //    LabelError.Visible = true;
            //    LabelError.Text = "Seleccione un semestre, y nombre de materia a buscar";
            //}
      //  }
        

        protected void ButtonEliminarDocente_Click(object sender, EventArgs e)
        {
            try
            {
                int idAlumno = BDhorario.LeerMatricula(TextBoxIdAlumno.Text);
                if (BDhorario.eliminarHorarioAlumno(idAlumno, Convert.ToInt32(DropDownListMateria.SelectedValue)))
                {

                    // LabelMensajeAlumno.ForeColor = Color.Red;
                    LabelMensaje.Visible = true;
                    LabelMensaje.Text = "Horario Eliminado Correctamente...";

                }
                else
                {
                    if (BDhorario.eliminarHorarioDocente(Convert.ToInt32(TextBoxIdDocente.Text), Convert.ToInt32(DropDownListMateria.SelectedValue)))
                    {

                        // LabelMensajeAlumno.ForeColor = Color.Red;
                        LabelMensaje.Visible = true;
                        LabelMensaje.Text = "Horario Eliminado Correctamente...";

                    }
                }
            }
            catch (Exception)
            {
                LabelError.Visible = true;
                LabelError.Text = " No se puede eliminar el horario por que hay problema de relacion de tablas con la tabla calificaciones...";
            }

        }

        protected void ButtonModificarHorario_Click(object sender, EventArgs e)
        {
            try
            {
                horario = new Horarios();
                int idAlumno = BDhorario.LeerMatricula(TextBoxIdAlumno.Text);
                horario.IdAlumno = idAlumno;
                horario.IdProfesor = int.Parse(TextBoxIdDocente.Text);
                horario.IdMateria = bdmateria.LeerIdMateria(TextBoxNombreMateria.Text);
                horario.IdSeemstre = obtenerValorDropSemestre();
                horario.CicloEscolar = DropDownListCicloEscolar.SelectedValue;
                horario.Grupo = DropDownListGrupo.SelectedValue;
                horario.Aula = TextBoxAula.Text;
                horario.HoraEntrada = TextBoxHoraEntrada.Text;
                horario.HoraSalida = TextBoxHoraSalida.Text;
                horario.Dias = DropDownListDias.SelectedValue;

                //horario docente

                horarioAux = new Horarios();

                horarioAux.IdProfesor = int.Parse(TextBoxIdDocente.Text);
                horario.IdMateria = bdmateria.LeerIdMateria(TextBoxNombreMateria.Text);
                horarioAux.IdSeemstre = obtenerValorDropSemestre();
                horarioAux.CicloEscolar = DropDownListCicloEscolar.SelectedValue;
                horarioAux.Grupo = DropDownListGrupo.SelectedValue;
                horarioAux.Aula = TextBoxAula.Text;
                horarioAux.HoraEntrada = TextBoxHoraEntrada.Text;
                horarioAux.HoraSalida = TextBoxHoraSalida.Text;
                horarioAux.Dias = DropDownListDias.SelectedValue;

                if (BDhorario.ModificarHorarioAumno(horario))
                {

                    // LabelMensajeAlumno.ForeColor = Color.Red;
                    LabelMensaje.Visible = true;
                    LabelMensaje.Text = "Horario Alumno Modificado Correctamente...";

                }
                else
                {
                    if (BDhorario.ModificarHorarioDocente(horarioAux))
                    {

                        // LabelMensajeAlumno.ForeColor = Color.Red;
                        LabelMensaje.Visible = true;
                        LabelMensaje.Text = "Horario Docente Modificado Correctamente...";

                    }
                }
            }
            catch (Exception)
            {
              
            }
            
        }
        protected void ButtonNuevoHorario_Click(object sender, EventArgs e)
        {
            TextBoxIdDocente.Text = "";
            TextBoxIdAlumno.Text = "";
            
            DropDownListSemestre.SelectedValue=null;
            DropDownListCicloEscolar.SelectedValue = "Seleccione una opcion";
            DropDownListGrupo.SelectedValue = "Seleccione una opcion";
            TextBoxAula.Text="";
            TextBoxHoraEntrada.Text="";
           TextBoxHoraSalida.Text="";
           DropDownListDias.SelectedValue = "Seleccione una opcion";
        }

        protected void ButtonCerrarsesion_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Cookies.Add(new HttpCookie("ASP.NET_SessionId", ""));
            Response.Redirect("Login.aspx");
 
        }

        
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ToString());
        
        public void cargarMaterias(int sem)
        {
            SqlCommand OrdenSqlSelect = new SqlCommand("select IdMateria,NombreMateria from Materias where IdSeemstre="+sem, cn);
            SqlDataAdapter da = new SqlDataAdapter(OrdenSqlSelect.CommandText, cn); 
            DataSet ds = new DataSet();
            da.Fill(ds);
            this.DropDownListMateria.DataSource = ds;
            this.DropDownListMateria.DataValueField = "IdMateria";
            this.DropDownListMateria.DataTextField = "NombreMateria";
            this.DropDownListMateria.DataBind();
        }

        
        protected void DropDownListSemestre_SelectedIndexChanged(object sender, EventArgs e)
        { 
            int nosemestre = obtenerValorDropSemestre();


            if (TextBoxIdDocente.Text != "" && TextBoxIdAlumno.Text == "")
            {
                cargarMaterias(nosemestre);
                LabelError.Visible = false;
            }
            else
            {
               
                if (TextBoxIdAlumno.Text == "")
                {
                    Response.Write("<script> window.alert('Introdusca una matricula') </script>");
                }
                else
                {
                    int idAlumno = BDhorario.LeerMatricula(TextBoxIdAlumno.Text);

                    int semestre = BDhorario.NumSemestre(Convert.ToInt32(idAlumno));
                   
                    if (nosemestre == semestre)
                    {
                        cargarMaterias(nosemestre);
                        LabelError.Visible = false;
                    }
                    else
                    {
                        LabelError.Visible = true;
                        LabelError.Text = "El alumno con esta matricula no  esta inscrito en este semestre..el semestre actual es:" + semestre;
                    }
                }
            }
               


        }
    }
}