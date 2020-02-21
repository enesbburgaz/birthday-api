using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace birthday.Models
{
    public class EfDbContext : DbContext
    {
        public EfDbContext(DbContextOptions<EfDbContext> options):base(options)
        {

        }
        public DbSet<Person> People { get; set; }
    }
}
