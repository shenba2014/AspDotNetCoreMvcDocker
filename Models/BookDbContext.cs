using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace AspDotNetCoreMvcDocker.Models
{
    public class BookDbContext : DbContext
    {
        IConfiguration _configuration;

        public BookDbContext(IConfiguration configuration, DbContextOptions<BookDbContext> options) : base(options)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            var envs = Environment.GetEnvironmentVariables();
            var host = envs["DBHOST"] ?? (_configuration["DBHOST"] ?? "localhost");
            var port = envs["DBPORT"] ?? (_configuration["DBPORT"] ?? "3306");
            var password = envs["DBPASSWORD"] ?? (_configuration["DBPASSWORD"] ?? "myscret");
            optionsBuilder.UseMySql($"server={host};userid=root;pwd={password};"
                            + $"port={port};database=books");
        }

        public DbSet<Book> Books { get; set; }
    }
}