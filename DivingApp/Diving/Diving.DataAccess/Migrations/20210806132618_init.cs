using Microsoft.EntityFrameworkCore.Migrations;

namespace Diving.DataAccess.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DivingBoats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DivingBoats", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HeadInstructors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    License = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DivingBoatsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeadInstructors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HeadInstructors_DivingBoats_DivingBoatsId",
                        column: x => x.DivingBoatsId,
                        principalTable: "DivingBoats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DivingSchools",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InstructorId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HeadInstructorId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DivingSchools", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DivingSchools_HeadInstructors_HeadInstructorId",
                        column: x => x.HeadInstructorId,
                        principalTable: "HeadInstructors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DivingSchools_HeadInstructorId",
                table: "DivingSchools",
                column: "HeadInstructorId");

            migrationBuilder.CreateIndex(
                name: "IX_HeadInstructors_DivingBoatsId",
                table: "HeadInstructors",
                column: "DivingBoatsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DivingSchools");

            migrationBuilder.DropTable(
                name: "HeadInstructors");

            migrationBuilder.DropTable(
                name: "DivingBoats");
        }
    }
}
