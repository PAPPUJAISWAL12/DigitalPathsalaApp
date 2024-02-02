using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DigitalpathsalaTestapp.Models;

public partial class DisitalPathsalaAppContext : DbContext
{
    public DisitalPathsalaAppContext()
    {
    }

    public DisitalPathsalaAppContext(DbContextOptions<DisitalPathsalaAppContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ProductList> ProductLists { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("name=conn");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ProductList>(entity =>
        {
            entity.HasKey(e => e.Pid).HasName("PK__ProductL__C57755403AD13933");

            entity.ToTable("ProductList");

            entity.Property(e => e.Pid).HasColumnName("PId");
            entity.Property(e => e.Quantity).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Rate).HasColumnType("decimal(12, 2)");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
