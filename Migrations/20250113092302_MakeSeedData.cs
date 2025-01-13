using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class MakeSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 13, 17, 23, 2, 84, DateTimeKind.Local).AddTicks(4451), new DateTime(2025, 1, 13, 17, 23, 2, 84, DateTimeKind.Local).AddTicks(4465) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 13, 17, 23, 2, 84, DateTimeKind.Local).AddTicks(4468), new DateTime(2025, 1, 13, 17, 23, 2, 84, DateTimeKind.Local).AddTicks(4469) });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 1, 13, 17, 23, 2, 84, DateTimeKind.Local).AddTicks(4749), new DateTime(2025, 1, 13, 17, 23, 2, 84, DateTimeKind.Local).AddTicks(4750), "BMW", "System" },
                    { 2, "System", new DateTime(2025, 1, 13, 17, 23, 2, 84, DateTimeKind.Local).AddTicks(4753), new DateTime(2025, 1, 13, 17, 23, 2, 84, DateTimeKind.Local).AddTicks(4753), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 1, 13, 17, 23, 2, 84, DateTimeKind.Local).AddTicks(4846), new DateTime(2025, 1, 13, 17, 23, 2, 84, DateTimeKind.Local).AddTicks(4847), "i4", "System" },
                    { 2, "System", new DateTime(2025, 1, 13, 17, 23, 2, 84, DateTimeKind.Local).AddTicks(4850), new DateTime(2025, 1, 13, 17, 23, 2, 84, DateTimeKind.Local).AddTicks(4851), "X5", "System" },
                    { 3, "System", new DateTime(2025, 1, 13, 17, 23, 2, 84, DateTimeKind.Local).AddTicks(4853), new DateTime(2025, 1, 13, 17, 23, 2, 84, DateTimeKind.Local).AddTicks(4854), "Prius", "System" },
                    { 4, "System", new DateTime(2025, 1, 13, 17, 23, 2, 84, DateTimeKind.Local).AddTicks(4855), new DateTime(2025, 1, 13, 17, 23, 2, 84, DateTimeKind.Local).AddTicks(4856), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 13, 17, 6, 18, 534, DateTimeKind.Local).AddTicks(2093), new DateTime(2025, 1, 13, 17, 6, 18, 534, DateTimeKind.Local).AddTicks(2102) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 13, 17, 6, 18, 534, DateTimeKind.Local).AddTicks(2104), new DateTime(2025, 1, 13, 17, 6, 18, 534, DateTimeKind.Local).AddTicks(2104) });
        }
    }
}
