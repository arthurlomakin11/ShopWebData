using Microsoft.EntityFrameworkCore.Migrations;

namespace ShopWebData.Migrations
{
    public partial class Migration_43 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MobileParentId",
                table: "Menu",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "MobileShowInMenu",
                table: "Menu",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateIndex(
                name: "IX_Menu_MobileParentId",
                table: "Menu",
                column: "MobileParentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Menu_Menu_MobileParentId",
                table: "Menu",
                column: "MobileParentId",
                principalTable: "Menu",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Menu_Menu_MobileParentId",
                table: "Menu");

            migrationBuilder.DropIndex(
                name: "IX_Menu_MobileParentId",
                table: "Menu");

            migrationBuilder.DropColumn(
                name: "MobileParentId",
                table: "Menu");

            migrationBuilder.DropColumn(
                name: "MobileShowInMenu",
                table: "Menu");
        }
    }
}
