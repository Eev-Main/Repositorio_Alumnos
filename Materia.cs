using System;

namespace Repositorio_Alumnos
{
    class materia
    {
        public string nombreMateria;

        public int semestre;

        public string NombreSemestre
        {
            get => TransoformarSemestreATexto() + " semestre"; //ej. "2o. semestre
        }
        private string TransoformarSemestreATexto()
        {
            if (this.semestre == 1)
            {
                return "1er";
            }
            else if (this.semestre == 2)
            {
                return "2do";
            }
            else if (this.semestre == 3)
            {
                return "3er";
            }
            else if (this.semestre == 7)
            {
                return "7mo.";
            }
            else if (this.semestre == 8)
            {
                return "8vo.";
            }
            else
            {
                return "to.";
            }
        }

        // (atributos heredados desde persona)
        public materia(string nombreMateria, int semestre)
        {
            this.nombreMateria = nombreMateria;
            this.semestre = semestre;
        }
    }
}