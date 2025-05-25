using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Model.Migrations
{
    /// <inheritdoc />
    public partial class portfolio_edited : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Portfolios_Categories_CategoryID",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "category_id",
                table: "Portfolios");

            migrationBuilder.RenameColumn(
                name: "title",
                table: "Portfolios",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "CategoryID",
                table: "Portfolios",
                newName: "CategoryId");

            migrationBuilder.RenameColumn(
                name: "project_url",
                table: "Portfolios",
                newName: "ProjectUrl");

            migrationBuilder.RenameColumn(
                name: "image_url",
                table: "Portfolios",
                newName: "ImageUrl");

            migrationBuilder.RenameIndex(
                name: "IX_Portfolios_CategoryID",
                table: "Portfolios",
                newName: "IX_Portfolios_CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Portfolios_Categories_CategoryId",
                table: "Portfolios",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Portfolios_Categories_CategoryId",
                table: "Portfolios");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Portfolios",
                newName: "title");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Portfolios",
                newName: "CategoryID");

            migrationBuilder.RenameColumn(
                name: "ProjectUrl",
                table: "Portfolios",
                newName: "project_url");

            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Portfolios",
                newName: "image_url");

            migrationBuilder.RenameIndex(
                name: "IX_Portfolios_CategoryId",
                table: "Portfolios",
                newName: "IX_Portfolios_CategoryID");

            migrationBuilder.AddColumn<int>(
                name: "category_id",
                table: "Portfolios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Portfolios_Categories_CategoryID",
                table: "Portfolios",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
