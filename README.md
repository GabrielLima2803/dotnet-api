# API CRUD de Estudantes com .NET Core

Este repositório contém uma API para realizar operações CRUD (Create, Read, Update, Delete) em estudantes usando .NET Core.

## Como Rodar o Projeto

### Pré-requisitos:

- Certifique-se de ter o .NET Core SDK instalado. Você pode baixá-lo em [dotnet.microsoft.com](https://dotnet.microsoft.com/download).
### Rodando o Projeto:

1. Abra o terminal do seu sistema operacional, é clone o repositório.

    ```
    git clone https://github.com/GabrielLima2803/dotnet-api.git
    ```

2. Entre na pasta raiz do projeto

   ```
   cd api-dotnet
    ```

4. Execute o seguinte comando para restaurar as dependências do projeto:

    ```
    dotnet restore
    ```

5. Após restaurar as dependências, execute o seguinte comando para compilar o projeto:

    ```
    dotnet build
    ```

6. Execute o seguinte comando para criar o banco de dados a partir das migrações do Entity Framework Core:

    ```
    dotnet ef database update
    ```

7. inicie o servidor local e executar o projeto, use o seguinte comando:

    ```
    dotnet run
    ```
8. Por fim, abra o swagger para usar os endpoints da api

    ```
    http://localhost:sua-porta/swagger/index.html
    ```

