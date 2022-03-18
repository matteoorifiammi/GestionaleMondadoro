#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using mondadoro_db.Models;

namespace mondadoro_db.Data
{
    public class mondadoro_dbContext : DbContext
    {
        public mondadoro_dbContext (DbContextOptions<mondadoro_dbContext> options)
            : base(options)
        {
        }

        public DbSet<mondadoro_db.Models.Item> Item { get; set; }
    }
}
