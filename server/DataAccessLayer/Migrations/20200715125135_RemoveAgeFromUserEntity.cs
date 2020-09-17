using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class RemoveAgeFromUserEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Deadline" },
                values: new object[] { new DateTime(2020, 7, 6, 15, 51, 35, 360, DateTimeKind.Local).AddTicks(52), new DateTime(2020, 7, 20, 15, 51, 35, 360, DateTimeKind.Local).AddTicks(539) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Deadline" },
                values: new object[] { new DateTime(2020, 7, 14, 15, 51, 35, 360, DateTimeKind.Local).AddTicks(1669), new DateTime(2020, 9, 3, 15, 51, 35, 360, DateTimeKind.Local).AddTicks(1688) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Deadline" },
                values: new object[] { new DateTime(2020, 6, 22, 15, 51, 35, 360, DateTimeKind.Local).AddTicks(1713), new DateTime(2020, 7, 26, 15, 51, 35, 360, DateTimeKind.Local).AddTicks(1716) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Deadline" },
                values: new object[] { new DateTime(2020, 7, 4, 15, 51, 35, 360, DateTimeKind.Local).AddTicks(1719), new DateTime(2020, 7, 23, 15, 51, 35, 360, DateTimeKind.Local).AddTicks(1722) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Deadline" },
                values: new object[] { new DateTime(2020, 7, 6, 15, 51, 35, 360, DateTimeKind.Local).AddTicks(1726), new DateTime(2020, 7, 22, 15, 51, 35, 360, DateTimeKind.Local).AddTicks(1728) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Deadline" },
                values: new object[] { new DateTime(2020, 7, 6, 15, 51, 35, 360, DateTimeKind.Local).AddTicks(1732), new DateTime(2020, 7, 18, 15, 51, 35, 360, DateTimeKind.Local).AddTicks(1735) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Deadline" },
                values: new object[] { new DateTime(2020, 7, 15, 15, 51, 35, 360, DateTimeKind.Local).AddTicks(1738), new DateTime(2020, 7, 24, 15, 51, 35, 360, DateTimeKind.Local).AddTicks(1741) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Deadline" },
                values: new object[] { new DateTime(2020, 7, 7, 15, 51, 35, 360, DateTimeKind.Local).AddTicks(1745), new DateTime(2020, 7, 16, 15, 51, 35, 360, DateTimeKind.Local).AddTicks(1748) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Deadline" },
                values: new object[] { new DateTime(2020, 7, 3, 15, 51, 35, 360, DateTimeKind.Local).AddTicks(1751), new DateTime(2020, 8, 5, 15, 51, 35, 360, DateTimeKind.Local).AddTicks(1754) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Deadline" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 51, 35, 360, DateTimeKind.Local).AddTicks(1757), new DateTime(2020, 7, 17, 15, 51, 35, 360, DateTimeKind.Local).AddTicks(1760) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "Deadline" },
                values: new object[] { new DateTime(2020, 7, 3, 15, 51, 35, 360, DateTimeKind.Local).AddTicks(1763), new DateTime(2020, 7, 18, 15, 51, 35, 360, DateTimeKind.Local).AddTicks(1766) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "Deadline" },
                values: new object[] { new DateTime(2020, 7, 10, 15, 51, 35, 360, DateTimeKind.Local).AddTicks(1770), new DateTime(2020, 7, 20, 15, 51, 35, 360, DateTimeKind.Local).AddTicks(1772) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "Deadline" },
                values: new object[] { new DateTime(2020, 7, 12, 15, 51, 35, 360, DateTimeKind.Local).AddTicks(1776), new DateTime(2020, 7, 22, 15, 51, 35, 360, DateTimeKind.Local).AddTicks(1779) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "Deadline" },
                values: new object[] { new DateTime(2020, 7, 7, 15, 51, 35, 360, DateTimeKind.Local).AddTicks(1782), new DateTime(2020, 7, 28, 15, 51, 35, 360, DateTimeKind.Local).AddTicks(1785) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "Deadline" },
                values: new object[] { new DateTime(2020, 7, 10, 15, 51, 35, 360, DateTimeKind.Local).AddTicks(1788), new DateTime(2020, 7, 20, 15, 51, 35, 360, DateTimeKind.Local).AddTicks(1791) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "FinishedAt" },
                values: new object[] { new DateTime(2020, 7, 5, 15, 51, 35, 360, DateTimeKind.Local).AddTicks(4879), new DateTime(2020, 7, 10, 15, 51, 35, 360, DateTimeKind.Local).AddTicks(5262) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "FinishedAt" },
                values: new object[] { new DateTime(2020, 7, 4, 15, 51, 35, 360, DateTimeKind.Local).AddTicks(6554), new DateTime(2020, 7, 15, 15, 51, 35, 360, DateTimeKind.Local).AddTicks(6578) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "FinishedAt" },
                values: new object[] { new DateTime(2020, 6, 30, 15, 51, 35, 360, DateTimeKind.Local).AddTicks(6606), new DateTime(2020, 7, 13, 15, 51, 35, 360, DateTimeKind.Local).AddTicks(6609) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "FinishedAt" },
                values: new object[] { new DateTime(2020, 7, 2, 15, 51, 35, 360, DateTimeKind.Local).AddTicks(6612), new DateTime(2020, 7, 12, 15, 51, 35, 360, DateTimeKind.Local).AddTicks(6615) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "FinishedAt" },
                values: new object[] { new DateTime(2020, 7, 6, 15, 51, 35, 360, DateTimeKind.Local).AddTicks(6619), new DateTime(2020, 7, 11, 15, 51, 35, 360, DateTimeKind.Local).AddTicks(6621) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "FinishedAt" },
                values: new object[] { new DateTime(2020, 7, 10, 15, 51, 35, 360, DateTimeKind.Local).AddTicks(6625), new DateTime(2020, 7, 14, 15, 51, 35, 360, DateTimeKind.Local).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "FinishedAt" },
                values: new object[] { new DateTime(2020, 6, 29, 15, 51, 35, 360, DateTimeKind.Local).AddTicks(6631), new DateTime(2020, 7, 11, 15, 51, 35, 360, DateTimeKind.Local).AddTicks(6634) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "FinishedAt" },
                values: new object[] { new DateTime(2020, 7, 12, 15, 51, 35, 360, DateTimeKind.Local).AddTicks(6637), new DateTime(2020, 7, 14, 15, 51, 35, 360, DateTimeKind.Local).AddTicks(6639) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "FinishedAt" },
                values: new object[] { new DateTime(2020, 7, 8, 15, 51, 35, 360, DateTimeKind.Local).AddTicks(6642), new DateTime(2020, 7, 14, 15, 51, 35, 360, DateTimeKind.Local).AddTicks(6645) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "FinishedAt" },
                values: new object[] { new DateTime(2020, 7, 11, 15, 51, 35, 360, DateTimeKind.Local).AddTicks(6679), new DateTime(2020, 7, 12, 15, 51, 35, 360, DateTimeKind.Local).AddTicks(6682) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "FinishedAt" },
                values: new object[] { new DateTime(2020, 7, 8, 15, 51, 35, 360, DateTimeKind.Local).AddTicks(6685), new DateTime(2020, 7, 12, 15, 51, 35, 360, DateTimeKind.Local).AddTicks(6688) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "FinishedAt" },
                values: new object[] { new DateTime(2020, 7, 9, 15, 51, 35, 360, DateTimeKind.Local).AddTicks(6691), new DateTime(2020, 7, 10, 15, 51, 35, 360, DateTimeKind.Local).AddTicks(6694) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "FinishedAt" },
                values: new object[] { new DateTime(2020, 7, 5, 15, 51, 35, 360, DateTimeKind.Local).AddTicks(6697), new DateTime(2020, 7, 10, 15, 51, 35, 360, DateTimeKind.Local).AddTicks(6700) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "FinishedAt" },
                values: new object[] { new DateTime(2020, 7, 1, 15, 51, 35, 360, DateTimeKind.Local).AddTicks(6703), new DateTime(2020, 7, 8, 15, 51, 35, 360, DateTimeKind.Local).AddTicks(6705) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "FinishedAt" },
                values: new object[] { new DateTime(2020, 7, 6, 15, 51, 35, 360, DateTimeKind.Local).AddTicks(6709), new DateTime(2020, 7, 14, 15, 51, 35, 360, DateTimeKind.Local).AddTicks(6711) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 25, 15, 51, 35, 356, DateTimeKind.Local).AddTicks(220));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 11, 15, 51, 35, 358, DateTimeKind.Local).AddTicks(4230));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 5, 31, 15, 51, 35, 358, DateTimeKind.Local).AddTicks(4269));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 24, 15, 51, 35, 358, DateTimeKind.Local).AddTicks(4274));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 18, 15, 51, 35, 358, DateTimeKind.Local).AddTicks(4277));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 15, 51, 35, 358, DateTimeKind.Local).AddTicks(4280));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 2, 15, 51, 35, 358, DateTimeKind.Local).AddTicks(4283));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 6, 15, 51, 35, 358, DateTimeKind.Local).AddTicks(4286));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 11, 15, 51, 35, 358, DateTimeKind.Local).AddTicks(4289));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 9, 15, 51, 35, 358, DateTimeKind.Local).AddTicks(4292));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Birthday", "RegisteredAt" },
                values: new object[] { new DateTime(1993, 2, 27, 15, 51, 35, 359, DateTimeKind.Local).AddTicks(7291), new DateTime(2020, 6, 5, 15, 51, 35, 359, DateTimeKind.Local).AddTicks(6882) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Birthday", "RegisteredAt" },
                values: new object[] { new DateTime(1994, 7, 12, 15, 51, 35, 359, DateTimeKind.Local).AddTicks(8081), new DateTime(2020, 5, 9, 15, 51, 35, 359, DateTimeKind.Local).AddTicks(8055) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Birthday", "RegisteredAt" },
                values: new object[] { new DateTime(1986, 4, 25, 15, 51, 35, 359, DateTimeKind.Local).AddTicks(8101), new DateTime(2020, 7, 1, 15, 51, 35, 359, DateTimeKind.Local).AddTicks(8098) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Birthday", "RegisteredAt" },
                values: new object[] { new DateTime(1998, 8, 20, 15, 51, 35, 359, DateTimeKind.Local).AddTicks(8108), new DateTime(2020, 6, 12, 15, 51, 35, 359, DateTimeKind.Local).AddTicks(8105) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Birthday", "RegisteredAt" },
                values: new object[] { new DateTime(1993, 2, 27, 15, 51, 35, 359, DateTimeKind.Local).AddTicks(8114), new DateTime(2020, 5, 30, 15, 51, 35, 359, DateTimeKind.Local).AddTicks(8111) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Birthday", "RegisteredAt" },
                values: new object[] { new DateTime(2000, 1, 2, 15, 51, 35, 359, DateTimeKind.Local).AddTicks(8120), new DateTime(2020, 6, 10, 15, 51, 35, 359, DateTimeKind.Local).AddTicks(8117) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Birthday", "RegisteredAt" },
                values: new object[] { new DateTime(1993, 9, 15, 15, 51, 35, 359, DateTimeKind.Local).AddTicks(8126), new DateTime(2020, 6, 22, 15, 51, 35, 359, DateTimeKind.Local).AddTicks(8123) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Birthday", "RegisteredAt" },
                values: new object[] { new DateTime(1995, 11, 24, 15, 51, 35, 359, DateTimeKind.Local).AddTicks(8132), new DateTime(2020, 4, 28, 15, 51, 35, 359, DateTimeKind.Local).AddTicks(8129) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Birthday", "RegisteredAt" },
                values: new object[] { new DateTime(1982, 3, 17, 15, 51, 35, 359, DateTimeKind.Local).AddTicks(8138), new DateTime(2020, 5, 24, 15, 51, 35, 359, DateTimeKind.Local).AddTicks(8135) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Birthday", "RegisteredAt" },
                values: new object[] { new DateTime(1989, 8, 7, 15, 51, 35, 359, DateTimeKind.Local).AddTicks(8144), new DateTime(2020, 7, 3, 15, 51, 35, 359, DateTimeKind.Local).AddTicks(8142) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Birthday", "RegisteredAt" },
                values: new object[] { new DateTime(2001, 5, 16, 15, 51, 35, 359, DateTimeKind.Local).AddTicks(8150), new DateTime(2020, 6, 8, 15, 51, 35, 359, DateTimeKind.Local).AddTicks(8147) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Birthday", "RegisteredAt" },
                values: new object[] { new DateTime(1993, 11, 24, 15, 51, 35, 359, DateTimeKind.Local).AddTicks(8156), new DateTime(2020, 6, 14, 15, 51, 35, 359, DateTimeKind.Local).AddTicks(8153) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Birthday", "RegisteredAt" },
                values: new object[] { new DateTime(1993, 2, 27, 15, 51, 35, 359, DateTimeKind.Local).AddTicks(8163), new DateTime(2020, 5, 3, 15, 51, 35, 359, DateTimeKind.Local).AddTicks(8160) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Birthday", "RegisteredAt" },
                values: new object[] { new DateTime(1993, 9, 15, 15, 51, 35, 359, DateTimeKind.Local).AddTicks(8169), new DateTime(2020, 6, 24, 15, 51, 35, 359, DateTimeKind.Local).AddTicks(8167) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Birthday", "RegisteredAt" },
                values: new object[] { new DateTime(1984, 12, 11, 15, 51, 35, 359, DateTimeKind.Local).AddTicks(8175), new DateTime(2020, 6, 5, 15, 51, 35, 359, DateTimeKind.Local).AddTicks(8172) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Deadline" },
                values: new object[] { new DateTime(2020, 7, 6, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(1540), new DateTime(2020, 7, 20, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(1905) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Deadline" },
                values: new object[] { new DateTime(2020, 7, 14, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(2931), new DateTime(2020, 9, 3, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(2948) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Deadline" },
                values: new object[] { new DateTime(2020, 6, 22, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(2969), new DateTime(2020, 7, 26, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(2972) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Deadline" },
                values: new object[] { new DateTime(2020, 7, 4, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(2976), new DateTime(2020, 7, 23, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(2978) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Deadline" },
                values: new object[] { new DateTime(2020, 7, 6, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(2982), new DateTime(2020, 7, 22, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(2985) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Deadline" },
                values: new object[] { new DateTime(2020, 7, 6, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(2988), new DateTime(2020, 7, 18, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(2991) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Deadline" },
                values: new object[] { new DateTime(2020, 7, 15, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(2994), new DateTime(2020, 7, 24, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(2996) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Deadline" },
                values: new object[] { new DateTime(2020, 7, 7, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(3000), new DateTime(2020, 7, 16, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(3003) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Deadline" },
                values: new object[] { new DateTime(2020, 7, 3, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(3006), new DateTime(2020, 8, 5, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(3008) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Deadline" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(3012), new DateTime(2020, 7, 17, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(3014) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "Deadline" },
                values: new object[] { new DateTime(2020, 7, 3, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(3017), new DateTime(2020, 7, 18, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(3020) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "Deadline" },
                values: new object[] { new DateTime(2020, 7, 10, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(3023), new DateTime(2020, 7, 20, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(3026) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "Deadline" },
                values: new object[] { new DateTime(2020, 7, 12, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(3029), new DateTime(2020, 7, 22, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(3032) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "Deadline" },
                values: new object[] { new DateTime(2020, 7, 7, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(3035), new DateTime(2020, 7, 28, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(3038) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "Deadline" },
                values: new object[] { new DateTime(2020, 7, 10, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(3042), new DateTime(2020, 7, 20, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(3044) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "FinishedAt" },
                values: new object[] { new DateTime(2020, 7, 5, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(6106), new DateTime(2020, 7, 10, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(6629) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "FinishedAt" },
                values: new object[] { new DateTime(2020, 7, 4, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(7913), new DateTime(2020, 7, 15, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(7933) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "FinishedAt" },
                values: new object[] { new DateTime(2020, 6, 30, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(7958), new DateTime(2020, 7, 13, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(7961) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "FinishedAt" },
                values: new object[] { new DateTime(2020, 7, 2, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(7965), new DateTime(2020, 7, 12, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(7967) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "FinishedAt" },
                values: new object[] { new DateTime(2020, 7, 6, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(7971), new DateTime(2020, 7, 11, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(7974) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "FinishedAt" },
                values: new object[] { new DateTime(2020, 7, 10, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(7977), new DateTime(2020, 7, 14, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(7979) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "FinishedAt" },
                values: new object[] { new DateTime(2020, 6, 29, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(7983), new DateTime(2020, 7, 11, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(7986) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "FinishedAt" },
                values: new object[] { new DateTime(2020, 7, 12, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(7989), new DateTime(2020, 7, 14, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(7992) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "FinishedAt" },
                values: new object[] { new DateTime(2020, 7, 8, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(7995), new DateTime(2020, 7, 14, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(7998) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "FinishedAt" },
                values: new object[] { new DateTime(2020, 7, 11, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(8001), new DateTime(2020, 7, 12, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(8003) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "FinishedAt" },
                values: new object[] { new DateTime(2020, 7, 8, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(8007), new DateTime(2020, 7, 12, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(8010) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "FinishedAt" },
                values: new object[] { new DateTime(2020, 7, 9, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(8013), new DateTime(2020, 7, 10, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(8016) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "FinishedAt" },
                values: new object[] { new DateTime(2020, 7, 5, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(8019), new DateTime(2020, 7, 10, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(8022) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "FinishedAt" },
                values: new object[] { new DateTime(2020, 7, 1, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(8025), new DateTime(2020, 7, 8, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(8027) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "FinishedAt" },
                values: new object[] { new DateTime(2020, 7, 6, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(8031), new DateTime(2020, 7, 14, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 25, 15, 50, 22, 253, DateTimeKind.Local).AddTicks(5252));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 11, 15, 50, 22, 255, DateTimeKind.Local).AddTicks(5686));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 5, 31, 15, 50, 22, 255, DateTimeKind.Local).AddTicks(5722));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 24, 15, 50, 22, 255, DateTimeKind.Local).AddTicks(5728));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 18, 15, 50, 22, 255, DateTimeKind.Local).AddTicks(5732));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 15, 50, 22, 255, DateTimeKind.Local).AddTicks(5735));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 2, 15, 50, 22, 255, DateTimeKind.Local).AddTicks(5738));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 6, 15, 50, 22, 255, DateTimeKind.Local).AddTicks(5741));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 11, 15, 50, 22, 255, DateTimeKind.Local).AddTicks(5744));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 9, 15, 50, 22, 255, DateTimeKind.Local).AddTicks(5747));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Birthday", "RegisteredAt" },
                values: new object[] { new DateTime(1993, 2, 27, 15, 50, 22, 256, DateTimeKind.Local).AddTicks(8874), new DateTime(2020, 6, 5, 15, 50, 22, 256, DateTimeKind.Local).AddTicks(8435) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Birthday", "RegisteredAt" },
                values: new object[] { new DateTime(1994, 7, 12, 15, 50, 22, 256, DateTimeKind.Local).AddTicks(9813), new DateTime(2020, 5, 9, 15, 50, 22, 256, DateTimeKind.Local).AddTicks(9789) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Birthday", "RegisteredAt" },
                values: new object[] { new DateTime(1986, 4, 25, 15, 50, 22, 256, DateTimeKind.Local).AddTicks(9834), new DateTime(2020, 7, 1, 15, 50, 22, 256, DateTimeKind.Local).AddTicks(9831) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Birthday", "RegisteredAt" },
                values: new object[] { new DateTime(1998, 8, 20, 15, 50, 22, 256, DateTimeKind.Local).AddTicks(9841), new DateTime(2020, 6, 12, 15, 50, 22, 256, DateTimeKind.Local).AddTicks(9837) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Birthday", "RegisteredAt" },
                values: new object[] { new DateTime(1993, 2, 27, 15, 50, 22, 256, DateTimeKind.Local).AddTicks(9846), new DateTime(2020, 5, 30, 15, 50, 22, 256, DateTimeKind.Local).AddTicks(9844) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Birthday", "RegisteredAt" },
                values: new object[] { new DateTime(2000, 1, 2, 15, 50, 22, 256, DateTimeKind.Local).AddTicks(9852), new DateTime(2020, 6, 10, 15, 50, 22, 256, DateTimeKind.Local).AddTicks(9850) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Birthday", "RegisteredAt" },
                values: new object[] { new DateTime(1993, 9, 15, 15, 50, 22, 256, DateTimeKind.Local).AddTicks(9858), new DateTime(2020, 6, 22, 15, 50, 22, 256, DateTimeKind.Local).AddTicks(9856) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Birthday", "RegisteredAt" },
                values: new object[] { new DateTime(1995, 11, 24, 15, 50, 22, 256, DateTimeKind.Local).AddTicks(9864), new DateTime(2020, 4, 28, 15, 50, 22, 256, DateTimeKind.Local).AddTicks(9862) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Birthday", "RegisteredAt" },
                values: new object[] { new DateTime(1982, 3, 17, 15, 50, 22, 256, DateTimeKind.Local).AddTicks(9870), new DateTime(2020, 5, 24, 15, 50, 22, 256, DateTimeKind.Local).AddTicks(9867) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Birthday", "RegisteredAt" },
                values: new object[] { new DateTime(1989, 8, 7, 15, 50, 22, 256, DateTimeKind.Local).AddTicks(9876), new DateTime(2020, 7, 3, 15, 50, 22, 256, DateTimeKind.Local).AddTicks(9873) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Birthday", "RegisteredAt" },
                values: new object[] { new DateTime(2001, 5, 16, 15, 50, 22, 256, DateTimeKind.Local).AddTicks(9882), new DateTime(2020, 6, 8, 15, 50, 22, 256, DateTimeKind.Local).AddTicks(9879) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Birthday", "RegisteredAt" },
                values: new object[] { new DateTime(1993, 11, 24, 15, 50, 22, 256, DateTimeKind.Local).AddTicks(9887), new DateTime(2020, 6, 14, 15, 50, 22, 256, DateTimeKind.Local).AddTicks(9885) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Birthday", "RegisteredAt" },
                values: new object[] { new DateTime(1993, 2, 27, 15, 50, 22, 256, DateTimeKind.Local).AddTicks(9893), new DateTime(2020, 5, 3, 15, 50, 22, 256, DateTimeKind.Local).AddTicks(9891) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Birthday", "RegisteredAt" },
                values: new object[] { new DateTime(1993, 9, 15, 15, 50, 22, 256, DateTimeKind.Local).AddTicks(9899), new DateTime(2020, 6, 24, 15, 50, 22, 256, DateTimeKind.Local).AddTicks(9896) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Birthday", "RegisteredAt" },
                values: new object[] { new DateTime(1984, 12, 11, 15, 50, 22, 256, DateTimeKind.Local).AddTicks(9935), new DateTime(2020, 6, 5, 15, 50, 22, 256, DateTimeKind.Local).AddTicks(9932) });
        }
    }
}
