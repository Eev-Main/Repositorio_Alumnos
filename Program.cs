using System;
using System.Collections.Generic;

namespace Repositorio_Alumnos
{
    class Program
    {
        static void Main(string[] args)
        {
            //creacion del alumno/persona
            Persona alumno1 = new Persona("Jose", "perez");
            
            //realizar accion
            Console.WriteLine(alumno1.NombreCompleto);
            alumno1.presentarse();
            
            //cambiar apellido
            alumno1.apellido = "Mendez";
            Console.WriteLine(alumno1.NombreCompleto);

            //color favorito
            alumno1.ColorFavorito = "Rojo";
            Console.WriteLine(alumno1.ColorFavorito);

            Alumno estudiante1 = new Alumno("jose", "Talamantes", 2758);
            Console.WriteLine("Primer alumno " + estudiante1.NombreCompleto);
            estudiante1.presentarse();

            //materia
            materia programacionI = new materia("Programacion I", 2);
            Console.WriteLine("La materia de " + programacionI.NombreSemestre + "se ve en " + programacionI.semestre);

            materia inteligenciaArtificial = new materia("inteligencia artificial", 7);
            Console.WriteLine("La materia de " + inteligenciaArtificial.NombreSemestre + "se ve en " + inteligenciaArtificial.semestre);

            //lista
            //using System.Collections.Generic; al comienzo para hacer una lista
            //operador diamante <> 
            //<materia> - Requiere Materias
            // requiere inicializacion!
            List<materia> materiasDeInteres = new List<materia>();
            materiasDeInteres.Add(programacionI);
            materiasDeInteres.Add(inteligenciaArtificial);
            materiasDeInteres.Add(new materia("Sistemas Interactivos I", 7));

            //materiasDeInteres[2]
            Console.WriteLine("La materia de " + materiasDeInteres[2].NombreSemestre + "se ve en " + materiasDeInteres[2].semestre);
            Console.WriteLine("me interesan " + materiasDeInteres.Count + "materias");

            for (int i = 0; i < materiasDeInteres.Count; i++)
            {
                Console.WriteLine(materiasDeInteres[i].nombreMateria);
            }
            Console.WriteLine(". . .");
            materiasDeInteres.Remove(programacionI);
            Console.WriteLine(" Ahora me interesan " + materiasDeInteres.Count + " materias");
            Console.WriteLine("primer materia ahora es " + materiasDeInteres[0].nombreMateria);

            //primer acercamiento ; indicar indice a remover
            //materiasDeInteres.RemoveAt(1);

            //segundo acercamiento ; arrepentirnos y "crear" la variable
            //materia sistemasInteractivosI = materiasDeInteres[1];

            //tercer acercamiento; buscar la variable a borrar
            materia materiaABorrar = null;
            for (int i = 0; i < materiasDeInteres.Count; i++)
            {
                if (materiasDeInteres[i].nombreMateria == "Sistemas Interactivos I")
                {
                    //encontramos la materia que buscamos
                    //materiasDeInteres.RemoveAt(i);
                    //materiasDeInteres.Remove(materiasDeInteres[i]);
                    materiaABorrar = materiasDeInteres[i];

                    break;
                }
            }
            //verificar si se encontro o no
            if (materiaABorrar != null)
            {
                materiasDeInteres.Remove(materiaABorrar);
            }


            Console.WriteLine("ahora me interesan "+ materiasDeInteres.Count + " materias");
            Console.WriteLine("primer materia ahora es: "+ materiasDeInteres[0].nombreMateria);
        }
    }
}
