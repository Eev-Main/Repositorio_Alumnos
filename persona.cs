using System;

namespace Repositorio_Alumnos
{
    class Persona
    {
        //caracteristicas de la persona
        public string nombre;
        public string apellido;

        //Propetyy
        // - public
        // - en C#, comienza con mayuscula
        // - tiene get y/o set
        public string NombreCompleto
        {
            get => this.nombre + " " + this.apellido;
        }

        private string colorFavorito;
        
        public string ColorFavorito
        {
            get => "color " + this.colorFavorito;
            //valce esta disponible dentro del set
            //quiere decir el valor que se va 
            //a asignar
            set => this.colorFavorito = value;
        }

        //definiendo a la persona
        public Persona(string nombre, string apellido)
        {
         this.nombre = nombre;
         this.apellido = apellido;
        }
        
        //accion
        public virtual void presentarse()
        {
            Console.WriteLine("Mucho gusto, me llamo " + this.nombre + " " + this.apellido);
            //Console.WriteLine($"Hola, mi nombre es {this.nombre} {this.apellido}");
            //Console.WriteLine($"Hola, mi nombre es {0} {1}", this.nombre, this apellido);
        }
    }
}