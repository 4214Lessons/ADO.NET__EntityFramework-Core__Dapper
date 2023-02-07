using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lesson9_EntityFrameworkCore_DbFirst_2.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Faculties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faculties", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Libs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Libs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Press",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Press", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Themes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Themes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Id_Dep = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teachers_Dep",
                        column: x => x.Id_Dep,
                        principalTable: "Departments",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Id_Faculty = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Groups_Faculty",
                        column: x => x.Id_Faculty,
                        principalTable: "Faculties",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Pages = table.Column<int>(type: "int", nullable: false),
                    YearPress = table.Column<int>(type: "int", nullable: false),
                    Id_Themes = table.Column<int>(type: "int", nullable: false),
                    Id_Category = table.Column<int>(type: "int", nullable: false),
                    Id_Author = table.Column<int>(type: "int", nullable: false),
                    Id_Press = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Author",
                        column: x => x.Id_Author,
                        principalTable: "Authors",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Books_Category",
                        column: x => x.Id_Category,
                        principalTable: "Categories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Books_Press",
                        column: x => x.Id_Press,
                        principalTable: "Press",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Books_Theme",
                        column: x => x.Id_Themes,
                        principalTable: "Themes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Id_Group = table.Column<int>(type: "int", nullable: false),
                    Term = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Students_Group",
                        column: x => x.Id_Group,
                        principalTable: "Groups",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "T_Cards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Id_Teacher = table.Column<int>(type: "int", nullable: false),
                    Id_Book = table.Column<int>(type: "int", nullable: false),
                    DateOut = table.Column<DateTime>(type: "datetime", nullable: false),
                    DateIn = table.Column<DateTime>(type: "datetime", nullable: true),
                    Id_Lib = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Cards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_T_Cards_Book",
                        column: x => x.Id_Book,
                        principalTable: "Books",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_T_Cards_Lib",
                        column: x => x.Id_Lib,
                        principalTable: "Libs",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_T_Cards_Teacher",
                        column: x => x.Id_Teacher,
                        principalTable: "Teachers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "S_Cards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Id_Student = table.Column<int>(type: "int", nullable: false),
                    Id_Book = table.Column<int>(type: "int", nullable: false),
                    DateOut = table.Column<DateTime>(type: "datetime", nullable: false),
                    DateIn = table.Column<DateTime>(type: "datetime", nullable: true),
                    Id_Lib = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_S_Cards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_S_Cards_Book",
                        column: x => x.Id_Book,
                        principalTable: "Books",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_S_Cards_Lib",
                        column: x => x.Id_Lib,
                        principalTable: "Libs",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_S_Cards_Stud",
                        column: x => x.Id_Student,
                        principalTable: "Students",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_Id_Author",
                table: "Books",
                column: "Id_Author");

            migrationBuilder.CreateIndex(
                name: "IX_Books_Id_Category",
                table: "Books",
                column: "Id_Category");

            migrationBuilder.CreateIndex(
                name: "IX_Books_Id_Press",
                table: "Books",
                column: "Id_Press");

            migrationBuilder.CreateIndex(
                name: "IX_Books_Id_Themes",
                table: "Books",
                column: "Id_Themes");

            migrationBuilder.CreateIndex(
                name: "IX_Groups_Id_Faculty",
                table: "Groups",
                column: "Id_Faculty");

            migrationBuilder.CreateIndex(
                name: "IX_S_Cards_Id_Book",
                table: "S_Cards",
                column: "Id_Book");

            migrationBuilder.CreateIndex(
                name: "IX_S_Cards_Id_Lib",
                table: "S_Cards",
                column: "Id_Lib");

            migrationBuilder.CreateIndex(
                name: "IX_S_Cards_Id_Student",
                table: "S_Cards",
                column: "Id_Student");

            migrationBuilder.CreateIndex(
                name: "IX_Students_Id_Group",
                table: "Students",
                column: "Id_Group");

            migrationBuilder.CreateIndex(
                name: "IX_T_Cards_Id_Book",
                table: "T_Cards",
                column: "Id_Book");

            migrationBuilder.CreateIndex(
                name: "IX_T_Cards_Id_Lib",
                table: "T_Cards",
                column: "Id_Lib");

            migrationBuilder.CreateIndex(
                name: "IX_T_Cards_Id_Teacher",
                table: "T_Cards",
                column: "Id_Teacher");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_Id_Dep",
                table: "Teachers",
                column: "Id_Dep");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "S_Cards");

            migrationBuilder.DropTable(
                name: "T_Cards");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Libs");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Press");

            migrationBuilder.DropTable(
                name: "Themes");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Faculties");
        }
    }
}
