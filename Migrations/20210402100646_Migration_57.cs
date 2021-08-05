using Microsoft.EntityFrameworkCore.Migrations;

namespace ShopWebData.Migrations
{
    public partial class Migration_57 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carts_AspNetUsers_BuyerId",
                table: "Carts");

            migrationBuilder.AlterColumn<string>(
                name: "BuyerId",
                table: "Carts",
                type: "nvarchar(128)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)");

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "Carts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Carts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_AspNetUsers_BuyerId",
                table: "Carts",
                column: "BuyerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carts_AspNetUsers_BuyerId",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "FullName",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Carts");

            migrationBuilder.AlterColumn<string>(
                name: "BuyerId",
                table: "Carts",
                type: "nvarchar(128)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_AspNetUsers_BuyerId",
                table: "Carts",
                column: "BuyerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
