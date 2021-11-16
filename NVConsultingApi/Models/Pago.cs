using System;
using System.Collections.Generic;

#nullable disable

namespace NVConsultingApi.Models
{
    public partial class Pago
    {
        public int IdPago { get; set; }
        public string FormaPago { get; set; }
        public string EntidadFinanciera { get; set; }
        public DateTime? FechaHora { get; set; }
        public string Estado { get; set; }
        public string Observacion { get; set; }
        public int? IdCursos { get; set; }
        public int? IdAlumno { get; set; }

        public virtual Alumno IdAlumnoNavigation { get; set; }
        public virtual Curso IdCursosNavigation { get; set; }
    }
}
