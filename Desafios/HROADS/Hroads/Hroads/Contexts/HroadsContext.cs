using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Hroads.Domains;

#nullable disable

namespace Hroads.Contexts
{
    public partial class HroadsContext : DbContext
    {
        public HroadsContext()
        {
        }

        public HroadsContext(DbContextOptions<HroadsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Class> Classes { get; set; }
        public virtual DbSet<Habilidade> Habilidades { get; set; }
        public virtual DbSet<Personagen> Personagens { get; set; }
        public virtual DbSet<TipoHabilidade> TipoHabilidades { get; set; }
        public virtual DbSet<TipoUsuario> TipoUsuarios { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public object Class { get; internal set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-LFIP8ID; Initial Catalog= Hroads; Integrated Security=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<Class>(entity =>
            {
                entity.HasKey(e => e.IdClasses)
                    .HasName("PK__Classes__6734F42847B07170");

                entity.Property(e => e.Classes)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdHabilidadesNavigation)
                    .WithMany(p => p.Classes)
                    .HasForeignKey(d => d.IdHabilidades)
                    .HasConstraintName("FK__Classes__IdHabil__30F848ED");
            });

            modelBuilder.Entity<Habilidade>(entity =>
            {
                entity.HasKey(e => e.IdHabilidades)
                    .HasName("PK__Habilida__6E775DBB3D7AEF0E");

                entity.Property(e => e.Habilidades)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdTipoHabilidadesNavigation)
                    .WithMany(p => p.Habilidades)
                    .HasForeignKey(d => d.IdTipoHabilidades)
                    .HasConstraintName("FK__Habilidad__IdTip__2E1BDC42");
            });

            modelBuilder.Entity<Personagen>(entity =>
            {
                entity.HasKey(e => e.IdPersonagens)
                    .HasName("PK__Personag__D9AFE9CFBF8F6548");

                entity.Property(e => e.CapacidadeMaxMana)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CapacidadeMaxVida)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DataDeAtt)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DataDeCriacao)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdClassesNavigation)
                    .WithMany(p => p.Personagens)
                    .HasForeignKey(d => d.IdClasses)
                    .HasConstraintName("FK__Personage__IdCla__33D4B598");
            });

            modelBuilder.Entity<TipoHabilidade>(entity =>
            {
                entity.HasKey(e => e.IdTipoHabilidades)
                    .HasName("PK__TipoHabi__0DEA1B4F5F10B48C");

                entity.Property(e => e.TipoHabilidades)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoUsuario>(entity =>
            {
                entity.HasKey(e => e.IdTipoUsuarios)
                    .HasName("PK__TipoUsua__59371116C87E5B5D");

                entity.HasIndex(e => e.TipoUsuarios, "UQ__TipoUsua__60205D379CF03376")
                    .IsUnique();

                entity.Property(e => e.TipoUsuarios)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuarios)
                    .HasName("PK__Usuarios__EAEBAC8FB3C8A5F9");

                entity.HasIndex(e => e.Nome, "UQ__Usuarios__7D8FE3B2461C7F8E")
                    .IsUnique();

                entity.HasIndex(e => e.Email, "UQ__Usuarios__A9D10534B47E1BB2")
                    .IsUnique();

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Senha)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdTipoUsuariosNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.IdTipoUsuarios)
                    .HasConstraintName("FK__Usuarios__IdTipo__29572725");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
