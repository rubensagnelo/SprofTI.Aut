# aspnet-core-3-jwt-authentication-api

ASP.NET Core 3.1 - JWT Authentication API

For documentation and instructions check out https://jasonwatmore.com/post/2019/10/11/aspnet-core-3-jwt-authentication-tutorial-with-example-api

Para deploy/execução do Aplicação de geração de token jwt seguir os seguites paços.


* Execução da solução a aprtir de um ambiente para desenvolvimento
- Clonar a solução do GitHub ou extrair o zip recebido.
- Abrir solução no VS Code. Deverá ser aberta na pasta "raiz" onde foi extraida a solução clonada
- Executar a palcação .Net core pressionando F5.


*Executar a Aplicação a pelo prompt de comando
- Clonar a solução do GitHub ou extrair o zip recebido.
- Abrir solução no VS Code. Deverá ser aberta na pasta "raiz" onde foi extraida a solução clonada
- Executar o arquivo buildandRun.bat ou os seguintes comandos a partir da pasta SprofTI.Aut\
dotnet clean
dotnet build
dotnet run
Executar no postman -(verbo Post) http://localhost:5005/Users/Authenticate  para obter o token jwt
Executar no postman -(verbo get) http://localhost:5005/Users/TestAutorize  para realizar um teste de autorização

Obs:O tempo de expiração está valodo para 120 seg no arquivo SprofTI.Aut\Services\UserService.cs


*Geração do deploy
- Executar o arquivo dep.bat no prompt ou os seguintes comandos:
    dotnet clean
    dotnet build
    dotnet publish -c Release -o out



