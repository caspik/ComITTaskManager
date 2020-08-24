using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskManager.Migrations
{
    public partial class MyFirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    TaskStartDate = table.Column<DateTime>(nullable: false),
                    TaskEndDate = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProjectList",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    TaskListId = table.Column<Guid>(nullable: false),
                    ProjectName = table.Column<string>(nullable: true),
                    ProjectStartDate = table.Column<DateTime>(nullable: false),
                    ProjectEndDate = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectList", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectList_Tasks_TaskListId",
                        column: x => x.TaskListId,
                        principalTable: "Tasks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProjectList_TaskListId",
                table: "ProjectList",
                column: "TaskListId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProjectList");

            migrationBuilder.DropTable(
                name: "Tasks");
        }
    }
}
