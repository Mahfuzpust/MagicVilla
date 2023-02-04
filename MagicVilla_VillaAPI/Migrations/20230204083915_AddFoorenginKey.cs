using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVillaVillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddFoorenginKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "VillaNumbers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 2, 4, 14, 39, 15, 235, DateTimeKind.Local).AddTicks(9734));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 2, 4, 14, 39, 15, 235, DateTimeKind.Local).AddTicks(9750));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 2, 4, 14, 39, 15, 235, DateTimeKind.Local).AddTicks(9751));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 2, 4, 14, 39, 15, 235, DateTimeKind.Local).AddTicks(9753));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2023, 2, 4, 14, 39, 15, 235, DateTimeKind.Local).AddTicks(9754));

            migrationBuilder.CreateIndex(
                name: "IX_VillaNumbers_Id",
                table: "VillaNumbers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_VillaNumbers_Villas_Id",
                table: "VillaNumbers",
                column: "Id",
                principalTable: "Villas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VillaNumbers_Villas_Id",
                table: "VillaNumbers");

            migrationBuilder.DropIndex(
                name: "IX_VillaNumbers_Id",
                table: "VillaNumbers");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "VillaNumbers");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 2, 4, 14, 27, 40, 619, DateTimeKind.Local).AddTicks(9184));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 2, 4, 14, 27, 40, 619, DateTimeKind.Local).AddTicks(9194));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 2, 4, 14, 27, 40, 619, DateTimeKind.Local).AddTicks(9195));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 2, 4, 14, 27, 40, 619, DateTimeKind.Local).AddTicks(9197));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2023, 2, 4, 14, 27, 40, 619, DateTimeKind.Local).AddTicks(9198));
        }
    }
}
