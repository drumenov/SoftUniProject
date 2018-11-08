using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SoftUniProject.Data.Migrations
{
    public partial class ExpandedDbWithConnectionBetweenExpertsAndRepairTasks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RepairTask",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RepairTask", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UsersRepairsTasks",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RepairTaskId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersRepairsTasks", x => new { x.RepairTaskId, x.UserId });
                    table.ForeignKey(
                        name: "FK_UsersRepairsTasks_RepairTask_RepairTaskId",
                        column: x => x.RepairTaskId,
                        principalTable: "RepairTask",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsersRepairsTasks_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UsersRepairsTasks_UserId",
                table: "UsersRepairsTasks",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UsersRepairsTasks");

            migrationBuilder.DropTable(
                name: "RepairTask");
        }
    }
}
