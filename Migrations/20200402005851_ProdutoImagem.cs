using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BazarPapelaria10.Migrations
{
    public partial class ProdutoImagem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Valorprod",
                table: "Produtos",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Imagens",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Caminho = table.Column<string>(nullable: true),
                    ProdutoCodprod = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Imagens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Imagens_Produtos_ProdutoCodprod",
                        column: x => x.ProdutoCodprod,
                        principalTable: "Produtos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Prodcategs_CategoriaCodCateg",
                table: "Prodcategs",
                column: "CategoriaCodCateg");

            migrationBuilder.CreateIndex(
                name: "IX_Prodcategs_ProdutoCodProd",
                table: "Prodcategs",
                column: "ProdutoCodProd");

            migrationBuilder.CreateIndex(
                name: "IX_Imagens_ProdutoCodprod",
                table: "Imagens",
                column: "ProdutoCodprod");

            migrationBuilder.AddForeignKey(
                name: "FK_Prodcategs_Categorias_CategoriaCodCateg",
                table: "Prodcategs",
                column: "CategoriaCodCateg",
                principalTable: "Categorias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Prodcategs_Produtos_ProdutoCodProd",
                table: "Prodcategs",
                column: "ProdutoCodProd",
                principalTable: "Produtos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prodcategs_Categorias_CategoriaCodCateg",
                table: "Prodcategs");

            migrationBuilder.DropForeignKey(
                name: "FK_Prodcategs_Produtos_ProdutoCodProd",
                table: "Prodcategs");

            migrationBuilder.DropTable(
                name: "Imagens");

            migrationBuilder.DropIndex(
                name: "IX_Prodcategs_CategoriaCodCateg",
                table: "Prodcategs");

            migrationBuilder.DropIndex(
                name: "IX_Prodcategs_ProdutoCodProd",
                table: "Prodcategs");

            migrationBuilder.AlterColumn<string>(
                name: "Valorprod",
                table: "Produtos",
                nullable: true,
                oldClrType: typeof(decimal));
        }
    }
}
