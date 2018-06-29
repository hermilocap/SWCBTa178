using SitioWebCBTA.BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace SitioWebCBTA
{
    public class BDAlumnos
    {
       private static SqlCommand cmd;
       private static SqlDataReader dr;
       private static Alumnos AuxAlumnos;
       SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ToString());
        

        public void registrarAlumno(Alumnos alumno)
        {

            cmd = new SqlCommand("InsertarAlumno", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MatriculaAlumno",alumno.IdAlumno);
            cmd.Parameters.AddWithValue("@UsuarioAlumno",alumno.UsuarioAlumnos);
            cmd.Parameters.AddWithValue("@ContrasenniaAlumno",alumno.ContrasenniaAlumno);
            cmd.Parameters.AddWithValue("@NombreAlumno", alumno.NombreAlumno);
            cmd.Parameters.AddWithValue("@ApellidosAlumno",alumno.ApellidosAlumno);
            cmd.Parameters.AddWithValue("@SexoAlumno", alumno.SexoAlumno);
            cmd.Parameters.AddWithValue("@EdadAlumno", alumno.EdadAlumno);
            cmd.Parameters.AddWithValue("@MunicipioAlumno",  alumno.MunicipioAlumno);
            cmd.Parameters.AddWithValue("@LocalidadAlumno",  alumno.LocalidadAlumno);
            cmd.Parameters.AddWithValue("@DirecccionAlumno", alumno.DirecccionAlumno);
            cmd.Parameters.AddWithValue("@CodigoPostalAlumno",alumno.CodigoPostalAlumno);
            cmd.Parameters.AddWithValue("@EmailAlumno", alumno.EmailAlumno);
            cmd.Parameters.AddWithValue("@FotoAlumno", alumno.FotoAlumno);
            cmd.Parameters.AddWithValue("@SemestreActual", alumno.SemestreAtual);
            cmd.Parameters.AddWithValue("@SemestreAnterior", alumno.Semestre);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }
      
        private Boolean existeMatriculaAlumnoNuevo()
        {
            string strsql = @"SELECT * FROM Alumnos";
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
            if (existeMatriculaAlumnoNuevo())
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
            string strsql = @"SELECT MAX(MatriculaAlumno) FROM Alumnos";
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


        public int ObtenerSemestreActual(int id)
        {       int semestre = 0;
                 string strsql = @"SELECT * FROM  Alumnos WHERE IdAlumno=" + id;
                SqlCommand cmdsql = new SqlCommand(strsql, cn);

                cn.Open();
                SqlDataReader rs = cmdsql.ExecuteReader();
                if (rs.Read())
                {
                    semestre = int.Parse(rs[14].ToString());

                }
                cn.Close();

                return semestre;

            }

        public List<Alumnos> consultaGeneralAlumnos()
       {
         List<Alumnos> listaAlumnos=new List<Alumnos>();
         string consultarQuery = String.Format("SELECT*FROM Alumnos");
         cmd = new SqlCommand(consultarQuery, BDConexion.cn);
         BDConexion.cn.Open();
         dr= cmd.ExecuteReader();
         while (dr.Read())
         {
             AuxAlumnos = new Alumnos();
             AuxAlumnos.IdAlumno =int.Parse(dr[0].ToString());
             AuxAlumnos.MatriculaAlumno = dr[1].ToString();
             AuxAlumnos.UsuarioAlumnos = dr[2].ToString();
             AuxAlumnos.ContrasenniaAlumno = dr[3].ToString();
             AuxAlumnos.NombreAlumno = dr[4].ToString();
             AuxAlumnos.ApellidosAlumno=dr[5].ToString();
             AuxAlumnos.SexoAlumno =dr[6].ToString();
             AuxAlumnos.EdadAlumno = Convert.ToInt32(dr[7].ToString());
             AuxAlumnos.MunicipioAlumno = dr[8].ToString();
             AuxAlumnos.LocalidadAlumno = dr[9].ToString();
             AuxAlumnos.DirecccionAlumno = dr[10].ToString();
             AuxAlumnos.CodigoPostalAlumno = dr[11].ToString();
             AuxAlumnos.EmailAlumno = dr[12].ToString();
             AuxAlumnos.FotoAlumno = dr[13].ToString();
             AuxAlumnos.Semestre =dr[14].ToString();
             listaAlumnos.Add(AuxAlumnos);
           
         }
         dr.Close();
         BDConexion.cn.Close();
         return listaAlumnos;
       }

        public bool buscarAlumnosMatricula(string matricula)
        {
            bool encontrado = false;
            string buscar = "SELECT*FROM Alumnos WHERE MatriculaAlumno='" + matricula + "'";
            cmd = new SqlCommand(buscar, cn);
            cn.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                AuxAlumnos = new Alumnos();


                AuxAlumnos.IdAlumno = int.Parse(dr[0].ToString());
                AuxAlumnos.UsuarioAlumnos = dr[1].ToString();
                AuxAlumnos.ContrasenniaAlumno = dr[2].ToString();
                AuxAlumnos.NombreAlumno = dr[3].ToString();
                AuxAlumnos.ApellidosAlumno = dr[4].ToString();
                AuxAlumnos.SexoAlumno = dr[5].ToString();
                AuxAlumnos.EdadAlumno = Convert.ToInt32(dr[6].ToString());
                AuxAlumnos.MunicipioAlumno = dr[7].ToString();
                AuxAlumnos.LocalidadAlumno = dr[8].ToString();
                AuxAlumnos.DirecccionAlumno = dr[9].ToString();
                AuxAlumnos.CodigoPostalAlumno = dr[10].ToString();
                AuxAlumnos.EmailAlumno = dr[11].ToString();
                AuxAlumnos.FotoAlumno = dr[12].ToString();
                AuxAlumnos.SemestreAtual =dr[13].ToString();
                encontrado = true;
            }

           cn.Close();

            return encontrado;
        }
        public bool buscarAlumnosUsuario(string usuario)
        {
            bool encontrado = false;
            string buscar = "SELECT*FROM Alumnos WHERE UsuarioAlumno='" + usuario + "'";
            cmd = new SqlCommand(buscar, cn);
            cn.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                AuxAlumnos = new Alumnos();

                AuxAlumnos.IdAlumno = int.Parse(dr[0].ToString());
                AuxAlumnos.UsuarioAlumnos = dr[1].ToString();
                AuxAlumnos.ContrasenniaAlumno = dr[2].ToString();
                AuxAlumnos.NombreAlumno = dr[3].ToString();
                AuxAlumnos.ApellidosAlumno = dr[4].ToString();
                AuxAlumnos.SexoAlumno = dr[5].ToString();
                AuxAlumnos.EdadAlumno = Convert.ToInt32(dr[6].ToString());
                AuxAlumnos.MunicipioAlumno = dr[7].ToString();
                AuxAlumnos.LocalidadAlumno = dr[8].ToString();
                AuxAlumnos.DirecccionAlumno = dr[9].ToString();
                AuxAlumnos.CodigoPostalAlumno = dr[10].ToString();
                AuxAlumnos.EmailAlumno = dr[12].ToString();
                AuxAlumnos.FotoAlumno = dr[13].ToString();
                AuxAlumnos.SemestreAtual = dr[14].ToString();
                encontrado = true;
            }

            cn.Close();

            return encontrado;
        }

        public bool buscarAlumnosPorNombre(string nombre)
        {

            bool encontrado = false;
            string buscar ="SELECT*FROM Alumnos WHERE NombreAlumno='" + nombre + "'";
            cmd = new SqlCommand(buscar, BDConexion.cn);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                AuxAlumnos = new Alumnos();

                AuxAlumnos.IdAlumno = int.Parse(dr[0].ToString());

                AuxAlumnos.UsuarioAlumnos = dr[1].ToString();
                AuxAlumnos.ContrasenniaAlumno = dr[2].ToString();
                AuxAlumnos.NombreAlumno = dr[3].ToString();
                AuxAlumnos.ApellidosAlumno = dr[4].ToString();
                AuxAlumnos.SexoAlumno = dr[5].ToString();
                AuxAlumnos.EdadAlumno = Convert.ToInt32(dr[6].ToString());
                AuxAlumnos.MunicipioAlumno = dr[7].ToString();
                AuxAlumnos.LocalidadAlumno = dr[8].ToString();
                AuxAlumnos.DirecccionAlumno = dr[9].ToString();
                AuxAlumnos.CodigoPostalAlumno = dr[10].ToString();
                AuxAlumnos.EmailAlumno = dr[12].ToString();
                AuxAlumnos.FotoAlumno = dr[13].ToString();
                AuxAlumnos.SemestreAtual = dr[14].ToString();
                encontrado = true;
            }

            BDConexion.cn.Close();

            return encontrado;
        }



        public Alumnos DevolverAlumnos()
    {
        return AuxAlumnos;
    }
        
        public void ActualizarAlumno(Alumnos alumno)
        {
            string actualizarquery = "UPDATE Alumnos SET UsuarioAlumno=@UsuarioAlumno,ContrasenniaAlumno=@ContrasenniaAlumno,NombreAlumno=@NombreAlumno,ApellidosAlumno=@ApellidosAlumno,SexoAlumno=@SexoAlumno,EdadAlumno=@EdadAlumno,MunicipioAlumno=@MunicipioAlumno,LocalidadAlumno=@LocalidadAlumno,DirecccionAlumno=@DirecccionAlumno,CodigoPostalAlumno=@CodigoPostalAlumno,EmailAlumno=@EmailAlumno,FotoAlumno=@FotoAlumno,SemestreActual=@SemestreActual WHERE MatriculaAlumno=@MatriculaAlumno";
         cmd = new SqlCommand(actualizarquery, cn);
         cmd.Parameters.AddWithValue("@MatriculaAlumno", alumno.IdAlumno);
         cmd.Parameters.AddWithValue("@UsuarioAlumno", alumno.UsuarioAlumnos);
         cmd.Parameters.AddWithValue("@ContrasenniaAlumno", alumno.ContrasenniaAlumno);
         cmd.Parameters.AddWithValue("@NombreAlumno", alumno.NombreAlumno);
         cmd.Parameters.AddWithValue("@ApellidosAlumno", alumno.ApellidosAlumno);
         cmd.Parameters.AddWithValue("@SexoAlumno", alumno.SexoAlumno);
         cmd.Parameters.AddWithValue("@EdadAlumno", alumno.EdadAlumno);
         cmd.Parameters.AddWithValue("@MunicipioAlumno", alumno.MunicipioAlumno);
         cmd.Parameters.AddWithValue("@LocalidadAlumno", alumno.LocalidadAlumno);
         cmd.Parameters.AddWithValue("@DirecccionAlumno", alumno.DirecccionAlumno);
         cmd.Parameters.AddWithValue("@CodigoPostalAlumno", alumno.CodigoPostalAlumno);
         cmd.Parameters.AddWithValue("@EmailAlumno", alumno.EmailAlumno);
         cmd.Parameters.AddWithValue("@FotoAlumno", alumno.FotoAlumno);
         cmd.Parameters.AddWithValue("@SemestreActual", alumno.SemestreAtual);
         cmd.Parameters.AddWithValue("@SemestreAnterior", alumno.Semestre);

         cn.Open();
         cmd.ExecuteNonQuery();
         cn.Close();


        }
        public void EliminarAlumno(string matricula)
        {
            string eliminarquery ="DELETE From Alumnos WHERE MatriculaAlumno='" + matricula + "'";
            cmd = new SqlCommand(eliminarquery, cn);
            cn.Open();
            cmd.ExecuteScalar();
            cn.Close();
        }

    }
}