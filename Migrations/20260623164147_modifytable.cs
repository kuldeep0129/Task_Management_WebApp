using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Task_Management_Web.Migrations
{
    /// <inheritdoc />
    public partial class modifytable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Task_status",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Assign_Id = table.Column<int>(type: "int", nullable: false),
                    Alloted_id = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Priority = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Is_Active = table.Column<bool>(type: "bit", nullable: false),
                    create_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    create_by = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    update_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    update_by = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Task_status", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_tbl_User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mobile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProfilePicture = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_tbl_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_task_Sub_Statuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    task_status_id = table.Column<int>(type: "int", nullable: false),
                    TaskStatusId = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Is_active = table.Column<bool>(type: "bit", nullable: false),
                    create_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    create_by = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    update_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    update_by = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_task_Sub_Statuses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_task_Sub_Statuses_Task_status_TaskStatusId",
                        column: x => x.TaskStatusId,
                        principalTable: "Task_status",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_task_Sub_Statuses_TaskStatusId",
                table: "tbl_task_Sub_Statuses",
                column: "TaskStatusId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_task_Sub_Statuses");

            migrationBuilder.DropTable(
                name: "tbl_tbl_User");

            migrationBuilder.DropTable(
                name: "Task_status");
        }
    }
}
