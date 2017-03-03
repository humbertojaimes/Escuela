using EscuelaLibreria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscuelaConsola
{
    class Program
    {
        static void Main(string[] args)
        {

            var alumnos = generarAlumnos();
            List<Alumno>alumnosAprobados = new List<Alumno>();
            List<Alumno>alumnosNoAprobados = new List<Alumno>();
            foreach (var alumno in alumnos)
            {
                if(alumno.Promedio<6)
                    alumnosNoAprobados.Add(alumno);
                else alumnosAprobados.Add(alumno);

                
            }

            Console.WriteLine($"Hubo {alumnosAprobados.Count} aprobados");

            foreach (var alumno in alumnosAprobados)
              
            {
                Console.WriteLine($"Nombre: {alumno.Nombre} Promedio: {alumno.Promedio}");
            }
            Console.WriteLine($"Hubo {alumnosNoAprobados.Count} no aprobados");
            foreach (var alumno in alumnosNoAprobados)
            {
                Console.WriteLine($"Nombre: {alumno.Nombre} Promedio: {alumno.Promedio}");
            }
                   
            Console.ReadKey();

        }

        private static List<Alumno> generarAlumnos()
        {
            List<Alumno> alumnos = new List<Alumno>();
            for (int i = 0; i < 10; i++)
            {
                Random rnd = new Random(DateTime.Now.Millisecond);
                var materias = new List<Materia>();
                for (int j = 0; j < rnd.Next(1,5); j++)
                {
                    materias.Add(new Materia((Materias)rnd.Next(0,6), rnd.NextDouble() * 10));
                }
                var alumno = new Alumno(i, "Alumno " + i);
                alumno.AsignarMaterias(materias);

                alumnos.Add(alumno);
                Task.Delay(100).Wait();
            }
            return alumnos;
        }

       

    }
}
