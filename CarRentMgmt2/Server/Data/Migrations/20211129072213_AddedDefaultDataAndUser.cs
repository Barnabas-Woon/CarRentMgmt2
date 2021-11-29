using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentMgmt2.Server.Data.Migrations
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
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "ce78d257-6dcb-4e82-957f-51a893e6dcf0", "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "5a6029e1-c773-4e4a-b0a2-ddb2f71e92f5", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "34bcd68b-c963-4c1f-9636-afa3dce93145", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN", "AQAAAAEAACcQAAAAEJb5PldN4WQiot8Ygc97MK0T494K4pXTqiPbeb6/YF8B7uxv3YsQJyiLyCbXn26c0g==", null, false, "d84a2d47-6466-47d7-86cd-fe0991510b7c", false, "Admin" });

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 11, 29, 15, 22, 12, 639, DateTimeKind.Local).AddTicks(4460), new DateTime(2021, 11, 29, 15, 22, 12, 640, DateTimeKind.Local).AddTicks(1739), "Black", "System" },
                    { 2, "System", new DateTime(2021, 11, 29, 15, 22, 12, 640, DateTimeKind.Local).AddTicks(2293), new DateTime(2021, 11, 29, 15, 22, 12, 640, DateTimeKind.Local).AddTicks(2296), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 11, 29, 15, 22, 12, 641, DateTimeKind.Local).AddTicks(1503), new DateTime(2021, 11, 29, 15, 22, 12, 641, DateTimeKind.Local).AddTicks(1512), "BMW", "System" },
                    { 2, "System", new DateTime(2021, 11, 29, 15, 22, 12, 641, DateTimeKind.Local).AddTicks(1514), new DateTime(2021, 11, 29, 15, 22, 12, 641, DateTimeKind.Local).AddTicks(1515), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 11, 29, 15, 22, 12, 641, DateTimeKind.Local).AddTicks(3996), new DateTime(2021, 11, 29, 15, 22, 12, 641, DateTimeKind.Local).AddTicks(4002), "3 Series", "System" },
                    { 2, "System", new DateTime(2021, 11, 29, 15, 22, 12, 641, DateTimeKind.Local).AddTicks(4004), new DateTime(2021, 11, 29, 15, 22, 12, 641, DateTimeKind.Local).AddTicks(4004), "X5", "System" },
                    { 3, "System", new DateTime(2021, 11, 29, 15, 22, 12, 641, DateTimeKind.Local).AddTicks(4006), new DateTime(2021, 11, 29, 15, 22, 12, 641, DateTimeKind.Local).AddTicks(4007), "Prius", "System" },
                    { 4, "System", new DateTime(2021, 11, 29, 15, 22, 12, 641, DateTimeKind.Local).AddTicks(4008), new DateTime(2021, 11, 29, 15, 22, 12, 641, DateTimeKind.Local).AddTicks(4008), "Rav4", "System" }
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
