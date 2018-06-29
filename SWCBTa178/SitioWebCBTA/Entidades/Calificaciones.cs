using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitioWebCBTA
{
    public class Calificaciones
    {

        int idCalificacion;

        public int IdCalificacion
        {
            get { return idCalificacion; }
            set { idCalificacion = value; }
        }
        int idIdHorarioClase;

        public int IdIdHorarioClase
        {
            get { return idIdHorarioClase; }
            set { idIdHorarioClase = value; }
        }
        int calFinal;

        public int CalFinal
        {
            get { return calFinal; }
            set { calFinal = value; }
        }

        int calParcial1;

        public int CalParcial1
        {
            get { return calParcial1; }
            set { calParcial1 = value; }
        }
        int calParcial2;

        public int CalParcial2
        {
            get { return calParcial2; }
            set { calParcial2 = value; }
        }
        int calParcial3;

        public int CalParcial3
        {
            get { return calParcial3; }
            set { calParcial3 = value; }
        }

    }
}