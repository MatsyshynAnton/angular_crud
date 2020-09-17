using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class DataSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TaskState",
                columns: new[] { "Id", "State" },
                values: new object[,]
                {
                    { 1, "Created" },
                    { 2, "Started" },
                    { 3, "Finished" },
                    { 4, "Canceled" }
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "CreatedAt", "Name" },
                values: new object[,]
                {
                    { 10, new DateTime(2020, 7, 9, 15, 32, 46, 850, DateTimeKind.Local).AddTicks(9470), "earum" },
                    { 9, new DateTime(2020, 7, 11, 15, 32, 46, 850, DateTimeKind.Local).AddTicks(9464), "provident" },
                    { 8, new DateTime(2020, 7, 6, 15, 32, 46, 850, DateTimeKind.Local).AddTicks(9461), "incidunt" },
                    { 7, new DateTime(2020, 7, 2, 15, 32, 46, 850, DateTimeKind.Local).AddTicks(9458), "dolorem" },
                    { 6, new DateTime(2020, 6, 28, 15, 32, 46, 850, DateTimeKind.Local).AddTicks(9455), "et" },
                    { 4, new DateTime(2020, 6, 24, 15, 32, 46, 850, DateTimeKind.Local).AddTicks(9448), "ea" },
                    { 3, new DateTime(2020, 5, 31, 15, 32, 46, 850, DateTimeKind.Local).AddTicks(9443), "cupiditate" },
                    { 2, new DateTime(2020, 7, 11, 15, 32, 46, 850, DateTimeKind.Local).AddTicks(9405), "asperiores" },
                    { 1, new DateTime(2020, 6, 25, 15, 32, 46, 848, DateTimeKind.Local).AddTicks(8753), "debitis" },
                    { 5, new DateTime(2020, 6, 18, 15, 32, 46, 850, DateTimeKind.Local).AddTicks(9451), "amet" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Age", "Birthday", "Email", "FirstName", "LastName", "RegisteredAt", "TeamId" },
                values: new object[,]
                {
                    { 14, 0, new DateTime(1993, 9, 15, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(4448), "Kirsten_Braun49@gmail.com", "Kirsten", "Braun", new DateTime(2020, 6, 24, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(4446), null },
                    { 3, 0, new DateTime(1986, 4, 25, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(4382), "Mabelle.Miller12@hotmail.com", "Mabelle", "Miller", new DateTime(2020, 7, 1, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(4379), null },
                    { 4, 0, new DateTime(1998, 8, 20, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(4389), "Verla.Bechtelar62@gmail.com", "Verla", "Bechtelar", new DateTime(2020, 6, 12, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(4386), null },
                    { 8, 0, new DateTime(1995, 11, 24, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(4413), "Norma_Gislason@yahoo.com", "Norma", "Gislason", new DateTime(2020, 4, 28, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(4410), null },
                    { 11, 0, new DateTime(2001, 5, 16, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(4431), "Jayde22@hotmail.com", "Jayde", "Pouros", new DateTime(2020, 6, 8, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(4428), null },
                    { 15, 0, new DateTime(1984, 12, 11, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(4455), "Tamara58@gmail.com", "Tamara", "Brakus", new DateTime(2020, 6, 5, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(4452), null }
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "AuthorId", "CreatedAt", "Deadline", "Description", "ProjectName", "TeamId" },
                values: new object[,]
                {
                    { 11, 14, new DateTime(2020, 7, 3, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(8492), new DateTime(2020, 7, 18, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(8494), @"Accusamus cumque eaque eaque qui consequatur non quos veniam deserunt.
                Veniam eligendi harum sapiente quaerat ab laborum voluptas.
                Quisquam eius facere quibusdam corporis.", "Nihil aut voluptatum ea ex.", 3 },
                    { 9, 4, new DateTime(2020, 7, 3, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(8480), new DateTime(2020, 8, 5, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(8483), @"Deleniti voluptates tempora enim voluptas.
                Voluptatem atque praesentium vel.
                Itaque eum deleniti voluptas veniam.
                Sapiente mollitia dolore placeat.
                Aut molestiae error eaque cum.", "In vitae neque soluta et.", 1 },
                    { 4, 4, new DateTime(2020, 7, 4, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(8451), new DateTime(2020, 7, 23, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(8454), @"Voluptatem eaque accusamus maiores quo beatae quos doloremque.
                Eos pariatur ea saepe atque.
                Delectus quidem voluptatem harum architecto repellat.
                Cupiditate culpa consectetur illo occaecati et.
                Cumque inventore voluptas tenetur.
                Facilis quaerat sed praesentium.", "Quia repellendus odit et eligendi.", 1 },
                    { 15, 3, new DateTime(2020, 7, 10, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(8515), new DateTime(2020, 7, 20, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(8518), @"Et quia sunt officiis inventore magni eligendi excepturi et.
                Qui atque accusantium in repellat aliquid.
                Modi numquam et qui omnis neque modi", "Explicabo qui nulla quia ipsa.", 7 },
                    { 5, 3, new DateTime(2020, 7, 6, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(8457), new DateTime(2020, 7, 22, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(8460), @"Qui rem mollitia inventore nulla nam nam excepturi.
                Quibusdam distinctio iste quo dolor.
                Beatae consequatur qui est quo amet et quia.", "Aspernatur vero quas et ipsum.", 7 },
                    { 3, 3, new DateTime(2020, 6, 22, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(8444), new DateTime(2020, 7, 26, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(8447), @"Quis dicta repudiandae consequatur et odio repudiandae occaecati.
                Dolore fugit veniam dolorem aperiam consequatur cum sed officiis ut.", "Eos illum eum minima quibusdam.", 6 },
                    { 1, 3, new DateTime(2020, 7, 6, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(6726), new DateTime(2020, 7, 20, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(7155), @"Ea ab omnis saepe rem vel et.
                Illo quaerat eos accusantium reiciendis dolores", "Expedita amet quas id a.", 7 },
                    { 10, 8, new DateTime(2020, 6, 13, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(8486), new DateTime(2020, 7, 17, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(8489), @"Rem ipsam et ipsa inventore.
                Quibusdam id omnis fuga.
                Et a porro ut deleniti.", "Atque ut nisi dignissimos quas.", 9 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Age", "Birthday", "Email", "FirstName", "LastName", "RegisteredAt", "TeamId" },
                values: new object[,]
                {
                    { 13, 0, new DateTime(1993, 2, 27, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(4443), "Issac.Rath@gmail.com", "Issac", "Rath", new DateTime(2020, 5, 3, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(4440), 8 },
                    { 7, 0, new DateTime(1993, 9, 15, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(4407), "Tracy.Schinner65@gmail.com", "Tracy", "Schinner", new DateTime(2020, 6, 22, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(4404), 5 },
                    { 2, 0, new DateTime(1994, 7, 12, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(4362), "Kolby_Jones@yahoo.com", "Kolby", "Jones", new DateTime(2020, 5, 9, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(4335), 5 },
                    { 12, 0, new DateTime(1993, 11, 24, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(4437), "Sherman_Kuhlman44@hotmail.com", "Sherman", "Kuhlman", new DateTime(2020, 6, 14, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(4434), 4 },
                    { 10, 0, new DateTime(1989, 8, 7, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(4425), "Edward_Kuvalis@yahoo.com", "Edward", "Edward", new DateTime(2020, 7, 3, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(4422), 4 },
                    { 1, 0, new DateTime(1993, 2, 27, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(3504), "Jordane.Walker@gmail.com", "Jordane", "Walker", new DateTime(2020, 6, 5, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(3067), 4 },
                    { 6, 0, new DateTime(2000, 1, 2, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(4401), "Roberto.Ruecker35@yahoo.com", "Roberto", "Ruecker", new DateTime(2020, 6, 10, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(4399), 2 },
                    { 9, 0, new DateTime(1982, 3, 17, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(4419), "Luisa92@yahoo.com", "Luisa", "Lind", new DateTime(2020, 5, 24, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(4416), 8 },
                    { 5, 0, new DateTime(1993, 2, 27, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(4395), "Retha67@yahoo.com", "Retha", "Will", new DateTime(2020, 5, 30, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(4392), 1 }
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "AuthorId", "CreatedAt", "Deadline", "Description", "ProjectName", "TeamId" },
                values: new object[,]
                {
                    { 14, 5, new DateTime(2020, 7, 7, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(8509), new DateTime(2020, 7, 28, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(8512), @"Non sed impedit doloremque.
                Aliquid expedita velit et odit accusantium est explicabo ut iste.
                Eligendi quia consequuntur.", "Est est quam vitae nostrum.", 9 },
                    { 2, 1, new DateTime(2020, 7, 14, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(8403), new DateTime(2020, 9, 3, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(8423), @"Aut quia id adipisci alias non mollitia.
                Alias et at quia soluta quisquam aspernatur nemo molestias.
                Vel id suscipit vero ipsa repudiandae nesciunt.
                Provident veritatis maiores aut.", "Totam autem hic atque suscipit.", 10 },
                    { 8, 1, new DateTime(2020, 7, 7, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(8474), new DateTime(2020, 7, 16, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(8477), @"Odio numquam quis quia ut sapiente facilis molestiae esse.
                Perspiciatis enim totam repudiandae non sint similique.", "Ad vero qui culpa odit.", 1 },
                    { 6, 2, new DateTime(2020, 7, 6, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(8463), new DateTime(2020, 7, 18, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(8466), @"Molestiae incidunt praesentium dolor odit culpa voluptatibus maxime et nam.
                Aut nam et laudantium omnis et sed.
                Odio perspiciatis iure exercitationem possimus dicta minima.", "Reprehenderit nam architecto sed aut.", 4 },
                    { 7, 9, new DateTime(2020, 7, 15, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(8469), new DateTime(2020, 7, 24, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(8471), @"Modi nisi quasi vero odio amet excepturi.
                Officiis et a molestiae rerum.
                Suscipit ea aut autem ipsa itaque nihil.
                Eum et nihil eveniet accusantium ea quod temporibus.", "Quaerat omnis enim sint ex.", 5 },
                    { 13, 9, new DateTime(2020, 7, 12, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(8503), new DateTime(2020, 7, 22, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(8506), @"Hic dolores vero dicta ut.
                In ut ut dolorem eum eveniet praesentium nobis.", "Sed velit blanditiis nam vel.", 8 },
                    { 12, 13, new DateTime(2020, 7, 10, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(8497), new DateTime(2020, 7, 20, 15, 32, 46, 852, DateTimeKind.Local).AddTicks(8500), @"Id officia et autem doloremque tempora maiores rerum voluptas vero.
                Dolorem maxime perspiciatis nihil autem.
                Asperiores eius et.
                Et minus ut cupiditate commodi dolorem dignissimos ut perferendis rem.
                Nihil inventore occaecati laudantium dolor sed.
                Dolores incidunt et tenetur.", "Quo dolore est consequatur dolore.", 5 }
                });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "CreatedAt", "Description", "FinishedAt", "Name", "PerformerId", "ProjectId", "TaskStateId" },
                values: new object[,]
                {
                    { 4, new DateTime(2020, 7, 2, 15, 32, 46, 853, DateTimeKind.Local).AddTicks(3636), @"Unde dignissimos libero minima quas aliquam.
                Consequuntur aliquid non.
                Eligendi quia quidem nihil sit veritatis.", new DateTime(2020, 7, 12, 15, 32, 46, 853, DateTimeKind.Local).AddTicks(3638), "Error sit sunt.", 5, 9, 1 },
                    { 1, new DateTime(2020, 7, 5, 15, 32, 46, 853, DateTimeKind.Local).AddTicks(1765), @"Sed voluptas quia dolores expedita eius laborum ut qui aspernatur.
                Molestias sapiente pariatur fuga architecto sed.
                Autem repellendus maxime magni qui exercitationem rerum.
                Dolorem magnam aut commodi nemo aut quaerat.
                Eos sit veniam qui molestiae facere voluptatem.
                Facilis eum atque enim dolor fac", new DateTime(2020, 7, 10, 15, 32, 46, 853, DateTimeKind.Local).AddTicks(2159), "Quasi consectetur nesciunt doloribus.", 4, 9, 4 },
                    { 15, new DateTime(2020, 7, 6, 15, 32, 46, 853, DateTimeKind.Local).AddTicks(3701), @"Laborum omnis dicta.
                Quas qui saepe perspiciatis aut asperiores dolor dolore.
                Aliquam temporibus repudiandae magnam non cum aut quia eius vel.
                Aut aliquid officia ad.", new DateTime(2020, 7, 14, 15, 32, 46, 853, DateTimeKind.Local).AddTicks(3704), "Qui facilis suscipit.", 9, 4, 1 },
                    { 11, new DateTime(2020, 7, 8, 15, 32, 46, 853, DateTimeKind.Local).AddTicks(3678), @"Quod autem atque similique molestiae dicta quia.
                Nulla nulla consequatur at sint enim et similique.
                Fugit occaecati enim aut doloremque aliquid vero molestiae iste.
                Quaerat delectus id.", new DateTime(2020, 7, 12, 15, 32, 46, 853, DateTimeKind.Local).AddTicks(3681), "Sit qui repellendus libero libero.", 10, 5, 3 },
                    { 14, new DateTime(2020, 7, 1, 15, 32, 46, 853, DateTimeKind.Local).AddTicks(3695), @"Ipsum odio qui in dolorum aperiam ut.
                Blanditiis ratione sapiente quos est quia pariatur.
                Similique repudiandae hic enim non neque magnam fugiat est.
                Excepturi accusamus non soluta inventore enim doloribus culpa veniam.
                Impedit sunt magni cumque autem.
                Quis suscipit culpa quia voluptatem.", new DateTime(2020, 7, 8, 15, 32, 46, 853, DateTimeKind.Local).AddTicks(3698), "Placeat impedit ullam eveniet corporis quidem doloribus.", 2, 3, 3 },
                    { 7, new DateTime(2020, 6, 29, 15, 32, 46, 853, DateTimeKind.Local).AddTicks(3653), @"olores esse quibusdam aut ut quidem nulla voluptatem.
                Quidem vitae sequi aut qui cumque adipisci quo quam.
                Alias quis voluptatibus.
                Qui est aut.
                Nihil quia occaecati occaecati totam laudantium.
                Nobis cum quae saepe molestiae voluptas id reiciendis a consequuntur.", new DateTime(2020, 7, 11, 15, 32, 46, 853, DateTimeKind.Local).AddTicks(3656), "Rerum eum qui ad repudiandae eum laborum ut saepe.", 3, 5, 1 },
                    { 8, new DateTime(2020, 7, 12, 15, 32, 46, 853, DateTimeKind.Local).AddTicks(3659), @"Nihil eos minima sed.
                Est et assumenda voluptatem voluptatem illum doloribus.
                Voluptatem enim voluptatem et ut.", new DateTime(2020, 7, 14, 15, 32, 46, 853, DateTimeKind.Local).AddTicks(3662), "Et ipsa voluptatem non eos et similique sunt.", 11, 9, 4 },
                    { 10, new DateTime(2020, 7, 11, 15, 32, 46, 853, DateTimeKind.Local).AddTicks(3672), @"Quia quam eveniet quisquam rerum voluptatum laboriosam repudiandae.
                Voluptate fugit esse eveniet ducimus sunt veniam a.
                Sed qui et consequatur similique eum velit ipsa voluptates ut", new DateTime(2020, 7, 12, 15, 32, 46, 853, DateTimeKind.Local).AddTicks(3675), "Dolorem eos incidunt eum perspiciatis officia ratione est rerum.", 1, 1, 1 },
                    { 9, new DateTime(2020, 7, 8, 15, 32, 46, 853, DateTimeKind.Local).AddTicks(3666), @"Ipsam quo soluta aut numquam aliquam sint.
                Aliquam voluptas error fuga est", new DateTime(2020, 7, 14, 15, 32, 46, 853, DateTimeKind.Local).AddTicks(3669), "Dolorem fugiat impedit nesciunt enim non.", 7, 5, 2 },
                    { 13, new DateTime(2020, 7, 5, 15, 32, 46, 853, DateTimeKind.Local).AddTicks(3690), @"Quas et quae optio ullam amet amet qui voluptatum.
                Ut eos neque quia occaecati voluptas voluptatem modi consequatur doloribus.
                Voluptatem occaecati et.
                Fuga deserunt nam porro nam nobis deserunt laboriosam asperiores.
                Autem voluptatem cumque amet totam ducimus unde officiis.", new DateTime(2020, 7, 10, 15, 32, 46, 853, DateTimeKind.Local).AddTicks(3692), "Minima vel eum atque perspiciatis laborum officiis cum.", 12, 10, 2 }
                });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "CreatedAt", "Description", "FinishedAt", "Name", "PerformerId", "ProjectId", "TaskStateId" },
                values: new object[,]
                {
                    { 3, new DateTime(2020, 6, 30, 15, 32, 46, 853, DateTimeKind.Local).AddTicks(3629), @"Nisi esse accusamus dolorem blanditiis porro est dolores.
                Explicabo consequatur rem dignissimos odit praesentium.
                Molestiae facilis et tenetur.
                Voluptas quis sed et ab nulla omnis cupiditate.
                ", new DateTime(2020, 7, 13, 15, 32, 46, 853, DateTimeKind.Local).AddTicks(3632), "Repellendus itaque expedita est ut", 4, 2, 2 },
                    { 2, new DateTime(2020, 7, 4, 15, 32, 46, 853, DateTimeKind.Local).AddTicks(3582), @"Praesentium autem consequatur magnam et doloribus exercitationem.
                Aut animi fuga cupiditate debitis atque nisi consequatur consequatur.
                Cupiditate necessitatibus quo eos sequi earum et quis accusamus", new DateTime(2020, 7, 15, 15, 32, 46, 853, DateTimeKind.Local).AddTicks(3603), "Praesentium ut consequatur cumque eveniet suscipit amet officia.", 6, 7, 3 },
                    { 6, new DateTime(2020, 7, 10, 15, 32, 46, 853, DateTimeKind.Local).AddTicks(3647), @"Sit tenetur nihil laborum qui quia assumenda ratione.
                Tempora esse deleniti quia debitis incidunt odio consequatur unde.
                Et quos quam consectetur excepturi sint qui enim autem eaque.
                Adipisci praesentium officia non quod vel rerum nihil.
                Veniam qui incidunt dolorum.
                Molestiae ea officia qui explicabo", new DateTime(2020, 7, 14, 15, 32, 46, 853, DateTimeKind.Local).AddTicks(3650), "In qui labore omnis voluptas voluptates aspernatur consectetur pariatur.", 9, 7, 3 },
                    { 5, new DateTime(2020, 7, 6, 15, 32, 46, 853, DateTimeKind.Local).AddTicks(3641), @"Rerum totam sit.
                Velit saepe iusto et repellat et consequuntur sit.
                Voluptate officiis pariatur ut ea.
                Neque ut sed voluptatem occaecati.
                Dolor velit quaerat molestiae assumenda veritatis ", new DateTime(2020, 7, 11, 15, 32, 46, 853, DateTimeKind.Local).AddTicks(3644), "Voluptate neque vel molestiae dolor nulla voluptas voluptas optio.", 3, 13, 1 },
                    { 12, new DateTime(2020, 7, 9, 15, 32, 46, 853, DateTimeKind.Local).AddTicks(3684), @"Optio modi exercitationem quia in omnis alias.
                Esse a voluptatem porro quo voluptatem fuga eos consequatur sit.
                Repellendus labore excepturi eaque impedit minus rerum ut qui eum.", new DateTime(2020, 7, 10, 15, 32, 46, 853, DateTimeKind.Local).AddTicks(3686), "Quidem dolores ut dolores atque sapiente laborum sint.", 7, 12, 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "TaskState",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TaskState",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TaskState",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TaskState",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 8);
        }
    }
}
