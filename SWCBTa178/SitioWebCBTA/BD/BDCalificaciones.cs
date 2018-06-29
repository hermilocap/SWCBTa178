using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using SitioWebCBTA.BD;
using System.Configuration;
using System.Web.UI.WebControls;

namespace SitioWebCBTA
{
    public class BDCalificaciones
    {
        private static SqlCommand cmd;
        private static SqlDataReader dr;
        private static Calificaciones calificaciones;
        BDAlumnos bdalumnos = new BDAlumnos();
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ToString());
        
        private Boolean existeCalificacion()
        {
            string strsql = @"SELECT * FROM Calificaciones";
            Boolean existe = false;
            SqlCommand cmdsql = new SqlCommand(strsql, cn);
            cn.Open();

            SqlDataReader rs = cmdsql.ExecuteReader();
            if (rs.Read())
            {
                existe = true;
            }
            cn.Close();
            return existe;
        }

        //establcer maximo
        public int EstablecerId()
        {
            if (existeCalificacion())
            {
                return idmax() + 1;
            }
            else
            {
                return 1;
            }
        }

        //Capturar el máximo ID
        private int idmax()
        {
            string strsql = @"SELECT MAX(IdCalificacion) FROM Calificaciones";
            int val = 0;
            SqlCommand cmdsql = new SqlCommand(strsql, cn);
            cn.Open();

            SqlDataReader rs = cmdsql.ExecuteReader();
            if (rs.Read())
            {
                val = int.Parse(rs[0].ToString());

            }
            cn.Close();
            return val;
        }

        public string LeerMateria(int id)
        {
            string strsql = @"SELECT NombreMateria FROM HorarioClase";
            string val = "";
            SqlCommand cmdsql = new SqlCommand(strsql, cn);
            cn.Open();

            SqlDataReader rs = cmdsql.ExecuteReader();
            if (rs.Read())
            {
                val = rs[4].ToString();

            }
            cn.Close();
            return val;
        }

