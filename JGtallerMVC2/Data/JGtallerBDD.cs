using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JGtallerMVC2.Models;

    public class JGtallerBDD : DbContext
    {
        public JGtallerBDD (DbContextOptions<JGtallerBDD> options)
            : base(options)
        {
        }

        public DbSet<JGtallerMVC2.Models.Burger> Burger { get; set; } = default!;
    }
