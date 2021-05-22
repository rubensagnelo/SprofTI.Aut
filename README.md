# SprofTI.Aut - Aplicação para geração de Token jwt

ASP.NET Core 3.1 - JWT Authentication API

Para deploy/execução do Aplicação de geração de token jwt seguir os seguites paços.

>> Execução da solução a aprtir de um ambiente para desenvolvimento
- Clonar a solução do GitHub ou extrair o zip recebido.
- Abrir solução no VS Code. Deverá ser aberta na pasta "raiz" onde foi extraida a solução clonada
- Executar a aplcação .Net core pressionando F5.

>> Executar a Aplicação a pelo prompt de comando
- Clonar a solução do GitHub ou extrair o zip recebido.
- Abrir solução no VS Code. Deverá ser aberta na pasta "raiz" onde foi extraida a solução clonada
- Executar o arquivo buildandRun.bat ou os seguintes comandos a partir da pasta SprofTI.Aut\
dotnet clean
dotnet build
dotnet run
Executar no postman -(verbo Post) http://localhost:5005/Users/Authenticate  para obter o token jwt
Obs: Autenticar no corpo da requisição com o usuário Username = "maria", Password = "bonita" conforme o json abaixo que deve ser inserido no "body" da requisição em contexto:
{
    "Username": "maria",
    "Password":"bonita"
}

Executar no postman -(verbo get) http://localhost:5005/Users/TestAutorize  para realizar um teste de autorização


Obs:O tempo de expiração está valodo para 120 seg no arquivo SprofTI.Aut\Services\UserService.cs

>> Geração do deploy
- Executar o arquivo dep.bat no prompt ou os seguintes comandos:
    dotnet clean
    dotnet build
    dotnet publish -c Release -o out
    Para executar a aplicação do deploy executar, na pasta SprofTI.Aut\out (ou onde será copiado o conteudo dessa pasta) deve-se executar o seguinte comando no prompt: 
    dotnet SprofTI.Aut




