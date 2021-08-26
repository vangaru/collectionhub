using Microsoft.EntityFrameworkCore.Migrations;

namespace CollectionHub.Data.Migrations
{
    public partial class ImagesFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "Collections");

            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Collections");

            migrationBuilder.AddColumn<string>(
                name: "ImageStorageName",
                table: "Collections",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Collections",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageStorageName",
                table: "Collections");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Collections");

            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "Collections",
                type: "TEXT",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Collections",
                type: "TEXT",
                maxLength: 250,
                nullable: true);
        }
    }
}
