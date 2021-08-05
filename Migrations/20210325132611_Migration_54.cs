using Microsoft.EntityFrameworkCore.Migrations;

namespace ShopWebData.Migrations
{
    public partial class Migration_54 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductCollections_ProductCollectionId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_ProductCollectionId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductCollectionId",
                table: "Products");

            migrationBuilder.CreateTable(
                name: "ProductsInCollection",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: true),
                    ProductCollectionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsInCollection", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductsInCollection_ProductCollections_ProductCollectionId",
                        column: x => x.ProductCollectionId,
                        principalTable: "ProductCollections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProductsInCollection_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductsInCollection_ProductCollectionId",
                table: "ProductsInCollection",
                column: "ProductCollectionId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsInCollection_ProductId",
                table: "ProductsInCollection",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductsInCollection");

            migrationBuilder.AddColumn<int>(
                name: "ProductCollectionId",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductCollectionId",
                table: "Products",
                column: "ProductCollectionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductCollections_ProductCollectionId",
                table: "Products",
                column: "ProductCollectionId",
                principalTable: "ProductCollections",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
