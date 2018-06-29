using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using SitioWebCBTA.BD;
using System.Configuration;

namespace SitioWebCBTA
{
    public class BDHorarios
    {
        private static SqlCommand cmd;
        private static SqlDataReader dr;
        private static Horarios horarios;
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ToString());
        private Boolean existeHorario()
        {
            string strsql = @"SELECT * FROM HorarioClase";
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
            if (existeHorario())
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
            string strsql = @"SELECT MAX(IdHorarioClase) FROM HorarioClase";
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

        public int LeerMatricula(string matricula)
        {
            string strsql = @"SELECT IdAlumno FROM Alumnos where MatriculaAlumno="+ matricula;
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

        public int  LeerSemestre(int id)
        {

            string strsql = @"SELECT IdSeemstre FROM Alumnos";
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
        public int NumSemestre(int id)
        {

            string strsql = @"SELECT IdSeemstre FROM Alumnos  where IdAlumno="+id;
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
             
        public void registrarHorario(Horarios horario)
        {
            cmd = new SqlCommand("InsertarHorarioClase", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdHorarioClase", horario.IdHorarioClase);
                cmd.Parameters.AddWithValue("@IdProfesor", horario.IdProfesor);
                cmd.Parameters.AddWithValue("@IdAlumno", horario.IdAlumno); 
            cmd.Parameters.AddWithValue("@IdSeemstre", horario.IdSeemstre);
               cmd.Parameters.AddWithValue("@IdMateria", horario.IdMateria);
               
                cmd.Parameters.AddWithValue("@CicloEscolar", horario.CicloEscolar);
                cmd.Parameters.AddWithValue("@Grupo", horario.Grupo);
                cmd.Parameters.AddWithValue("@Aula", horario.Aula);
                cmd.Parameters.AddWithValue("@HoraEntrada", horario.HoraEntrada);
                cmd.Parameters.AddWithValue("@HoraSalida", horario.HoraSalida);
                cmd.Parameters.AddWithValue("@Dias", horario.Dias);
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            
        }
        
        public bool ExisteHorario(int idsemestre,int idmateria,string cicloescolar,string grupo,string horaentrada, string horasalida, string dias)
       {
               string query = "SELECT COUNT(*) FROM HorarioClase WHERE  IdSeemstre=@IdSeemstre AND IdMateria=@IdMateria AND CicloEscolar=@CicloEscolar AND Grupo=@Grupo AND HoraEntrada = @HoraEntrada AND  HoraSalida=@HoraSalida AND Dias=@Dias";
               SqlCommand cmd = new SqlCommand(query, cn);

               cmd.Parameters.AddWithValue("@IdSeemstre",idsemestre);
               cmd.Parameters.AddWithValue("@IdMateria", idmateria);
               cmd.Parameters.AddWithValue("@CicloEscolar",cicloescolar);
               cmd.Parameters.AddWithValue("@Grupo", grupo);
               cmd.Parameters.AddWithValue("@HoraEntrada",horaentrada);
               cmd.Parameters.AddWithValue("@HoraSalida", horasalida);
               cmd.Parameters.AddWithValue("@Dias",dias);
               

               cn.Open();

               int count = Convert.ToInt32(cmd.ExecuteScalar());
               cn.Close();

               if (count == 0)
               {
                   return false;
               }
               else
               {
                   return true;
               }
               
           
       }

        public bool buscarHorarioAlumno(int id,int idmateria)
        {
            bool encontrado = false;
            string buscarQuery = "Select * from HorarioClase where IdAlumno='" + id + "' and IdMateria='" + idmateria + "'";
            cmd = new SqlCommand(buscarQuery, cn);
            
            cn.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                horarios = new Horarios();

                horarios.IdHorarioClase =int.Parse(dr[0].ToString()); 
                horarios.IdProfesor = int.Parse(dr[1].ToString());
                horarios.IdAlumno = int.Parse(dr[2].ToString());
               
                horarios.IdSeemstre = int.Parse(dr[3].ToString());
                horarios.IdMateria = int.Parse(dr[4].ToString());
                horarios.CicloEscolar = dr[5].ToString();
                horarios.Grupo = dr[6].ToString();
                horarios.Aula = dr[7].ToString();
                horarios.HoraEntrada = dr[8].ToString();
                horarios.HoraSalida = dr[9].ToString();
                horarios.Dias = dr[10].ToString();
                encontrado = true;

            }
            cn.Close();
            return encontrado;
        }

        public bool buscarHorarioDocente(int iddocente,int idmateria)
        {
            bool encontrado = false;
            string buscarQuery = "Select * from HorarioClase where IdProfesor='" + iddocente + "' and IdMateria='" + idmateria + "'";
            cmd = new SqlCommand(buscarQuery, cn);

            cn.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                horarios = new Horarios();

                horarios.IdHorarioClase =int.Parse(dr[0].ToString()); 
                horarios.IdProfesor = int.Parse(dr[1].ToString());
                horarios.IdAlumno = int.Parse(dr[2].ToString());
              
                horarios.IdSeemstre = int.Parse(dr[3].ToString());
                horarios.IdMateria = int.Parse(dr[4].ToString());
                horarios.CicloEscolar = dr[5].ToString();
                horarios.Grupo = dr[6].ToString();
                horarios.Aula = dr[7].ToString();
                horarios.HoraEntrada = dr[8].ToString();
                horarios.HoraSalida = dr[9].ToString();
                horarios.Dias = dr[10].ToString();
                encontrado = true;

            }
            cn.Close();
            return encontrado;
        }

        public bool ConsultarHorarioDocente(int iddocente, int idmateria)
        {
            bool encontrado = false;
            string buscarQuery = "Select * from HorarioClase where IdProfesor='" + iddocente + "'";
            cmd = new SqlCommand(buscarQuery, cn);

            cn.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                horarios = new Horarios();

                horarios.IdHorarioClase =int.Parse(dr[0].ToString());
                horarios.IdAlumno = int.Parse(dr[1].ToString());
                horarios.IdProfesor = int.Parse(dr[2].ToString());
                horarios.IdSeemstre = int.Parse(dr[3].ToString());
                horarios.IdMateria = int.Parse(dr[4].ToString());
                horarios.CicloEscolar = dr[5].ToString();
                horarios.Grupo = dr[6].ToString();
                horarios.Aula = dr[7].ToString();
                horarios.HoraEntrada = dr[8].ToString();
                horarios.HoraSalida = dr[9].ToString();
                horarios.Dias = dr[10].ToString();
                encontrado = true;

            }
            cn.Close();
            return encontrado;
        }

       public Horarios ReornarHorario()
       {
           return horarios;
       }

       public bool ModificarHorarioAumno(Horarios horario)
       {
           bool modificar = false;
           cmd = new SqlCommand("UPDATE HorarioClase SET IdProfesor=@IdProfesor,IdSeemstre=@IdSeemstre,IdMateria=@IdMateria,CicloEscolar=@CicloEscolar,Grupo=@Grupo,Aula=@Aula,HoraEntrada=@HoraEntrada,HoraSalida=@HoraSalida,Dias=@Dias where IdAlumno=@IdAlumno", cn);
           cmd.Parameters.AddWithValue("@IdProfesor", horario.IdProfesor); 
           cmd.Parameters.AddWithValue("@IdAlumno", horario.IdAlumno); 
           cmd.Parameters.AddWithValue("@IdSeemstre", horario.IdSeemstre);
           cmd.Parameters.AddWithValue("@IdMateria", horario.IdMateria);
           cmd.Parameters.AddWithValue("@CicloEscolar", horario.CicloEscolar);
           cmd.Parameters.AddWithValue("@Grupo", horario.Grupo);
           cmd.Parameters.AddWithValue("@Aula", horario.Aula);
           cmd.Parameters.AddWithValue("@HoraEntrada", horario.HoraEntrada);
           cmd.Parameters.AddWithValue("@HoraSalida", horario.HoraSalida);
           cmd.Parameters.AddWithValue("@Dias", horario.Dias);
           cn.Open();
           cmd.ExecuteNonQuery();
           cn.Close();
           modificar = true;
           return modificar;
       }

       public bool ModificarHorarioDocente(Horarios horario)
       {
           bool modificar = false;
           cmd = new SqlCommand("UPDATE HorarioClase SET IdSeemstre=@IdSeemstre,IdMateria=@IdMateria,CicloEscolar=@CicloEscolar,Grupo=@Grupo,Aula=@Aula,HoraEntrada=@HoraEntrada,HoraSalida=@HoraSalida,Dias=@Dias where IdProfesor=@IdProfesor", cn);

           cmd.Parameters.AddWithValue("@IdProfesor", horario.IdAlumno);
           cmd.Parameters.AddWithValue("@IdSeemstre", horario.IdSeemstre);
           cmd.Parameters.AddWithValue("@IdMateria", horario.IdMateria);
           cmd.Parameters.AddWithValue("@CicloEscolar", horario.CicloEscolar);
           cmd.Parameters.AddWithValue("@Grupo", horario.Grupo);
           cmd.Parameters.AddWithValue("@Aula", horario.Aula);
           cmd.Parameters.AddWithValue("@HoraEntrada", horario.HoraEntrada);
           cmd.Parameters.AddWithValue("@HoraSalida", horario.HoraSalida);
           cmd.Parameters.AddWithValue("@Dias", horario.Dias);
           cn.Open();
           cmd.ExecuteNonQuery();
           cn.Close();
           modificar = true;
           return modificar;
       }

       public bool eliminarHorarioDocente(int iddocente, int idmateria)
       {

           bool eliminar = false;
           string eliminarQuery = "Delete from HorarioClase where IdProfesor='" + iddocente + "' and IdMateria='" + idmateria + "'";
           cmd = new SqlCommand(eliminarQuery,cn);
        cn.Open();
           cmd.ExecuteNonQuery();
        cn.Close();
        eliminar = true;
        return eliminar;
       }
       public bool eliminarHorarioAlumno(int idalumno, int idmateria)
       {
           bool eliminar = false;
           string eliminarQuery = "Delete from HorarioClase where IdAlumno='" + idalumno + "' and IdMateria='" + idmateria + "'";
           cmd = new SqlCommand(eliminarQuery,cn);
           cn.Open();
           cmd.ExecuteNonQuery();
           cn.Close();
          eliminar = true;
           return eliminar;

       }
      

    }
}