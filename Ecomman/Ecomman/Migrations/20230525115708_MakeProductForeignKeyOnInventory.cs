using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecomman.Migrations
{
    /// <inheritdoc />
    public partial class MakeProductForeignKeyOnInventory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Inventory_InventoryId",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_InventoryId",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "InventoryId",
                table: "Product");

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "Inventory",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Inventory_ProductId",
                table: "Inventory",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Inventory_Product_ProductId",
                table: "Inventory",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inventory_Product_ProductId",
                table: "Inventory");

            migrationBuilder.DropIndex(
                name: "IX_Inventory_ProductId",
                table: "Inventory");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Inventory");

            migrationBuilder.AddColumn<int>(
                name: "InventoryId",
                table: "Product",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Product_InventoryId",
                table: "Product",
                column: "InventoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Inventory_InventoryId",
                table: "Product",
                column: "InventoryId",
                principalTable: "Inventory",
                principalColumn: "Id");
        }
    }
}
