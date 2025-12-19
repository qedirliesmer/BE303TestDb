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

    public DbSet<Student> Students { get; set; } = null!;
}

