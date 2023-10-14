using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BBMApi.Migrations
{
    /// <inheritdoc />
    public partial class UpdateMinistry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "cellLeader",
                table: "Person",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "cellLocation",
                table: "Person",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ministry",
                table: "Person",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "cellLeader",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "cellLocation",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "ministry",
                table: "Person");
        }
    }
}
