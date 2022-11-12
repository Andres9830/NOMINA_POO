using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CRUDLINQPOO
{
    public class Area
    {
        [Key]
        public int id { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]

        public string nombre_area { get; set; }


    }
}
