using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitioWebCBTA
{
    public class Materias
    {
        int idMateria;

        public int IdMateria
        {
            get { return idMateria; }
            set { idMateria = value; }
        }

        string nombreMateria;

        public string NombreMateria
        {
            get { return nombreMateria; }
            set { nombreMateria = value; }
        }

        String idSeemstre;

        public String IdSeemstre
        {
            get { return idSeemstre; }
            set { idSeemstre = value; }
        }
        int idprofesor;

        public int Idprofesor
        {
            get { return idprofesor; }
            set { idprofesor = value; }
        }

    }
}