using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JGtallerMVC2.Models;

namespace JGtallerMVC2.Data
{
    public class JGtallerMVC2Context : DbContext
    {
        public JGtallerMVC2Context (DbContextOptions<JGtallerMVC2Context> options)
            : base(options)
        {
        }

        public DbSet<JGtallerMVC2.Models.Burger> Burger { get; set; } = default!;
    }
}
