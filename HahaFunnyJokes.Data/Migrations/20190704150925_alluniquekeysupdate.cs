using Microsoft.EntityFrameworkCore.Migrations;

namespace HahaFunnyJokes.Data.Migrations
{
    public partial class alluniquekeysupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AK_Users_Slug_Email",
                table: "Users");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_Jokes_Slug",
                table: "Jokes");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_Hobbies_Slug",
                table: "Hobbies");

            migrationBuilder.AlterColumn<string>(
                name: "Slug",
                table: "Users",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Slug",
                table: "Jokes",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Slug",
                table: "Hobbies",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.CreateIndex(
                name: "IX_Users_Slug_Email",
                table: "Users",
                columns: new[] { "Slug", "Email" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Jokes_Slug",
                table: "Jokes",
                column: "Slug",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Hobbies_Slug",
                table: "Hobbies",
                column: "Slug",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Users_Slug_Email",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Jokes_Slug",
                table: "Jokes");

            migrationBuilder.DropIndex(
                name: "IX_Hobbies_Slug",
                table: "Hobbies");

            migrationBuilder.AlterColumn<string>(
                name: "Slug",
                table: "Users",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Slug",
                table: "Jokes",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Slug",
                table: "Hobbies",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Users_Slug_Email",
                table: "Users",
                columns: new[] { "Slug", "Email" });

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Jokes_Slug",
                table: "Jokes",
                column: "Slug");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Hobbies_Slug",
                table: "Hobbies",
                column: "Slug");
        }
    }
}
