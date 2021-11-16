using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace NVConsultingApi.Models
{
    public partial class DBNVConsultingContext : DbContext
    {
        public DBNVConsultingContext()
        {
        }

        public DBNVConsultingContext(DbContextOptions<DBNVConsultingContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Alumno> Alumnos { get; set; }
        public virtual DbSet<AlumnoCurso> AlumnoCursos { get; set; }
        public virtual DbSet<Cargo> Cargos { get; set; }
        public virtual DbSet<Curso> Cursos { get; set; }
        public virtual DbSet<Empleado> Empleados { get; set; }
        public virtual DbSet<Pago> Pagos { get; set; }
        public virtual DbSet<Rol> Rols { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=DBNVConsulting;Integrated Security=SSPI; User ID=sa;Password=123;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Alumno>(entity =>
            {
                entity.HasKey(e => e.IdAlumno);

                entity.ToTable("ALUMNOS");

                entity.Property(e => e.IdAlumno).HasColumnName("ID_ALUMNO");

                entity.Property(e => e.Apellidos)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("APELLIDOS");

                entity.Property(e => e.Correo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CORREO");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DIRECCION");

                entity.Property(e => e.Dni)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("DNI")
                    .IsFixedLength(true);

                entity.Property(e => e.Nombres)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRES");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("TELEFONO")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<AlumnoCurso>(entity =>
            {
                entity.HasKey(e => e.IdAlumnoCursos);

                entity.ToTable("ALUMNO_CURSOS");

                entity.Property(e => e.IdAlumnoCursos).HasColumnName("ID_ALUMNO_CURSOS");

                entity.Property(e => e.IdAlumno).HasColumnName("ID_ALUMNO");

                entity.Property(e => e.IdCursos).HasColumnName("ID_CURSOS");

                entity.HasOne(d => d.IdAlumnoNavigation)
                    .WithMany(p => p.AlumnoCursos)
                    .HasForeignKey(d => d.IdAlumno)
                    .HasConstraintName("FK_ALUMNO_CURSOS_ALUMNO");

                entity.HasOne(d => d.IdCursosNavigation)
                    .WithMany(p => p.AlumnoCursos)
                    .HasForeignKey(d => d.IdCursos)
                    .HasConstraintName("FK_ALUMNO_CURSOS_CURSO");
            });

            modelBuilder.Entity<Cargo>(entity =>
            {
                entity.HasKey(e => e.IdCargo);

                entity.ToTable("CARGO");

                entity.Property(e => e.IdCargo).HasColumnName("ID_CARGO");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE");
            });

            modelBuilder.Entity<Curso>(entity =>
            {
                entity.HasKey(e => e.IdCursos);

                entity.ToTable("CURSOS");

                entity.Property(e => e.IdCursos).HasColumnName("ID_CURSOS");

                entity.Property(e => e.FechaFin)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_FIN");

                entity.Property(e => e.FechaInicio)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_INICIO");

                entity.Property(e => e.IdEmpleados).HasColumnName("ID_EMPLEADOS");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .HasColumnName("NOMBRE");

                entity.Property(e => e.NroHoras).HasColumnName("NRO_HORAS");

                entity.Property(e => e.PrecioCurso)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("PRECIO_CURSO");

                entity.HasOne(d => d.IdEmpleadosNavigation)
                    .WithMany(p => p.Cursos)
                    .HasForeignKey(d => d.IdEmpleados)
                    .HasConstraintName("FK_CURSOS_EMPLEADOS");
            });

            modelBuilder.Entity<Empleado>(entity =>
            {
                entity.HasKey(e => e.IdEmpleados);

                entity.ToTable("EMPLEADOS");

                entity.Property(e => e.IdEmpleados).HasColumnName("ID_EMPLEADOS");

                entity.Property(e => e.Apellidos)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("APELLIDOS");

                entity.Property(e => e.Correo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CORREO");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DIRECCION");

                entity.Property(e => e.Dni)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("DNI")
                    .IsFixedLength(true);

                entity.Property(e => e.IdCargo).HasColumnName("ID_CARGO");

                entity.Property(e => e.Nombres)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRES");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("TELEFONO")
                    .IsFixedLength(true);

                entity.HasOne(d => d.IdCargoNavigation)
                    .WithMany(p => p.Empleados)
                    .HasForeignKey(d => d.IdCargo)
                    .HasConstraintName("FK_EMPLEADOS_CARGO");
            });

            modelBuilder.Entity<Pago>(entity =>
            {
                entity.HasKey(e => e.IdPago);

                entity.ToTable("PAGO");

                entity.Property(e => e.IdPago).HasColumnName("ID_PAGO");

                entity.Property(e => e.EntidadFinanciera)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ENTIDAD_FINANCIERA");

                entity.Property(e => e.Estado)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ESTADO");

                entity.Property(e => e.FechaHora)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_HORA");

                entity.Property(e => e.FormaPago)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FORMA_PAGO");

                entity.Property(e => e.IdAlumno).HasColumnName("ID_ALUMNO");

                entity.Property(e => e.IdCursos).HasColumnName("ID_CURSOS");

                entity.Property(e => e.Observacion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OBSERVACION");

                entity.HasOne(d => d.IdAlumnoNavigation)
                    .WithMany(p => p.Pagos)
                    .HasForeignKey(d => d.IdAlumno)
                    .HasConstraintName("FK_PAGO_ALUMNO");

                entity.HasOne(d => d.IdCursosNavigation)
                    .WithMany(p => p.Pagos)
                    .HasForeignKey(d => d.IdCursos)
                    .HasConstraintName("FK_PAGO_CURSOS");
            });

            modelBuilder.Entity<Rol>(entity =>
            {
                entity.HasKey(e => e.IdRol);

                entity.ToTable("ROL");

                entity.Property(e => e.IdRol).HasColumnName("ID_ROL");

                entity.Property(e => e.Estado)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ESTADO");

                entity.Property(e => e.IdUsuarios).HasColumnName("ID_USUARIOS");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE");

                entity.HasOne(d => d.IdUsuariosNavigation)
                    .WithMany(p => p.Rols)
                    .HasForeignKey(d => d.IdUsuarios)
                    .HasConstraintName("FK_ROL_USUARIOS");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuarios);

                entity.ToTable("USUARIOS");

                entity.Property(e => e.IdUsuarios).HasColumnName("ID_USUARIOS");

                entity.Property(e => e.IdAlumno).HasColumnName("ID_ALUMNO");

                entity.Property(e => e.IdEmpleados).HasColumnName("ID_EMPLEADOS");

                entity.Property(e => e.Observacion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OBSERVACION");

                entity.HasOne(d => d.IdAlumnoNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.IdAlumno)
                    .HasConstraintName("FK_USUARIOS_ALUMNO");

                entity.HasOne(d => d.IdEmpleadosNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.IdEmpleados)
                    .HasConstraintName("FK_USUARIOS_EMPLEADOS");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
