using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace imobiliariaLocacao.Migrations
{
    /// <inheritdoc />
    public partial class CriandoTabelaContatos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Bairro",
                table: "Contato",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Cep",
                table: "Contato",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Cidade",
                table: "Contato",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Endereco",
                table: "Contato",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Estado",
                table: "Contato",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<decimal>(
                name: "ValorAluguel",
                table: "Contato",
                type: "decimal(65,30)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bairro",
                table: "Contato");

            migrationBuilder.DropColumn(
                name: "Cep",
                table: "Contato");

            migrationBuilder.DropColumn(
                name: "Cidade",
                table: "Contato");

            migrationBuilder.DropColumn(
                name: "Endereco",
                table: "Contato");

            migrationBuilder.DropColumn(
                name: "Estado",
                table: "Contato");

            migrationBuilder.DropColumn(
                name: "ValorAluguel",
                table: "Contato");
        }
    }
}
