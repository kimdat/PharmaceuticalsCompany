using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PharmaceuticalsCompany.Models.Career;
using PharmaceuticalsCompany.Models;

namespace PharmaceuticalsCompany.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<kimdat> Kimdat { get; set; }
        public DbSet<table> Table { get; set; }
    }
}
