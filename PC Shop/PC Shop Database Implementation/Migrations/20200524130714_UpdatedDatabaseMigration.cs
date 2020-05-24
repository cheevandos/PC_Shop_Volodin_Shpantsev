using Microsoft.EntityFrameworkCore.Migrations;

namespace PC_Shop_Database_Implementation.Migrations
{
    public partial class UpdatedDatabaseMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Warehouses_Suppliers_WarehouseID",
                table: "Warehouses");

            migrationBuilder.DropIndex(
                name: "IX_Warehouses_WarehouseID",
                table: "Warehouses");

            migrationBuilder.DropColumn(
                name: "WarehouseID",
                table: "Warehouses");

            migrationBuilder.DropColumn(
                name: "WarehouseID",
                table: "Suppliers");

            migrationBuilder.AddColumn<int>(
                name: "SupplierID",
                table: "Warehouses",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Warehouses_SupplierID",
                table: "Warehouses",
                column: "SupplierID");

            migrationBuilder.AddForeignKey(
                name: "FK_Warehouses_Suppliers_SupplierID",
                table: "Warehouses",
                column: "SupplierID",
                principalTable: "Suppliers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Warehouses_Suppliers_SupplierID",
                table: "Warehouses");

            migrationBuilder.DropIndex(
                name: "IX_Warehouses_SupplierID",
                table: "Warehouses");

            migrationBuilder.DropColumn(
                name: "SupplierID",
                table: "Warehouses");

            migrationBuilder.AddColumn<int>(
                name: "WarehouseID",
                table: "Warehouses",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WarehouseID",
                table: "Suppliers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Warehouses_WarehouseID",
                table: "Warehouses",
                column: "WarehouseID",
                unique: true,
                filter: "[WarehouseID] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Warehouses_Suppliers_WarehouseID",
                table: "Warehouses",
                column: "WarehouseID",
                principalTable: "Suppliers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
