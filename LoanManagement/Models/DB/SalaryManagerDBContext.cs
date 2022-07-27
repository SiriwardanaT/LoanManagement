using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace LoanManagement.Models.DB
{
    public partial class SalaryManagerDBContext : DbContext
    {
        public SalaryManagerDBContext()
        {
        }

        public SalaryManagerDBContext(DbContextOptions<SalaryManagerDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Expenditure> Expenditure { get; set; }
        public virtual DbSet<Expenditures> Expenditures { get; set; }
        public virtual DbSet<Income> Income { get; set; }
        public virtual DbSet<Incomes> Incomes { get; set; }
        public virtual DbSet<UserInfo> UserInfo { get; set; }
        public virtual DbSet<UserInfoes> UserInfoes { get; set; }
        public virtual DbSet<UserSalary> UserSalary { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Data Source=DESKTOP-PQQMJ6D;Initial Catalog=SalaryManagerDB;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Expenditure>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Reason)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Expenditure)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Expenditu__UserI__30F848ED");
            });

            modelBuilder.Entity<Expenditures>(entity =>
            {
                entity.HasIndex(e => e.UserId)
                    .HasName("IX_FK_Expenditures_UserInfoes");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Reason)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Expenditures)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Expenditures_UserInfoes");
            });

            modelBuilder.Entity<Income>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Income)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Income__UserId__2E1BDC42");
            });

            modelBuilder.Entity<Incomes>(entity =>
            {
                entity.HasIndex(e => e.UserId)
                    .HasName("IX_FK_Incomes_UserInfoes");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Incomes)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Incomes_UserInfoes");
            });

            modelBuilder.Entity<UserInfo>(entity =>
            {
                entity.HasIndex(e => e.FirstName)
                    .HasName("IX_UserInfo");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserInfoes>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserSalary>(entity =>
            {
                entity.ToTable("User_Salary");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_FK__User_Sala__UserI__2B3F6F97");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserSalary)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__User_Sala__UserI__2B3F6F97");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
