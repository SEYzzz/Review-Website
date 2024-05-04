using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Review_Website.Migrations
{
    /// <inheritdoc />
    public partial class Typoremoved : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProdilePictureURL",
                table: "Producers",
                newName: "ProfilePictureURL");

            migrationBuilder.AlterColumn<string>(
                name: "ProfilePictureURL",
                table: "Actors",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Bio",
                table: "Actors",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProfilePictureURL",
                table: "Producers",
                newName: "ProdilePictureURL");

            migrationBuilder.AlterColumn<string>(
                name: "ProfilePictureURL",
                table: "Actors",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Bio",
                table: "Actors",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");
        }
    }
}
