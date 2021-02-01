using System;
using WebApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace WebApp.Context
{
    public class WebAppContext : DbContext
    {
        public IConfiguration Configuration;
        public WebAppContext()
        {
            
        }

        public WebAppContext(IConfiguration _configuration)
        {
            Configuration = _configuration;
        }

        public WebAppContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }
        
        public DbSet<Student> Students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
        }
    }
}