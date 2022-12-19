using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorApp1.Server.Migrations
{
    public partial class AddPersona : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Personas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "station",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "station",
                table: "Personas");
        }
    }
}
