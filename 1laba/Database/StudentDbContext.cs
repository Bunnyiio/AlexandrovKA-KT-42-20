using _1laba.Database.Configurations;
using _1laba.Models;
using Microsoft.EntityFrameworkCore;

namespace _1laba.Database
{
    public class StudentDbContext : DbContext
    {
        //Добавляем таблицы
        public DbSet<Student> Students { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Course> Courses { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Добавляем конфигурации к таблицам
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.ApplyConfiguration(new GroupConfiguration());
            modelBuilder.ApplyConfiguration(new CourseConfiguration());

        }

        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
        {
        }
    }
}
