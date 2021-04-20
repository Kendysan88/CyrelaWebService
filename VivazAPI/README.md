Inicializa o banco de dados (necessário ter o docker e docker-compose instalados):

```console
docker-compose up -d
```

Instala as dependências do projeto:

```console
dotnet restore
```

Executa as migrações e o seed no banco de dados:

```console
dotnet ef database update
```

Inicia o servidor da aplicação:

```console
dotnet run
```
