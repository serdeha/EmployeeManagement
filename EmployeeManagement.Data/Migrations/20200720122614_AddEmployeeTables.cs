using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeManagement.Data.Migrations
{
    public partial class AddEmployeeTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmployeeLeaveTypes",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    DefaultDays = table.Column<int>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeLeaveTypes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeLeaveAllocations",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumberOfDays = table.Column<int>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    Period = table.Column<int>(nullable: false),
                    EmployeeID = table.Column<string>(nullable: true),
                    EmployeeLeaveTypeID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeLeaveAllocations", x => x.ID);
                    table.ForeignKey(
                        name: "FK_EmployeeLeaveAllocations_AspNetUsers_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmployeeLeaveAllocations_EmployeeLeaveTypes_EmployeeLeaveTypeID",
                        column: x => x.EmployeeLeaveTypeID,
                        principalTable: "EmployeeLeaveTypes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeLeaveRequests",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestingEmployeeID = table.Column<string>(nullable: true),
                    ApprovedEmployeeID = table.Column<string>(nullable: true),
                    EmployeeLeaveTypeID = table.Column<int>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    DateRequested = table.Column<DateTime>(nullable: false),
                    RequestComments = table.Column<string>(nullable: true),
                    Approved = table.Column<bool>(nullable: true),
                    Cancelled = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeLeaveRequests", x => x.ID);
                    table.ForeignKey(
                        name: "FK_EmployeeLeaveRequests_AspNetUsers_ApprovedEmployeeID",
                        column: x => x.ApprovedEmployeeID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmployeeLeaveRequests_EmployeeLeaveTypes_EmployeeLeaveTypeID",
                        column: x => x.EmployeeLeaveTypeID,
                        principalTable: "EmployeeLeaveTypes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeLeaveRequests_AspNetUsers_RequestingEmployeeID",
                        column: x => x.RequestingEmployeeID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeLeaveAllocations_EmployeeID",
                table: "EmployeeLeaveAllocations",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeLeaveAllocations_EmployeeLeaveTypeID",
                table: "EmployeeLeaveAllocations",
                column: "EmployeeLeaveTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeLeaveRequests_ApprovedEmployeeID",
                table: "EmployeeLeaveRequests",
                column: "ApprovedEmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeLeaveRequests_EmployeeLeaveTypeID",
                table: "EmployeeLeaveRequests",
                column: "EmployeeLeaveTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeLeaveRequests_RequestingEmployeeID",
                table: "EmployeeLeaveRequests",
                column: "RequestingEmployeeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeLeaveAllocations");

            migrationBuilder.DropTable(
                name: "EmployeeLeaveRequests");

            migrationBuilder.DropTable(
                name: "EmployeeLeaveTypes");
        }
    }
}
