using Microsoft.EntityFrameworkCore.Migrations;

namespace ShoppincCart.data.Migrations
{
    public partial class DisbaleProductMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_products_Categories_categoryid",
                table: "products");

            migrationBuilder.RenameColumn(
                name: "categoryid",
                table: "products",
                newName: "CategoryID");

            migrationBuilder.RenameIndex(
                name: "IX_products_categoryid",
                table: "products",
                newName: "IX_products_CategoryID");

            migrationBuilder.AddColumn<bool>(
                name: "disbale",
                table: "products",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddForeignKey(
                name: "FK_products_Categories_CategoryID",
                table: "products",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_products_Categories_CategoryID",
                table: "products");

            migrationBuilder.DropColumn(
                name: "disbale",
                table: "products");

            migrationBuilder.RenameColumn(
                name: "CategoryID",
                table: "products",
                newName: "categoryid");

            migrationBuilder.RenameIndex(
                name: "IX_products_CategoryID",
                table: "products",
                newName: "IX_products_categoryid");

            migrationBuilder.AddForeignKey(
                name: "FK_products_Categories_categoryid",
                table: "products",
                column: "categoryid",
                principalTable: "Categories",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
