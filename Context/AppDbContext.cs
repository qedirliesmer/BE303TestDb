using BE303TestDb.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE303TestDb.Context;

public class AppDbContext:DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
            .UseSqlServer("Server=DESKTOP-6IFI2CF\\SQLEXPRESS;Database=BE303TestDb;Trusted_Connection=True;TrustServerCertificate=True;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Student>()
            .HasOne(s => s.StudentDetail)
            .WithOne(sd => sd.Student)
            .HasForeignKey<Student>(s => s.StudentDetailId);

        modelBuilder.Entity<Payment>()
            .HasOne(p => p.Student)
            .WithMany(s => s.Payments)
            .HasForeignKey(p => p.StudentId);

        modelBuilder.Entity<Student>()
            .HasMany(s => s.Groups)
            .WithMany(g => g.Students);

    }

    public DbSet<Student> Students { get; set; } = null!;
    public DbSet<StudentDetail> StudentDetails { get; set; } = null!;
    public DbSet<Payment> Payments { get; set; } = null!;
    public DbSet<Group> Groups { get; set; } = null!;


}

