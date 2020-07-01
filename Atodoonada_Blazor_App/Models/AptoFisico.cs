using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;

namespace Atodoonada_Blazor_App.Data
{
    public class AptoFisico
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "La fecha de emision del apto fisico es requerida")]
        public DateTime FechaEmision { get; set; }

        public bool PuedeParticipar { get; set; }

    }
}
