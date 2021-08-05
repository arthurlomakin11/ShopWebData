using Microsoft.EntityFrameworkCore.Migrations;

namespace ShopWebData.Migrations
{
    public partial class Migration_40 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MenuItemId",
                table: "Images",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Images_MenuItemId",
                table: "Images",
                column: "MenuItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Menu_MenuItemId",
                table: "Images",
                column: "MenuItemId",
                principalTable: "Menu",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_Menu_MenuItemId",
                table: "Images");

            migrationBuilder.DropIndex(
                name: "IX_Images_MenuItemId",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "MenuItemId",
                table: "Images");
        }
    }
}
