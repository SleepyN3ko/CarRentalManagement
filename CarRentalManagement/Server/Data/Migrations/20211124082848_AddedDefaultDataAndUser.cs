using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedDefaultDataAndUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "0fddb557-db76-436b-a01b-56e51cba0abc", "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "a7262f09-f291-4cd9-8bbd-437fb7055dbb", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "3a80a524-0e49-4b85-949d-d2193ed133b7", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN", "AQAAAAEAACcQAAAAEIvF6C2S8BDQgRWJyRFpe4N81IZvwKh+qOIiYDSHtOijteYDTMJBgGAf0rXQwh3TZw==", null, false, "eba96c9c-2df4-4d7f-8a9c-dbcf1dc8c5db", false, "Admin" });

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 11, 24, 16, 28, 48, 278, DateTimeKind.Local).AddTicks(709), new DateTime(2021, 11, 24, 16, 28, 48, 278, DateTimeKind.Local).AddTicks(7320), "Black", "System" },
                    { 2, "System", new DateTime(2021, 11, 24, 16, 28, 48, 278, DateTimeKind.Local).AddTicks(7932), new DateTime(2021, 11, 24, 16, 28, 48, 278, DateTimeKind.Local).AddTicks(7935), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 11, 24, 16, 28, 48, 279, DateTimeKind.Local).AddTicks(7361), new DateTime(2021, 11, 24, 16, 28, 48, 279, DateTimeKind.Local).AddTicks(7371), "BMW", "System" },
                    { 2, "System", new DateTime(2021, 11, 24, 16, 28, 48, 279, DateTimeKind.Local).AddTicks(7374), new DateTime(2021, 11, 24, 16, 28, 48, 279, DateTimeKind.Local).AddTicks(7375), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 11, 24, 16, 28, 48, 280, DateTimeKind.Local).AddTicks(25), new DateTime(2021, 11, 24, 16, 28, 48, 280, DateTimeKind.Local).AddTicks(30), "3 Series", "System" },
                    { 2, "System", new DateTime(2021, 11, 24, 16, 28, 48, 280, DateTimeKind.Local).AddTicks(33), new DateTime(2021, 11, 24, 16, 28, 48, 280, DateTimeKind.Local).AddTicks(34), "X5", "System" },
                    { 3, "System", new DateTime(2021, 11, 24, 16, 28, 48, 280, DateTimeKind.Local).AddTicks(35), new DateTime(2021, 11, 24, 16, 28, 48, 280, DateTimeKind.Local).AddTicks(36), "Prius", "System" },
                    { 4, "System", new DateTime(2021, 11, 24, 16, 28, 48, 280, DateTimeKind.Local).AddTicks(37), new DateTime(2021, 11, 24, 16, 28, 48, 280, DateTimeKind.Local).AddTicks(38), "Rav4", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");
        }
    }
}
