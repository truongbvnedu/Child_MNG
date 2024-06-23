using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Child_mg.Models;

public partial class ChildDbContext : DbContext
{
    public ChildDbContext()
    {
    }

    public ChildDbContext(DbContextOptions<ChildDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Child> Children { get; set; }

    public virtual DbSet<Class> Classes { get; set; }

    public virtual DbSet<Schedule> Schedules { get; set; }

    public virtual DbSet<ScheduleInfo> ScheduleInfos { get; set; }

    public virtual DbSet<Subject> Subjects { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=MSI\\MAYAO;Database=Child_DB;Integrated Security=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Child>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Child__3214EC274711B9C9");

            entity.ToTable("Child");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .HasColumnName("gender");
            entity.Property(e => e.IdClass).HasColumnName("id_class");
            entity.Property(e => e.IdUsers).HasColumnName("id_users");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Status).HasColumnName("status");

            entity.HasOne(d => d.IdClassNavigation).WithMany(p => p.Children)
                .HasForeignKey(d => d.IdClass)
                .HasConstraintName("Fk_ch_cl");

            entity.HasOne(d => d.IdUsersNavigation).WithMany(p => p.Children)
                .HasForeignKey(d => d.IdUsers)
                .HasConstraintName("Fk_ch_us");
            entity.Property(e => e.Comment).HasMaxLength(500);
            entity.Property(e => e.Comment).HasColumnName("Comment");
            entity.Property(e => e.Image).HasMaxLength(500);
            entity.Property(e => e.Image).HasColumnName("image");
        });

        modelBuilder.Entity<Class>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__class__3214EC27FB36ABDF");

            entity.ToTable("class");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IdUser).HasColumnName("id_user");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Status).HasColumnName("status");

            entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.Classes)
                .HasForeignKey(d => d.IdUser)
                .HasConstraintName("Fk_cl_us");
        });

        modelBuilder.Entity<Schedule>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__schedule__3214EC277A9423E3");

            entity.ToTable("schedule");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.IdClass).HasColumnName("id_class");
            entity.Property(e => e.Status).HasColumnName("status");

            entity.HasOne(d => d.IdClassNavigation).WithMany(p => p.Schedules)
                .HasForeignKey(d => d.IdClass)
                .HasConstraintName("Fk_sc_cl");
        });

        modelBuilder.Entity<ScheduleInfo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__schedule__3214EC27023AABED");

            entity.ToTable("schedule_info");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IdSchedule).HasColumnName("id_schedule");
            entity.Property(e => e.IdSubject).HasColumnName("id_subject");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Status).HasColumnName("status");

            entity.HasOne(d => d.IdScheduleNavigation).WithMany(p => p.ScheduleInfos)
                .HasForeignKey(d => d.IdSchedule)
                .HasConstraintName("Fk_scin_sc");

            entity.HasOne(d => d.IdSubjectNavigation).WithMany(p => p.ScheduleInfos)
                .HasForeignKey(d => d.IdSubject)
                .HasConstraintName("FK_scin_su");
        });

        modelBuilder.Entity<Subject>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__subject__3214EC27BB4483DA");

            entity.ToTable("subject");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Status).HasColumnName("status");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Users__3214EC275EB0192A");

            entity.HasIndex(e => e.Account, "UQ__Users__B0C3AC4673A1329F").IsUnique();
            entity.HasIndex(e => e.Phone).IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Account).HasMaxLength(50);
            entity.Property(e => e.Address).HasColumnName("address");
            entity.Property(e => e.Email).HasColumnName("email");
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .HasColumnName("gender");
            entity.Property(e => e.IdentityId).HasMaxLength(20);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Password).HasMaxLength(500);
            entity.Property(e => e.Phone).HasMaxLength(16);
            entity.Property(e => e.Role).HasColumnName("role");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Image).HasMaxLength(500);
            entity.Property(e => e.Image).HasColumnName("image");

        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
