using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QrCodeGenerator.Migrations
{
    /// <inheritdoc />
    public partial class modelUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsLogoIncluded",
                table: "Qrs");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsLogoIncluded",
                table: "Qrs",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
