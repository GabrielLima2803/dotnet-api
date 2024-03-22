# API CRUD de Estudantes com .NET Core

Este repositório contém uma API para realizar operações CRUD (Create, Read, Update, Delete) em estudantes usando .NET Core.

## Como Rodar o Projeto

### Pré-requisitos:

- Certifique-se de ter o .NET Core SDK instalado. Você pode baixá-lo em [dotnet.microsoft.com](https://dotnet.microsoft.com/download).
### Rodando o Projeto:

1. Abra o terminal do seu sistema operacional na pasta raiz do projeto.

    ```
    cd dotnet-api
    ```


3. Execute o seguinte comando para restaurar as dependências do projeto:

    ```
    dotnet restore
    ```

4. Após restaurar as dependências, execute o seguinte comando para compilar o projeto:

    ```
    dotnet build
    ```

5. Por fim, para iniciar o servidor local e executar o projeto, use o seguinte comando:

    ```
    dotnet run
    ```

### Criando o Banco de Dados:


1. No terminal, execute o seguinte comando para criar o banco de dados a partir das migrações do Entity Framework Core:

    ```
    dotnet ef database update
    ```

Isso irá criar o banco de dados de acordo com as migrações definidas no projeto.
