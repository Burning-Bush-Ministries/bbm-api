using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BBMApi.Migrations
{
    /// <inheritdoc />
    public partial class updateStatsTbl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "aow",
                table: "Stats",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ck",
                table: "Stats",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "aow",
                table: "Stats");

            migrationBuilder.DropColumn(
                name: "ck",
                table: "Stats");
        }
    }
}
