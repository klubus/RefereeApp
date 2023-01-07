using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RefereeApp.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "10130992-e553-46e7-84c4-3a28eefb28fe");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "adf997c8-28f8-4104-b7b8-6b7b9e651afc");

            migrationBuilder.RenameColumn(
                name: "DateOfInvoice",
                table: "Finances",
                newName: "DateOfInvoices");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1a846d4d-986f-4939-ba2a-b8d5031c9d06", "ef80fef9-24db-4be8-8469-d648948f557e", "Admin", null });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "89a11624-fd02-42dc-83d3-bd379c7877f6", "9fb96b13-c184-43c0-ad31-6d77e0041d78", "Referee", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1a846d4d-986f-4939-ba2a-b8d5031c9d06");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "89a11624-fd02-42dc-83d3-bd379c7877f6");

            migrationBuilder.RenameColumn(
                name: "DateOfInvoices",
                table: "Finances",
                newName: "DateOfInvoice");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "10130992-e553-46e7-84c4-3a28eefb28fe", "8e35106f-9f7c-4441-ab33-5c3e8b536752", "Referee", null });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "adf997c8-28f8-4104-b7b8-6b7b9e651afc", "ccd585ce-81d8-499f-badc-1744893a1d13", "Admin", null });
        }
    }
}
