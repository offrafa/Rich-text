using Microsoft.EntityFrameworkCore.Migrations;

namespace Rich_text.Migrations
{
    public partial class remove : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descricacao",
                table: "Textos");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Descricacao",
                table: "Textos",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
