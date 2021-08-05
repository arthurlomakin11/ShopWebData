using Microsoft.EntityFrameworkCore.Migrations;

namespace ShopWebData.Migrations
{
    public partial class Migration_64 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsCustom",
                schema: "dbo",
                table: "Categories",
                newName: "IsSmart");

            migrationBuilder.RenameColumn(
                name: "CustomQuery",
                schema: "dbo",
                table: "Categories",
                newName: "SmartQuery");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SmartQuery",
                schema: "dbo",
                table: "Categories",
                newName: "CustomQuery");

            migrationBuilder.RenameColumn(
                name: "IsSmart",
                schema: "dbo",
                table: "Categories",
                newName: "IsCustom");
        }
    }
}
