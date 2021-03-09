using System;

namespace Repositorio_Alumnos
{
    //Alumno hereda de persona
    //Alumno extiende la clase Persona
    //persona es la clase base de alumno
    class Alumno : Persona
    {
        public int matricula;
        //todos los alumnos son de la misma escuela(por eso es static)
        static public string escuela = "CRESP";

        // (atributos heredados desde persona)
        public Alumno(string nombre, string apellido, int matricula) : base(nombre,apellido)
        {
            this.matricula = matricula;
        }

        //override -> modificar su funcionamiento
        public override void presentarse()
        {
            Console.WriteLine($"Hola, mi nombre es {this.NombreCompleto} y soy estudiante en {Alumno.escuela} con matricula {this.matricula}");
        }
    }
}