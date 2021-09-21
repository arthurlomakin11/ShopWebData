using Microsoft.EntityFrameworkCore.Migrations;

namespace ShopWebData.Migrations
{
    public partial class Migration_67 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsAvailable",
                schema: "dbo",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAvailable",
                schema: "dbo",
                table: "Products");
        }
    }
}
