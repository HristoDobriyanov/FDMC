using System;
using FDMC.Models;
using Microsoft.EntityFrameworkCore;

namespace FDMC.Data
{
    public class FDMCAppDbContext : DbContext 
    {
        public DbSet<Cat> Cats { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=DESKTOP-R4OGD90\SQLEXPRESS;
                                                            Database=FDMC;
                                                            Integrated Security=True");

                
            }
        }
    }
}
