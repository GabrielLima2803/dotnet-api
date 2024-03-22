using System;

namespace api_dotnet.models.estudantes
{
    public class Estudante 
    {
        public Guid Id { get; init; }
        public string Nome { get;  set; }
        public bool IsAtivo { get; private set; }

        public Estudante(string nome) 
        {
            Nome = nome;
            Id = Guid.NewGuid(); 
            IsAtivo = true;
        }
        public void Desativar(){
            IsAtivo = false;
        }
    }
}
