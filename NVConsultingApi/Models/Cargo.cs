using System;
using System.Collections.Generic;

#nullable disable

namespace NVConsultingApi.Models
{
    public partial class Cargo
    {
        public Cargo()
        {
            Empleados = new HashSet<Empleado>();
        }

        public int IdCargo { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Empleado> Empleados { get; set; }
    }
}
