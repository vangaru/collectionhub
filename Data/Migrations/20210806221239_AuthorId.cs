using Microsoft.EntityFrameworkCore.Migrations;

namespace CollectionHub.Data.Migrations
{
    public partial class AuthorId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Collections_AspNetUsers_AuthorId",
                table: "Collections");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_AspNetUsers_AuthorId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_AuthorId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Collections_AuthorId",
                table: "Collections");

            migrationBuilder.AlterColumn<string>(
                name: "AuthorId",
                table: "Items",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Collections",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Collections_ApplicationUserId",
                table: "Collections",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Collections_AspNetUsers_ApplicationUserId",
                table: "Collections",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Collections_AspNetUsers_ApplicationUserId",
                table: "Collections");

            migrationBuilder.DropIndex(
                name: "IX_Collections_ApplicationUserId",
                table: "Collections");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Collections");

            migrationBuilder.AlterColumn<string>(
                name: "AuthorId",
                table: "Items",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.CreateIndex(
                name: "IX_Items_AuthorId",
                table: "Items",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Collections_AuthorId",
                table: "Collections",
                column: "AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Collections_AspNetUsers_AuthorId",
                table: "Collections",
                column: "AuthorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_AspNetUsers_AuthorId",
                table: "Items",
                column: "AuthorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
