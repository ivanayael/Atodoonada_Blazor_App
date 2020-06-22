using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Atodoonada_Blazor_App.Data
{
    public class ConcursanteInfo
    {
        [Key]
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "nombre")]
        public string nombre { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "apellido")]
        public string apellido { get; set; }

        [Required]
        [Display(Name = "edad")]
        [Range(18, 60, ErrorMessage = "La edad no puede ser superior a 60 años")]
        public int edad { get; set; }

        [Required]
        [StringLength(20)]
        [Display(Name = "concurso")]
        public string concurso { get; set; }

    }
}
