
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CRUDLINQPOO
{
    public class Empleados
    {
        [Key]
        public int id { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]

        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public DateTime fecha_ing { get; set; } 

        [ForeignKey("IdArea")]
        public int IdArea { get; set; }
    }
}
