using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CoffeeShopListLab.Models;

public partial class CoffeeShopContext : DbContext
{
    public CoffeeShopContext()
    {
    }

    public CoffeeShopContext(DbContextOptions<CoffeeShopContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Drink> Drinks { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=.\\sqlexpress;Initial Catalog=CoffeeShop; Integrated Security=SSPI;Encrypt=false;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Drink>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Drinks__3213E83FD2414D38");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Category)
                .HasMaxLength(50)
                .HasColumnName("category");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .HasColumnName("description");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
            entity.Property(e => e.Price).HasColumnName("price");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
