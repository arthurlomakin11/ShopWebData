using Microsoft.EntityFrameworkCore.Migrations;

namespace ShopWebData.Migrations
{
    public partial class Migration_51 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carts_DeliveryTimes_DeliveryTimeId",
                table: "Carts");

            migrationBuilder.DropIndex(
                name: "IX_Carts_DeliveryTimeId",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "DeliveryTimeId",
                table: "Carts");

            migrationBuilder.AddColumn<string>(
                name: "DeliveryTime",
                table: "Carts",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeliveryTime",
                table: "Carts");

            migrationBuilder.AddColumn<int>(
                name: "DeliveryTimeId",
                table: "Carts",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Carts_DeliveryTimeId",
                table: "Carts",
                column: "DeliveryTimeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_DeliveryTimes_DeliveryTimeId",
                table: "Carts",
                column: "DeliveryTimeId",
                principalTable: "DeliveryTimes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
