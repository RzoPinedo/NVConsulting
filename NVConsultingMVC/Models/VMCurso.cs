using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NVConsultingMVC.Models
{
    public class VMCurso
    {
        public VMCurso()
        {
        }

        public int IdCursos { get; set; }
        public string Nombre { get; set; }
        public int? NroHoras { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public decimal? PrecioCurso { get; set; }
        public int? IdEmpleados { get; set; }

      
    }
}