        public void registrarCalificaciones(Calificaciones calificacion)
        {
            cmd = new SqlCommand("InsertarCalificaciones", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdCalificacion", calificacion.IdCalificacion);
            cmd.Parameters.AddWithValue("@IdHorarioClase", calificacion.IdIdHorarioClase);
            cmd.Parameters.AddWithValue("@CalFinal", calificacion.CalFinal);
            cmd.Parameters.AddWithValue("@CalParcial1", calificacion.CalParcial1);
            cmd.Parameters.AddWithValue("@CalParcial2", calificacion.CalParcial2);
            cmd.Parameters.AddWithValue("@CalParcial3", calificacion.CalParcial3);
           
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        

        public void consultarHorarioAlumno(GridView gridview,int id)
        {           DataTable dt = new DataTable();

        SqlCommand cmd = new SqlCommand("select IdHorarioClase,NombreProfesor,NombreMateria,Aula,Dias,Grupo,HoraEntrada,HoraSalida from HorarioClase inner join Profesores ON HorarioClase.IdProfesor=Profesores.IdProfesor inner join Materias ON HorarioClase.IdMateria=Materias.IdMateria where HorarioClase.IdAlumno=@IdAlumno", cn);
                    cmd.Parameters.AddWithValue("@IdAlumno", id);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    gridview.DataSource = dt;
                    gridview.DataBind();
           }

        public void consultarHorarioDocente(GridView gridview, int id)
        {
            DataTable dt = new DataTable();

            SqlCommand cmd = new SqlCommand("select IdHorarioClase,NombreProfesor,NombreMateria,Aula,Dias,Grupo,HoraEntrada,HoraSalida from HorarioClase inner join Profesores ON HorarioClase.IdProfesor=Profesores.IdProfesor inner join Materias ON HorarioClase.IdMateria=Materias.IdMateria where Materias.IdProfesor=@IdProfesor", cn);
            cmd.Parameters.AddWithValue("@UsuarioProfesor", id);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            gridview.DataSource = dt;
            gridview.DataBind();
        }

        public void consultarCalificacionParcialAlumno(GridView gridview, int id)
        {
            DataTable dt = new DataTable();

            SqlCommand cmd = new SqlCommand("select NombreMateria, CalParcial1,CalParcial2,CalParcial3 from Materias inner join  HorarioClase on Materias.IdMateria=HorarioClase.IdMateria inner join Calificaciones on Calificaciones.IdHorarioClase=HorarioClase.IdHorarioClase where IdAlumno=@IdAlumno and HorarioClase.IdSeemstre=@IdSeemstre", cn);
            cmd.Parameters.AddWithValue("@IdAlumno", id);
            cmd.Parameters.AddWithValue("@IdSeemstre", bdalumnos.ObtenerSemestreActual(id));            
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            gridview.DataSource = dt;
            gridview.DataBind();
        }
        public void consultarCalificacionFinalAlumno(GridView gridview, int id)
        {
            DataTable dt = new DataTable();

            SqlCommand cmd = new SqlCommand("select NombreMateria, CalFinal from Materias inner join  HorarioClase on Materias.IdMateria=HorarioClase.IdMateria inner join Calificaciones on Calificaciones.IdHorarioClase=HorarioClase.IdHorarioClase where IdAlumno=@IdAlumno and HorarioClase.IdSeemstre=@IdSeemstre", cn);
            cmd.Parameters.AddWithValue("@IdAlumno", id);
            cmd.Parameters.AddWithValue("@IdSeemstre", bdalumnos.ObtenerSemestreActual(id));

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            gridview.DataSource = dt;
            gridview.DataBind();
        }
        public void consultarCalificacionFinalKardexAlumno(GridView gridview, int id)
        {
            DataTable dt = new DataTable();

            SqlCommand cmd = new SqlCommand("select NombreMateria, CalFinal from Materias inner join  HorarioClase on Materias.IdMateria=HorarioClase.IdMateria inner join Calificaciones on Calificaciones.IdHorarioClase=HorarioClase.IdHorarioClase where IdAlumno=@IdAlumno", cn);
            cmd.Parameters.AddWithValue("@IdAlumno", id);


            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            gridview.DataSource = dt;
            gridview.DataBind();
        }

        public int LeerMatricula(string matricula)
        {
            string strsql = @"SELECT IdAlumno FROM Alumnos";
            int val = 0;
            SqlCommand cmdsql = new SqlCommand(strsql, cn);
            cn.Open();

            SqlDataReader rs = cmdsql.ExecuteReader();
            if (rs.Read())
            {
                val = int.Parse(rs[0].ToString());

            }
            cn.Close();
            return val;
        }

     public bool ConsultarCalificaciones(int idhorario)
        {
         bool encontrado=false;
         string consultarQuey = "select*from Calificaciones where IdHorarioClase='" + idhorario + "'";
            cmd = new SqlCommand(consultarQuey,cn);
            cn.Open();   
             dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                calificaciones = new Calificaciones();
                calificaciones.IdCalificacion =int.Parse(dr[0].ToString());
                calificaciones.IdIdHorarioClase = int.Parse(dr[1].ToString());
                calificaciones.CalFinal = int.Parse(dr[2].ToString());
                calificaciones.CalParcial1 = int.Parse(dr[3].ToString());
                calificaciones.CalParcial2 = int.Parse(dr[4].ToString());
                calificaciones.CalParcial3 = int.Parse(dr[5].ToString());
                encontrado = true;
            }

           cn.Close();
           return encontrado;
        }
     public Calificaciones RetornerCalificacion()
     {
         return calificaciones;
     }

        public void ModificarCalificaciones(Calificaciones calificacion)
        {

            cmd = new SqlCommand("UPDATE Calificaciones SET CalFinal=@CalFinal,CalParcial1=@CalParcial1,CalParcial2=@CalParcial2,CalParcial3=@CalParcial3 where IdHorarioClase=@IdHorarioClase", cn);

            cmd.Parameters.AddWithValue("@IdHorarioClase", calificacion.IdIdHorarioClase);
            cmd.Parameters.AddWithValue("@CalFinal", calificacion.CalFinal);
            cmd.Parameters.AddWithValue("@CalParcial1", calificacion.CalParcial1);
            cmd.Parameters.AddWithValue("@CalParcial2", calificacion.CalParcial2);
            cmd.Parameters.AddWithValue("@CalParcial3", calificacion.CalParcial3);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();

        }

        public void eliminarCalificaciones(int idhorario)
        {

            string eliminarQuery = "Delete from Calificaciones where where IdHorarioClase='" + idhorario + "'";
            cmd = new SqlCommand(eliminarQuery, cn);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
            
        }

    }
}