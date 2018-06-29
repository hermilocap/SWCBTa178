using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitioWebCBTA
{
    public class Administrador
    {

        int idAdministrador;

        public int IdAdministrador
        {
            get { return idAdministrador; }
            set { idAdministrador = value; }
        }
        string nombreAdmin;

        public string NombreAdmin
        {
            get { return nombreAdmin; }
            set { nombreAdmin = value; }
        }
        string apellidos;

        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }
        string contrasennia;

        public string Contrasennia
        {
            get { return contrasennia; }
            set { contrasennia = value; }
        }
        string usuario;

        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
    }
}