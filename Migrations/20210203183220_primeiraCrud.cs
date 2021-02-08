using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WEB_agendaLanlink.Migrations
{
    public partial class primeiraCrud : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "enderecos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    numero = table.Column<int>(maxLength: 4, nullable: false),
                    cep = table.Column<int>(maxLength: 8, nullable: false),
                    bairro = table.Column<string>(maxLength: 50, nullable: false),
                    cidade = table.Column<string>(maxLength: 50, nullable: false),
                    estado = table.Column<string>(maxLength: 30, nullable: false),
                    logradouro = table.Column<string>(maxLength: 50, nullable: false),
                    complemento = table.Column<string>(maxLength: 100, nullable: true),
                    tipoEndereco = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_enderecos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tipoEnderecos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tipoEnderecos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "pessoas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nome = table.Column<string>(maxLength: 100, nullable: false),
                    cpf = table.Column<int>(maxLength: 11, nullable: false),
                    telefone = table.Column<int>(maxLength: 10, nullable: false),
                    celular = table.Column<int>(maxLength: 10, nullable: false),
                    email = table.Column<string>(maxLength: 100, nullable: true),
                    site = table.Column<string>(maxLength: 100, nullable: true),
                    tipoContato = table.Column<int>(nullable: false),
                    enderecoId = table.Column<int>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pessoas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_pessoas_enderecos_enderecoId",
                        column: x => x.enderecoId,
                        principalTable: "enderecos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "tipoEnderecos",
                columns: new[] { "Id", "Descricao" },
                values: new object[,]
                {
                    { 1, "apartamento" },
                    { 2, "casa" },
                    { 3, "sitio" },
                    { 4, "galpao" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_pessoas_enderecoId",
                table: "pessoas",
                column: "enderecoId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "pessoas");

            migrationBuilder.DropTable(
                name: "tipoEnderecos");

            migrationBuilder.DropTable(
                name: "enderecos");
        }
    }
}
