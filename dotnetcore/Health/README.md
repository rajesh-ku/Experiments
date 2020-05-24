**DotNet Core - Starter Application**

Step by step guide - Example taken from => https://www.youtube.com/watch?v=EXIzgR-JSwg


-- Dotnet Core Commands

dotnet new webapi
dotnet watch run

-- Install Visual Studio Code
code .

-- INSTALL 
dotnet tool install --global dotnet-ef
dotnet tool install -g dotnet-aspnet-codegenerator

-- Install the following libraries
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Tools
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design

dotnet aspnet-codegenerator controller -name ValuesController -async -api --readWriteActions -outDir Controllers

-- Install SQL Server docker container 
docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=SqlExpress!" -e "MSSQL_PID=Express" -p "1444:1433" -d mcr.microsoft.com/mssql/server:2017-latest-ubuntu 

docker ps

-- Add Connection String in appsettings.json
"Server=tcp:127.0.0.1,1444;Database=HealthAPI;UID=sa;PWD=SqlExpress!"


-- After Models and Data is created .. create the Migration 
dotnet ef migrations add InitialCheckin -o Data/Migrations

-- THis command creates the database and all the artifacts
dotnet-ef database update 

- Scafforld controller for patient
dotnet aspnet-codegenerator controller -name PatientsController -m Patient -dc HealthContext -async -api --readWriteActions -outDir Controllers

-- Create the CORS Client
dotnet new web

-- To test 
dotnet watch run

-- Modify the launch JSON file to point to port 6000 and 6001 

-- Create a Solution file
dotnet new sln

-- Add project to solution
dotnet sln add 

-- Add both prohjects to the solution file
dotnet sln add HealthAPI/HealthAPI.csproj 
dotnet sln add CorsClient/CorsClient.csproj


- To serve Static Files / add to the startup file
app.UseStaticFiles();


-- Add lib manager 
dotnet tool install -g Microsoft.Web.LibraryManager.Cli 


-- Add JQuery
libman install jquery --provider cdnjs --destination wwwroot/scripts/jquery -files=jquery.min.js 


- Start both the servers (API as well as Client)
- Run the ClientWeb application
- Cross Origin Resource Sharing - Blocked



