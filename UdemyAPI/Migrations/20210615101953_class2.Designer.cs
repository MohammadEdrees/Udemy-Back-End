﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UdemyAPI.Models;

namespace UdemyAPI.Migrations
{
    [DbContext(typeof(UdemyContext))]
    [Migration("20210615101953_class2")]
    partial class class2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("UdemyAPI.Authentication.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("UdemyAPI.Models.Admin", b =>
                {
                    b.Property<int>("AdminId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Admin_Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Img")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("AdminId");

                    b.ToTable("Admin");
                });

            modelBuilder.Entity("UdemyAPI.Models.AdminCr", b =>
                {
                    b.Property<int>("AdminId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Admin_Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CrsId")
                        .HasColumnType("int")
                        .HasColumnName("Crs_Id");

                    b.Property<string>("Manage")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("AdminId", "CrsId");

                    b.ToTable("Admin_Crs");
                });

            modelBuilder.Entity("UdemyAPI.Models.Card", b =>
                {
                    b.Property<int>("CId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("InstId")
                        .HasColumnType("int");

                    b.Property<int?>("StdId")
                        .HasColumnType("int");

                    b.HasKey("CId");

                    b.HasIndex("InstId")
                        .IsUnique()
                        .HasFilter("[InstId] IS NOT NULL");

                    b.HasIndex("StdId")
                        .IsUnique()
                        .HasFilter("[StdId] IS NOT NULL");

                    b.ToTable("Card");
                });

            modelBuilder.Entity("UdemyAPI.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Category_Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Category_Name");

                    b.Property<string>("imgPath")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("UdemyAPI.Models.Choice", b =>
                {
                    b.Property<int>("QuestionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Question_Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Choices")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("QuestionId", "Choices");

                    b.ToTable("Choice");
                });

            modelBuilder.Entity("UdemyAPI.Models.Course", b =>
                {
                    b.Property<int>("CrsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Crs_Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Duration")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("InstId")
                        .HasColumnType("int");

                    b.Property<string>("Languge")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Levels")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PaymentMethod")
                        .HasColumnType("int");

                    b.Property<double?>("Price")
                        .HasColumnType("float");

                    b.Property<double>("Rate")
                        .HasColumnType("float");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Subtitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasDefaultValueSql("(N'')");

                    b.Property<int?>("TopId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("CrsId");

                    b.HasIndex("CId");

                    b.HasIndex("InstId");

                    b.HasIndex("TopId");

                    b.ToTable("Course");
                });

            modelBuilder.Entity("UdemyAPI.Models.CourseInCard", b =>
                {
                    b.Property<int>("CId")
                        .HasColumnType("int");

                    b.Property<int>("CrsId")
                        .HasColumnType("int");

                    b.HasKey("CId", "CrsId");

                    b.HasIndex("CrsId");

                    b.ToTable("CourseInCards");
                });

            modelBuilder.Entity("UdemyAPI.Models.CourseSection", b =>
                {
                    b.Property<int>("SectionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CrsId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SectionId");

                    b.HasIndex("CrsId");

                    b.ToTable("CourseSections");
                });

            modelBuilder.Entity("UdemyAPI.Models.Exam", b =>
                {
                    b.Property<int>("ExmId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Exm_Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CrsId")
                        .HasColumnType("int")
                        .HasColumnName("Crs_Id");

                    b.Property<string>("ExamName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Exam_Name");

                    b.HasKey("ExmId");

                    b.ToTable("Exam");
                });

            modelBuilder.Entity("UdemyAPI.Models.Instructor", b =>
                {
                    b.Property<int>("InstId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Inst_Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Biography")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("CId")
                        .HasColumnType("int");

                    b.Property<string>("Class")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Communication")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Fname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("HeadLine")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ImagPath")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Language")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Lname")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Phone")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("InstId");

                    b.ToTable("Instructor");
                });

            modelBuilder.Entity("UdemyAPI.Models.Lecture", b =>
                {
                    b.Property<int>("LectureId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Lecture_Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("Duration")
                        .HasColumnType("int");

                    b.Property<string>("Link")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SectionId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("LectureId");

                    b.HasIndex("SectionId");

                    b.ToTable("Lecture");
                });

            modelBuilder.Entity("UdemyAPI.Models.Question", b =>
                {
                    b.Property<int>("QuestionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Question_Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Answer")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Degree")
                        .HasColumnType("int");

                    b.Property<string>("Formula")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("type");

                    b.HasKey("QuestionId");

                    b.ToTable("Question");
                });

            modelBuilder.Entity("UdemyAPI.Models.StdCr", b =>
                {
                    b.Property<int>("StdId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Std_Id");

                    b.Property<int>("CrsId")
                        .HasColumnType("int")
                        .HasColumnName("Crs_Id");

                    b.Property<string>("Certificate")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("Grade")
                        .HasColumnType("int");

                    b.HasKey("StdId", "CrsId");

                    b.HasIndex("CrsId");

                    b.ToTable("Std_Crs");
                });

            modelBuilder.Entity("UdemyAPI.Models.StdExam", b =>
                {
                    b.Property<int>("StdId")
                        .HasColumnType("int")
                        .HasColumnName("Std_Id");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int")
                        .HasColumnName("Question_Id");

                    b.Property<int>("ExamId")
                        .HasColumnType("int")
                        .HasColumnName("Exam_Id");

                    b.Property<string>("StdAnswer")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Std_Answer");

                    b.HasKey("StdId", "QuestionId", "ExamId")
                        .HasName("PK_Std_Exam_1");

                    b.ToTable("Std_Exam");
                });

            modelBuilder.Entity("UdemyAPI.Models.Student", b =>
                {
                    b.Property<int>("StdId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Std_Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Class")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ImagePath")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("imagePath");

                    b.Property<string>("Lname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("password");

                    b.Property<string>("Phone")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("phone");

                    b.Property<string>("Token")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StdId");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("UdemyAPI.Models.SupCateg", b =>
                {
                    b.Property<int>("SupCatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("SupCatTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SupCatId");

                    b.HasIndex("CategoryId");

                    b.ToTable("SupCategs");
                });

            modelBuilder.Entity("UdemyAPI.Models.Topic", b =>
                {
                    b.Property<int>("TopId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Top_Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("SupCatId")
                        .HasColumnType("int")
                        .HasColumnName("SupCat_Id");

                    b.Property<string>("TopImg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TopName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Top_Name");

                    b.HasKey("TopId");

                    b.HasIndex("SupCatId");

                    b.ToTable("Topic");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("UdemyAPI.Authentication.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("UdemyAPI.Authentication.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UdemyAPI.Authentication.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("UdemyAPI.Authentication.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("UdemyAPI.Models.Card", b =>
                {
                    b.HasOne("UdemyAPI.Models.Instructor", "Instructor")
                        .WithOne("Card")
                        .HasForeignKey("UdemyAPI.Models.Card", "InstId");

                    b.HasOne("UdemyAPI.Models.Student", "Student")
                        .WithOne("Card")
                        .HasForeignKey("UdemyAPI.Models.Card", "StdId");

                    b.Navigation("Instructor");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("UdemyAPI.Models.Course", b =>
                {
                    b.HasOne("UdemyAPI.Models.Card", "Card")
                        .WithMany("Courses")
                        .HasForeignKey("CId");

                    b.HasOne("UdemyAPI.Models.Instructor", "Instructor")
                        .WithMany("courses")
                        .HasForeignKey("InstId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UdemyAPI.Models.Topic", "Top")
                        .WithMany("Courses")
                        .HasForeignKey("TopId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Card");

                    b.Navigation("Instructor");

                    b.Navigation("Top");
                });

            modelBuilder.Entity("UdemyAPI.Models.CourseInCard", b =>
                {
                    b.HasOne("UdemyAPI.Models.Card", "Card")
                        .WithMany("CourseInCards")
                        .HasForeignKey("CId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UdemyAPI.Models.Course", "Course")
                        .WithMany("CourseInCards")
                        .HasForeignKey("CrsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Card");

                    b.Navigation("Course");
                });

            modelBuilder.Entity("UdemyAPI.Models.CourseSection", b =>
                {
                    b.HasOne("UdemyAPI.Models.Course", "Course")
                        .WithMany("CourseSections")
                        .HasForeignKey("CrsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("UdemyAPI.Models.Lecture", b =>
                {
                    b.HasOne("UdemyAPI.Models.CourseSection", "CourseSection")
                        .WithMany("CourseLecture")
                        .HasForeignKey("SectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CourseSection");
                });

            modelBuilder.Entity("UdemyAPI.Models.StdCr", b =>
                {
                    b.HasOne("UdemyAPI.Models.Course", "Course")
                        .WithMany("studentCourses")
                        .HasForeignKey("CrsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UdemyAPI.Models.Student", "Student")
                        .WithMany("StudentCourses")
                        .HasForeignKey("StdId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("UdemyAPI.Models.SupCateg", b =>
                {
                    b.HasOne("UdemyAPI.Models.Category", "Category")
                        .WithMany("SupCategs")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("UdemyAPI.Models.Topic", b =>
                {
                    b.HasOne("UdemyAPI.Models.SupCateg", "supCateg")
                        .WithMany("Topics")
                        .HasForeignKey("SupCatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("supCateg");
                });

            modelBuilder.Entity("UdemyAPI.Models.Card", b =>
                {
                    b.Navigation("CourseInCards");

                    b.Navigation("Courses");
                });

            modelBuilder.Entity("UdemyAPI.Models.Category", b =>
                {
                    b.Navigation("SupCategs");
                });

            modelBuilder.Entity("UdemyAPI.Models.Course", b =>
                {
                    b.Navigation("CourseInCards");

                    b.Navigation("CourseSections");

                    b.Navigation("studentCourses");
                });

            modelBuilder.Entity("UdemyAPI.Models.CourseSection", b =>
                {
                    b.Navigation("CourseLecture");
                });

            modelBuilder.Entity("UdemyAPI.Models.Instructor", b =>
                {
                    b.Navigation("Card");

                    b.Navigation("courses");
                });

            modelBuilder.Entity("UdemyAPI.Models.Student", b =>
                {
                    b.Navigation("Card");

                    b.Navigation("StudentCourses");
                });

            modelBuilder.Entity("UdemyAPI.Models.SupCateg", b =>
                {
                    b.Navigation("Topics");
                });

            modelBuilder.Entity("UdemyAPI.Models.Topic", b =>
                {
                    b.Navigation("Courses");
                });
#pragma warning restore 612, 618
        }
    }
}
