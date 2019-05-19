using System;
using System.Collections.Generic;
using System.Text;
using FDMC.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace FDMC.Data
{
    public class FdmcDbContext : IdentityDbContext<FdmcUser>
    {
        //public DbSet<FdmcUser> Users { get; set; }

        public FdmcDbContext(DbContextOptions<FdmcDbContext> options)
            : base(options)
        {
        }
    }
}
