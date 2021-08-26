using Microsoft.EntityFrameworkCore.Migrations;

namespace CollectionHub.Data.Migrations
{
    public partial class OptionalFieldsFixes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstOptionalDataTimeFieldVisible",
                table: "Collections");

            migrationBuilder.RenameColumn(
                name: "ThirdOptionalDataTimeFieldName",
                table: "Collections",
                newName: "ThirdOptionalDateTimeFieldName");

            migrationBuilder.RenameColumn(
                name: "SecondOptionalDataTimeFieldName",
                table: "Collections",
                newName: "SecondOptionalDateTimeFieldName");

            migrationBuilder.RenameColumn(
                name: "FirstOptionalDataTimeFieldName",
                table: "Collections",
                newName: "FirstOptionalDateTimeFieldName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ThirdOptionalDateTimeFieldName",
                table: "Collections",
                newName: "ThirdOptionalDataTimeFieldName");

            migrationBuilder.RenameColumn(
                name: "SecondOptionalDateTimeFieldName",
                table: "Collections",
                newName: "SecondOptionalDataTimeFieldName");

            migrationBuilder.RenameColumn(
                name: "FirstOptionalDateTimeFieldName",
                table: "Collections",
                newName: "FirstOptionalDataTimeFieldName");

            migrationBuilder.AddColumn<bool>(
                name: "FirstOptionalDataTimeFieldVisible",
                table: "Collections",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }
    }
}
