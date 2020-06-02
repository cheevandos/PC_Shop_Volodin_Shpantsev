using Microsoft.EntityFrameworkCore.Migrations;

namespace PC_Shop_Database_Implementation.Migrations
{
    public partial class DBUpdated2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsReserved",
                table: "RequestComponents");

            migrationBuilder.AddColumn<bool>(
                name: "InReserve",
                table: "RequestComponents",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InReserve",
                table: "RequestComponents");

            migrationBuilder.AddColumn<bool>(
                name: "IsReserved",
                table: "RequestComponents",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
