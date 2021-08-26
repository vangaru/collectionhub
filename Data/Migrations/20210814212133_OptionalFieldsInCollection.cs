using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CollectionHub.Data.Migrations
{
    public partial class OptionalFieldsInCollection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OptionalBoolField_Items_ItemId",
                table: "OptionalBoolField");

            migrationBuilder.DropForeignKey(
                name: "FK_OptionalNumberField_Items_ItemId",
                table: "OptionalNumberField");

            migrationBuilder.DropForeignKey(
                name: "FK_OptionalStringField_Items_ItemId",
                table: "OptionalStringField");

            migrationBuilder.DropForeignKey(
                name: "FK_OptionalTextField_Items_ItemId",
                table: "OptionalTextField");

            migrationBuilder.DropTable(
                name: "OptionalDateTimeField");

            migrationBuilder.DropIndex(
                name: "IX_OptionalTextField_ItemId",
                table: "OptionalTextField");

            migrationBuilder.DropIndex(
                name: "IX_OptionalStringField_ItemId",
                table: "OptionalStringField");

            migrationBuilder.DropIndex(
                name: "IX_OptionalNumberField_ItemId",
                table: "OptionalNumberField");

            migrationBuilder.DropIndex(
                name: "IX_OptionalBoolField_ItemId",
                table: "OptionalBoolField");

            migrationBuilder.DropColumn(
                name: "ItemId",
                table: "OptionalTextField");

            migrationBuilder.DropColumn(
                name: "ItemId",
                table: "OptionalStringField");

            migrationBuilder.DropColumn(
                name: "ItemId",
                table: "OptionalNumberField");

            migrationBuilder.DropColumn(
                name: "ItemId",
                table: "OptionalBoolField");

            migrationBuilder.AddColumn<int>(
                name: "OptionalBoolField1Id",
                table: "Items",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OptionalBoolField2Id",
                table: "Items",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OptionalBoolField3Id",
                table: "Items",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OptionalNumberField1Id",
                table: "Items",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OptionalNumberField2Id",
                table: "Items",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OptionalNumberField3Id",
                table: "Items",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OptionalStringField1Id",
                table: "Items",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OptionalStringField2Id",
                table: "Items",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OptionalStringField3Id",
                table: "Items",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OptionalTextField1Id",
                table: "Items",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OptionalTextField2Id",
                table: "Items",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OptionalTextField3Id",
                table: "Items",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "FirstOptionalBoolFieldVisible",
                table: "Collections",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "FirstOptionalDataTimeFieldVisible",
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

            migrationBuilder.CreateIndex(
                name: "IX_Items_OptionalBoolField1Id",
                table: "Items",
                column: "OptionalBoolField1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Items_OptionalBoolField2Id",
                table: "Items",
                column: "OptionalBoolField2Id");

            migrationBuilder.CreateIndex(
                name: "IX_Items_OptionalBoolField3Id",
                table: "Items",
                column: "OptionalBoolField3Id");

            migrationBuilder.CreateIndex(
                name: "IX_Items_OptionalNumberField1Id",
                table: "Items",
                column: "OptionalNumberField1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Items_OptionalNumberField2Id",
                table: "Items",
                column: "OptionalNumberField2Id");

            migrationBuilder.CreateIndex(
                name: "IX_Items_OptionalNumberField3Id",
                table: "Items",
                column: "OptionalNumberField3Id");

            migrationBuilder.CreateIndex(
                name: "IX_Items_OptionalStringField1Id",
                table: "Items",
                column: "OptionalStringField1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Items_OptionalStringField2Id",
                table: "Items",
                column: "OptionalStringField2Id");

            migrationBuilder.CreateIndex(
                name: "IX_Items_OptionalStringField3Id",
                table: "Items",
                column: "OptionalStringField3Id");

            migrationBuilder.CreateIndex(
                name: "IX_Items_OptionalTextField1Id",
                table: "Items",
                column: "OptionalTextField1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Items_OptionalTextField2Id",
                table: "Items",
                column: "OptionalTextField2Id");

            migrationBuilder.CreateIndex(
                name: "IX_Items_OptionalTextField3Id",
                table: "Items",
                column: "OptionalTextField3Id");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropIndex(
                name: "IX_Items_OptionalBoolField1Id",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_OptionalBoolField2Id",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_OptionalBoolField3Id",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_OptionalNumberField1Id",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_OptionalNumberField2Id",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_OptionalNumberField3Id",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_OptionalStringField1Id",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_OptionalStringField2Id",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_OptionalStringField3Id",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_OptionalTextField1Id",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_OptionalTextField2Id",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_OptionalTextField3Id",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "OptionalBoolField1Id",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "OptionalBoolField2Id",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "OptionalBoolField3Id",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "OptionalNumberField1Id",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "OptionalNumberField2Id",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "OptionalNumberField3Id",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "OptionalStringField1Id",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "OptionalStringField2Id",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "OptionalStringField3Id",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "OptionalTextField1Id",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "OptionalTextField2Id",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "OptionalTextField3Id",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "FirstOptionalBoolFieldVisible",
                table: "Collections");

            migrationBuilder.DropColumn(
                name: "FirstOptionalDataTimeFieldVisible",
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

            migrationBuilder.AddColumn<int>(
                name: "ItemId",
                table: "OptionalTextField",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemId",
                table: "OptionalStringField",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemId",
                table: "OptionalNumberField",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemId",
                table: "OptionalBoolField",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "OptionalDateTimeField",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ItemId = table.Column<int>(type: "INTEGER", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Value = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OptionalDateTimeField", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OptionalDateTimeField_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OptionalTextField_ItemId",
                table: "OptionalTextField",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_OptionalStringField_ItemId",
                table: "OptionalStringField",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_OptionalNumberField_ItemId",
                table: "OptionalNumberField",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_OptionalBoolField_ItemId",
                table: "OptionalBoolField",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_OptionalDateTimeField_ItemId",
                table: "OptionalDateTimeField",
                column: "ItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_OptionalBoolField_Items_ItemId",
                table: "OptionalBoolField",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OptionalNumberField_Items_ItemId",
                table: "OptionalNumberField",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OptionalStringField_Items_ItemId",
                table: "OptionalStringField",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OptionalTextField_Items_ItemId",
                table: "OptionalTextField",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
