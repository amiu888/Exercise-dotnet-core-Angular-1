using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

//#nullable disable

namespace SPA.Models
{
    public partial class MoviesContext : DbContext
    {
        public MoviesContext()
        {
        }

        public MoviesContext(DbContextOptions<MoviesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AspectRatio> AspectRatios { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<Production> Productions { get; set; }
        public virtual DbSet<Project> Projects { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var fileName = "./Data/MovieDb.db";
            if (!optionsBuilder.IsConfigured)
            {
#warning  Must use your local SQL express instance name. replace "OTSWITF86VHR2XL\\SQLEXPRESS" to your local instance name
                // optionsBuilder.UseSqlServer("Server=OTSWITF86VHR2XL\\SQLEXPRESS;Database=Movies;Trusted_Connection=True;");
                optionsBuilder.UseSqlite($"Data Source={fileName};");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspectRatio>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Aspect_Ratio");

                entity.Property(e => e.AspectRatioId).HasColumnName("Aspect_Ratio_Id");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Genre>(entity =>
            {
                entity.ToTable("Genre");

                entity.Property(e => e.GenreId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("Genre_Id");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Genre1)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Genre");

                entity.Property(e => e.GenreShortName)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("Genre_Short_Name");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Production>(entity =>
            {
                entity.ToTable("Production");

                entity.Property(e => e.ProductionId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("Production_Id");

                entity.Property(e => e.ActualShootDays)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("Actual_Shoot_days");

                entity.Property(e => e.AspectRatioId).HasColumnName("Aspect_Ratio_Id");

                entity.Property(e => e.CodeTitle)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Code_Title");

                entity.Property(e => e.CompletedDate).HasColumnName("Completed_Date");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description3d)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Description_3D");

                entity.Property(e => e.DevelopmentNumber)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("Development_Number");

                entity.Property(e => e.Format3d).HasColumnName("Format_3D");

                entity.Property(e => e.GenreId).HasColumnName("Genre_Id");

                entity.Property(e => e.Locations)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ProductionNumber)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("Production_Number");

                entity.Property(e => e.ProjectId).HasColumnName("Project_Id");

                entity.Property(e => e.Total)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.Productions)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Production_Genre");
            });

            modelBuilder.Entity<Project>(entity =>
            {
                entity.ToTable("Project");

                entity.Property(e => e.ProjectId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("Project_Id");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DevelopmentNumber)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("Development_Number");



                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ProductionNumber)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("Production_Number");


                entity.Property(e => e.ScriptContractuallyDue)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Script_Contractually_Due");

                entity.Property(e => e.ScriptExpected)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("Script_Expected");

                entity.Property(e => e.SgenNo).HasColumnName("SGEN_No");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
