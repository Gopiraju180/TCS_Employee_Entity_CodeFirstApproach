﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TCS_Employee_Entity_CodeFirstApproach.Migrations
{
    /// <inheritdoc />
    public partial class Department : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "departements",
                columns: table => new
                {
                    deptid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    deptname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    deptlocation = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_departements", x => x.deptid);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "departements");
        }
    }
}
