using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CollectionHub.Data.Migrations
{
    public partial class OptionalFieldsDbSet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_OptionalBoolField_OptionalBoolField1Id",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_OptionalBoolField_OptionalBoolField2Id",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_OptionalBoolField_OptionalBoolField3Id",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_OptionalNumberField_OptionalNumberField1Id",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_OptionalNumberField_OptionalNumberField2Id",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_OptionalNumberField_OptionalNumberField3Id",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_OptionalStringField_OptionalStringField1Id",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_OptionalStringField_OptionalStringField2Id",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_OptionalStringField_OptionalStringField3Id",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_OptionalTextField_OptionalTextField1Id",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_OptionalTextField_OptionalTextField2Id",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_OptionalTextField_OptionalTextField3Id",
                table: "Items");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OptionalTextField",
                table: "OptionalTextField");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OptionalStringField",
                table: "OptionalStringField");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OptionalNumberField",
                table: "OptionalNumberField");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OptionalBoolField",
                table: "OptionalBoolField");

            migrationBuilder.RenameTable(
                name: "OptionalTextField",
                newName: "OptionalTextFields");

            migrationBuilder.RenameTable(
                name: "OptionalStringField",
                newName: "OptionalStringFields");

            migrationBuilder.RenameTable(
                name: "OptionalNumberField",
                newName: "OptionalNumberFields");

            migrationBuilder.RenameTable(
                name: "OptionalBoolField",
                newName: "OptionalBoolFields");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OptionalTextFields",
                table: "OptionalTextFields",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OptionalStringFields",
                table: "OptionalStringFields",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OptionalNumberFields",
                table: "OptionalNumberFields",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OptionalBoolFields",
                table: "OptionalBoolFields",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "OptionalDateTimeFields",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Value = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OptionalDateTimeFields", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Items_OptionalBoolFields_OptionalBoolField1Id",
                table: "Items",
                column: "OptionalBoolField1Id",
                principalTable: "OptionalBoolFields",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_OptionalBoolFields_OptionalBoolField2Id",
                table: "Items",
                column: "OptionalBoolField2Id",
                principalTable: "OptionalBoolFields",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_OptionalBoolFields_OptionalBoolField3Id",
                table: "Items",
                column: "OptionalBoolField3Id",
                principalTable: "OptionalBoolFields",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_OptionalNumberFields_OptionalNumberField1Id",
                table: "Items",
                column: "OptionalNumberField1Id",
                principalTable: "OptionalNumberFields",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_OptionalNumberFields_OptionalNumberField2Id",
                table: "Items",
                column: "OptionalNumberField2Id",
                principalTable: "OptionalNumberFields",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_OptionalNumberFields_OptionalNumberField3Id",
                table: "Items",
                column: "OptionalNumberField3Id",
                principalTable: "OptionalNumberFields",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_OptionalStringFields_OptionalStringField1Id",
                table: "Items",
                column: "OptionalStringField1Id",
                principalTable: "OptionalStringFields",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_OptionalStringFields_OptionalStringField2Id",
                table: "Items",
                column: "OptionalStringField2Id",
                principalTable: "OptionalStringFields",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_OptionalStringFields_OptionalStringField3Id",
                table: "Items",
                column: "OptionalStringField3Id",
                principalTable: "OptionalStringFields",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_OptionalTextFields_OptionalTextField1Id",
                table: "Items",
                column: "OptionalTextField1Id",
                principalTable: "OptionalTextFields",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_OptionalTextFields_OptionalTextField2Id",
                table: "Items",
                column: "OptionalTextField2Id",
                principalTable: "OptionalTextFields",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_OptionalTextFields_OptionalTextField3Id",
                table: "Items",
                column: "OptionalTextField3Id",
                principalTable: "OptionalTextFields",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_OptionalBoolFields_OptionalBoolField1Id",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_OptionalBoolFields_OptionalBoolField2Id",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_OptionalBoolFields_OptionalBoolField3Id",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_OptionalNumberFields_OptionalNumberField1Id",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_OptionalNumberFields_OptionalNumberField2Id",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_OptionalNumberFields_OptionalNumberField3Id",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_OptionalStringFields_OptionalStringField1Id",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_OptionalStringFields_OptionalStringField2Id",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_OptionalStringFields_OptionalStringField3Id",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_OptionalTextFields_OptionalTextField1Id",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_OptionalTextFields_OptionalTextField2Id",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_OptionalTextFields_OptionalTextField3Id",
                table: "Items");

            migrationBuilder.DropTable(
                name: "OptionalDateTimeFields");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OptionalTextFields",
                table: "OptionalTextFields");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OptionalStringFields",
                table: "OptionalStringFields");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OptionalNumberFields",
                table: "OptionalNumberFields");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OptionalBoolFields",
                table: "OptionalBoolFields");

            migrationBuilder.RenameTable(
                name: "OptionalTextFields",
                newName: "OptionalTextField");

            migrationBuilder.RenameTable(
                name: "OptionalStringFields",
                newName: "OptionalStringField");

            migrationBuilder.RenameTable(
                name: "OptionalNumberFields",
                newName: "OptionalNumberField");

            migrationBuilder.RenameTable(
                name: "OptionalBoolFields",
                newName: "OptionalBoolField");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OptionalTextField",
                table: "OptionalTextField",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OptionalStringField",
                table: "OptionalStringField",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OptionalNumberField",
                table: "OptionalNumberField",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OptionalBoolField",
                table: "OptionalBoolField",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_OptionalBoolField_OptionalBoolField1Id",
                table: "Items",
                column: "OptionalBoolField1Id",
                principalTable: "OptionalBoolField",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_OptionalBoolField_OptionalBoolField2Id",
                table: "Items",
                column: "OptionalBoolField2Id",
                principalTable: "OptionalBoolField",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_OptionalBoolField_OptionalBoolField3Id",
                table: "Items",
                column: "OptionalBoolField3Id",
                principalTable: "OptionalBoolField",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_OptionalNumberField_OptionalNumberField1Id",
                table: "Items",
                column: "OptionalNumberField1Id",
                principalTable: "OptionalNumberField",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_OptionalNumberField_OptionalNumberField2Id",
                table: "Items",
                column: "OptionalNumberField2Id",
                principalTable: "OptionalNumberField",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_OptionalNumberField_OptionalNumberField3Id",
                table: "Items",
                column: "OptionalNumberField3Id",
                principalTable: "OptionalNumberField",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_OptionalStringField_OptionalStringField1Id",
                table: "Items",
                column: "OptionalStringField1Id",
                principalTable: "OptionalStringField",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_OptionalStringField_OptionalStringField2Id",
                table: "Items",
                column: "OptionalStringField2Id",
                principalTable: "OptionalStringField",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_OptionalStringField_OptionalStringField3Id",
                table: "Items",
                column: "OptionalStringField3Id",
                principalTable: "OptionalStringField",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_OptionalTextField_OptionalTextField1Id",
                table: "Items",
                column: "OptionalTextField1Id",
                principalTable: "OptionalTextField",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_OptionalTextField_OptionalTextField2Id",
                table: "Items",
                column: "OptionalTextField2Id",
                principalTable: "OptionalTextField",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_OptionalTextField_OptionalTextField3Id",
                table: "Items",
                column: "OptionalTextField3Id",
                principalTable: "OptionalTextField",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
