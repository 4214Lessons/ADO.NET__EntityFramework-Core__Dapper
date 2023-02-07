﻿// <auto-generated />
using System;
using Lesson9_EntityFrameworkCore_DbFirst_2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Lesson9_EntityFrameworkCore_DbFirst_2.Migrations
{
    [DbContext(typeof(LibraryContext))]
    [Migration("20230207071810_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Lesson9_EntityFrameworkCore_DbFirst_2.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("Id");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("Lesson9_EntityFrameworkCore_DbFirst_2.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Comment")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("IdAuthor")
                        .HasColumnType("int")
                        .HasColumnName("Id_Author");

                    b.Property<int>("IdCategory")
                        .HasColumnType("int")
                        .HasColumnName("Id_Category");

                    b.Property<int>("IdPress")
                        .HasColumnType("int")
                        .HasColumnName("Id_Press");

                    b.Property<int>("IdThemes")
                        .HasColumnType("int")
                        .HasColumnName("Id_Themes");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Pages")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("YearPress")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdAuthor");

                    b.HasIndex("IdCategory");

                    b.HasIndex("IdPress");

                    b.HasIndex("IdThemes");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("Lesson9_EntityFrameworkCore_DbFirst_2.Models.BooksViewTest", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Pages")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("YearPress")
                        .HasColumnType("int");

                    b.ToView("BooksViewTest");
                });

            modelBuilder.Entity("Lesson9_EntityFrameworkCore_DbFirst_2.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Lesson9_EntityFrameworkCore_DbFirst_2.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("Id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("Lesson9_EntityFrameworkCore_DbFirst_2.Models.Faculty", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Faculties");
                });

            modelBuilder.Entity("Lesson9_EntityFrameworkCore_DbFirst_2.Models.Group", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("IdFaculty")
                        .HasColumnType("int")
                        .HasColumnName("Id_Faculty");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.HasIndex("IdFaculty");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("Lesson9_EntityFrameworkCore_DbFirst_2.Models.Lib", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("Id");

                    b.ToTable("Libs");
                });

            modelBuilder.Entity("Lesson9_EntityFrameworkCore_DbFirst_2.Models.Press", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Press", (string)null);
                });

            modelBuilder.Entity("Lesson9_EntityFrameworkCore_DbFirst_2.Models.SCard", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DateIn")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("DateOut")
                        .HasColumnType("datetime");

                    b.Property<int>("IdBook")
                        .HasColumnType("int")
                        .HasColumnName("Id_Book");

                    b.Property<int>("IdLib")
                        .HasColumnType("int")
                        .HasColumnName("Id_Lib");

                    b.Property<int>("IdStudent")
                        .HasColumnType("int")
                        .HasColumnName("Id_Student");

                    b.HasKey("Id");

                    b.HasIndex("IdBook");

                    b.HasIndex("IdLib");

                    b.HasIndex("IdStudent");

                    b.ToTable("S_Cards", (string)null);
                });

            modelBuilder.Entity("Lesson9_EntityFrameworkCore_DbFirst_2.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<int>("IdGroup")
                        .HasColumnType("int")
                        .HasColumnName("Id_Group");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<int>("Term")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdGroup");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Lesson9_EntityFrameworkCore_DbFirst_2.Models.TCard", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DateIn")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("DateOut")
                        .HasColumnType("datetime");

                    b.Property<int>("IdBook")
                        .HasColumnType("int")
                        .HasColumnName("Id_Book");

                    b.Property<int>("IdLib")
                        .HasColumnType("int")
                        .HasColumnName("Id_Lib");

                    b.Property<int>("IdTeacher")
                        .HasColumnType("int")
                        .HasColumnName("Id_Teacher");

                    b.HasKey("Id");

                    b.HasIndex("IdBook");

                    b.HasIndex("IdLib");

                    b.HasIndex("IdTeacher");

                    b.ToTable("T_Cards", (string)null);
                });

            modelBuilder.Entity("Lesson9_EntityFrameworkCore_DbFirst_2.Models.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<int>("IdDep")
                        .HasColumnType("int")
                        .HasColumnName("Id_Dep");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("Id");

                    b.HasIndex("IdDep");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("Lesson9_EntityFrameworkCore_DbFirst_2.Models.Theme", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Themes");
                });

            modelBuilder.Entity("Lesson9_EntityFrameworkCore_DbFirst_2.Models.Book", b =>
                {
                    b.HasOne("Lesson9_EntityFrameworkCore_DbFirst_2.Models.Author", "IdAuthorNavigation")
                        .WithMany("Books")
                        .HasForeignKey("IdAuthor")
                        .IsRequired()
                        .HasConstraintName("FK_Books_Author");

                    b.HasOne("Lesson9_EntityFrameworkCore_DbFirst_2.Models.Category", "IdCategoryNavigation")
                        .WithMany("Books")
                        .HasForeignKey("IdCategory")
                        .IsRequired()
                        .HasConstraintName("FK_Books_Category");

                    b.HasOne("Lesson9_EntityFrameworkCore_DbFirst_2.Models.Press", "IdPressNavigation")
                        .WithMany("Books")
                        .HasForeignKey("IdPress")
                        .IsRequired()
                        .HasConstraintName("FK_Books_Press");

                    b.HasOne("Lesson9_EntityFrameworkCore_DbFirst_2.Models.Theme", "IdThemesNavigation")
                        .WithMany("Books")
                        .HasForeignKey("IdThemes")
                        .IsRequired()
                        .HasConstraintName("FK_Books_Theme");

                    b.Navigation("IdAuthorNavigation");

                    b.Navigation("IdCategoryNavigation");

                    b.Navigation("IdPressNavigation");

                    b.Navigation("IdThemesNavigation");
                });

            modelBuilder.Entity("Lesson9_EntityFrameworkCore_DbFirst_2.Models.Group", b =>
                {
                    b.HasOne("Lesson9_EntityFrameworkCore_DbFirst_2.Models.Faculty", "IdFacultyNavigation")
                        .WithMany("Groups")
                        .HasForeignKey("IdFaculty")
                        .IsRequired()
                        .HasConstraintName("FK_Groups_Faculty");

                    b.Navigation("IdFacultyNavigation");
                });

            modelBuilder.Entity("Lesson9_EntityFrameworkCore_DbFirst_2.Models.SCard", b =>
                {
                    b.HasOne("Lesson9_EntityFrameworkCore_DbFirst_2.Models.Book", "IdBookNavigation")
                        .WithMany("SCards")
                        .HasForeignKey("IdBook")
                        .IsRequired()
                        .HasConstraintName("FK_S_Cards_Book");

                    b.HasOne("Lesson9_EntityFrameworkCore_DbFirst_2.Models.Lib", "IdLibNavigation")
                        .WithMany("SCards")
                        .HasForeignKey("IdLib")
                        .IsRequired()
                        .HasConstraintName("FK_S_Cards_Lib");

                    b.HasOne("Lesson9_EntityFrameworkCore_DbFirst_2.Models.Student", "IdStudentNavigation")
                        .WithMany("SCards")
                        .HasForeignKey("IdStudent")
                        .IsRequired()
                        .HasConstraintName("FK_S_Cards_Stud");

                    b.Navigation("IdBookNavigation");

                    b.Navigation("IdLibNavigation");

                    b.Navigation("IdStudentNavigation");
                });

            modelBuilder.Entity("Lesson9_EntityFrameworkCore_DbFirst_2.Models.Student", b =>
                {
                    b.HasOne("Lesson9_EntityFrameworkCore_DbFirst_2.Models.Group", "IdGroupNavigation")
                        .WithMany("Students")
                        .HasForeignKey("IdGroup")
                        .IsRequired()
                        .HasConstraintName("FK_Students_Group");

                    b.Navigation("IdGroupNavigation");
                });

            modelBuilder.Entity("Lesson9_EntityFrameworkCore_DbFirst_2.Models.TCard", b =>
                {
                    b.HasOne("Lesson9_EntityFrameworkCore_DbFirst_2.Models.Book", "IdBookNavigation")
                        .WithMany("TCards")
                        .HasForeignKey("IdBook")
                        .IsRequired()
                        .HasConstraintName("FK_T_Cards_Book");

                    b.HasOne("Lesson9_EntityFrameworkCore_DbFirst_2.Models.Lib", "IdLibNavigation")
                        .WithMany("TCards")
                        .HasForeignKey("IdLib")
                        .IsRequired()
                        .HasConstraintName("FK_T_Cards_Lib");

                    b.HasOne("Lesson9_EntityFrameworkCore_DbFirst_2.Models.Teacher", "IdTeacherNavigation")
                        .WithMany("TCards")
                        .HasForeignKey("IdTeacher")
                        .IsRequired()
                        .HasConstraintName("FK_T_Cards_Teacher");

                    b.Navigation("IdBookNavigation");

                    b.Navigation("IdLibNavigation");

                    b.Navigation("IdTeacherNavigation");
                });

            modelBuilder.Entity("Lesson9_EntityFrameworkCore_DbFirst_2.Models.Teacher", b =>
                {
                    b.HasOne("Lesson9_EntityFrameworkCore_DbFirst_2.Models.Department", "IdDepNavigation")
                        .WithMany("Teachers")
                        .HasForeignKey("IdDep")
                        .IsRequired()
                        .HasConstraintName("FK_Teachers_Dep");

                    b.Navigation("IdDepNavigation");
                });

            modelBuilder.Entity("Lesson9_EntityFrameworkCore_DbFirst_2.Models.Author", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("Lesson9_EntityFrameworkCore_DbFirst_2.Models.Book", b =>
                {
                    b.Navigation("SCards");

                    b.Navigation("TCards");
                });

            modelBuilder.Entity("Lesson9_EntityFrameworkCore_DbFirst_2.Models.Category", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("Lesson9_EntityFrameworkCore_DbFirst_2.Models.Department", b =>
                {
                    b.Navigation("Teachers");
                });

            modelBuilder.Entity("Lesson9_EntityFrameworkCore_DbFirst_2.Models.Faculty", b =>
                {
                    b.Navigation("Groups");
                });

            modelBuilder.Entity("Lesson9_EntityFrameworkCore_DbFirst_2.Models.Group", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("Lesson9_EntityFrameworkCore_DbFirst_2.Models.Lib", b =>
                {
                    b.Navigation("SCards");

                    b.Navigation("TCards");
                });

            modelBuilder.Entity("Lesson9_EntityFrameworkCore_DbFirst_2.Models.Press", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("Lesson9_EntityFrameworkCore_DbFirst_2.Models.Student", b =>
                {
                    b.Navigation("SCards");
                });

            modelBuilder.Entity("Lesson9_EntityFrameworkCore_DbFirst_2.Models.Teacher", b =>
                {
                    b.Navigation("TCards");
                });

            modelBuilder.Entity("Lesson9_EntityFrameworkCore_DbFirst_2.Models.Theme", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
