using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class AddTaskStateTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "State",
                table: "Tasks");

            migrationBuilder.AddColumn<int>(
                name: "TaskStateId",
                table: "Tasks",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "TaskState",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    State = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskState", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_TaskStateId",
                table: "Tasks",
                column: "TaskStateId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_TaskState_TaskStateId",
                table: "Tasks",
                column: "TaskStateId",
                principalTable: "TaskState",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_TaskState_TaskStateId",
                table: "Tasks");

            migrationBuilder.DropTable(
                name: "TaskState");

            migrationBuilder.DropIndex(
                name: "IX_Tasks_TaskStateId",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "TaskStateId",
                table: "Tasks");

            migrationBuilder.AddColumn<int>(
                name: "State",
                table: "Tasks",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
