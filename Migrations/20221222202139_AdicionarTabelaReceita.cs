using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace livroreceitas.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarTabelaReceita : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "receitas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descrição = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tipo = table.Column<int>(type: "int", nullable: false),
                    Igredientes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModoDePreparo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LinkYoutube = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_receitas", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "receitas");
        }
    }
}
