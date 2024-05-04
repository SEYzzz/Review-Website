using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Review_Website.Migrations
{
    /// <inheritdoc />
    public partial class MoviesPictureURLAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Text",
                table: "Reviews",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PictureURL",
                table: "Movies",
                type: "text",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Text",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "PictureURL",
                table: "Movies");
        }
    }
}
