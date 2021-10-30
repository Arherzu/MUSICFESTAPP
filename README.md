# MUSICFESTAPP




## parte catalogo
dotnet tool install--global dotnet-aspnet-codegenerator --version 5.0.2

dotnet tool update --global dotnet-ef --version 5.0.9

dotnet ef migrations add CatalogoMigration --context musicfest.Data.ApplicationDbContext -o "C:\Users\AYRTON\Desktop\PROYECTOS\MUSICFESTAPP\MUSICFESTAPP\musicfest\Migrations"

dotnet ef database update

## parte proforma
dotnet ef migrations add ProformaMigration --context musicfest.Data.ApplicationDbContext -o "C:\Users\AYRTON\Desktop\PROYECTOS\MUSICFESTAPP\MUSICFESTAPP\musicfest\Migrations"

## parte pago
dotnet ef migrations add PagoMigration --context musicfest.Data.ApplicationDbContext -o "C:\Users\AYRTON\Desktop\PROYECTOS\MUSICFESTAPP\MUSICFESTAPP\musicfest\Migrations"
## parte pedido
dotnet ef migrations add PedidoMigration --context musicfest.Data.ApplicationDbContext -o "C:\Users\AYRTON\Desktop\PROYECTOS\MUSICFESTAPP\MUSICFESTAPP\musicfest\Migrations"
## parte producto
dotnet aspnet-codegenerator controller -name ProductoController -m Productos -dc musicfest.Data.ApplicationDbContext --elativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries