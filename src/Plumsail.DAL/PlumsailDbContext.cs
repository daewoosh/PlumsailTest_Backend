using Microsoft.EntityFrameworkCore;
using Plumsail.DAL.Configurations;
using Plumsail.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Plumsail.DAL
{
    public class PlumsailDbContext : DbContext
    {
        public PlumsailDbContext(DbContextOptions<PlumsailDbContext> options) : base(options)
        {
        }

        public DbSet<Notebook> Notebooks { get; set; }

        public DbSet<Vendor> Vendors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new NotebookConfiguration());
            modelBuilder.ApplyConfiguration(new VendorConfiguration());
        }
    }
}
