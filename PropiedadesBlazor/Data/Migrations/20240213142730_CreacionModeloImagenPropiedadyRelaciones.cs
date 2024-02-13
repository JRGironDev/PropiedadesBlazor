using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PropiedadesBlazor.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreacionModeloImagenPropiedadyRelaciones : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ImagenPropiedad",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PropiedadId = table.Column<int>(type: "INTEGER", nullable: false),
                    UrlImagenPropiedad = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImagenPropiedad", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ImagenPropiedad_Propiedad_PropiedadId",
                        column: x => x.PropiedadId,
                        principalTable: "Propiedad",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ImagenPropiedad_PropiedadId",
                table: "ImagenPropiedad",
                column: "PropiedadId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ImagenPropiedad");
        }
    }
}
