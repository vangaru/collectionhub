using Microsoft.EntityFrameworkCore.Migrations;

namespace CollectionHub.Data.Migrations
{
    public partial class OptionalFieldsFixes3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstOptionalBoolFieldVisible",
                table: "Collections");

            migrationBuilder.DropColumn(
                name: "FirstOptionalDateTimeFieldVisible",
                table: "Collections");

            migrationBuilder.DropColumn(
                name: "FirstOptionalNumberFieldVisible",
                table: "Collections");

            migrationBuilder.DropColumn(
                name: "FirstOptionalStringFieldVisible",
                table: "Collections");

            migrationBuilder.DropColumn(
                name: "FirstOptionalTextFieldVisible",
                table: "Collections");

            migrationBuilder.DropColumn(
                name: "SecondOptionalBoolFieldVisible",
                table: "Collections");

            migrationBuilder.DropColumn(
                name: "SecondOptionalDateTimeFieldVisible",
                table: "Collections");

            migrationBuilder.DropColumn(
                name: "SecondOptionalNumberFieldVisible",
                table: "Collections");

            migrationBuilder.DropColumn(
                name: "SecondOptionalStringFieldVisible",
                table: "Collections");

            migrationBuilder.DropColumn(
                name: "SecondOptionalTextFieldVisible",
                table: "Collections");

            migrationBuilder.DropColumn(
                name: "ThirdOptionalBoolFieldVisible",
                table: "Collections");

            migrationBuilder.DropColumn(
                name: "ThirdOptionalDateTimeFieldVisible",
                table: "Collections");

            migrationBuilder.DropColumn(
                name: "ThirdOptionalNumberFieldVisible",
                table: "Collections");

            migrationBuilder.DropColumn(
                name: "ThirdOptionalStringFieldVisible",
                table: "Collections");

            migrationBuilder.DropColumn(
                name: "ThirdOptionalTextFieldVisible",
                table: "Collections");

            migrationBuilder.AddColumn<string>(
                name: "FirstOptionalBoolFieldName",
                table: "Collections",
                type: "TEXT",
                maxLength: 30,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstOptionalDateTimeFieldName",
                table: "Collections",
                type: "TEXT",
                maxLength: 30,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstOptionalNumberFieldName",
                table: "Collections",
                type: "TEXT",
                maxLength: 30,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstOptionalStringFieldName",
                table: "Collections",
                type: "TEXT",
                maxLength: 30,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstOptionalTextFieldName",
                table: "Collections",
                type: "TEXT",
                maxLength: 30,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecondOptionalBoolFieldName",
                table: "Collections",
                type: "TEXT",
                maxLength: 30,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecondOptionalDateTimeFieldName",
                table: "Collections",
                type: "TEXT",
                maxLength: 30,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecondOptionalNumberFieldName",
                table: "Collections",
                type: "TEXT",
                maxLength: 30,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecondOptionalStringFieldName",
                table: "Collections",
                type: "TEXT",
                maxLength: 30,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecondOptionalTextFieldName",
                table: "Collections",
                type: "TEXT",
                maxLength: 30,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ThirdOptionalBoolFieldName",
                table: "Collections",
                type: "TEXT",
                maxLength: 30,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ThirdOptionalDateTimeFieldName",
                table: "Collections",
                type: "TEXT",
                maxLength: 30,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ThirdOptionalNumberFieldName",
                table: "Collections",
                type: "TEXT",
                maxLength: 30,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ThirdOptionalStringFieldName",
                table: "Collections",
                type: "TEXT",
                maxLength: 30,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ThirdOptionalTextFieldName",
                table: "Collections",
                type: "TEXT",
                maxLength: 30,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstOptionalBoolFieldName",
                table: "Collections");

            migrationBuilder.DropColumn(
                name: "FirstOptionalDateTimeFieldName",
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
                name: "SecondOptionalDateTimeFieldName",
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
                name: "ThirdOptionalDateTimeFieldName",
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

            migrationBuilder.AddColumn<bool>(
                name: "FirstOptionalBoolFieldVisible",
                table: "Collections",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "FirstOptionalDateTimeFieldVisible",
                table: "Collections",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "FirstOptionalNumberFieldVisible",
                table: "Collections",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "FirstOptionalStringFieldVisible",
                table: "Collections",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "FirstOptionalTextFieldVisible",
                table: "Collections",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "SecondOptionalBoolFieldVisible",
                table: "Collections",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "SecondOptionalDateTimeFieldVisible",
                table: "Collections",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "SecondOptionalNumberFieldVisible",
                table: "Collections",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "SecondOptionalStringFieldVisible",
                table: "Collections",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "SecondOptionalTextFieldVisible",
                table: "Collections",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ThirdOptionalBoolFieldVisible",
                table: "Collections",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ThirdOptionalDateTimeFieldVisible",
                table: "Collections",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ThirdOptionalNumberFieldVisible",
                table: "Collections",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ThirdOptionalStringFieldVisible",
                table: "Collections",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ThirdOptionalTextFieldVisible",
                table: "Collections",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }
    }
}
