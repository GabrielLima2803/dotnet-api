using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using api_dotnet.models.estudantes;
using api_dotnet.models;

namespace api_dotnet.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Estudante> Estudantes { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }

protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    modelBuilder.Entity<Produto>()
        .HasOne(p => p.Categoria)   // Um Produto pertence a uma Categoria
        .WithMany(c => c.Produtos)  // Uma Categoria tem muitos Produtos
        .HasForeignKey(p => p.CategoriaId); // Chave estrangeira em Produto
}


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=dev.sqlite");
            optionsBuilder.LogTo(Console.WriteLine);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
