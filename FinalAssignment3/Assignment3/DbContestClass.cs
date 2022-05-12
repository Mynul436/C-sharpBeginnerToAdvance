using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class DbContestClass:DbContext
    {
        private string _connectionString;
        private string _assembleName;
        DbSet<Student> Students { get; set; }
        DbSet<Course> Courses { get; set; }
        
        public DbContestClass()
        {
            _connectionString = "Server=DESKTOP-UAD9J96\\SQLEXPRESS;Database=Assignment3;User Id=assignment3;Password=123456;";
            _assembleName = Assembly.GetExecutingAssembly().FullName;
            Console.WriteLine(_assembleName);  
        }
        protected  override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            if (!dbContextOptionsBuilder.IsConfigured)
            {
                dbContextOptionsBuilder.UseSqlServer(_connectionString,
                    m => m.MigrationsAssembly(_assembleName));
            }
            base.OnConfiguring(dbContextOptionsBuilder);     
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Topic>().ToTable("Topics");
        }
    }
}
