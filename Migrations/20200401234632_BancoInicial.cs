using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BazarPapelaria10.Migrations
{
    public partial class BancoInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nomecateg = table.Column<string>(nullable: true),
                    Desccateg = table.Column<string>(nullable: true),
                    Obscateg = table.Column<string>(nullable: true),
                    Dtcriacao = table.Column<DateTime>(nullable: false),
                    Dtalteracao = table.Column<DateTime>(nullable: false),
                    Ativo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Prodcategs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Dtcriacao = table.Column<DateTime>(nullable: false),
                    Dtalteracao = table.Column<DateTime>(nullable: false),
                    ProdutoCodProd = table.Column<int>(nullable: false),
                    CategoriaCodCateg = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prodcategs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nomeprod = table.Column<string>(nullable: true),
                    Descprod = table.Column<string>(nullable: true),
                    Valorprod = table.Column<string>(nullable: true),
                    Dtcriacao = table.Column<DateTime>(nullable: false),
                    Dtalteracao = table.Column<DateTime>(nullable: false),
                    Ativo = table.Column<int>(nullable: false),
                    Obsprod = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropTable(
                name: "Prodcategs");

            migrationBuilder.DropTable(
                name: "Produtos");
        }
    }
}
