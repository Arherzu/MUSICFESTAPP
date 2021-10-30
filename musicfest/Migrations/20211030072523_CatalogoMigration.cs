using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace musicfest.Migrations
{
    public partial class CatalogoMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cantidad",
                table: "t_productos");

            migrationBuilder.RenameColumn(
                name: "Precio",
                table: "t_productos",
                newName: "price");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "t_productos",
                newName: "name");

            migrationBuilder.AddColumn<string>(
                name: "descripcion",
                table: "t_productos",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "duedate",
                table: "t_productos",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "image",
                table: "t_productos",
                type: "text",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "t_proforma",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserID = table.Column<string>(type: "text", nullable: true),
                    ProductoId = table.Column<int>(type: "integer", nullable: true),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    Price = table.Column<decimal>(type: "numeric", nullable: false),
                    Status = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_proforma", x => x.id);
                    table.ForeignKey(
                        name: "FK_t_proforma_t_productos_ProductoId",
                        column: x => x.ProductoId,
                        principalTable: "t_productos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_t_proforma_ProductoId",
                table: "t_proforma",
                column: "ProductoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "t_proforma");

            migrationBuilder.DropColumn(
                name: "descripcion",
                table: "t_productos");

            migrationBuilder.DropColumn(
                name: "duedate",
                table: "t_productos");

            migrationBuilder.DropColumn(
                name: "image",
                table: "t_productos");

            migrationBuilder.RenameColumn(
                name: "price",
                table: "t_productos",
                newName: "Precio");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "t_productos",
                newName: "Nombre");

            migrationBuilder.AddColumn<int>(
                name: "Cantidad",
                table: "t_productos",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
