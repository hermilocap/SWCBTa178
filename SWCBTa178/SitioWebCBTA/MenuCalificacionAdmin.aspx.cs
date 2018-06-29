using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

namespace SitioWebCBTA
{
    public partial class MenuCalificacionAdmin : System.Web.UI.Page
    {
        BDCalificaciones bdcalificaion=new BDCalificaciones();
        Calificaciones calificacion;
        BDHorarios bdhorario=new BDHorarios();
        static int idhorario;
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

        protected void ButtonBuscarHorario_Click(object sender, EventArgs e)
        {
            if (TextBoxIdAlumno.Text == "")
            {
                LabelError.Visible = true;
                LabelError.Text = "El campo matricula es obligatorio...";
           
            }
            else
            {
                int idAlumno = bdhorario.LeerMatricula(TextBoxIdAlumno.Text);
                bdcalificaion.consultarHorarioAlumno(GridViewHorario, idAlumno);

            }
        }

        public bool validar()
        {
            bool vacio=false;
            if (TextBoxCalFinal.Text == "0")
            {
                vacio = true;
            }
            else
            {
                if (TextBoxCalParcial1.Text == "0")
                {
                    vacio = true;
                }
                else
                {
                    if (TextBoxCalParcial2.Text == "0")
                    {
                        vacio = true;
                    }
                    else
                    {
                        if (TextBoxCalParcial3.Text == "0")
                        {
                            vacio = true;
                        }
                    }
                }
            }
               
            return vacio;
        }
        protected void ButtonGuardarCalificacion_Click(object sender, EventArgs e)
        {
           
            if (idhorario==0)
            {
                LabelError.Visible = true;
                LabelError.Text = "No hay materias seleccionadas...";
            }
            else
            {
                int idcalificaion = bdcalificaion.EstablecerId();

                calificacion = new Calificaciones();
                calificacion.IdCalificacion = idcalificaion;
                calificacion.IdIdHorarioClase = idhorario;

                calificacion.CalFinal = int.Parse(TextBoxCalFinal.Text);
                calificacion.CalParcial1 = int.Parse(TextBoxCalParcial1.Text);
                calificacion.CalParcial2 = int.Parse(TextBoxCalParcial2.Text);
                calificacion.CalParcial3 = int.Parse(TextBoxCalParcial3.Text);
                bdcalificaion.registrarCalificaciones(calificacion);

                LabelMensaje.Visible = true;
                LabelMensaje.Text = "Calificacion  Guardado Correctamente...";
            }
        }

        protected void GridViewHorario_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            idhorario = Convert.ToInt32(GridViewHorario.DataKeys[e.NewSelectedIndex].Values["IdHorarioClase"].ToString());
            //string nombre = GridViewHorario.FindControl("NombreMateria").ToString();
        }

        protected void ButtonModificarCaificacion_Click(object sender, EventArgs e)
        {
            try
            {
                calificacion = new Calificaciones();
                calificacion.IdIdHorarioClase = idhorario;
                calificacion.CalFinal = int.Parse(TextBoxCalFinal.Text);
                calificacion.CalParcial1 = int.Parse(TextBoxCalParcial1.Text);
                calificacion.CalParcial2 = int.Parse(TextBoxCalParcial2.Text);
                calificacion.CalParcial3 = int.Parse(TextBoxCalParcial3.Text);
                bdcalificaion.ModificarCalificaciones(calificacion);

                LabelMensaje.Visible = true;
                LabelMensaje.Text = "Calificacion Modificado Correctamente...";
            }
            catch (Exception)
            {
                LabelAdvertencia.Visible = true;
                LabelAdvertencia.Text = "No ha seleccionado ningun calificacion para modificar...";
            }
        }


        protected void ButtonEliminarCaificaciom_Click(object sender, EventArgs e)
        {
            try
            {
                bdcalificaion.eliminarCalificaciones(idhorario);
                LabelMensaje.Visible = true;
                LabelMensaje.Text = "calificacion Eliminado Correctamente...";
            }
            catch (Exception)
            {
                LabelAdvertencia.Visible = true;
                LabelAdvertencia.Text = "No ha seleccionado ningun calificacion para eliminar";
               
            }
        }

        protected void ButtonBuscarCalificacion_Click(object sender, EventArgs e)
        {
            try
            {
                if (bdcalificaion.ConsultarCalificaciones(idhorario))
                {
                    calificacion = new Calificaciones();
                    calificacion = bdcalificaion.RetornerCalificacion();
                    TextBoxCalFinal.Text = Convert.ToString(calificacion.CalFinal);
                    TextBoxCalParcial1.Text = Convert.ToString(calificacion.CalParcial1);
                    TextBoxCalParcial2.Text = Convert.ToString(calificacion.CalParcial2);
                    TextBoxCalParcial3.Text = Convert.ToString(calificacion.CalParcial3);
                    //mostrando a amteri
                }
            }
            catch (Exception)
            {
                LabelAdvertencia.Visible=true;
                LabelAdvertencia.Text = "Debe buscar el horario del alumno..Porteriormente seleccionar una materia de su horario para buscar..";
            }
        }

        protected void ButtonNuevoCaificacion_Click(object sender, EventArgs e)
        {
            TextBoxIdAlumno.Text = "";
            TextBoxNombreMateria.Text = "";
            TextBoxCalFinal.Text = "";
            TextBoxCalParcial1.Text = "";
            TextBoxCalParcial2.Text = "";
            TextBoxCalParcial3.Text = "";
           
        }

        protected void ButtonCerrarsesion_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Cookies.Add(new HttpCookie("ASP.NET_SessionId", ""));
            Response.Redirect("Login.aspx");
        }

      

    }
}