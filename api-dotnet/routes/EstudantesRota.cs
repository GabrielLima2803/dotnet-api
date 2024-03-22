using api_dotnet.models.estudantes;
using api_dotnet.services;
using api_dotnet.Data;
using Microsoft.EntityFrameworkCore;

namespace api_dotnet.routes.estudantes
{
    public static class EstudantesRota
    {
        public static void AddRotasEstudantes(this WebApplication app)
        {
            var rotasEstudantes = app.MapGroup("estudantes");

            rotasEstudantes.MapPost("", async (AddEstudantesRequest request, AppDbContext context, CancellationToken ct) =>
            {
                var novoEstudante = new Estudante(request.Nome);
                await context.Estudantes.AddAsync(novoEstudante, ct);
                await context.SaveChangesAsync(ct);
            });

            rotasEstudantes.MapGet("", async (AppDbContext context, CancellationToken ct) => {
                var estudantes = await context.Estudantes
                    .Where(estudante => estudante.IsAtivo)
                    .ToListAsync(ct);
                return estudantes;
            });

            rotasEstudantes.MapPut("/{id}", async (Guid id, UpdateEstudanteRequest request, AppDbContext context, CancellationToken ct) => {
                var estudante = await context.Estudantes.FindAsync(id, ct);

                if (estudante == null)
                {
                    return Results.NotFound();
                }

                estudante.Nome = request.Nome;
                await context.SaveChangesAsync(ct);

                return Results.NoContent();
            });

            rotasEstudantes.MapDelete("/{id}", async (Guid id, AppDbContext context, CancellationToken ct) => {
                var estudante = await context.Estudantes.FindAsync(id, ct);

                if (estudante == null)
                {
                    return Results.NotFound();
                }

                context.Estudantes.Remove(estudante);
                await context.SaveChangesAsync(ct);

                return Results.NoContent();
            });
        }
    }
}
