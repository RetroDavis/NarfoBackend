using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;


namespace backendAPI.Models
{
    public class NarfoContext : DbContext
    {

        public NarfoContext(DbContextOptions<NarfoContext> options)
            : base(options)
        { }

        public DbSet<Employee> Employees { get; set; }

    }
}
