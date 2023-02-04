using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVillaVillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class ADDVilllaNumber : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VillaNumbers_Villas_Id",
                table: "VillaNumbers");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "VillaNumbers",
                newName: "VillaID");

            migrationBuilder.RenameIndex(
                name: "IX_VillaNumbers_Id",
                table: "VillaNumbers",
                newName: "IX_VillaNumbers_VillaID");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 2, 4, 14, 43, 22, 562, DateTimeKind.Local).AddTicks(2341));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 2, 4, 14, 43, 22, 562, DateTimeKind.Local).AddTicks(2350));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 2, 4, 14, 43, 22, 562, DateTimeKind.Local).AddTicks(2352));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 2, 4, 14, 43, 22, 562, DateTimeKind.Local).AddTicks(2354));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2023, 2, 4, 14, 43, 22, 562, DateTimeKind.Local).AddTicks(2355));

            migrationBuilder.AddForeignKey(
                name: "FK_VillaNumbers_Villas_VillaID",
                table: "VillaNumbers",
                column: "VillaID",
                principalTable: "Villas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VillaNumbers_Villas_VillaID",
                table: "VillaNumbers");

            migrationBuilder.RenameColumn(
                name: "VillaID",
                table: "VillaNumbers",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_VillaNumbers_VillaID",
                table: "VillaNumbers",
                newName: "IX_VillaNumbers_Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_VillaNumbers_Villas_Id",
                table: "VillaNumbers",
                column: "Id",
                principalTable: "Villas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
