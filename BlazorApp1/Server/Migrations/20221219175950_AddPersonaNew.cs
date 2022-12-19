using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorApp1.Server.Migrations
{
    public partial class AddPersonaNew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "station",
                table: "Personas");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "station",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
