using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Child_mg.Migrations
{
    /// <inheritdoc />

    /// <inheritdoc />
    public partial class uniquePhone : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Users_Phone",
                table: "Users",
                column: "Phone",
                unique: true,
                filter: "[Phone] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Users_Phone",
                table: "Users");
        }
    }
}
    
