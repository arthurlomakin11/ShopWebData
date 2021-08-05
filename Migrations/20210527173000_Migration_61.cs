using Microsoft.EntityFrameworkCore.Migrations;

namespace ShopWebData.Migrations
{
    public partial class Migration_61 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MinQuantity",
                schema: "dbo",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "QuantityStep",
                schema: "dbo",
                table: "Products");

            migrationBuilder.AddColumn<decimal>(
                name: "DollarsPrice",
                schema: "dbo",
                table: "Products",
                type: "decimal(7,4)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "DollarsPrice",
                schema: "dbo",
                table: "CartItems",
                type: "decimal(7,3)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DollarsPrice",
                schema: "dbo",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "DollarsPrice",
                schema: "dbo",
                table: "CartItems");

            migrationBuilder.AddColumn<decimal>(
                name: "MinQuantity",
                schema: "dbo",
                table: "Products",
                type: "decimal(3,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "QuantityStep",
                schema: "dbo",
                table: "Products",
                type: "decimal(3,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
