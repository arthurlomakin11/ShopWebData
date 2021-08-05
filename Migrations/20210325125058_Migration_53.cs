using Microsoft.EntityFrameworkCore.Migrations;

namespace ShopWebData.Migrations
{
    public partial class Migration_53 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductCollectionId",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ProductCollections",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    ShowInCart = table.Column<bool>(type: "bit", nullable: false),
                    ShowOnMainPage = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCollections", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductCollections_ProductCollectionId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "ProductCollections");

            migrationBuilder.DropIndex(
                name: "IX_Products_ProductCollectionId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductCollectionId",
                table: "Products");
        }
    }
}
