using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SitioWebCBTA
{
    public partial class MenuAlumnos : System.Web.UI.Page
    {
        Alumnos alumno;
        BDAlumnos alumnoBd = new BDAlumnos();
        static string usuario;
        BDHorarios bdhorario = new BDHorarios();
        BDCalificaciones bdcalificaion = new BDCalificaciones();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["alumno"] != null)
            {

                usuario = Session["alumno"].ToString();
                

                buscarDatosAlumnos(Session["alumno"].ToString());
                int idAlumno = bdhorario.LeerMatricula(TextBoxMatriculaAlumno.Text);
            bdcalificaion.consultarHorarioAlumno(GridViewHorario, idAlumno);
            bdcalificaion.consultarCalificacionParcialAlumno(GridViewCalificacionParcial,idAlumno);
            bdcalificaion.consultarCalificacionFinalAlumno(GridViewCalificacionFinal,idAlumno);
            bdcalificaion.consultarCalificacionFinalKardexAlumno(GridViewKardex,idAlumno);
            }
            else
            {
                Response.Redirect("Login.aspx");
            }

        }
        
        public void buscarDatosAlumnos(string usuario)
        {
            if (alumnoBd.buscarAlumnosUsuario(usuario))
            {
                alumno = new Alumnos();
                alumno = alumnoBd.DevolverAlumnos();
                TextBoxMatriculaAlumno.Text =Convert.ToString(alumno.MatriculaAlumno);
                TextBoxUsuarioAlumno.Text = alumno.UsuarioAlumnos;
                TextBoxPasswordAlumno.Text = alumno.ContrasenniaAlumno;
                TextBoxNombreAlumno.Text = alumno.NombreAlumno;
                TextBoxApellidoAlumno.Text = alumno.ApellidosAlumno;
                if (alumno.SexoAlumno == "M")
                {
                    RadioButtonMasculinoAlumno.Checked = true;
                }
                else
                {
                    if (alumno.SexoAlumno == "F")
                    {
                        RadioButtonFemeninoAlumno.Checked = true;
                    }
                }
                TextBoxEdadAlumno.Text = Convert.ToString(alumno.EdadAlumno);
                TextBoxMuncipioAlumno.Text = alumno.MunicipioAlumno;
                TextBoxLocalidadAlumno.Text = alumno.LocalidadAlumno;
                TextBoxDireccionAlumno.Text = alumno.DirecccionAlumno;
                TextBoxCodigoPostalAlumno.Text = alumno.CodigoPostalAlumno;
                TextBoxEmailAlumno.Text = alumno.EmailAlumno;
                ImageAlumno.ImageUrl = alumno.FotoAlumno;

                TextBoxSemestre.Text = alumno.SemestreAtual;


            }
        }
        public string seleccionradio()
        {
            string sexo = "";
            string hombre = "M";
            string mujer = "F";

            if (RadioButtonFemeninoAlumno.Checked)
            {
                sexo = mujer;
            }
            else
            {
                if (RadioButtonMasculinoAlumno.Checked)
                {
                    sexo = hombre;
                }
            }
            return sexo;

        }
        
        protected void ButtonModificarAlumno_Click(object sender, EventArgs e)
        {
            alumno = new Alumnos();

            alumno.MatriculaAlumno =Convert.ToString(TextBoxMatriculaAlumno.Text);
            alumno.UsuarioAlumnos = TextBoxUsuarioAlumno.Text;
            alumno.ContrasenniaAlumno = TextBoxPasswordAlumno.Text;
            alumno.NombreAlumno = TextBoxNombreAlumno.Text;
            alumno.ApellidosAlumno = TextBoxApellidoAlumno.Text;
            alumno.SexoAlumno = seleccionradio();
            alumno.EdadAlumno = int.Parse(TextBoxEdadAlumno.Text);
            alumno.MunicipioAlumno = TextBoxMuncipioAlumno.Text;
            alumno.LocalidadAlumno = TextBoxLocalidadAlumno.Text;
            alumno.DirecccionAlumno = TextBoxDireccionAlumno.Text;
            alumno.CodigoPostalAlumno = TextBoxCodigoPostalAlumno.Text;
            alumno.EmailAlumno = TextBoxEmailAlumno.Text;
            alumno.FotoAlumno = ImageAlumno.ImageUrl;
            alumno.SemestreAtual =  TextBoxSemestre.Text;
            alumnoBd.ActualizarAlumno(alumno);

            LabelMensajeAlumno.Visible = true;
            LabelMensajeAlumno.Text = "Alumno Modificado Correctamente...";

        }

        protected void ButtonCargarImagenAlumno_Click(object sender, EventArgs e)
        {

            try
            {
                string ruta = Server.MapPath("~//") + FileUploadAlumno.FileName;
                FileUploadAlumno.SaveAs(ruta);
                ImageAlumno.ImageUrl = "~//" + FileUploadAlumno.FileName;

            }
            catch (Exception)
            {
                Response.Write("<script>window.alert('Seleccione una imagen')</script>");
            }

        }

        protected void ButtonCerrarsesion_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Cookies.Add(new HttpCookie("ASP.NET_SessionId", ""));
            Response.Redirect("Login.aspx");
 
        }


    }
}