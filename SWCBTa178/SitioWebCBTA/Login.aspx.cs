using SitioWebCBTA.BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SitioWebCBTA
{
    public partial class Login : System.Web.UI.Page
    {
        private static string nickname;
        private static string password;

        BDUsuarios usuario = new BDUsuarios();

        protected void Page_Load(object sender, EventArgs e)
        {


        }
        protected void ButtonAceptar_Click(object sender, EventArgs e)
        {

            if (TextBoxUsuario.Text == "")
            {
                LabelError.Visible = true;
                LabelError.Text = "EL Usuario es obligatorio";
            }

            else
            {
                if (TextBoxPassword.Text == "")
                {
                    LabelError.Visible = true;
                    LabelError.Text = "La  contraseña es obligatorio";
                }
                else
                {
                    if (DropDownListRol.SelectedValue == "Seleccione una opcion...")
                    {
                        LabelError.Visible = true;
                        LabelError.Text = "Seleccione un tipo de usuario";
                    }
                    else
                    {
                        nickname = TextBoxUsuario.Text;
                        password = TextBoxPassword.Text;

                        if (DropDownListRol.SelectedValue == "Administrador")
                        {
                            if (usuario.autenticarAdmin(nickname, password))
                            {
                                Session["admin"] = nickname;
                                Response.Redirect("MenuAdministrador.aspx");
                            }
                            else
                            {
                                LabelError.Visible = true;
                                LabelError.Text = "Usuario o contraseña invalido..";
                            }
                        }
                        else
                        {
                            if (DropDownListRol.SelectedValue == "Docente")
                            {
                                if (usuario.autenticarProfesor(nickname, password))
                                {
                                    Session["docente"] = nickname;
                                    Response.Redirect("MenuProfesores.aspx");
                                }

                                else
                                {
                                    LabelError.Visible = true;
                                    LabelError.Text = "Usuario o contraseña invalido..";
                                }
                            }
                            else
                            {
                                if (DropDownListRol.SelectedValue == "Alumno")
                                {
                                    if (usuario.autenticarAlumno(nickname, password))
                                    {
                                        Session["alumno"] = nickname;
                                        Response.Redirect("MenuAlumnos.aspx");
                                    }
                                    else
                                    {
                                        LabelError.Visible = true;
                                        LabelError.Text = "Usuario o contraseña invalido..";
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