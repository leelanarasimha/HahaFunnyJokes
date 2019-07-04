using Microsoft.EntityFrameworkCore.Migrations;

namespace HahaFunnyJokes.Data.Migrations
{
    public partial class uniquekeyupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AK_Categories_Slug",
                table: "Categories");

            migrationBuilder.AlterColumn<string>(
                name: "Slug",
                table: "Categories",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.CreateIndex(
                name: "IX_Categories_Slug",
                table: "Categories",
                column: "Slug",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Categories_Slug",
                table: "Categories");

            migrationBuilder.AlterColumn<string>(
                name: "Slug",
                table: "Categories",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Categories_Slug",
                table: "Categories",
                column: "Slug");
        }
    }
}
