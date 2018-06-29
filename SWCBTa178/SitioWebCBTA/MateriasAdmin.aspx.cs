using SitioWebCBTA.BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

namespace SitioWebCBTA
{
    public partial class MateriasAdmin : System.Web.UI.Page
    {

        Materias materia;
        BDMaterias bdmateria=new BDMaterias();
        public static string usuario;
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

      
        protected void ButtonGuardarMateria_Click(object sender, EventArgs e)
        {
            if (TextBoxNombreMateria.Text == "")
            {
                LabelError.Visible = true;
                LabelError.Text = "Campos obligatorio";
                TextBoxNombreMateria.Focus();
            }
            else
            {

                int id = bdmateria.EstablecerId();
                materia = new Materias();
                materia.IdMateria = id;
                materia.NombreMateria = TextBoxNombreMateria.Text;
                materia.IdSeemstre = DropDownListSemestre.SelectedValue;
                materia.Idprofesor =Convert.ToInt32(DropDownListProfesor.SelectedValue);
                bdmateria.RegistrarMateria(materia);

                LabelMensaje.Visible = true;
                LabelMensaje.Text = "Materia Guardado Correctamente...";
            }
        }

        protected void ButtonBuscarMateria_Click(object sender, EventArgs e)
        {
            if (bdmateria.buscarMateria(TextBoxIdmateria.Text))
            {
                materia = new Materias();

                materia = bdmateria.ObtenerMateria();
                TextBoxIdmateria.Text = Convert.ToString(materia.IdMateria);
                TextBoxNombreMateria.Text = materia.NombreMateria;
                DropDownListSemestre.SelectedValue = Convert.ToString(materia.IdSeemstre);
                DropDownListProfesor.SelectedValue = Convert.ToString(materia.Idprofesor);
            }
            else
            {
                LabelAdvertencia.Visible = true;
                LabelAdvertencia.Text = "Materia no se encuentra en la base de datos...";
            }
        }

        protected void ButtonEliminarMateria_Click(object sender, EventArgs e)
        {
            if (TextBoxIdmateria.Text == "")
            {
                LabelAdvertencia.Visible = true;
                LabelAdvertencia.Text = "Debe buscar la materia a eliminar";

            }
            else
            {
                bdmateria.eliminarMateria(TextBoxIdmateria.Text);
                LabelMensaje.Visible = true;
                LabelMensaje.Text = "Materia Eliminado Correctamente...";
            }
        }

        protected void ButtonModificarMateria_Click(object sender, EventArgs e)
        {
            if (TextBoxIdmateria.Text == "")
            {
                LabelAdvertencia.Visible = true;
                LabelAdvertencia.Text = "Debe buscar la materia a modificar";

            }
            else
            {
                materia = new Materias();
                materia.IdMateria = int.Parse(TextBoxIdmateria.Text);
                materia.NombreMateria = TextBoxNombreMateria.Text;
                materia.IdSeemstre = DropDownListSemestre.SelectedValue;
                materia.Idprofesor = Convert.ToInt32(DropDownListProfesor.SelectedValue);
                bdmateria.modificarMateria(materia);

                LabelMensaje.Visible = true;
                LabelMensaje.Text = "Materia Modificado Correctamente...";
            }
        }

        protected void ButtonNuevoMateria_Click(object sender, EventArgs e)
        {
            TextBoxIdmateria.Text = "";
            TextBoxNombreMateria.Text = "";
            DropDownListSemestre.SelectedValue = null;
        }

        protected void ButtonCerrarsesion_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Cookies.Add(new HttpCookie("ASP.NET_SessionId", ""));
            Response.Redirect("Login.aspx");
        }

        protected void ButtonConsultarMateria_Click(object sender, EventArgs e)
        {
            Response.Redirect("ConsultarMaterias.aspx");
        }
    }
}