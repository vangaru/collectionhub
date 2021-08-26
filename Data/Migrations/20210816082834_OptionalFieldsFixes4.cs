using Microsoft.EntityFrameworkCore.Migrations;

namespace CollectionHub.Data.Migrations
{
    public partial class OptionalFieldsFixes4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "OptionalTextField3Id",
                table: "Items",
                newName: "ThirdOptionalTextFieldId");

            migrationBuilder.RenameColumn(
                name: "OptionalTextField2Id",
                table: "Items",
                newName: "ThirdOptionalStringFieldId");

            migrationBuilder.RenameColumn(
                name: "OptionalTextField1Id",
                table: "Items",
                newName: "ThirdOptionalNumberFieldId");

            migrationBuilder.RenameColumn(
                name: "OptionalStringField3Id",
                table: "Items",
                newName: "ThirdOptionalDateTimeFieldId");

            migrationBuilder.RenameColumn(
                name: "OptionalStringField2Id",
                table: "Items",
                newName: "ThirdOptionalBoolFieldId");

            migrationBuilder.RenameColumn(
                name: "OptionalStringField1Id",
                table: "Items",
                newName: "SecondOptionalTextFieldId");

            migrationBuilder.RenameColumn(
                name: "OptionalNumberField3Id",
                table: "Items",
                newName: "SecondOptionalStringFieldId");

            migrationBuilder.RenameColumn(
                name: "OptionalNumberField2Id",
                table: "Items",
                newName: "SecondOptionalNumberFieldId");

            migrationBuilder.RenameColumn(
                name: "OptionalNumberField1Id",
                table: "Items",
                newName: "SecondOptionalDateTimeFieldId");

            migrationBuilder.RenameColumn(
                name: "OptionalBoolField3Id",
                table: "Items",
                newName: "SecondOptionalBoolFieldId");

            migrationBuilder.RenameColumn(
                name: "OptionalBoolField2Id",
                table: "Items",
                newName: "FirstOptionalTextFieldId");

            migrationBuilder.RenameColumn(
                name: "OptionalBoolField1Id",
                table: "Items",
                newName: "FirstOptionalStringFieldId");

            migrationBuilder.RenameIndex(
                name: "IX_Items_OptionalTextField3Id",
                table: "Items",
                newName: "IX_Items_ThirdOptionalTextFieldId");

            migrationBuilder.RenameIndex(
                name: "IX_Items_OptionalTextField2Id",
                table: "Items",
                newName: "IX_Items_ThirdOptionalStringFieldId");

            migrationBuilder.RenameIndex(
                name: "IX_Items_OptionalTextField1Id",
                table: "Items",
                newName: "IX_Items_ThirdOptionalNumberFieldId");

            migrationBuilder.RenameIndex(
                name: "IX_Items_OptionalStringField3Id",
                table: "Items",
                newName: "IX_Items_ThirdOptionalDateTimeFieldId");

            migrationBuilder.RenameIndex(
                name: "IX_Items_OptionalStringField2Id",
                table: "Items",
                newName: "IX_Items_ThirdOptionalBoolFieldId");

            migrationBuilder.RenameIndex(
                name: "IX_Items_OptionalStringField1Id",
                table: "Items",
                newName: "IX_Items_SecondOptionalTextFieldId");

            migrationBuilder.RenameIndex(
                name: "IX_Items_OptionalNumberField3Id",
                table: "Items",
                newName: "IX_Items_SecondOptionalStringFieldId");

            migrationBuilder.RenameIndex(
                name: "IX_Items_OptionalNumberField2Id",
                table: "Items",
                newName: "IX_Items_SecondOptionalNumberFieldId");

            migrationBuilder.RenameIndex(
                name: "IX_Items_OptionalNumberField1Id",
                table: "Items",
                newName: "IX_Items_SecondOptionalDateTimeFieldId");

            migrationBuilder.RenameIndex(
                name: "IX_Items_OptionalBoolField3Id",
                table: "Items",
                newName: "IX_Items_SecondOptionalBoolFieldId");

            migrationBuilder.RenameIndex(
                name: "IX_Items_OptionalBoolField2Id",
                table: "Items",
                newName: "IX_Items_FirstOptionalTextFieldId");

            migrationBuilder.RenameIndex(
                name: "IX_Items_OptionalBoolField1Id",
                table: "Items",
                newName: "IX_Items_FirstOptionalStringFieldId");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropIndex(
                name: "IX_Items_FirstOptionalBoolFieldId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_FirstOptionalDateTimeFieldId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_FirstOptionalNumberFieldId",
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

            migrationBuilder.RenameColumn(
                name: "ThirdOptionalTextFieldId",
                table: "Items",
                newName: "OptionalTextField3Id");

            migrationBuilder.RenameColumn(
                name: "ThirdOptionalStringFieldId",
                table: "Items",
                newName: "OptionalTextField2Id");

            migrationBuilder.RenameColumn(
                name: "ThirdOptionalNumberFieldId",
                table: "Items",
                newName: "OptionalTextField1Id");

            migrationBuilder.RenameColumn(
                name: "ThirdOptionalDateTimeFieldId",
                table: "Items",
                newName: "OptionalStringField3Id");

            migrationBuilder.RenameColumn(
                name: "ThirdOptionalBoolFieldId",
                table: "Items",
                newName: "OptionalStringField2Id");

            migrationBuilder.RenameColumn(
                name: "SecondOptionalTextFieldId",
                table: "Items",
                newName: "OptionalStringField1Id");

            migrationBuilder.RenameColumn(
                name: "SecondOptionalStringFieldId",
                table: "Items",
                newName: "OptionalNumberField3Id");

            migrationBuilder.RenameColumn(
                name: "SecondOptionalNumberFieldId",
                table: "Items",
                newName: "OptionalNumberField2Id");

            migrationBuilder.RenameColumn(
                name: "SecondOptionalDateTimeFieldId",
                table: "Items",
                newName: "OptionalNumberField1Id");

            migrationBuilder.RenameColumn(
                name: "SecondOptionalBoolFieldId",
                table: "Items",
                newName: "OptionalBoolField3Id");

            migrationBuilder.RenameColumn(
                name: "FirstOptionalTextFieldId",
                table: "Items",
                newName: "OptionalBoolField2Id");

            migrationBuilder.RenameColumn(
                name: "FirstOptionalStringFieldId",
                table: "Items",
                newName: "OptionalBoolField1Id");

            migrationBuilder.RenameIndex(
                name: "IX_Items_ThirdOptionalTextFieldId",
                table: "Items",
                newName: "IX_Items_OptionalTextField3Id");

            migrationBuilder.RenameIndex(
                name: "IX_Items_ThirdOptionalStringFieldId",
                table: "Items",
                newName: "IX_Items_OptionalTextField2Id");

            migrationBuilder.RenameIndex(
                name: "IX_Items_ThirdOptionalNumberFieldId",
                table: "Items",
                newName: "IX_Items_OptionalTextField1Id");

            migrationBuilder.RenameIndex(
                name: "IX_Items_ThirdOptionalDateTimeFieldId",
                table: "Items",
                newName: "IX_Items_OptionalStringField3Id");

            migrationBuilder.RenameIndex(
                name: "IX_Items_ThirdOptionalBoolFieldId",
                table: "Items",
                newName: "IX_Items_OptionalStringField2Id");

            migrationBuilder.RenameIndex(
                name: "IX_Items_SecondOptionalTextFieldId",
                table: "Items",
                newName: "IX_Items_OptionalStringField1Id");

            migrationBuilder.RenameIndex(
                name: "IX_Items_SecondOptionalStringFieldId",
                table: "Items",
                newName: "IX_Items_OptionalNumberField3Id");

            migrationBuilder.RenameIndex(
                name: "IX_Items_SecondOptionalNumberFieldId",
                table: "Items",
                newName: "IX_Items_OptionalNumberField2Id");

            migrationBuilder.RenameIndex(
                name: "IX_Items_SecondOptionalDateTimeFieldId",
                table: "Items",
                newName: "IX_Items_OptionalNumberField1Id");

            migrationBuilder.RenameIndex(
                name: "IX_Items_SecondOptionalBoolFieldId",
                table: "Items",
                newName: "IX_Items_OptionalBoolField3Id");

            migrationBuilder.RenameIndex(
                name: "IX_Items_FirstOptionalTextFieldId",
                table: "Items",
                newName: "IX_Items_OptionalBoolField2Id");

            migrationBuilder.RenameIndex(
                name: "IX_Items_FirstOptionalStringFieldId",
                table: "Items",
                newName: "IX_Items_OptionalBoolField1Id");

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
    }
}
