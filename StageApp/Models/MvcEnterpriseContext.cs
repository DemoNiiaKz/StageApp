using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StageApp.Models
{
    public class MvcEntrepriseContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }

        public MvcEntrepriseContext(DbContextOptions<MvcEntrepriseContext> options)
            : base(options)
        {

        }
    }
}
