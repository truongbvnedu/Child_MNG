using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Child_mg.Migrations
{
    /// <inheritdoc />
    public partial class ImangeCommentAddForChild : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Comment",
                table: "Child",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "image",
                table: "Child",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Comment",
                table: "Child");

            migrationBuilder.DropColumn(
                name: "image",
                table: "Child");
        }
    }
}
