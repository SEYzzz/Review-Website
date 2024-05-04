using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Review_Website.Migrations
{
    /// <inheritdoc />
    public partial class MovieTypoCorrected : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Titlte",
                table: "Movies",
                newName: "Title");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Movies",
                newName: "Titlte");
        }
    }
}
