using System;
using System.Collections.Generic;

#nullable disable

namespace NVConsultingApi.Models
{
    public partial class Rol
    {
        public int IdRol { get; set; }
        public string Nombre { get; set; }
        public string Estado { get; set; }
        public int? IdUsuarios { get; set; }

        public virtual Usuario IdUsuariosNavigation { get; set; }
    }
}
