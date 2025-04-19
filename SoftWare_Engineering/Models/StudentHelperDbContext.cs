using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SoftWare_Engineering.Models;

public partial class StudentHelperDbContext : DbContext
{
    public StudentHelperDbContext()
    {
    }

    public StudentHelperDbContext(DbContextOptions<StudentHelperDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Course> Courses { get; set; }

    public virtual DbSet<GetCourse> GetCourses { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost;Database=StudentHelperDB;Trusted_connection=true;MultipleActiveResultSets=true;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Course>(entity =>
        {
            entity.Property(e => e.ExamHour).HasMaxLength(10);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.Property(e => e.FullName).HasColumnName("fullName");
            entity.Property(e => e.UserName).HasColumnName("userName");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
