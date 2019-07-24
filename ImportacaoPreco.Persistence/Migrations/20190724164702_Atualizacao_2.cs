using Microsoft.EntityFrameworkCore.Migrations;

namespace ImportacaoPreco.Persistence.Migrations
{
    public partial class Atualizacao_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "Subgrupos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "Produtos",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nome",
                table: "Subgrupos");

            migrationBuilder.DropColumn(
                name: "Nome",
                table: "Produtos");
        }
    }
}
