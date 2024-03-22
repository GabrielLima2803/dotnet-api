using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using api_dotnet.models.estudantes; 

namespace api_dotnet.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Estudante> Estudantes { get; set; } 

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=dev.sqlite");
            optionsBuilder.LogTo(Console.WriteLine);
            base.OnConfiguring(optionsBuilder); 
        }
    }
}
