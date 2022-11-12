using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CRUDLINQPOO.Entities
{
    class Nomina
    {
        [Key]
        public int id { get;  set; }
        [Required(ErrorMessage = "Campo Requerido")]

        public DateTime fecha { get; set; }
        [ForeignKey("IdEmpleado")]
        public int IdEmpleado { get; set; }

        public double sueldo { get; set; }
        public double dias { get; set; }
        public double total_Basico { get; set; } 
        public double otros { get; set; }
        public double devengado { get; set; }

    }
}
