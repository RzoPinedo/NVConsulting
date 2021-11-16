using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NVConsultingApi.VIewModel
{
    public class VMAlumno
    {
        public VMAlumno()
        {
            /*AlumnoCursos = new HashSet<AlumnoCurso>();
            Pagos = new HashSet<Pago>();
            Usuarios = new HashSet<Usuario>();*/
        }

        public int IdAlumno { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Dni { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }

       /* public virtual ICollection<AlumnoCurso> AlumnoCursos { get; set; }
        public virtual ICollection<Pago> Pagos { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }*/
    }
}
