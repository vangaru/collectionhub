using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CollectionHub.Data.Migrations
{
    public partial class OptionalFieldsFixes5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_OptionalBoolFields_FirstOptionalBoolFieldId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_OptionalBoolFields_SecondOptionalBoolFieldId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_OptionalBoolFields_ThirdOptionalBoolFieldId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_OptionalDateTimeFields_FirstOptionalDateTimeFieldId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_OptionalDateTimeFields_SecondOptionalDateTimeFieldId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_OptionalDateTimeFields_ThirdOptionalDateTimeFieldId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_OptionalNumberFields_FirstOptionalNumberFieldId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_OptionalNumberFields_SecondOptionalNumberFieldId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_OptionalNumberFields_ThirdOptionalNumberFieldId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_OptionalStringFields_FirstOptionalStringFieldId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_OptionalStringFields_SecondOptionalStringFieldId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_OptionalStringFields_ThirdOptionalStringFieldId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_OptionalTextFields_FirstOptionalTextFieldId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_OptionalTextFields_SecondOptionalTextFieldId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_OptionalTextFields_ThirdOptionalTextFieldId",
                table: "Items");

            migrationBuilder.DropTable(
                name: "OptionalBoolFields");

            migrationBuilder.DropTable(
                name: "OptionalDateTimeFields");

            migrationBuilder.DropTable(
                name: "OptionalNumberFields");

            migrationBuilder.DropTable(
                name: "OptionalStringFields");

            migrationBuilder.DropTable(
                name: "OptionalTextFields");

            migrationBuilder.DropIndex(
                name: "IX_Items_FirstOptionalBoolFieldId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_FirstOptionalDateTimeFieldId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_FirstOptionalNumberFieldId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_FirstOptionalStringFieldId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_FirstOptionalTextFieldId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_SecondOptionalBoolFieldId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_SecondOptionalDateTimeFieldId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_SecondOptionalNumberFieldId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_SecondOptionalStringFieldId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_SecondOptionalTextFieldId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_ThirdOptionalBoolFieldId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_ThirdOptionalDateTimeFieldId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_ThirdOptionalNumberFieldId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_ThirdOptionalStringFieldId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_ThirdOptionalTextFieldId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "FirstOptionalBoolFieldId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "FirstOptionalDateTimeFieldId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "FirstOptionalNumberFieldId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "FirstOptionalStringFieldId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "FirstOptionalTextFieldId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "SecondOptionalBoolFieldId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "SecondOptionalDateTimeFieldId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "SecondOptionalNumberFieldId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "SecondOptionalStringFieldId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "SecondOptionalTextFieldId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "ThirdOptionalBoolFieldId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "ThirdOptionalDateTimeFieldId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "ThirdOptionalNumberFieldId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "ThirdOptionalStringFieldId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "ThirdOptionalTextFieldId",
                table: "Items");

            migrationBuilder.AddColumn<bool>(
                name: "FirstOptionalBoolField",
                table: "Items",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "FirstOptionalDateTimeField",
                table: "Items",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<double>(
                name: "FirstOptionalNumberField",
                table: "Items",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "FirstOptionalStringField",
                table: "Items",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstOptionalTextField",
                table: "Items",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OptionalTextField3",
                table: "Items",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "SecondOptionalBoolField",
                table: "Items",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "SecondOptionalDateTimeField",
                table: "Items",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<double>(
                name: "SecondOptionalNumberField",
                table: "Items",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "SecondOptionalStringField",
                table: "Items",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecondOptionalTextField",
                table: "Items",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "ThirdOptionalBoolField",
                table: "Items",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "ThirdOptionalDateTimeField",
                table: "Items",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<double>(
                name: "ThirdOptionalNumberField",
                table: "Items",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "ThirdOptionalStringField",
                table: "Items",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstOptionalBoolField",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "FirstOptionalDateTimeField",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "FirstOptionalNumberField",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "FirstOptionalStringField",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "FirstOptionalTextField",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "OptionalTextField3",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "SecondOptionalBoolField",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "SecondOptionalDateTimeField",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "SecondOptionalNumberField",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "SecondOptionalStringField",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "SecondOptionalTextField",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "ThirdOptionalBoolField",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "ThirdOptionalDateTimeField",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "ThirdOptionalNumberField",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "ThirdOptionalStringField",
                table: "Items");

            migrationBuilder.AddColumn<int>(
                name: "FirstOptionalBoolFieldId",
                table: "Items",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FirstOptionalDateTimeFieldId",
                table: "Items",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FirstOptionalNumberFieldId",
                table: "Items",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FirstOptionalStringFieldId",
                table: "Items",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FirstOptionalTextFieldId",
                table: "Items",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SecondOptionalBoolFieldId",
                table: "Items",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SecondOptionalDateTimeFieldId",
                table: "Items",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SecondOptionalNumberFieldId",
                table: "Items",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SecondOptionalStringFieldId",
                table: "Items",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SecondOptionalTextFieldId",
                table: "Items",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ThirdOptionalBoolFieldId",
                table: "Items",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ThirdOptionalDateTimeFieldId",
                table: "Items",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ThirdOptionalNumberFieldId",
                table: "Items",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ThirdOptionalStringFieldId",
                table: "Items",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ThirdOptionalTextFieldId",
                table: "Items",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "OptionalBoolFields",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 30, nullable: true),
                    Value = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OptionalBoolFields", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OptionalDateTimeFields",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 30, nullable: true),
                    Value = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OptionalDateTimeFields", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OptionalNumberFields",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 30, nullable: true),
                    Value = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OptionalNumberFields", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OptionalStringFields",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 30, nullable: true),
                    Value = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OptionalStringFields", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OptionalTextFields",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 30, nullable: true),
                    Value = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OptionalTextFields", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Items_FirstOptionalBoolFieldId",
                table: "Items",
                column: "FirstOptionalBoolFieldId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_FirstOptionalDateTimeFieldId",
                table: "Items",
                column: "FirstOptionalDateTimeFieldId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_FirstOptionalNumberFieldId",
                table: "Items",
                column: "FirstOptionalNumberFieldId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_FirstOptionalStringFieldId",
                table: "Items",
                column: "FirstOptionalStringFieldId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_FirstOptionalTextFieldId",
                table: "Items",
                column: "FirstOptionalTextFieldId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_SecondOptionalBoolFieldId",
                table: "Items",
                column: "SecondOptionalBoolFieldId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_SecondOptionalDateTimeFieldId",
                table: "Items",
                column: "SecondOptionalDateTimeFieldId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_SecondOptionalNumberFieldId",
                table: "Items",
                column: "SecondOptionalNumberFieldId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_SecondOptionalStringFieldId",
                table: "Items",
                column: "SecondOptionalStringFieldId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_SecondOptionalTextFieldId",
                table: "Items",
                column: "SecondOptionalTextFieldId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_ThirdOptionalBoolFieldId",
                table: "Items",
                column: "ThirdOptionalBoolFieldId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_ThirdOptionalDateTimeFieldId",
                table: "Items",
                column: "ThirdOptionalDateTimeFieldId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_ThirdOptionalNumberFieldId",
                table: "Items",
                column: "ThirdOptionalNumberFieldId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_ThirdOptionalStringFieldId",
                table: "Items",
                column: "ThirdOptionalStringFieldId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_ThirdOptionalTextFieldId",
                table: "Items",
                column: "ThirdOptionalTextFieldId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_OptionalBoolFields_FirstOptionalBoolFieldId",
                table: "Items",
                column: "FirstOptionalBoolFieldId",
                principalTable: "OptionalBoolFields",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_OptionalBoolFields_SecondOptionalBoolFieldId",
                table: "Items",
                column: "SecondOptionalBoolFieldId",
                principalTable: "OptionalBoolFields",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_OptionalBoolFields_ThirdOptionalBoolFieldId",
                table: "Items",
                column: "ThirdOptionalBoolFieldId",
                principalTable: "OptionalBoolFields",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_OptionalDateTimeFields_FirstOptionalDateTimeFieldId",
                table: "Items",
                column: "FirstOptionalDateTimeFieldId",
                principalTable: "OptionalDateTimeFields",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_OptionalDateTimeFields_SecondOptionalDateTimeFieldId",
                table: "Items",
                column: "SecondOptionalDateTimeFieldId",
                principalTable: "OptionalDateTimeFields",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_OptionalDateTimeFields_ThirdOptionalDateTimeFieldId",
                table: "Items",
                column: "ThirdOptionalDateTimeFieldId",
                principalTable: "OptionalDateTimeFields",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_OptionalNumberFields_FirstOptionalNumberFieldId",
                table: "Items",
                column: "FirstOptionalNumberFieldId",
                principalTable: "OptionalNumberFields",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_OptionalNumberFields_SecondOptionalNumberFieldId",
                table: "Items",
                column: "SecondOptionalNumberFieldId",
                principalTable: "OptionalNumberFields",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_OptionalNumberFields_ThirdOptionalNumberFieldId",
                table: "Items",
                column: "ThirdOptionalNumberFieldId",
                principalTable: "OptionalNumberFields",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_OptionalStringFields_FirstOptionalStringFieldId",
                table: "Items",
                column: "FirstOptionalStringFieldId",
                principalTable: "OptionalStringFields",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_OptionalStringFields_SecondOptionalStringFieldId",
                table: "Items",
                column: "SecondOptionalStringFieldId",
                principalTable: "OptionalStringFields",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_OptionalStringFields_ThirdOptionalStringFieldId",
                table: "Items",
                column: "ThirdOptionalStringFieldId",
                principalTable: "OptionalStringFields",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_OptionalTextFields_FirstOptionalTextFieldId",
                table: "Items",
                column: "FirstOptionalTextFieldId",
                principalTable: "OptionalTextFields",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_OptionalTextFields_SecondOptionalTextFieldId",
                table: "Items",
                column: "SecondOptionalTextFieldId",
                principalTable: "OptionalTextFields",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_OptionalTextFields_ThirdOptionalTextFieldId",
                table: "Items",
                column: "ThirdOptionalTextFieldId",
                principalTable: "OptionalTextFields",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
