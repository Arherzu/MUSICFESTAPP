using Microsoft.EntityFrameworkCore.Migrations;

namespace musicfest.Data.Migrations
{
    public partial class t_contactosMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Contacto",
                table: "Contacto");

            migrationBuilder.RenameTable(
                name: "Contacto",
                newName: "t_contactos");

            migrationBuilder.AddPrimaryKey(
                name: "PK_t_contactos",
                table: "t_contactos",
                column: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_t_contactos",
                table: "t_contactos");

            migrationBuilder.RenameTable(
                name: "t_contactos",
                newName: "Contacto");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contacto",
                table: "Contacto",
                column: "id");
        }
    }
}
