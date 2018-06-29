using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace SitioWebCBTA.BD
{
    public class BDUsuarios
    {
        private static SqlCommand cmd;

        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ToString());


        string usuario;

        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public bool autenticarAlumno(string usuario, string contrasennia)
        {
            string validarQuery = "SELECT COUNT(*) FROM Alumnos WHERE UsuarioAlumno = '" + usuario + "' AND ContrasenniaAlumno ='" + contrasennia + "'";
           cmd = new SqlCommand(validarQuery,cn);
           cn.Open();
          
            int count = Convert.ToInt32(cmd.ExecuteScalar()); //devuelve la fila afectada

           if (count == 0)
               return false;
           else
               cn.Close();
               return true;
        }
        public bool autenticarProfesor(string usuario, string contrasennia)
        {

            string validarQuery = "SELECT COUNT(*) FROM Profesores WHERE UsuarioProfesor = '" + usuario + "' AND ContrasenniaProfesor ='" + contrasennia + "'";
            cmd = new SqlCommand(validarQuery, cn);
            cn.Open();
            int count = Convert.ToInt32(cmd.ExecuteScalar()); //devuelve la fila afectada

            if (count == 0)
                return false;
            else
                cn.Close();
            return true;
        }
        public bool autenticarAdmin(string usuario, string contrasennia)
        {
          string validarQuery = "SELECT COUNT(*) FROM Administrador WHERE UsuarioAdmin = '" + usuario + "' AND ContrasenniaAdmin ='" + contrasennia + "'";
            cmd = new SqlCommand(validarQuery,cn);
            cn.Open(); 
            int count = Convert.ToInt32(cmd.ExecuteScalar()); //devuelve la fila afectada

            if (count == 0)
                return false;
            else
              cn.Close();
            return true;
        }


        ////Existe matricula Nueva
        //private Boolean existeMatriculaNueva()
        //{
        //    string strsql = @"SELECT * FROM Usuarios";
        //    Boolean existe = false;
        //    using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["SIACOBConnectionString1"].ToString()))
        //    {
        //        SqlCommand cmdsql = new SqlCommand(strsql, cn);
        //        cn.Open();

        //        SqlDataReader rs = cmdsql.ExecuteReader();
        //        if (rs.Read())
        //        {
        //            existe = true;

        //        }
        //    }
        //    return existe;
        //}
        ////establecer matricula nueva
        //public int EstablecerId()
        //{
        //    if (existeMatriculaNueva())
        //    {
        //        return idmax() + 1;
        //    }
        //    else
        //    {
        //        return 1;
        //    }
        //}


        ////Capturar el máximo ID nueva matricula
        //private int idmax()
        //{
        //    string strsql = @"SELECT MAX(IdUsuarios) FROM Usuarios";
        //    int val = 0;
        //    using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["SIACOBConnectionString1"].ToString()))
        //    {
        //        SqlCommand cmdsql = new SqlCommand(strsql, cn);
        //        cn.Open();

        //        SqlDataReader rs = cmdsql.ExecuteReader();
        //        if (rs.Read())
        //        {
        //            val = int.Parse(rs[0].ToString());

        //        }

        //        return val;
        //    }
        //}


    }
}