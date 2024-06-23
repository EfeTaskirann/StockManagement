using Microsoft.EntityFrameworkCore.Migrations;

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Products_Subcategory_id1",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Subcategory_id1",
                table: "Products");

            migrationBuilder.AlterColumn<string>(
                name: "ProductDescription",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Products_Subcategory_id",
                table: "Products",
                column: "Subcategory_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Subcategories_Subcategory_id",
                table: "Products",
                column: "Subcategory_id",
                principalTable: "Subcategories",
                principalColumn: "Subcategory_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Subcategories_Subcategory_id",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_Subcategory_id",
                table: "Products");

            migrationBuilder.AlterColumn<string>(
                name: "ProductDescription",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Subcategory_id1",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_Subcategory_id1",
                table: "Products",
                column: "Subcategory_id1");
        }
    }
}
