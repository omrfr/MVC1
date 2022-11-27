using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVC1.Models;

    public class AppDbContext : DbContext
    {
        public AppDbContext (DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<MVC1.Models.Student> Student { get; set; } = default!;
    }
