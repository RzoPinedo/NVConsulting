using System;
using System.Collections.Generic;

#nullable disable

namespace NVConsultingApi.Models
{
    public partial class Usuario
    {
        public Usuario()
        {
            Rols = new HashSet<Rol>();
        }

        public int IdUsuarios { get; set; }
        public string Observacion { get; set; }
        public int? IdEmpleados { get; set; }
        public int? IdAlumno { get; set; }

        public virtual Alumno IdAlumnoNavigation { get; set; }
        public virtual Empleado IdEmpleadosNavigation { get; set; }
        public virtual ICollection<Rol> Rols { get; set; }
    }
}
