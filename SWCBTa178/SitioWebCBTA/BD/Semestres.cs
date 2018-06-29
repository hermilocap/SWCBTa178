using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace SitioWebCBTA.BD
{
    public class Semestres
    {
        public void leerSemestre()
        {
         string consultarQuery = String.Format("SELECT*FROM Alumnos");
        SqlCommand cmd = new SqlCommand(consultarQuery, BDConexion.cn);
         BDConexion.cn.Open();
         SqlDataReader dr= cmd.ExecuteReader();
         while (dr.Read())
         {
             int id =int.Parse(dr[0].ToString());
            string nombreSemestre = dr[1].ToString();

         }
         dr.Close();
         BDConexion.cn.Close();
        }
    }
}