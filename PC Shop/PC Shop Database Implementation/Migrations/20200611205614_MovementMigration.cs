using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PC_Shop_Database_Implementation.Migrations
{
    public partial class MovementMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CompletionDate",
                table: "Requests",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ComponentMovements",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Count = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    SupplierID = table.Column<int>(nullable: false),
                    ComponentID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComponentMovements", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ComponentMovements_Components_ComponentID",
                        column: x => x.ComponentID,
                        principalTable: "Components",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ComponentMovements_Suppliers_SupplierID",
                        column: x => x.SupplierID,
                        principalTable: "Suppliers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ComponentMovements_ComponentID",
                table: "ComponentMovements",
                column: "ComponentID");

            migrationBuilder.CreateIndex(
                name: "IX_ComponentMovements_SupplierID",
                table: "ComponentMovements",
                column: "SupplierID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ComponentMovements");

            migrationBuilder.DropColumn(
                name: "CompletionDate",
                table: "Requests");
        }
    }
}
