using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Plumsail.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Plumsail.DAL.Configurations
{
    internal class NotebookConfiguration : IEntityTypeConfiguration<Notebook>
    {
        public void Configure(EntityTypeBuilder<Notebook> builder)
        {
            builder.ToTable("Notebooks");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(30);

            builder.Property(p => p.Description)
                .IsRequired(false)
                .HasMaxLength(150);

            builder.HasOne(e => e.Vendor)
                .WithMany(e => e.Notebooks)
                .HasForeignKey(e => e.VendorId);
        }
    }
}
