using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SourcingManager.Migrations
{
    /// <inheritdoc />
    public partial class InicialProveedores : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategoriasProveedor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", maxLength: 80, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriasProveedor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Proveedores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", maxLength: 120, nullable: false),
                    RucONit = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    Telefono = table.Column<string>(type: "TEXT", nullable: true),
                    Direccion = table.Column<string>(type: "TEXT", nullable: true),
                    CategoriaProveedorId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proveedores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Proveedores_CategoriasProveedor_CategoriaProveedorId",
                        column: x => x.CategoriaProveedorId,
                        principalTable: "CategoriasProveedor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CategoriasProveedor",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { 1, "Tecnología" },
                    { 2, "Materia Prima" },
                    { 3, "Logística" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Proveedores_CategoriaProveedorId",
                table: "Proveedores",
                column: "CategoriaProveedorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Proveedores");

            migrationBuilder.DropTable(
                name: "CategoriasProveedor");
        }
    }
}
