using System;

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
        }
    }
}
