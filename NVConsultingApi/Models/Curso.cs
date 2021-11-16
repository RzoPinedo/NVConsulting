using System;
using System.Collections.Generic;

#nullable disable

namespace NVConsultingApi.Models
{
    public partial class Curso
    {
        public Curso()
        {
            AlumnoCursos = new HashSet<AlumnoCurso>();
            Pagos = new HashSet<Pago>();
        }

        public int IdCursos { get; set; }
        public string Nombre { get; set; }
        public int? NroHoras { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public decimal? PrecioCurso { get; set; }
        public int? IdEmpleados { get; set; }

        public virtual Empleado IdEmpleadosNavigation { get; set; }
        public virtual ICollection<AlumnoCurso> AlumnoCursos { get; set; }
        public virtual ICollection<Pago> Pagos { get; set; }
    }
}
