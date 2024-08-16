using assignment_1.entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_1.contexts
{
    internal class itiDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = . ; Database = ITIDataBase ; Trusted_Connection = True ; Encrypt= False");
        }

        DbSet<Student> students {  get; set; }
        DbSet<Instructor> instructors { get; set; }
        DbSet<Department> departments { get; set; }
        DbSet<Course> courses { get; set; }
        DbSet<Topic> topic { get; set; }
        DbSet<CourseIns> coursesIns { get; set; }
        DbSet<StudCourse> studCourse { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CourseIns>(e => e.HasNoKey());
            modelBuilder.Entity<StudCourse>(e => e.HasNoKey());

        }
    }
}
