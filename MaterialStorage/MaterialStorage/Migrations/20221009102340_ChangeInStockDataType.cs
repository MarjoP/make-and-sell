using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MaterialStorage.Migrations
{
    public partial class ChangeInStockDataType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RawMaterialStocks_RawMaterials_RawMaterialId",
                table: "RawMaterialStocks");

            migrationBuilder.DropForeignKey(
                name: "FK_VariantStocks_Variants_VariantId",
                table: "VariantStocks");

            migrationBuilder.DropIndex(
                name: "IX_VariantStocks_VariantId",
                table: "VariantStocks");

            migrationBuilder.DropIndex(
                name: "IX_RawMaterialStocks_RawMaterialId",
                table: "RawMaterialStocks");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_VariantStocks_VariantId",
                table: "VariantStocks",
                column: "VariantId");

            migrationBuilder.CreateIndex(
                name: "IX_RawMaterialStocks_RawMaterialId",
                table: "RawMaterialStocks",
                column: "RawMaterialId");

            migrationBuilder.AddForeignKey(
                name: "FK_RawMaterialStocks_RawMaterials_RawMaterialId",
                table: "RawMaterialStocks",
                column: "RawMaterialId",
                principalTable: "RawMaterials",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VariantStocks_Variants_VariantId",
                table: "VariantStocks",
                column: "VariantId",
                principalTable: "Variants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
