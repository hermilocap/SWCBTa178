using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

namespace SitioWebCBTA
{
    public partial class MenuAdministrador : System.Web.UI.Page
    {
        Alumnos alumno;
        BDAlumnos alumnoBd=new BDAlumnos();
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

        public string seleccionradio()
        {
            string sexo="";
            string hombre = "M"; 
            string mujer="F";

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
        public bool validar()
        {
            bool vacio = false;

            if (TextBoxMatriculaAlumno.Text == "")
            {
                vacio = true;
            }
            else
            {
                if (TextBoxUsuarioAlumno.Text == "")
                {
                    vacio = true;
                }
                else
                {
                    if (TextBoxPasswordAlumno.Text == "")
                    {
                        vacio = true;
                    }
                    else

                        if (TextBoxNombreAlumno.Text == "")
                        {
                            vacio = true;
                        }
                        else
                        {
                            if (TextBoxApellidoAlumno.Text == "")
                            {
                                vacio = true;
                            }
                            else
                            {
                                if (TextBoxEdadAlumno.Text == "")
                                {
                                    vacio = true;
                                }
                                else
                                {
                                    if (TextBoxDireccionAlumno.Text == "")
                                    {
                                        return vacio;
                                    }
                                    else
                                    {
                                        if (TextBoxLocalidadAlumno.Text == "")
                                        {
                                            vacio = true;
                                        }
                                        else
                                        {
                                            if (TextBoxMuncipioAlumno.Text == "")
                                            {
                                                vacio = true;
                                            }
                                            else
                                            {
                                                if (TextBoxEmailAlumno.Text == "")
                                                {
                                                    vacio = true;
                                                }
                                                else
                                                {
                                                    if (TextBoxCodigoPostalAlumno.Text == "")
                                                    {
                                                        vacio = true;
                                                    }
                                                    else
                                                    {
                                                        if (RadioButtonFemeninoAlumno.Checked == false)
                                                        {
                                                            vacio = true;
                                                        }
                                                        else
                                                        {
                                                            if (RadioButtonMasculinoAlumno.Checked == false)
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
                }
            }

            return vacio;
        }

        protected void ButtonGuardarAlumno_Click(object sender, EventArgs e)
        {
            //bool vacio=validar();
            //if (vacio == true)
            //{
            //    // LabelMensajeAlumno.ForeColor = Color.Red;
            //    LabelError.Visible = true;
            //   LabelError.Text = "Todos los campos son obligatorio...";
            //}
            //else
            //{
                int id = alumnoBd.EstablecerId();
                alumno = new Alumnos();
                alumno.IdAlumno = id;
                alumno.MatriculaAlumno = TextBoxMatriculaAlumno.Text;
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
                alumno.SemestreAtual = DropDownListSemestre.SelectedValue;
                alumnoBd.registrarAlumno(alumno);

                // LabelMensajeAlumno.ForeColor = Color.Red;
                LabelMensajeAlumno.Visible = true;
                LabelMensajeAlumno.Text = "Alumno Guardado Correctamente...";
            //}
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

        protected void ButtonBuscarAlumno_Click(object sender, EventArgs e)
        {
            if (TextBoxMatriculaAlumno.Text == "")
            {
                LabelError.Visible = true;
                LabelError.Text = "Introduzca la matricula del alumno...";
            }
            else
            {
                if (alumnoBd.buscarAlumnosMatricula(TextBoxMatriculaAlumno.Text))
                {
                    alumno = new Alumnos();
                    alumno = alumnoBd.DevolverAlumnos();
                    TextBoxMatriculaAlumno.Text =Convert.ToString(alumno.IdAlumno);
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

                    DropDownListSemestre.SelectedValue = Convert.ToString(alumno.SemestreAtual);


                }
                else
                {
                    LabelError.Visible = true;
                    LabelError.Text = "La Matricula del Alumno no existe en la base de datos...";

                }
            }
        }

        protected void ButtonEliminarAlumno_Click(object sender, EventArgs e)
        {
            if (TextBoxMatriculaAlumno.Text =="")
            {

                LabelError.Visible = true;
                LabelError.Text = "Introduzca la matricula del alumno...";
           
            }
            else
            {
                alumnoBd.EliminarAlumno(TextBoxMatriculaAlumno.Text);
                LabelMensajeAlumno.Visible = true;
                LabelMensajeAlumno.Text = "Alumno Eliminado Correctamente...";
            }
        }

        protected void ButtonModificarAlumno_Click(object sender, EventArgs e)
        {
            if (TextBoxMatriculaAlumno.Text == "")
            {
                LabelError.Visible = true;
                LabelError.Text = "Introduzca la matricula del alumno...";
           
            }
            else
            {
                alumno = new Alumnos();

                alumno.MatriculaAlumno = TextBoxMatriculaAlumno.Text;
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
                alumno.SemestreAtual = DropDownListSemestre.SelectedValue;

                alumnoBd.ActualizarAlumno(alumno);

                LabelMensajeAlumno.Visible = true;
                LabelMensajeAlumno.Text = "Alumno Modificado Correctamente...";
            }
        }

        protected void ButtonNuevoAlumno_Click(object sender, EventArgs e)
        {
            TextBoxMatriculaAlumno.Text="";
            TextBoxUsuarioAlumno.Text="";
            TextBoxPasswordAlumno.Text="";
            TextBoxNombreAlumno.Text="";
            TextBoxApellidoAlumno.Text="";
            RadioButtonFemeninoAlumno.Checked=false;
            RadioButtonMasculinoAlumno.Checked=false;
            TextBoxEdadAlumno.Text="";
            TextBoxMuncipioAlumno.Text="";
            TextBoxLocalidadAlumno.Text="";
            TextBoxDireccionAlumno.Text="";
            TextBoxCodigoPostalAlumno.Text="";
            TextBoxEmailAlumno.Text="";
            ImageAlumno.ImageUrl="";
            DropDownListSemestre.SelectedValue=null;
        }

        protected void RadioButtonMasculinoAlumno_CheckedChanged(object sender, EventArgs e)
        {
            
           
            RadioButtonFemeninoAlumno.Checked = false; 
            RadioButtonMasculinoAlumno.Checked = true;
        }

        protected void RadioButtonFemeninoAlumno_CheckedChanged(object sender, EventArgs e)
        {
          
            RadioButtonMasculinoAlumno.Checked = false;
            RadioButtonFemeninoAlumno.Checked = true;

        }

      

        protected void ButtonCerrarsesion_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Cookies.Add(new HttpCookie("ASP.NET_SessionId", ""));
            Response.Redirect("Login.aspx");
        }

        protected void ButtonConsultarAlumno_Click(object sender, EventArgs e)
        {
            Response.Redirect("ConsultarAlumnos.aspx");
        }

        
    }
}