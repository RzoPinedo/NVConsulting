using System;
using System.Collections.Generic;

#nullable disable

namespace NVConsultingApi.Models
{
    public partial class AlumnoCurso
    {
        public int IdAlumnoCursos { get; set; }
        public int? IdCursos { get; set; }
        public int? IdAlumno { get; set; }

        public virtual Alumno IdAlumnoNavigation { get; set; }
        public virtual Curso IdCursosNavigation { get; set; }
    }
}
