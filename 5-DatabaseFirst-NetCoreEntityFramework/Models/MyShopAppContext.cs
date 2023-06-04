using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace _5_DatabaseFirst_NetCoreEntityFramework.Models;

public partial class MyShopAppContext : DbContext
{
    public MyShopAppContext()
    {
    }

    public MyShopAppContext(DbContextOptions<MyShopAppContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=MyShopApp;Trusted_Connection=True");
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>(entity =>
        {
            entity.Property(e => e.Description).HasDefaultValueSql("(N'')");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Employee__3214EC071190BB12");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.Property(e => e.IsContinued).HasDefaultValueSql("(CONVERT([bit],(0)))");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
