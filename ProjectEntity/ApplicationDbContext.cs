using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEntity
{
    public class ApplicationDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optins) =>
            optins.UseSqlServer(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=ProjectEntityFV2;Integrated Security=True;");
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<StudentMark> StudentMarks { get; set; }
        public DbSet<SubjectLecture> SubjectLectures { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}
