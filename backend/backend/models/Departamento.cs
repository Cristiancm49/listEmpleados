using System;
using System.Collections.Generic;

namespace backend.Models
{
    public partial class Departamento
    {
        internal object idDepartamentoNavigation;

        public Departamento()
        {
            Empleados = new HashSet<Empleado>();
        }

        public int IdDepartaemtno { get; set; }
        public string? Nombre { get; set; }
        public DateTime? FechaCreacion { get; set; }

        public virtual ICollection<Empleado> Empleados { get; set; }
    }
}
