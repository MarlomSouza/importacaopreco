using Microsoft.EntityFrameworkCore.Migrations;

namespace ImportacaoPreco.Persistence.Migrations
{
    public partial class Produtos_atualizacao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProdutoId",
                table: "Tamanhos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SubgrupoId",
                table: "Produtos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProdutoId",
                table: "Cores",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tamanhos_ProdutoId",
                table: "Tamanhos",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_SubgrupoId",
                table: "Produtos",
                column: "SubgrupoId");

            migrationBuilder.CreateIndex(
                name: "IX_Cores_ProdutoId",
                table: "Cores",
                column: "ProdutoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cores_Produtos_ProdutoId",
                table: "Cores",
                column: "ProdutoId",
                principalTable: "Produtos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Subgrupos_SubgrupoId",
                table: "Produtos",
                column: "SubgrupoId",
                principalTable: "Subgrupos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tamanhos_Produtos_ProdutoId",
                table: "Tamanhos",
                column: "ProdutoId",
                principalTable: "Produtos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cores_Produtos_ProdutoId",
                table: "Cores");

            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Subgrupos_SubgrupoId",
                table: "Produtos");

            migrationBuilder.DropForeignKey(
                name: "FK_Tamanhos_Produtos_ProdutoId",
                table: "Tamanhos");

            migrationBuilder.DropIndex(
                name: "IX_Tamanhos_ProdutoId",
                table: "Tamanhos");

            migrationBuilder.DropIndex(
                name: "IX_Produtos_SubgrupoId",
                table: "Produtos");

            migrationBuilder.DropIndex(
                name: "IX_Cores_ProdutoId",
                table: "Cores");

            migrationBuilder.DropColumn(
                name: "ProdutoId",
                table: "Tamanhos");

            migrationBuilder.DropColumn(
                name: "SubgrupoId",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "ProdutoId",
                table: "Cores");
        }
    }
}
