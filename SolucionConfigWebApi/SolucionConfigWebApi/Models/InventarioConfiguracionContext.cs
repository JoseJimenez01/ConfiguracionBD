using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SolucionConfigWebApi.Models;

public partial class InventarioConfiguracionContext : DbContext
{
    public InventarioConfiguracionContext()
    {
    }

    public InventarioConfiguracionContext(DbContextOptions<InventarioConfiguracionContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Articulo> Articulos { get; set; }

    public virtual DbSet<EventLog> EventLogs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-NVUTANU\\SQLEXPRESS; Initial Catalog=InventarioConfiguracion;user id= sa ; pwd= 123elSQLs.;Integrated Security=True; TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Articulo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Articulo__3213E83FAB9DCA75");

            entity.ToTable("Articulo");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nombre)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.Precio).HasColumnType("money");
        });

        modelBuilder.Entity<EventLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EventLog__3213E83F0F86B1A2");

            entity.ToTable("EventLog");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.LogDescription)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.PostTime).HasColumnType("datetime");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
