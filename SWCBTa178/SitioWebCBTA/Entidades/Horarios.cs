using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitioWebCBTA
{
    public class Horarios
    {
        string dias;

        public string Dias
        {
            get { return dias; }
            set { dias = value; }
        }

        int idMateria;

        public int IdMateria
        {
            get { return idMateria; }
            set { idMateria = value; }
        }
        int idHorarioClase;

        public int IdHorarioClase
        {
            get { return idHorarioClase; }
            set { idHorarioClase = value; }
        }
        int idProfesor;

        public int IdProfesor
        {
            get { return idProfesor; }
            set { idProfesor = value; }
        }
        int idAlumno;

        public int IdAlumno
        {
            get { return idAlumno; }
            set { idAlumno = value; }
        }
        string nombreMateria;

        public string NombreMateria
        {
            get { return nombreMateria; }
            set { nombreMateria = value; }
        }

        int idSeemstre;


        public int IdSeemstre
        {
            get { return idSeemstre; }
            set { idSeemstre = value; }
        }

        string cicloEscolar;

        public string CicloEscolar
        {
            get { return cicloEscolar; }
            set { cicloEscolar = value; }
        }
        string grupo;

        public string Grupo
        {
            get { return grupo; }
            set { grupo = value; }
        }
        string aula;

        public string Aula
        {
            get { return aula; }
            set { aula = value; }
        }
        string horaEntrada;

        public string HoraEntrada
        {
            get { return horaEntrada; }
            set { horaEntrada = value; }
        }
        string horaSalida;

        public string HoraSalida
        {
            get { return horaSalida; }
            set { horaSalida = value; }
        }
    }
}