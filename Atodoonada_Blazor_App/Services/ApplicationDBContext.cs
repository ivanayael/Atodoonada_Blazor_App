using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atodoonada_Blazor_App.Data
{
    public class ApplicationDBContext: DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
            :base(options)
        {


        }
        public DbSet<Concursante> Concursantes { get; set;  }
        public DbSet<AptoFisico> AptoFisicos { get; set; }
    }
}
