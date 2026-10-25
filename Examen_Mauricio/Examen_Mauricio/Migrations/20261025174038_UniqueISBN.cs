using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Biblioteca_Api.Migrations
{
    /// <inheritdoc />
    public partial class UniqueISBN : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Book_ISBN",
                table: "Book",
                column: "ISBN",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Book_ISBN",
                table: "Book");
        }
    }
}
