using Microsoft.EntityFrameworkCore.Migrations;

namespace PC_Shop_Database_Implementation.Migrations
{
    public partial class DBUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsReserved",
                table: "RequestComponents",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsReserved",
                table: "RequestComponents");
        }
    }
}
