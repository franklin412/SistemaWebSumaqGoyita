using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebApi.Models
{
    public partial class GoyitaContext : DbContext
    {
        public GoyitaContext()
        {
        }

        public GoyitaContext(DbContextOptions<GoyitaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Categorium> Categoria { get; set; } = null!;
        public virtual DbSet<DetalleCarrito> DetalleCarritos { get; set; } = null!;
        public virtual DbSet<Empresa> Empresas { get; set; } = null!;
        public virtual DbSet<Factura> Facturas { get; set; } = null!;
        public virtual DbSet<Marca> Marcas { get; set; } = null!;
        public virtual DbSet<Pedido> Pedidos { get; set; } = null!;
        public virtual DbSet<Persona> Personas { get; set; } = null!;
        public virtual DbSet<Producto> Productos { get; set; } = null!;
        public virtual DbSet<Reclamo> Reclamos { get; set; } = null!;
        public virtual DbSet<Usuario> Usuarios { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Goyita");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categorium>(entity =>
            {
                entity.HasKey(e => e.IdCategoria)
                    .HasName("PK__Categori__8A3D240C5FCA5696");

                entity.Property(e => e.IdCategoria).HasColumnName("idCategoria");

                entity.Property(e => e.EstadoCategoria).HasColumnName("estadoCategoria");

                entity.Property(e => e.NombreCat)
                    .HasMaxLength(30)
                    .HasColumnName("nombreCat");
            });

            modelBuilder.Entity<DetalleCarrito>(entity =>
            {
                entity.HasKey(e => e.IdDetalleCarro)
                    .HasName("PK__detalleC__B4AC32027F475D9A");

                entity.ToTable("detalleCarrito");

                entity.Property(e => e.IdDetalleCarro).HasColumnName("idDetalleCarro");

                entity.Property(e => e.EstadoCarrito).HasColumnName("estadoCarrito");

                entity.Property(e => e.IdPersona).HasColumnName("idPersona");

                entity.Property(e => e.IdProducto).HasColumnName("idProducto");

                entity.HasOne(d => d.IdPersonaNavigation)
                    .WithMany(p => p.DetalleCarritos)
                    .HasForeignKey(d => d.IdPersona)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__detalleCa__idPer__45F365D3");

                entity.HasOne(d => d.IdPersona1)
                    .WithMany(p => p.DetalleCarritos)
                    .HasForeignKey(d => d.IdPersona)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__detalleCa__idPer__44FF419A");
            });

            modelBuilder.Entity<Empresa>(entity =>
            {
                entity.HasKey(e => e.IdEmpresa)
                    .HasName("PK__Empresa__75D2CED4130E6B67");

                entity.ToTable("Empresa");

                entity.Property(e => e.IdEmpresa).HasColumnName("idEmpresa");

                entity.Property(e => e.Detalle1)
                    .HasMaxLength(50)
                    .HasColumnName("detalle1");

                entity.Property(e => e.Detalle2)
                    .HasMaxLength(50)
                    .HasColumnName("detalle2");

                entity.Property(e => e.Detalle3)
                    .HasMaxLength(50)
                    .HasColumnName("detalle3");

                entity.Property(e => e.NomEmpresa)
                    .HasMaxLength(50)
                    .HasColumnName("nomEmpresa");

                entity.Property(e => e.Ruc).HasColumnName("ruc");
            });

            modelBuilder.Entity<Factura>(entity =>
            {
                entity.HasKey(e => e.IdFactura)
                    .HasName("PK__Factura__3CD5687E216B3B7A");

                entity.ToTable("Factura");

                entity.Property(e => e.IdFactura).HasColumnName("idFactura");

                entity.Property(e => e.IdEmpresa).HasColumnName("idEmpresa");

                entity.Property(e => e.IdPedido).HasColumnName("idPedido");

                entity.HasOne(d => d.IdEmpresaNavigation)
                    .WithMany(p => p.Facturas)
                    .HasForeignKey(d => d.IdEmpresa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Factura__idEmpre__4F7CD00D");

                entity.HasOne(d => d.IdPedidoNavigation)
                    .WithMany(p => p.Facturas)
                    .HasForeignKey(d => d.IdPedido)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Factura__idPedid__4E88ABD4");
            });

            modelBuilder.Entity<Marca>(entity =>
            {
                entity.HasKey(e => e.IdMarca)
                    .HasName("PK__Marca__703318129A8AB950");

                entity.ToTable("Marca");

                entity.Property(e => e.IdMarca).HasColumnName("idMarca");

                entity.Property(e => e.NombreMarca)
                    .HasMaxLength(30)
                    .HasColumnName("nombreMarca");
            });

            modelBuilder.Entity<Pedido>(entity =>
            {
                entity.HasKey(e => e.IdPedido)
                    .HasName("PK__Pedidos__A9F619B7BDFAC5D9");

                entity.Property(e => e.IdPedido).HasColumnName("idPedido");

                entity.Property(e => e.IdDetalleCarro).HasColumnName("idDetalleCarro");

                entity.Property(e => e.RegistroFecha)
                    .HasColumnType("datetime")
                    .HasColumnName("registroFecha");

                entity.HasOne(d => d.IdDetalleCarroNavigation)
                    .WithMany(p => p.Pedidos)
                    .HasForeignKey(d => d.IdDetalleCarro)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Pedidos__idDetal__48CFD27E");
            });

            modelBuilder.Entity<Persona>(entity =>
            {
                entity.HasKey(e => e.IdPersona)
                    .HasName("PK__Personas__A4788141598884CB");

                entity.Property(e => e.IdPersona).HasColumnName("idPersona");

                entity.Property(e => e.AMaterno)
                    .HasMaxLength(50)
                    .HasColumnName("aMaterno");

                entity.Property(e => e.APaterno)
                    .HasMaxLength(50)
                    .HasColumnName("aPaterno");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(50)
                    .HasColumnName("direccion");

                entity.Property(e => e.DocIdentidad)
                    .HasMaxLength(50)
                    .HasColumnName("docIdentidad");

                entity.Property(e => e.Email)
                    .HasMaxLength(200)
                    .HasColumnName("email");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .HasColumnName("nombre");

                entity.Property(e => e.NumeroDoc)
                    .HasMaxLength(50)
                    .HasColumnName("numeroDoc");

                entity.Property(e => e.RazonSocial)
                    .HasMaxLength(150)
                    .HasColumnName("razonSocial");

                entity.Property(e => e.Telefono).HasColumnName("telefono");
            });

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.HasKey(e => e.IdProducto)
                    .HasName("PK__Producto__07F4A13250899614");

                entity.Property(e => e.IdProducto).HasColumnName("idProducto");

                entity.Property(e => e.Base64)
                    .HasMaxLength(500)
                    .HasColumnName("base64");

                entity.Property(e => e.EstadoProducto).HasColumnName("estadoProducto");

                entity.Property(e => e.IdCategoria).HasColumnName("idCategoria");

                entity.Property(e => e.IdMarca).HasColumnName("idMarca");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .HasColumnName("nombre");

                entity.Property(e => e.PrecioCompra).HasColumnName("precioCompra");

                entity.Property(e => e.PrecioVenta).HasColumnName("precioVenta");

                entity.Property(e => e.PrecioXmayor).HasColumnName("precioXMayor");

                entity.Property(e => e.PrecioXmenor).HasColumnName("precioXMenor");

                entity.Property(e => e.Stock).HasColumnName("stock");

                entity.HasOne(d => d.IdCategoriaNavigation)
                    .WithMany(p => p.Productos)
                    .HasForeignKey(d => d.IdCategoria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Productos__idCat__3E52440B");

                entity.HasOne(d => d.IdMarcaNavigation)
                    .WithMany(p => p.Productos)
                    .HasForeignKey(d => d.IdMarca)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Productos__idMar__3F466844");
            });

            modelBuilder.Entity<Reclamo>(entity =>
            {
                entity.HasKey(e => e.IdReclamo)
                    .HasName("PK__Reclamos__5EB0D864C58EF431");

                entity.Property(e => e.IdReclamo).HasColumnName("idReclamo");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(255)
                    .HasColumnName("descripcion");

                entity.Property(e => e.IdPersona).HasColumnName("idPersona");

                entity.Property(e => e.TipoMensaje)
                    .HasMaxLength(50)
                    .HasColumnName("tipoMensaje");

                entity.HasOne(d => d.IdPersonaNavigation)
                    .WithMany(p => p.Reclamos)
                    .HasForeignKey(d => d.IdPersona)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Reclamos__idPers__4222D4EF");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("PK__Usuario__645723A6A88F69F4");

                entity.ToTable("Usuario");

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.Property(e => e.IdPersona).HasColumnName("idPersona");

                entity.Property(e => e.LoginUsuario)
                    .HasMaxLength(30)
                    .HasColumnName("loginUsuario");

                entity.Property(e => e.Password)
                    .HasMaxLength(15)
                    .HasColumnName("password");

                entity.HasOne(d => d.IdPersonaNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.IdPersona)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Usuario__idPerso__4BAC3F29");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
