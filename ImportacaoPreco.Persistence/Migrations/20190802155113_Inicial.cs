using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ImportacaoPreco.Persistence.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Grupos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grupos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Precos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    ValorBase = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Precos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PrecoPromocional",
                columns: table => new
                {
                    Valor = table.Column<decimal>(nullable: false),
                    DataInicioPromocao = table.Column<DateTime>(nullable: false),
                    DataFimPromocao = table.Column<DateTime>(nullable: false),
                    PrecoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrecoPromocional", x => new { x.Valor, x.DataInicioPromocao, x.DataFimPromocao });
                    table.ForeignKey(
                        name: "FK_PrecoPromocional_Precos_PrecoId",
                        column: x => x.PrecoId,
                        principalTable: "Precos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    PrecoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Produtos_Precos_PrecoId",
                        column: x => x.PrecoId,
                        principalTable: "Precos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cor",
                columns: table => new
                {
                    Nome = table.Column<string>(nullable: false),
                    ProdutoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cor", x => x.Nome);
                    table.ForeignKey(
                        name: "FK_Cor_Produtos_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produtos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Subgrupo",
                columns: table => new
                {
                    ProdutoId = table.Column<int>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    GrupoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subgrupo", x => x.ProdutoId);
                    table.ForeignKey(
                        name: "FK_Subgrupo_Grupos_GrupoId",
                        column: x => x.GrupoId,
                        principalTable: "Grupos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Subgrupo_Produtos_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produtos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tamanho",
                columns: table => new
                {
                    Nome = table.Column<string>(nullable: false),
                    ProdutoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tamanho", x => x.Nome);
                    table.ForeignKey(
                        name: "FK_Tamanho_Produtos_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produtos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cor_ProdutoId",
                table: "Cor",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_PrecoPromocional_PrecoId",
                table: "PrecoPromocional",
                column: "PrecoId");

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_PrecoId",
                table: "Produtos",
                column: "PrecoId");

            migrationBuilder.CreateIndex(
                name: "IX_Subgrupo_GrupoId",
                table: "Subgrupo",
                column: "GrupoId");

            migrationBuilder.CreateIndex(
                name: "IX_Tamanho_ProdutoId",
                table: "Tamanho",
                column: "ProdutoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cor");

            migrationBuilder.DropTable(
                name: "PrecoPromocional");

            migrationBuilder.DropTable(
                name: "Subgrupo");

            migrationBuilder.DropTable(
                name: "Tamanho");

            migrationBuilder.DropTable(
                name: "Grupos");

            migrationBuilder.DropTable(
                name: "Produtos");

            migrationBuilder.DropTable(
                name: "Precos");
        }
    }
}
