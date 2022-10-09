using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MaterialStorage.Migrations
{
    public partial class AddAndUpdateProductDatabaseTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BOMs_RawMaterials_RawMaterialId",
                table: "BOMs");

            migrationBuilder.DropForeignKey(
                name: "FK_BOMs_Variants_VariantId",
                table: "BOMs");

            migrationBuilder.DropIndex(
                name: "IX_BOMs_RawMaterialId",
                table: "BOMs");

            migrationBuilder.DropIndex(
                name: "IX_BOMs_VariantId",
                table: "BOMs");

            migrationBuilder.CreateTable(
                name: "VariantStocks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VariantId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VariantStocks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VariantStocks_Variants_VariantId",
                        column: x => x.VariantId,
                        principalTable: "Variants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VariantStocks_VariantId",
                table: "VariantStocks",
                column: "VariantId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VariantStocks");

            migrationBuilder.CreateIndex(
                name: "IX_BOMs_RawMaterialId",
                table: "BOMs",
                column: "RawMaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_BOMs_VariantId",
                table: "BOMs",
                column: "VariantId");

            migrationBuilder.AddForeignKey(
                name: "FK_BOMs_RawMaterials_RawMaterialId",
                table: "BOMs",
                column: "RawMaterialId",
                principalTable: "RawMaterials",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BOMs_Variants_VariantId",
                table: "BOMs",
                column: "VariantId",
                principalTable: "Variants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
