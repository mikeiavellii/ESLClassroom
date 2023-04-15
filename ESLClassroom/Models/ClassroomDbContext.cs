using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ESLClassroom.Models;

public partial class ClassroomDbContext : DbContext
{
    public ClassroomDbContext()
    {
    }

    public ClassroomDbContext(DbContextOptions<ClassroomDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Classroom> Classrooms { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=.\\sqlexpress;Initial Catalog=ClassroomDB; Integrated Security=SSPI;Encrypt=false;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Classroom>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Classroo__3214EC27FE5246FB");

            entity.ToTable("Classroom");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ClassroomToken).HasMaxLength(100);
            entity.Property(e => e.GoogleToken).HasMaxLength(600);
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Student__3214EC279B520365");

            entity.ToTable("Student");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ClassroomToken).HasMaxLength(100);
            entity.Property(e => e.StudentName).HasMaxLength(70);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__User__3214EC2700FC1EF1");

            entity.ToTable("User");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.GoogleName).HasMaxLength(150);
            entity.Property(e => e.GoogleToken).HasMaxLength(600);
            entity.Property(e => e.TeacherId).HasColumnName("TeacherID");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
