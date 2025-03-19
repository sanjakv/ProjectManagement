using Microsoft.EntityFrameworkCore;
using ProjectManagement.DataAccessLayer.Entities;

namespace ProjectManagement.DataAccessLayer.Contexts
{
    public class AppDbContext : DbContext

    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
       : base(options)
        {
        }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<ProjectEmployee> ProjectEmployees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Получаем строку подключения из переменной окружения
            var connectionString = Environment.GetEnvironmentVariable("DB_CONNECTION");

            if (!string.IsNullOrEmpty(connectionString))
            {
                optionsBuilder.UseNpgsql(connectionString);
            }
            else
            {
                throw new InvalidOperationException("Строка подключения не найдена в переменных окружения.");
            }
        }

        // Ваши


    }
}
