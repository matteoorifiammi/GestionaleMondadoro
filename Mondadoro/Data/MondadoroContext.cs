#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Mondadoro.Models;

namespace Mondadoro.Data
{
    public class MondadoroContext : DbContext
    {
        public MondadoroContext (DbContextOptions<MondadoroContext> options)
            : base(options)
        {
        }

        public DbSet<Mondadoro.Models.Storage> Storage { get; set; }
    }
}
