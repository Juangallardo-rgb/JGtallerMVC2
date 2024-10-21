using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JGtallerMVC.Models;

namespace JGtallerMVC2.Data
{
    public class JGtallerMVCContext : DbContext
    {
        public JGtallerMVCContext (DbContextOptions<JGtallerMVCContext> options)
            : base(options)
        {
        }

        public DbSet<JGtallerMVC.Models.Burger> Burger { get; set; } = default!;
    }
}
