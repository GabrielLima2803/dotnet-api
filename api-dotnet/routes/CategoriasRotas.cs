using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api_dotnet.Data;
using api_dotnet.models;
using api_dotnet.services;
using Microsoft.EntityFrameworkCore;

namespace api_dotnet.routes
{
    public static class CategoriasRota
    {
        public static void AddCategoria(this WebApplication app)
        {
            var rotasCategoria = app.MapGroup("categorias");

            rotasCategoria.MapGet("", async (AppDbContext context, CancellationToken ct) =>
            {
                var categorias = await context.Categorias.ToListAsync(ct);
                return categorias;
            });

            rotasCategoria.MapPost("", async (AppDbContext context, CancellationToken ct, AddCategoriaRequest request) =>
            {
                var newCategoria = new Categoria(request.Nome);

                await context.Categorias.AddAsync(newCategoria, ct);
                await context.SaveChangesAsync(ct);
                return newCategoria;

            });
            rotasCategoria.MapPut("/{id}", async (AppDbContext context, int id, AddCategoriaRequest request, CancellationToken ct) =>
            {
                var categoria = await context.Categorias.FindAsync(id, ct);

                if (categoria == null)
                {
                    return Results.NotFound();
                }

                categoria.Nome = request.Nome;
                await context.SaveChangesAsync(ct);

                return Results.NoContent();
            });
            rotasCategoria.MapDelete("/{id}", async (AppDbContext context, int id, CancellationToken ct) =>
              {
                  var categoria = await context.Categorias.FindAsync(id);

                  if (categoria == null)
                  {
                      return Results.NotFound();
                  }

                  context.Categorias.Remove(categoria);
                  await context.SaveChangesAsync(ct);

                  return Results.NoContent();
              });


        }

    }
}
