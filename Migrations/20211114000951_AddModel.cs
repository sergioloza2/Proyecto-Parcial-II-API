using Microsoft.EntityFrameworkCore.Migrations;

namespace proyecto_api_parcial2.Migrations
{
    public partial class AddModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ImagenStr",
                columns: table => new
                {
                    ImagenStrId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImagenBase64 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImagenStr", x => x.ImagenStrId);
                });

            migrationBuilder.CreateTable(
                name: "Usuario_1",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NUsuario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contraseña = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaRegistro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FotoPerfilId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario_1", x => x.UsuarioId);
                });

            migrationBuilder.CreateTable(
                name: "Nota_1",
                columns: table => new
                {
                    NotaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Contenido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaCreado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Categoria = table.Column<int>(type: "int", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nota_1", x => x.NotaId);
                    table.ForeignKey(
                        name: "FK_Nota_1_Usuario_1_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario_1",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Nota_1_UsuarioId",
                table: "Nota_1",
                column: "UsuarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ImagenStr");

            migrationBuilder.DropTable(
                name: "Nota_1");

            migrationBuilder.DropTable(
                name: "Usuario_1");
        }
    }
}
