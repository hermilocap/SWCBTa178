using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.UI.WebControls;

namespace SitioWebCBTA.BD
{
    public class BDMaterias
    {
        private static SqlCommand cmd;
        private static SqlDataReader dr;
        private static Materias AuxMateria;
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ToString());

        public void RegistrarMateria(Materias materia)
        {

            cmd = new SqlCommand("insert into Materias values(@IdMateria,@NombreMateria,@Semestre,@IdProfesor)", cn);
            cmd.Parameters.AddWithValue("@IdMateria", materia.IdMateria);
            cmd.Parameters.AddWithValue("@NombreMateria", materia.NombreMateria);
            cmd.Parameters.AddWithValue("@Semestre", materia.IdSeemstre);
            cmd.Parameters.AddWithValue("@IdProfesor", materia.Idprofesor);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }
     
        private Boolean existeIdDocente()
        {
            string strsql = @"SELECT * FROM Materias";
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
            if (existeIdDocente())
            {
                return idmax() + 1;
            }
            else
            {
                return 1;
            }
        }

        private int idmax()
        {
            string strsql = @"SELECT MAX(IdMateria) FROM Materias";
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

        public bool buscarMateria(string id)
        {
            bool encontrado = false;
            string buscarQuery = "SELECT*FROM Materias WHERE IdMateria='" + id + "'";
            cmd = new SqlCommand(buscarQuery, cn);
            cn.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                AuxMateria = new Materias();
                AuxMateria.IdMateria = int.Parse(dr[0].ToString());
                AuxMateria.NombreMateria = dr[1].ToString();
                AuxMateria.IdSeemstre =dr[2].ToString();
            
                encontrado = true;
            }
            cn.Close();
            return encontrado;
        }

        public  Materias ObtenerMateria()
        {
            return AuxMateria;
        }

        public void modificarMateria(Materias materia)
        {
            string actualizarquery = "UPDATE Materias SET  NombreMateria=@NombreMateria,Semestre=@Semestre,IdProfesor=@IdProfesor where IdMateria=@IdMateria";
            cmd = new SqlCommand(actualizarquery, cn);
            cmd.Parameters.AddWithValue("@IdMateria", materia.IdMateria);
            cmd.Parameters.AddWithValue("@NombreMateria", materia.NombreMateria);
            cmd.Parameters.AddWithValue("@Semestre", materia.IdSeemstre);
            cmd.Parameters.AddWithValue("@IdProfesor", materia.Idprofesor);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();

        }

        public void eliminarMateria(string id)
        {
            string eliminarQuery = "Select * from Materias where IdMateria='" + id + "'";
            cmd = new SqlCommand(eliminarQuery, cn);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public string LeerNombreMateria(int idmateria)
        {
            string strsql = @"SELECT NombreMateria FROM Materias";
            string val = "";
            SqlCommand cmdsql = new SqlCommand(strsql, cn);
            cn.Open();

            SqlDataReader rs = cmdsql.ExecuteReader();
            if (rs.Read())
            {
                val = rs[0].ToString();

            }
            cn.Close();
            return val;
        }

        public int LeerIdMateria(string nombremateria)
        {
            string strsql = @"SELECT IdMateria FROM Materias";
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

    }
}