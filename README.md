following this tutorial
https://learn.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/model?view=aspnetcore-7.0&tabs=visual-studio-code

and it worked creating a new ASP.NET 7 from scratch

i did need to run this command before the code generator would work
 
    dotnet add package Microsoft.EntityFrameworkCore.Tools

i originally configured CI here
https://learn.microsoft.com/en-us/azure/app-service/deploy-github-actions?tabs=applevel
note that this did not work with the database component added. homepage rendered but /movies and /restaurants did not

using code deployment to azure (bc it's free). will test out container deployment later

needed to follow this guide to instantiate a webapp with a database
https://learn.microsoft.com/en-us/azure/app-service/tutorial-dotnetcore-sqldb-app