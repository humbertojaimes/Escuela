using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscuelaLibreria
{
    public enum Materias
    {
        Español,
        Matematicas,
        Ciencias,
        Fisica,
        Ingles,
        Programacion
    }
    public class Alumno
    {
        private int matricula;

        public int Matricula
        {
            get { return matricula; }
        }

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string nivelAcademico;

        public string NivelAcademico
        {
            get { return nivelAcademico; }
            set { nivelAcademico = value; }
        }

        private double promedio;

        public double Promedio
        {
            get { return promedio; }
        }

        private List<Materia> materias;

        public List<Materia> Materias
        {
            get { return materias; }
        }

        public Alumno(int matricula, string nombre)
        {
            this.matricula = matricula;
            this.nombre = nombre;
            this.materias = new List<Materia>();
        }

        public bool AsignarMaterias(List<Materia> materias)
        {
            if (materias != null & materias.Count() >= 2 && materias.Count() <= 4)
            {
                this.materias = materias;
                PromedioAlumno();
                return true;
            }
            return false;

        }

        private void PromedioAlumno()
        {
            double suma = 0;
            for (int i = 0; i < materias.Count; i++)
            {
                suma += materias.ElementAt(i).Calificacion;
            }
            promedio = suma / materias.Count;
            
        }
        

    }

    public class Materia
    {
        private Materias nombre;

        public Materias Nombre
        {
            get { return nombre; }
        
        }
        private double calificacion; 

        public double Calificacion
        {
            get { return calificacion; }
           
        }

        public Materia(Materias materia,double calificacion)
        {
            this.nombre = materia;
            this.calificacion = calificacion;
        }

    }
}
