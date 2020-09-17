using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class AddValidation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Users",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Users",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Teams",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "TaskState",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Tasks",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Tasks",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProjectName",
                table: "Projects",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Projects",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Deadline", "Description" },
                values: new object[] { new DateTime(2020, 7, 6, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(1540), new DateTime(2020, 7, 20, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(1905), @"Ea ab omnis saepe rem vel et.
Illo quaerat eos accusantium reiciendis dolores" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Deadline", "Description" },
                values: new object[] { new DateTime(2020, 7, 14, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(2931), new DateTime(2020, 9, 3, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(2948), @"Aut quia id adipisci alias non mollitia.
Alias et at quia soluta quisquam aspernatur nemo molestias.
Vel id suscipit vero ipsa repudiandae nesciunt.
Provident veritatis maiores aut." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Deadline", "Description" },
                values: new object[] { new DateTime(2020, 6, 22, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(2969), new DateTime(2020, 7, 26, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(2972), @"Quis dicta repudiandae consequatur et odio repudiandae occaecati.
Dolore fugit veniam dolorem aperiam consequatur cum sed officiis ut." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Deadline", "Description" },
                values: new object[] { new DateTime(2020, 7, 4, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(2976), new DateTime(2020, 7, 23, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(2978), @"Voluptatem eaque accusamus maiores quo beatae quos doloremque.
Eos pariatur ea saepe atque.
Delectus quidem voluptatem harum architecto repellat.
Cupiditate culpa consectetur illo occaecati et.
Cumque inventore voluptas tenetur.
Facilis quaerat sed praesentium." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Deadline", "Description" },
                values: new object[] { new DateTime(2020, 7, 6, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(2982), new DateTime(2020, 7, 22, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(2985), @"Qui rem mollitia inventore nulla nam nam excepturi.
Quibusdam distinctio iste quo dolor.
Beatae consequatur qui est quo amet et quia." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Deadline", "Description" },
                values: new object[] { new DateTime(2020, 7, 6, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(2988), new DateTime(2020, 7, 18, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(2991), @"Molestiae incidunt praesentium dolor odit culpa voluptatibus maxime et nam.
Aut nam et laudantium omnis et sed.
Odio perspiciatis iure exercitationem possimus dicta minima." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Deadline", "Description" },
                values: new object[] { new DateTime(2020, 7, 15, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(2994), new DateTime(2020, 7, 24, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(2996), @"Modi nisi quasi vero odio amet excepturi.
Officiis et a molestiae rerum.
Suscipit ea aut autem ipsa itaque nihil.
Eum et nihil eveniet accusantium ea quod temporibus." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Deadline", "Description" },
                values: new object[] { new DateTime(2020, 7, 7, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(3000), new DateTime(2020, 7, 16, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(3003), @"Odio numquam quis quia ut sapiente facilis molestiae esse.
Perspiciatis enim totam repudiandae non sint similique." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Deadline", "Description" },
                values: new object[] { new DateTime(2020, 7, 3, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(3006), new DateTime(2020, 8, 5, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(3008), @"Deleniti voluptates tempora enim voluptas.
Voluptatem atque praesentium vel.
Itaque eum deleniti voluptas veniam.
Sapiente mollitia dolore placeat.
Aut molestiae error eaque cum." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Deadline", "Description" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(3012), new DateTime(2020, 7, 17, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(3014), @"Rem ipsam et ipsa inventore.
Quibusdam id omnis fuga.
Et a porro ut deleniti." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "Deadline", "Description" },
                values: new object[] { new DateTime(2020, 7, 3, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(3017), new DateTime(2020, 7, 18, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(3020), @"Accusamus cumque eaque eaque qui consequatur non quos veniam deserunt.
Veniam eligendi harum sapiente quaerat ab laborum voluptas.
Quisquam eius facere quibusdam corporis." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "Deadline", "Description" },
                values: new object[] { new DateTime(2020, 7, 10, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(3023), new DateTime(2020, 7, 20, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(3026), @"Id officia et autem doloremque tempora maiores rerum voluptas vero.
Dolorem maxime perspiciatis nihil autem.
Asperiores eius et.
Et minus ut cupiditate commodi dolorem dignissimos ut perferendis rem.
Nihil inventore occaecati laudantium dolor sed.
Dolores incidunt et tenetur." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "Deadline", "Description" },
                values: new object[] { new DateTime(2020, 7, 12, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(3029), new DateTime(2020, 7, 22, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(3032), @"Hic dolores vero dicta ut.
In ut ut dolorem eum eveniet praesentium nobis." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "Deadline", "Description" },
                values: new object[] { new DateTime(2020, 7, 7, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(3035), new DateTime(2020, 7, 28, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(3038), @"Non sed impedit doloremque.
Aliquid expedita velit et odit accusantium est explicabo ut iste.
Eligendi quia consequuntur." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "Deadline", "Description" },
                values: new object[] { new DateTime(2020, 7, 10, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(3042), new DateTime(2020, 7, 20, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(3044), @"Et quia sunt officiis inventore magni eligendi excepturi et.
Qui atque accusantium in repellat aliquid.
Modi numquam et qui omnis neque modi" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Description", "FinishedAt" },
                values: new object[] { new DateTime(2020, 7, 5, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(6106), @"Sed voluptas quia dolores expedita eius laborum ut qui aspernatur.
Molestias sapiente pariatur fuga architecto sed.
Autem repellendus maxime magni qui exercitationem rerum.
Dolorem magnam aut commodi nemo aut quaerat.
Eos sit veniam qui molestiae facere voluptatem.
Facilis eum atque enim dolor fac", new DateTime(2020, 7, 10, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(6629) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Description", "FinishedAt" },
                values: new object[] { new DateTime(2020, 7, 4, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(7913), @"Praesentium autem consequatur magnam et doloribus exercitationem.
Aut animi fuga cupiditate debitis atque nisi consequatur consequatur.
Cupiditate necessitatibus quo eos sequi earum et quis accusamus", new DateTime(2020, 7, 15, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(7933) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Description", "FinishedAt" },
                values: new object[] { new DateTime(2020, 6, 30, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(7958), @"Nisi esse accusamus dolorem blanditiis porro est dolores.
Explicabo consequatur rem dignissimos odit praesentium.
Molestiae facilis et tenetur.
Voluptas quis sed et ab nulla omnis cupiditate.
", new DateTime(2020, 7, 13, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(7961) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Description", "FinishedAt" },
                values: new object[] { new DateTime(2020, 7, 2, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(7965), @"Unde dignissimos libero minima quas aliquam.
Consequuntur aliquid non.
Eligendi quia quidem nihil sit veritatis.", new DateTime(2020, 7, 12, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(7967) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Description", "FinishedAt" },
                values: new object[] { new DateTime(2020, 7, 6, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(7971), @"Rerum totam sit.
Velit saepe iusto et repellat et consequuntur sit.
Voluptate officiis pariatur ut ea.
Neque ut sed voluptatem occaecati.
Dolor velit quaerat molestiae assumenda veritatis ", new DateTime(2020, 7, 11, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(7974) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Description", "FinishedAt" },
                values: new object[] { new DateTime(2020, 7, 10, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(7977), @"Sit tenetur nihil laborum qui quia assumenda ratione.
Tempora esse deleniti quia debitis incidunt odio consequatur unde.
Et quos quam consectetur excepturi sint qui enim autem eaque.
Adipisci praesentium officia non quod vel rerum nihil.
Veniam qui incidunt dolorum.
Molestiae ea officia qui explicabo", new DateTime(2020, 7, 14, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(7979) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Description", "FinishedAt" },
                values: new object[] { new DateTime(2020, 6, 29, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(7983), @"olores esse quibusdam aut ut quidem nulla voluptatem.
Quidem vitae sequi aut qui cumque adipisci quo quam.
Alias quis voluptatibus.
Qui est aut.
Nihil quia occaecati occaecati totam laudantium.
Nobis cum quae saepe molestiae voluptas id reiciendis a consequuntur.", new DateTime(2020, 7, 11, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(7986) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Description", "FinishedAt" },
                values: new object[] { new DateTime(2020, 7, 12, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(7989), @"Nihil eos minima sed.
Est et assumenda voluptatem voluptatem illum doloribus.
Voluptatem enim voluptatem et ut.", new DateTime(2020, 7, 14, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(7992) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Description", "FinishedAt" },
                values: new object[] { new DateTime(2020, 7, 8, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(7995), @"Ipsam quo soluta aut numquam aliquam sint.
Aliquam voluptas error fuga est", new DateTime(2020, 7, 14, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(7998) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Description", "FinishedAt" },
                values: new object[] { new DateTime(2020, 7, 11, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(8001), @"Quia quam eveniet quisquam rerum voluptatum laboriosam repudiandae.
Voluptate fugit esse eveniet ducimus sunt veniam a.
Sed qui et consequatur similique eum velit ipsa voluptates ut", new DateTime(2020, 7, 12, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(8003) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "Description", "FinishedAt" },
                values: new object[] { new DateTime(2020, 7, 8, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(8007), @"Quod autem atque similique molestiae dicta quia.
Nulla nulla consequatur at sint enim et similique.
Fugit occaecati enim aut doloremque aliquid vero molestiae iste.
Quaerat delectus id.", new DateTime(2020, 7, 12, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(8010) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "Description", "FinishedAt" },
                values: new object[] { new DateTime(2020, 7, 9, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(8013), @"Optio modi exercitationem quia in omnis alias.
Esse a voluptatem porro quo voluptatem fuga eos consequatur sit.
Repellendus labore excepturi eaque impedit minus rerum ut qui eum.", new DateTime(2020, 7, 10, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(8016) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "Description", "FinishedAt" },
                values: new object[] { new DateTime(2020, 7, 5, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(8019), @"Quas et quae optio ullam amet amet qui voluptatum.
Ut eos neque quia occaecati voluptas voluptatem modi consequatur doloribus.
Voluptatem occaecati et.
Fuga deserunt nam porro nam nobis deserunt laboriosam asperiores.
Autem voluptatem cumque amet totam ducimus unde officiis.", new DateTime(2020, 7, 10, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(8022) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "Description", "FinishedAt" },
                values: new object[] { new DateTime(2020, 7, 1, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(8025), @"Ipsum odio qui in dolorum aperiam ut.
Blanditiis ratione sapiente quos est quia pariatur.
Similique repudiandae hic enim non neque magnam fugiat est.
Excepturi accusamus non soluta inventore enim doloribus culpa veniam.
Impedit sunt magni cumque autem.
Quis suscipit culpa quia voluptatem.", new DateTime(2020, 7, 8, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(8027) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "Description", "FinishedAt" },
                values: new object[] { new DateTime(2020, 7, 6, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(8031), @"Laborum omnis dicta.
Quas qui saepe perspiciatis aut asperiores dolor dolore.
Aliquam temporibus repudiandae magnam non cum aut quia eius vel.
Aut aliquid officia ad.", new DateTime(2020, 7, 14, 15, 50, 22, 257, DateTimeKind.Local).AddTicks(8033) });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Teams",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "TaskState",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Tasks",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Tasks",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "ProjectName",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Deadline", "Description" },
                values: new object[] { new DateTime(2020, 7, 6, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(6726), new DateTime(2020, 7, 20, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(7155), @"Ea ab omnis saepe rem vel et.
Illo quaerat eos accusantium reiciendis dolores" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Deadline", "Description" },
                values: new object[] { new DateTime(2020, 7, 14, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(8403), new DateTime(2020, 9, 3, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(8423), @"Aut quia id adipisci alias non mollitia.
Alias et at quia soluta quisquam aspernatur nemo molestias.
Vel id suscipit vero ipsa repudiandae nesciunt.
Provident veritatis maiores aut." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Deadline", "Description" },
                values: new object[] { new DateTime(2020, 6, 22, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(8444), new DateTime(2020, 7, 26, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(8447), @"Quis dicta repudiandae consequatur et odio repudiandae occaecati.
Dolore fugit veniam dolorem aperiam consequatur cum sed officiis ut." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Deadline", "Description" },
                values: new object[] { new DateTime(2020, 7, 4, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(8451), new DateTime(2020, 7, 23, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(8454), @"Voluptatem eaque accusamus maiores quo beatae quos doloremque.
Eos pariatur ea saepe atque.
Delectus quidem voluptatem harum architecto repellat.
Cupiditate culpa consectetur illo occaecati et.
Cumque inventore voluptas tenetur.
Facilis quaerat sed praesentium." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Deadline", "Description" },
                values: new object[] { new DateTime(2020, 7, 6, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(8457), new DateTime(2020, 7, 22, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(8460), @"Qui rem mollitia inventore nulla nam nam excepturi.
Quibusdam distinctio iste quo dolor.
Beatae consequatur qui est quo amet et quia." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Deadline", "Description" },
                values: new object[] { new DateTime(2020, 7, 6, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(8463), new DateTime(2020, 7, 18, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(8466), @"Molestiae incidunt praesentium dolor odit culpa voluptatibus maxime et nam.
Aut nam et laudantium omnis et sed.
Odio perspiciatis iure exercitationem possimus dicta minima." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Deadline", "Description" },
                values: new object[] { new DateTime(2020, 7, 15, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(8469), new DateTime(2020, 7, 24, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(8471), @"Modi nisi quasi vero odio amet excepturi.
Officiis et a molestiae rerum.
Suscipit ea aut autem ipsa itaque nihil.
Eum et nihil eveniet accusantium ea quod temporibus." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Deadline", "Description" },
                values: new object[] { new DateTime(2020, 7, 7, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(8474), new DateTime(2020, 7, 16, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(8477), @"Odio numquam quis quia ut sapiente facilis molestiae esse.
Perspiciatis enim totam repudiandae non sint similique." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Deadline", "Description" },
                values: new object[] { new DateTime(2020, 7, 3, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(8480), new DateTime(2020, 8, 5, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(8483), @"Deleniti voluptates tempora enim voluptas.
Voluptatem atque praesentium vel.
Itaque eum deleniti voluptas veniam.
Sapiente mollitia dolore placeat.
Aut molestiae error eaque cum." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Deadline", "Description" },
                values: new object[] { new DateTime(2020, 6, 13, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(8486), new DateTime(2020, 7, 17, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(8489), @"Rem ipsam et ipsa inventore.
Quibusdam id omnis fuga.
Et a porro ut deleniti." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "Deadline", "Description" },
                values: new object[] { new DateTime(2020, 7, 3, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(8492), new DateTime(2020, 7, 18, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(8494), @"Accusamus cumque eaque eaque qui consequatur non quos veniam deserunt.
Veniam eligendi harum sapiente quaerat ab laborum voluptas.
Quisquam eius facere quibusdam corporis." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "Deadline", "Description" },
                values: new object[] { new DateTime(2020, 7, 10, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(8497), new DateTime(2020, 7, 20, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(8500), @"Id officia et autem doloremque tempora maiores rerum voluptas vero.
Dolorem maxime perspiciatis nihil autem.
Asperiores eius et.
Et minus ut cupiditate commodi dolorem dignissimos ut perferendis rem.
Nihil inventore occaecati laudantium dolor sed.
Dolores incidunt et tenetur." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "Deadline", "Description" },
                values: new object[] { new DateTime(2020, 7, 12, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(8503), new DateTime(2020, 7, 22, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(8506), @"Hic dolores vero dicta ut.
In ut ut dolorem eum eveniet praesentium nobis." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "Deadline", "Description" },
                values: new object[] { new DateTime(2020, 7, 7, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(8509), new DateTime(2020, 7, 28, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(8512), @"Non sed impedit doloremque.
Aliquid expedita velit et odit accusantium est explicabo ut iste.
Eligendi quia consequuntur." });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "Deadline", "Description" },
                values: new object[] { new DateTime(2020, 7, 10, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(8515), new DateTime(2020, 7, 20, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(8518), @"Et quia sunt officiis inventore magni eligendi excepturi et.
Qui atque accusantium in repellat aliquid.
Modi numquam et qui omnis neque modi" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Description", "FinishedAt" },
                values: new object[] { new DateTime(2020, 7, 5, 15, 32, 46, 853, DateTimeKind.Local).AddTicks(1765), @"Sed voluptas quia dolores expedita eius laborum ut qui aspernatur.
Molestias sapiente pariatur fuga architecto sed.
Autem repellendus maxime magni qui exercitationem rerum.
Dolorem magnam aut commodi nemo aut quaerat.
Eos sit veniam qui molestiae facere voluptatem.
Facilis eum atque enim dolor fac", new DateTime(2020, 7, 10, 15, 32, 46, 853, DateTimeKind.Local).AddTicks(2159) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Description", "FinishedAt" },
                values: new object[] { new DateTime(2020, 7, 4, 15, 32, 46, 853, DateTimeKind.Local).AddTicks(3582), @"Praesentium autem consequatur magnam et doloribus exercitationem.
Aut animi fuga cupiditate debitis atque nisi consequatur consequatur.
Cupiditate necessitatibus quo eos sequi earum et quis accusamus", new DateTime(2020, 7, 15, 15, 32, 46, 853, DateTimeKind.Local).AddTicks(3603) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Description", "FinishedAt" },
                values: new object[] { new DateTime(2020, 6, 30, 15, 32, 46, 853, DateTimeKind.Local).AddTicks(3629), @"Nisi esse accusamus dolorem blanditiis porro est dolores.
Explicabo consequatur rem dignissimos odit praesentium.
Molestiae facilis et tenetur.
Voluptas quis sed et ab nulla omnis cupiditate.
", new DateTime(2020, 7, 13, 15, 32, 46, 853, DateTimeKind.Local).AddTicks(3632) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Description", "FinishedAt" },
                values: new object[] { new DateTime(2020, 7, 2, 15, 32, 46, 853, DateTimeKind.Local).AddTicks(3636), @"Unde dignissimos libero minima quas aliquam.
Consequuntur aliquid non.
Eligendi quia quidem nihil sit veritatis.", new DateTime(2020, 7, 12, 15, 32, 46, 853, DateTimeKind.Local).AddTicks(3638) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Description", "FinishedAt" },
                values: new object[] { new DateTime(2020, 7, 6, 15, 32, 46, 853, DateTimeKind.Local).AddTicks(3641), @"Rerum totam sit.
Velit saepe iusto et repellat et consequuntur sit.
Voluptate officiis pariatur ut ea.
Neque ut sed voluptatem occaecati.
Dolor velit quaerat molestiae assumenda veritatis ", new DateTime(2020, 7, 11, 15, 32, 46, 853, DateTimeKind.Local).AddTicks(3644) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Description", "FinishedAt" },
                values: new object[] { new DateTime(2020, 7, 10, 15, 32, 46, 853, DateTimeKind.Local).AddTicks(3647), @"Sit tenetur nihil laborum qui quia assumenda ratione.
Tempora esse deleniti quia debitis incidunt odio consequatur unde.
Et quos quam consectetur excepturi sint qui enim autem eaque.
Adipisci praesentium officia non quod vel rerum nihil.
Veniam qui incidunt dolorum.
Molestiae ea officia qui explicabo", new DateTime(2020, 7, 14, 15, 32, 46, 853, DateTimeKind.Local).AddTicks(3650) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Description", "FinishedAt" },
                values: new object[] { new DateTime(2020, 6, 29, 15, 32, 46, 853, DateTimeKind.Local).AddTicks(3653), @"olores esse quibusdam aut ut quidem nulla voluptatem.
Quidem vitae sequi aut qui cumque adipisci quo quam.
Alias quis voluptatibus.
Qui est aut.
Nihil quia occaecati occaecati totam laudantium.
Nobis cum quae saepe molestiae voluptas id reiciendis a consequuntur.", new DateTime(2020, 7, 11, 15, 32, 46, 853, DateTimeKind.Local).AddTicks(3656) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Description", "FinishedAt" },
                values: new object[] { new DateTime(2020, 7, 12, 15, 32, 46, 853, DateTimeKind.Local).AddTicks(3659), @"Nihil eos minima sed.
Est et assumenda voluptatem voluptatem illum doloribus.
Voluptatem enim voluptatem et ut.", new DateTime(2020, 7, 14, 15, 32, 46, 853, DateTimeKind.Local).AddTicks(3662) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Description", "FinishedAt" },
                values: new object[] { new DateTime(2020, 7, 8, 15, 32, 46, 853, DateTimeKind.Local).AddTicks(3666), @"Ipsam quo soluta aut numquam aliquam sint.
Aliquam voluptas error fuga est", new DateTime(2020, 7, 14, 15, 32, 46, 853, DateTimeKind.Local).AddTicks(3669) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Description", "FinishedAt" },
                values: new object[] { new DateTime(2020, 7, 11, 15, 32, 46, 853, DateTimeKind.Local).AddTicks(3672), @"Quia quam eveniet quisquam rerum voluptatum laboriosam repudiandae.
Voluptate fugit esse eveniet ducimus sunt veniam a.
Sed qui et consequatur similique eum velit ipsa voluptates ut", new DateTime(2020, 7, 12, 15, 32, 46, 853, DateTimeKind.Local).AddTicks(3675) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "Description", "FinishedAt" },
                values: new object[] { new DateTime(2020, 7, 8, 15, 32, 46, 853, DateTimeKind.Local).AddTicks(3678), @"Quod autem atque similique molestiae dicta quia.
Nulla nulla consequatur at sint enim et similique.
Fugit occaecati enim aut doloremque aliquid vero molestiae iste.
Quaerat delectus id.", new DateTime(2020, 7, 12, 15, 32, 46, 853, DateTimeKind.Local).AddTicks(3681) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "Description", "FinishedAt" },
                values: new object[] { new DateTime(2020, 7, 9, 15, 32, 46, 853, DateTimeKind.Local).AddTicks(3684), @"Optio modi exercitationem quia in omnis alias.
Esse a voluptatem porro quo voluptatem fuga eos consequatur sit.
Repellendus labore excepturi eaque impedit minus rerum ut qui eum.", new DateTime(2020, 7, 10, 15, 32, 46, 853, DateTimeKind.Local).AddTicks(3686) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "Description", "FinishedAt" },
                values: new object[] { new DateTime(2020, 7, 5, 15, 32, 46, 853, DateTimeKind.Local).AddTicks(3690), @"Quas et quae optio ullam amet amet qui voluptatum.
Ut eos neque quia occaecati voluptas voluptatem modi consequatur doloribus.
Voluptatem occaecati et.
Fuga deserunt nam porro nam nobis deserunt laboriosam asperiores.
Autem voluptatem cumque amet totam ducimus unde officiis.", new DateTime(2020, 7, 10, 15, 32, 46, 853, DateTimeKind.Local).AddTicks(3692) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "Description", "FinishedAt" },
                values: new object[] { new DateTime(2020, 7, 1, 15, 32, 46, 853, DateTimeKind.Local).AddTicks(3695), @"Ipsum odio qui in dolorum aperiam ut.
Blanditiis ratione sapiente quos est quia pariatur.
Similique repudiandae hic enim non neque magnam fugiat est.
Excepturi accusamus non soluta inventore enim doloribus culpa veniam.
Impedit sunt magni cumque autem.
Quis suscipit culpa quia voluptatem.", new DateTime(2020, 7, 8, 15, 32, 46, 853, DateTimeKind.Local).AddTicks(3698) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "Description", "FinishedAt" },
                values: new object[] { new DateTime(2020, 7, 6, 15, 32, 46, 853, DateTimeKind.Local).AddTicks(3701), @"Laborum omnis dicta.
Quas qui saepe perspiciatis aut asperiores dolor dolore.
Aliquam temporibus repudiandae magnam non cum aut quia eius vel.
Aut aliquid officia ad.", new DateTime(2020, 7, 14, 15, 32, 46, 853, DateTimeKind.Local).AddTicks(3704) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 25, 15, 32, 46, 848, DateTimeKind.Local).AddTicks(8753));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 11, 15, 32, 46, 850, DateTimeKind.Local).AddTicks(9405));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 5, 31, 15, 32, 46, 850, DateTimeKind.Local).AddTicks(9443));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 24, 15, 32, 46, 850, DateTimeKind.Local).AddTicks(9448));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 18, 15, 32, 46, 850, DateTimeKind.Local).AddTicks(9451));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 15, 32, 46, 850, DateTimeKind.Local).AddTicks(9455));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 2, 15, 32, 46, 850, DateTimeKind.Local).AddTicks(9458));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 6, 15, 32, 46, 850, DateTimeKind.Local).AddTicks(9461));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 11, 15, 32, 46, 850, DateTimeKind.Local).AddTicks(9464));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 9, 15, 32, 46, 850, DateTimeKind.Local).AddTicks(9470));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Birthday", "RegisteredAt" },
                values: new object[] { new DateTime(1993, 2, 27, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(3504), new DateTime(2020, 6, 5, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(3067) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Birthday", "RegisteredAt" },
                values: new object[] { new DateTime(1994, 7, 12, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(4362), new DateTime(2020, 5, 9, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(4335) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Birthday", "RegisteredAt" },
                values: new object[] { new DateTime(1986, 4, 25, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(4382), new DateTime(2020, 7, 1, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(4379) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Birthday", "RegisteredAt" },
                values: new object[] { new DateTime(1998, 8, 20, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(4389), new DateTime(2020, 6, 12, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(4386) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Birthday", "RegisteredAt" },
                values: new object[] { new DateTime(1993, 2, 27, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(4395), new DateTime(2020, 5, 30, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(4392) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Birthday", "RegisteredAt" },
                values: new object[] { new DateTime(2000, 1, 2, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(4401), new DateTime(2020, 6, 10, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(4399) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Birthday", "RegisteredAt" },
                values: new object[] { new DateTime(1993, 9, 15, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(4407), new DateTime(2020, 6, 22, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(4404) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Birthday", "RegisteredAt" },
                values: new object[] { new DateTime(1995, 11, 24, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(4413), new DateTime(2020, 4, 28, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(4410) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Birthday", "RegisteredAt" },
                values: new object[] { new DateTime(1982, 3, 17, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(4419), new DateTime(2020, 5, 24, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(4416) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Birthday", "RegisteredAt" },
                values: new object[] { new DateTime(1989, 8, 7, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(4425), new DateTime(2020, 7, 3, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(4422) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Birthday", "RegisteredAt" },
                values: new object[] { new DateTime(2001, 5, 16, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(4431), new DateTime(2020, 6, 8, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(4428) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Birthday", "RegisteredAt" },
                values: new object[] { new DateTime(1993, 11, 24, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(4437), new DateTime(2020, 6, 14, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(4434) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Birthday", "RegisteredAt" },
                values: new object[] { new DateTime(1993, 2, 27, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(4443), new DateTime(2020, 5, 3, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(4440) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Birthday", "RegisteredAt" },
                values: new object[] { new DateTime(1993, 9, 15, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(4448), new DateTime(2020, 6, 24, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(4446) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Birthday", "RegisteredAt" },
                values: new object[] { new DateTime(1984, 12, 11, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(4455), new DateTime(2020, 6, 5, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(4452) });
        }
    }
}
