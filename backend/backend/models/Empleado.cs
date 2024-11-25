using System;
using System.Collections.Generic;

namespace backend.Models
{
    public partial class Empleado
    {
        public int IdEmpleado { get; set; }
        public string? NombreCompleto { get; set; }
        public int? IdDepartaemtno { get; set; }
        public int? Sueldo { get; set; }
        public DateTime? FechaContrato { get; set; }
        public DateTime? FechaCreacion { get; set; }

        public virtual Departamento? IdDepartaemtnoNavigation { get; set; }
    }
}
