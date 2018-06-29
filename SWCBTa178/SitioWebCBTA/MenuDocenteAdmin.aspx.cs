using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

namespace SitioWebCBTA
{
    public partial class MenuDocenteAdmin : System.Web.UI.Page
    {
        BDProfesores BDProfesor=new BDProfesores();
        Profesores profesor;
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
            if (TextBoxUsuarioDocente.Text == "")
            {
                vacio = true;
            }
            if (TextBoxPassworDocente.Text == "")
            {
                vacio = true;
            }
            if (TextBoxNombreDocente.Text == "")
            {
                vacio = true;
            }
            if (TextBoxApellidoDocente.Text == "")
            {
                vacio = true;
            }
            if (TextBoxEdadDocente.Text == "")
            {
                vacio = true;
            }
            if (TextBoxDireccionDocente.Text == "")
            {
                vacio = true;
            }
            if (TextBoxLocalidadAlumno.Text == "")
            {
                vacio = true;
            }
            if (TextBoxMuncipioDocente.Text == "")
            {
                vacio = true;
            }
            if (TextBoxCodigoPostalDocente.Text == "")
            {
                vacio = true;
            }
            if (TextBoxEmailDocente.Text == "")
            {
                vacio = true;
            }
            if (DropDownListSexo.SelectedValue == "Seleccione un opcion")
            {
                vacio = true;
            }

            return vacio;
        }
        protected void ButtonGuardarDocente_Click(object sender, EventArgs e)
        {
            bool vacio = validar();

            if (vacio == true)
            {
                LabelError.Visible = true;
                LabelError.Text = "Todos los campos son obligatorios...";
            }
            else
            {
                int id = BDProfesor.EstablecerId();

                profesor = new Profesores();

                profesor.IdProfesor = id;
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

                BDProfesor.RegistrarProfesor(profesor);
                LabelMensaje.Visible = true;
                LabelMensaje.Text = "Docente Guardado Correctamente...";
            }
        }

        protected void ButtonBuscarDocente_Click(object sender, EventArgs e)
        {
            if (TextBoxIdDocente.Text == "")
            {
                LabelError.Visible = true;
                LabelError.Text = "Introduzca la clave del docente...";
            }
            else
            {
                if (BDProfesor.buscarProfesor(TextBoxIdDocente.Text))
                {
                    profesor = new Profesores();
                    profesor = BDProfesor.ObtenerProfesor();

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
                else
                {
                    LabelError.Visible = true;
                    LabelError.Text = "El Id del Docente no existe en la base de datos...";
                }
            }
        }

        protected void ButtonEliminarDocente_Click(object sender, EventArgs e)
        {

            if (TextBoxIdDocente.Text == "")
            {
                LabelError.Visible = true;
                LabelError.Text = "Introduzca la clave del docente...";
            }
            else
            {

                BDProfesor.eliminarDocente(TextBoxIdDocente.Text);
                LabelMensaje.Visible = true;
                LabelMensaje.Text = "Profesor Eliminado Correctamente...";
            }
        }
        protected void ButtonModificarDocente_Click(object sender, EventArgs e)
        {

            if (TextBoxIdDocente.Text == "")
            {
                LabelError.Visible = true;
                LabelError.Text = "Introduzca la clave del docente...";
            }
            else
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

        protected void ButtonNuevoDocente_Click(object sender, EventArgs e)
        {
            TextBoxIdDocente.Enabled = true;
            TextBoxUsuarioDocente.Text ="";
            TextBoxPassworDocente.Text = "";
            TextBoxNombreDocente.Text = "";
            TextBoxApellidoDocente.Text = "";
            TextBoxEdadDocente.Text = "";
            TextBoxEmailDocente.Text = "";
            TextBoxCodigoPostalDocente.Text = "";
            TextBoxDireccionDocente.Text = "";
            TextBoxLocalidadAlumno.Text = "";
            TextBoxMuncipioDocente.Text ="";
        }

        protected void ButtonCerrarsesion_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Cookies.Add(new HttpCookie("ASP.NET_SessionId", ""));
            Response.Redirect("Login.aspx");
 
        }

        protected void ButtonConsultarDocente_Click(object sender, EventArgs e)
        {
            Response.Redirect("ConsultarProfesores.aspx");
        }
    }
}