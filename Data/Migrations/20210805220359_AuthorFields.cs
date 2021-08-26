using Microsoft.EntityFrameworkCore.Migrations;

namespace CollectionHub.Data.Migrations
{
    public partial class AuthorFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AuthorId",
                table: "Items",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Author",
                table: "Collections",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Items_AuthorId",
                table: "Items",
                column: "AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_AspNetUsers_AuthorId",
                table: "Items",
                column: "AuthorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_AspNetUsers_AuthorId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_AuthorId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "Author",
                table: "Collections");
        }
    }
}
