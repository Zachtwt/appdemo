using System.Collections.Generic;

namespace App.api.Modelos
{
    
    public class Profesor
    {
        public int id { get; set; }
        // [required]
        public string nombre { get; set; }
        // [required]
         public Escuela escuela { get; set; }
        // [required]
         public int escuelaId { get; set; }
        // [required]
        public ICollection<Curso> Cursos  { get; set; }
    }
    }

