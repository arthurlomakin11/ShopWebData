using Microsoft.EntityFrameworkCore.Migrations;

namespace ShopWebData.Migrations
{
    public partial class Migration_42 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartGifts");

            migrationBuilder.AddColumn<int>(
                name: "CartId",
                table: "Gifts",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Gifts_CartId",
                table: "Gifts",
                column: "CartId");

            migrationBuilder.AddForeignKey(
                name: "FK_Gifts_Carts_CartId",
                table: "Gifts",
                column: "CartId",
                principalTable: "Carts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Gifts_Carts_CartId",
                table: "Gifts");

            migrationBuilder.DropIndex(
                name: "IX_Gifts_CartId",
                table: "Gifts");

            migrationBuilder.DropColumn(
                name: "CartId",
                table: "Gifts");

            migrationBuilder.CreateTable(
                name: "CartGifts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<decimal>(type: "decimal(7,3)", nullable: false),
                    CartId = table.Column<int>(type: "int", nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartGifts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CartGifts_Carts_CartId",
                        column: x => x.CartId,
                        principalTable: "Carts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CartGifts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CartGifts_CartId",
                table: "CartGifts",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_CartGifts_ProductId",
                table: "CartGifts",
                column: "ProductId");
        }
    }
}
