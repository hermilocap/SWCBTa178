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
    public class BDProfesores
    {

        private static SqlCommand cmd;
        private static SqlDataReader dr;
        private static Profesores AuxProfesores;
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ToString());
       
        public void RegistrarProfesor(Profesores profesores)
        {

            cmd = new SqlCommand("InsertarProfesor", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdProfesor", profesores.IdProfesor);
            cmd.Parameters.AddWithValue("@UsuarioProfesor", profesores.UsuarioProfesor);
            cmd.Parameters.AddWithValue("@ContrasenniaProfesor", profesores.ContrasenniaProfesor);
            cmd.Parameters.AddWithValue("@NombreProfesor", profesores.NombreProfesor);
            cmd.Parameters.AddWithValue("@ApellidosProfesor", profesores.ApellidosProfesor);
            cmd.Parameters.AddWithValue("@SexoProfesor", profesores.SexoProfesor);
            cmd.Parameters.AddWithValue("@EdadProfesor", profesores.EdadProfesor);
            cmd.Parameters.AddWithValue("@MunicipioProfesor", profesores.MunicipioProfesor);
            cmd.Parameters.AddWithValue("@LocalidadProfesor", profesores.LocalidadProfesor);
            cmd.Parameters.AddWithValue("@DirecccionProfesor", profesores.DirecccionProfesor);
            cmd.Parameters.AddWithValue("@CodigoPostalProfesor",profesores.CodigoPostalProfesor);
            cmd.Parameters.AddWithValue("@EmailProfesor", profesores.EmailProfesor);
            cmd.Parameters.AddWithValue("@FotoProfesor", profesores.FotoProfesor);
            

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        private Boolean existeIdDocente()
        {
            string strsql = @"SELECT * FROM Profesores";
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
            string strsql = @"SELECT MAX(IdProfesor) FROM Profesores";
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

        public List<Profesores> ConsultaGeneralProfesor()
        {
            List<Profesores> listaDocente = new List<Profesores>();
            string consultaQuery = "SELECT*FROM Profesores";
            cmd = new SqlCommand(consultaQuery, BDConexion.cn);
            BDConexion.cn.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                AuxProfesores = new Profesores();
                AuxProfesores.IdProfesor = int.Parse(dr[0].ToString());
                AuxProfesores.ContrasenniaProfesor = dr[1].ToString();
                AuxProfesores.NombreProfesor = dr[2].ToString();
                AuxProfesores.ApellidosProfesor = dr[3].ToString();
                AuxProfesores.SexoProfesor = dr[4].ToString();
                AuxProfesores.EdadProfesor = int.Parse(dr[5].ToString());
                AuxProfesores.MunicipioProfesor = dr[6].ToString();
                AuxProfesores.LocalidadProfesor = dr[7].ToString();
                AuxProfesores.DirecccionProfesor = dr[8].ToString();
                AuxProfesores.CodigoPostalProfesor = dr[9].ToString();
                AuxProfesores.EmailProfesor = dr[10].ToString();
                AuxProfesores.FotoProfesor = dr[11].ToString();

                listaDocente.Add(AuxProfesores);
            }

            BDConexion.cn.Close();
            return listaDocente;
        }

        public bool buscarProfesor(string id)
        {
            bool encontrado = false;
            string buscarQuery = "SELECT*FROM Profesores WHERE IdProfesor='" + id + "'";
            cmd = new SqlCommand(buscarQuery,cn);
            cn.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                AuxProfesores = new Profesores();
                AuxProfesores.IdProfesor = int.Parse(dr[0].ToString());
                AuxProfesores.UsuarioProfesor = dr[1].ToString();
                AuxProfesores.ContrasenniaProfesor = dr[2].ToString();
                AuxProfesores.NombreProfesor = dr[3].ToString();
                AuxProfesores.ApellidosProfesor = dr[4].ToString();
                AuxProfesores.SexoProfesor = dr[5].ToString();
                AuxProfesores.EdadProfesor = int.Parse(dr[6].ToString());
                AuxProfesores.MunicipioProfesor = dr[7].ToString();
                AuxProfesores.LocalidadProfesor = dr[8].ToString();
                AuxProfesores.DirecccionProfesor = dr[9].ToString();
                AuxProfesores.CodigoPostalProfesor = dr[10].ToString();
                AuxProfesores.EmailProfesor = dr[11].ToString();
                AuxProfesores.FotoProfesor = dr[12].ToString();
                encontrado = true;
            }
           cn.Close();
            return encontrado;
        }

        public bool buscarDatosProfesor(string Usuario)
        {
            bool encontrado = false;
            string buscarQuery = "SELECT*FROM Profesores WHERE UsuarioProfesor='" + Usuario + "'";
            cmd = new SqlCommand(buscarQuery, cn);
            cn.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                AuxProfesores = new Profesores();
                AuxProfesores.IdProfesor = int.Parse(dr[0].ToString());
                AuxProfesores.UsuarioProfesor = dr[1].ToString();
                AuxProfesores.ContrasenniaProfesor = dr[2].ToString();
                AuxProfesores.NombreProfesor = dr[3].ToString();
                AuxProfesores.ApellidosProfesor = dr[4].ToString();
                AuxProfesores.SexoProfesor = dr[5].ToString();
                AuxProfesores.EdadProfesor = int.Parse(dr[6].ToString());
                AuxProfesores.MunicipioProfesor = dr[7].ToString();
                AuxProfesores.LocalidadProfesor = dr[8].ToString();
                AuxProfesores.DirecccionProfesor = dr[9].ToString();
                AuxProfesores.CodigoPostalProfesor = dr[10].ToString();
                AuxProfesores.EmailProfesor = dr[11].ToString();
                AuxProfesores.FotoProfesor = dr[12].ToString();
                encontrado = true;
            }
            cn.Close();
            return encontrado;
        }

        public Profesores ObtenerProfesor()
        {
            return AuxProfesores;
        }
        public void modificarProfesor(Profesores profesor)
        {
            string actualizarquery = "UPDATE Alumnos SET UsuarioProfesor=@UsuarioProfesor,ContrasenniaProfesor=@ContrasenniaProfesor,NombreProfesor=@NombreProfesor,ApellidosProfesor=@ApellidosProfesor,SexoProfesor=@SexoProfesor,EdadProfesor=@EdadProfesor,MunicipioProfesor=@MunicipioProfesor,LocalidadProfesor=@LocalidadProfesor,DirecccionProfesor=@DirecccionProfesor,CodigoPostalProfesor=@CodigoPostalProfesor,EmailProfesor=@EmailProfesor,FotoProfesor=@FotoProfesor WHERE IdProfesor=@IdProfesor";
            cmd = new SqlCommand(actualizarquery, cn);
            cmd.Parameters.AddWithValue("@IdProfesor", profesor.IdProfesor);
            cmd.Parameters.AddWithValue("@UsuarioProfesor", profesor.UsuarioProfesor);
            cmd.Parameters.AddWithValue("@ContrasenniaProfesor", profesor.ContrasenniaProfesor);
            cmd.Parameters.AddWithValue("@NombreProfesor", profesor.NombreProfesor);
            cmd.Parameters.AddWithValue("@ApellidosProfesor", profesor.ApellidosProfesor);
            cmd.Parameters.AddWithValue("@SexoProfesor", profesor.SexoProfesor);
            cmd.Parameters.AddWithValue("@EdadProfesor", profesor.EdadProfesor);
            cmd.Parameters.AddWithValue("@MunicipioProfesor", profesor.MunicipioProfesor);
            cmd.Parameters.AddWithValue("@LocalidadProfesor", profesor.LocalidadProfesor);
            cmd.Parameters.AddWithValue("@DirecccionProfesor", profesor.DirecccionProfesor);
            cmd.Parameters.AddWithValue("@CodigoPostalProfesor", profesor.CodigoPostalProfesor);
            cmd.Parameters.AddWithValue("@EmailProfesor", profesor.EmailProfesor);
            cmd.Parameters.AddWithValue("@FotoProfesor", profesor.FotoProfesor);
            

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();

       }
        public void eliminarDocente(string id)
        {

            string eliminarQuery = "Select * from Profesores where IdProfesor='" + id + "'";
            cmd = new SqlCommand(eliminarQuery, cn);
           cn.Open();
            cmd.ExecuteNonQuery();
           cn.Close();
        }

    }
}