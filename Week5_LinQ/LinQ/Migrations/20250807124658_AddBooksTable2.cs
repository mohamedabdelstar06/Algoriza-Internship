using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Core.Migrations
{
    /// <inheritdoc />
    public partial class AddBooksTable2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Books",
                schema: "Blogging",
                table: "Books");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Abdelstar",
                schema: "Blogging",
                table: "Books",
                column: "Abdelstar");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Abdelstar",
                schema: "Blogging",
                table: "Books");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Books",
                schema: "Blogging",
                table: "Books" ,
                column: "Abdelstar");
        }
    }
}
