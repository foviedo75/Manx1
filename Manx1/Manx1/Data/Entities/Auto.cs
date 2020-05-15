using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Manx1.Data.Entities
{
    public class Auto
    {
       
        public Guid AutoID { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [StringLength(7, MinimumLength = 7, ErrorMessage = "La patente tiene que tener 7 caracteres")]
        public string AutoPatente { get; set; }

        [Display(Name = ("Color Auto"))]
        public string AutoColor { get; set; }
        
    }
}
