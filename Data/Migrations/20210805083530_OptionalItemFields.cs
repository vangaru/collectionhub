using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CollectionHub.Data.Migrations
{
    public partial class OptionalItemFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Theme",
                table: "Collections",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "OptionalBoolField",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Value = table.Column<bool>(type: "INTEGER", nullable: false),
                    ItemId = table.Column<int>(type: "INTEGER", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OptionalBoolField", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OptionalBoolField_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OptionalDateTimeField",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Value = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ItemId = table.Column<int>(type: "INTEGER", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
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

            migrationBuilder.CreateTable(
                name: "OptionalNumberField",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Value = table.Column<double>(type: "REAL", nullable: false),
                    ItemId = table.Column<int>(type: "INTEGER", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OptionalNumberField", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OptionalNumberField_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OptionalStringField",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Value = table.Column<string>(type: "TEXT", nullable: true),
                    ItemId = table.Column<int>(type: "INTEGER", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OptionalStringField", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OptionalStringField_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OptionalTextField",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Value = table.Column<string>(type: "TEXT", nullable: true),
                    ItemId = table.Column<int>(type: "INTEGER", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OptionalTextField", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OptionalTextField_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OptionalBoolField_ItemId",
                table: "OptionalBoolField",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_OptionalDateTimeField_ItemId",
                table: "OptionalDateTimeField",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_OptionalNumberField_ItemId",
                table: "OptionalNumberField",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_OptionalStringField_ItemId",
                table: "OptionalStringField",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_OptionalTextField_ItemId",
                table: "OptionalTextField",
                column: "ItemId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OptionalBoolField");

            migrationBuilder.DropTable(
                name: "OptionalDateTimeField");

            migrationBuilder.DropTable(
                name: "OptionalNumberField");

            migrationBuilder.DropTable(
                name: "OptionalStringField");

            migrationBuilder.DropTable(
                name: "OptionalTextField");

            migrationBuilder.DropColumn(
                name: "Theme",
                table: "Collections");
        }
    }
}
