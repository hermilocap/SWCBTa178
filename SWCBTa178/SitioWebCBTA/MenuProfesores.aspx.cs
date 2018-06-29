using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SitioWebCBTA
{
    public partial class MenuProfesores : System.Web.UI.Page
    {

        BDCalificaciones bdcalificaion = new BDCalificaciones();
        Calificaciones calificacion;
        BDHorarios bdhorario = new BDHorarios();
        static int idhorario;
        static string usuario;
        Profesores profesor;
        BDProfesores BDProfesor = new BDProfesores();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["docente"] != null)
            {

                usuario = Session["docente"].ToString();
                LabelUsurio.Visible = true;
                LabelUsurio.ForeColor = Color.White;
                LabelUsurio.Text = usuario;
                consultarDatosDocente(Session["docente"].ToString());
               // consultarHorarioDocente(Session["docente"].ToString());
            }
            else
            {
                Response.Redirect("Login.aspx");
            }

        }
        public void consultarDatosDocente(string usuario)
        {
            if (BDProfesor.buscarDatosProfesor(usuario))
            {
                profesor = new Profesores();
                profesor = BDProfesor.ObtenerProfesor();
                TextBoxIdDocente.Text =Convert.ToString(profesor.IdProfesor);
                TextBoxUsuarioDocente.Text = profesor.UsuarioProfesor;

                TextBoxPassworDocente.Text = profesor.ContrasenniaProfesor;
                TextBoxNombreDocente.Text = profesor.NombreProfesor;
                TextBoxApellidoDocente.Text = profesor.ApellidosProfesor;
                DropDownListSexo.SelectedValue = profesor.SexoProfesor;
                TextBoxEdadDocente.Text = Convert.ToString(profesor.EdadProfesor);
                TextBoxMuncipioDocente.Text = profesor.MunicipioProfesor;
                TextBoxLocalidadAlumno.Text = profesor.LocalidadProfesor;
                TextBoxDireccionDocente.Text = profesor.DirecccionProfesor;
                TextBoxCodigoPostalDocente.Text = profesor.CodigoPostalProfesor;
                TextBoxEmailDocente.Text = profesor.EmailProfesor;
                ImageDocente.ImageUrl = profesor.FotoProfesor;
            }
        
        }
        public void consultarHorarioDocente(string usuario)
        {
            bdcalificaion.consultarHorarioDocente(GridViewHorarioDocente, Convert.ToInt32(TextBoxIdDocente.Text));
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
                LabelAdvertencia.Visible = true;
                LabelAdvertencia.Text = "Debe buscar el horario del alumno..Porteriormente seleccionar una materia de su horario para buscar la calificacion..";
            }
        }
        public bool validar()
        {
            bool vacio = false;
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

            if (idhorario == 0)
            {
                LabelError.Visible = true;
                LabelError.Text = "No hay materias seleccionadas...Por favor seleccione una materia...";
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
                LabelMensaje.Text = "Calificacion Guardado Correctamente...";
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

        protected void ButtonEliminarCaificaciom_Click(object sender, EventArgs e)
        {
            try
            {
                bdcalificaion.eliminarCalificaciones(idhorario);
                LabelMensaje.Visible = true;
                LabelMensaje.Text = "Calificacion Eliminado Correctamente...";
            }
            catch (Exception)
            {
                LabelAdvertencia.Visible = true;
                LabelAdvertencia.Text = "No ha seleccionado ninguna calificacion para eliminar...";
            }

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
                LabelAdvertencia.Text = "No ha seleccionado ninguna calificacion para modificacion..";
            }
        }

        protected void GridViewHorario_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            idhorario = Convert.ToInt32(GridViewHorario.DataKeys[e.NewSelectedIndex].Values["IdHorarioClase"].ToString());
            //string nombre = GridViewHorario.FindControl("NombreMateria").ToString();
        }

        protected void ButtonCargarImagenDocente_Click(object sender, EventArgs e)
        {
            try
            {
                string ruta = Server.MapPath("~//") + FileUploadDocente.FileName;
                FileUploadDocente.SaveAs(ruta);
                ImageDocente.ImageUrl = "~//" + FileUploadDocente.FileName;

            }
            catch (Exception)
            {
                Response.Write("<script>window.alert('Seleccione una imagen')</script>");
            }
        }

        protected void ButtonModificarDocente_Click(object sender, EventArgs e)
        {

            profesor = new Profesores();
            profesor.IdProfesor = int.Parse(TextBoxIdDocente.Text);
            profesor.UsuarioProfesor = TextBoxUsuarioDocente.Text;
            profesor.ContrasenniaProfesor = TextBoxPassworDocente.Text;
            profesor.NombreProfesor = TextBoxNombreDocente.Text;
            profesor.ApellidosProfesor = TextBoxApellidoDocente.Text;
            profesor.SexoProfesor = DropDownListSexo.SelectedValue;
            profesor.EdadProfesor = int.Parse(TextBoxEdadDocente.Text);
            profesor.MunicipioProfesor = TextBoxMuncipioDocente.Text;
            profesor.LocalidadProfesor = TextBoxLocalidadAlumno.Text;
            profesor.DirecccionProfesor = TextBoxDireccionDocente.Text;
            profesor.CodigoPostalProfesor = TextBoxCodigoPostalDocente.Text;
            profesor.EmailProfesor = TextBoxEmailDocente.Text;
            profesor.FotoProfesor = ImageDocente.ImageUrl;

            BDProfesor.modificarProfesor(profesor);
            LabelMensaje.Visible = true;
            LabelMensaje.Text = "Docente modificado Correctamente...";
        }

        protected void ButtonCerrarsesion_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Cookies.Add(new HttpCookie("ASP.NET_SessionId", ""));
            Response.Redirect("Login.aspx");
 
        }
    }
}