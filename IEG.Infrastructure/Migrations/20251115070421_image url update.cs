using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IEG.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class imageurlupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "backgroundImageURL",
                table: "Books",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "imageURL",
                table: "Books",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "backgroundImageURL",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "imageURL",
                table: "Books");
        }
    }
}
