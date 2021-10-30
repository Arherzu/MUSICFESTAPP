# MUSICFESTAPP
Tienda en linea de venta de componentes de musica
Karina Pumacayo Marca
---- Migración y creación de Tabla ---
dotnet tool install--global dotnet-aspnet-codegenerator --version 5.0.2
dotnet tool update --global dotnet-ef --version 5.0.9
dotnet tool update --global dotnet-ef --version 5.0.9
dotnet ef migrations add ContactoMigration --context musicfest.Data.ApplicationDbContext -o "D:\GitHup_Repositorios\TrabajoGrupal\MUSICFESTAPP\musicfest\Data\Migrations"
dotnet ef database update
