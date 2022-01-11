using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Student_Project_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Student_Project_API.Data
{
    public class AppDbContext: DbContext {
        public  AppDbContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Specialty> Specialties { get; set; }
        public DbSet<Student> Students { get; set; }

    }
}


