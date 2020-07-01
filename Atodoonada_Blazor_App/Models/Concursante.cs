using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Atodoonada_Blazor_App.Data
{
    public class Concursante
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "El nombre es requerido")]
        [StringLength(50)]
        [Display(Name = "nombre")]
        public string nombre { get; set; }

        [Required(ErrorMessage = "El apellido es requerido")]
        [StringLength(50)]
        [Display(Name = "apellido")]
        public string apellido { get; set; }

        [Required(ErrorMessage = "La edad es requerida")]
        [Display(Name = "edad")]
        public int edad { get; set; }

        [Required(ErrorMessage = "El tipo de concurso es requerido")]
        [StringLength(30)]
        [Display(Name = "concurso")]
        public string concurso { get; set; }
    }
}
