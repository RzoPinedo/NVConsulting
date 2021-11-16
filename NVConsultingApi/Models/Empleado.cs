using System;
using System.Collections.Generic;

#nullable disable

namespace NVConsultingApi.Models
{
    public partial class Empleado
    {
        public Empleado()
        {
            Cursos = new HashSet<Curso>();
            Usuarios = new HashSet<Usuario>();
        }

        public int IdEmpleados { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Dni { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public int? IdCargo { get; set; }

        public virtual Cargo IdCargoNavigation { get; set; }
        public virtual ICollection<Curso> Cursos { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
