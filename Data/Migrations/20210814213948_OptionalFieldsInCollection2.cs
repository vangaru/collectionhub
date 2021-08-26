using Microsoft.EntityFrameworkCore.Migrations;

namespace CollectionHub.Data.Migrations
{
    public partial class OptionalFieldsInCollection2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstOptionalBoolFieldName",
                table: "Collections",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstOptionalDataTimeFieldName",
                table: "Collections",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstOptionalNumberFieldName",
                table: "Collections",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstOptionalStringFieldName",
                table: "Collections",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstOptionalTextFieldName",
                table: "Collections",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecondOptionalBoolFieldName",
                table: "Collections",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecondOptionalDataTimeFieldName",
                table: "Collections",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecondOptionalNumberFieldName",
                table: "Collections",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecondOptionalStringFieldName",
                table: "Collections",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecondOptionalTextFieldName",
                table: "Collections",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ThirdOptionalBoolFieldName",
                table: "Collections",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ThirdOptionalDataTimeFieldName",
                table: "Collections",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ThirdOptionalNumberFieldName",
                table: "Collections",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ThirdOptionalStringFieldName",
                table: "Collections",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ThirdOptionalTextFieldName",
                table: "Collections",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstOptionalBoolFieldName",
                table: "Collections");

            migrationBuilder.DropColumn(
                name: "FirstOptionalDataTimeFieldName",
                table: "Collections");

            migrationBuilder.DropColumn(
                name: "FirstOptionalNumberFieldName",
                table: "Collections");

            migrationBuilder.DropColumn(
                name: "FirstOptionalStringFieldName",
                table: "Collections");

            migrationBuilder.DropColumn(
                name: "FirstOptionalTextFieldName",
                table: "Collections");

            migrationBuilder.DropColumn(
                name: "SecondOptionalBoolFieldName",
                table: "Collections");

            migrationBuilder.DropColumn(
                name: "SecondOptionalDataTimeFieldName",
                table: "Collections");

            migrationBuilder.DropColumn(
                name: "SecondOptionalNumberFieldName",
                table: "Collections");

            migrationBuilder.DropColumn(
                name: "SecondOptionalStringFieldName",
                table: "Collections");

            migrationBuilder.DropColumn(
                name: "SecondOptionalTextFieldName",
                table: "Collections");

            migrationBuilder.DropColumn(
                name: "ThirdOptionalBoolFieldName",
                table: "Collections");

            migrationBuilder.DropColumn(
                name: "ThirdOptionalDataTimeFieldName",
                table: "Collections");

            migrationBuilder.DropColumn(
                name: "ThirdOptionalNumberFieldName",
                table: "Collections");

            migrationBuilder.DropColumn(
                name: "ThirdOptionalStringFieldName",
                table: "Collections");

            migrationBuilder.DropColumn(
                name: "ThirdOptionalTextFieldName",
                table: "Collections");
        }
    }
}
