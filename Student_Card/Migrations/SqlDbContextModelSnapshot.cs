﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Student_Card.Data;

#nullable disable

namespace Student_Card.Migrations
{
    [DbContext(typeof(SqlDbContext))]
    partial class SqlDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

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

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
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

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
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

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Student_Card.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CourseNumber")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Initials")
                        .HasColumnType("nvarchar(max)");

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

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
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

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Student_Card.Models.Course", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("CourseCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CourseDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CourseName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CourseCode = "DP_ITC",
                            CourseDescription = "The world is increasingly becoming a global village, with Information and Communication Technologies (ICTs) playing a fundamental role in our day-to-day lives. South Africa, like other countries, realises that ICTs can indeed bring about positive change in its socio-economic development. CUT’s contribution to this national agenda is realised through diploma, BTech and MTech programmes offered in the Department of IT. Through these programmes, the university contributes to the ever-increasing demand for a wide range of highly skilled information technology professionals in fields such as web applications, communication networks and software development. The department is particularly unique in the country, as it offers courses in mobile programming and games development. The department has state-of-the-art Cisco equipment through which students get hands-on experience in computer networking, which provides opportunities for various professional certification pathways.",
                            CourseName = "Diploma in Information Technology"
                        },
                        new
                        {
                            ID = 2,
                            CourseCode = "HC_ITC",
                            CourseDescription = "The world is increasingly becoming a global village, with Information and Communication Technologies (ICTs) playing a fundamental role in our day-to-day lives. South Africa, like other countries, realises that ICTs can indeed bring about positive change in its socio-economic development. CUT’s contribution to this national agenda is realised through diploma, BTech and MTech programmes offered in the Department of IT. Through these programmes, the university contributes to the ever-increasing demand for a wide range of highly skilled information technology professionals in fields such as web applications, communication networks and software development. The department is particularly unique in the country, as it offers courses in mobile programming and games development. The department has state-of-the-art Cisco equipment through which students get hands-on experience in computer networking, which provides opportunities for various professional certification pathways.",
                            CourseName = "Higher Certificate in Information Technology"
                        },
                        new
                        {
                            ID = 3,
                            CourseCode = "PGCE",
                            CourseDescription = "The world is increasingly becoming a global village, with Information and Communication Technologies (ICTs) playing a fundamental role in our day-to-day lives. South Africa, like other countries, realises that ICTs can indeed bring about positive change in its socio-economic development. CUT’s contribution to this national agenda is realised through diploma, BTech and MTech programmes offered in the Department of IT. Through these programmes, the university contributes to the ever-increasing demand for a wide range of highly skilled information technology professionals in fields such as web applications, communication networks and software development. The department is particularly unique in the country, as it offers courses in mobile programming and games development. The department has state-of-the-art Cisco equipment through which students get hands-on experience in computer networking, which provides opportunities for various professional certification pathways.",
                            CourseName = "Postgraduate Certificate In Education"
                        },
                        new
                        {
                            ID = 4,
                            CourseCode = "MEd",
                            CourseDescription = "The world is increasingly becoming a global village, with Information and Communication Technologies (ICTs) playing a fundamental role in our day-to-day lives. South Africa, like other countries, realises that ICTs can indeed bring about positive change in its socio-economic development. CUT’s contribution to this national agenda is realised through diploma, BTech and MTech programmes offered in the Department of IT. Through these programmes, the university contributes to the ever-increasing demand for a wide range of highly skilled information technology professionals in fields such as web applications, communication networks and software development. The department is particularly unique in the country, as it offers courses in mobile programming and games development. The department has state-of-the-art Cisco equipment through which students get hands-on experience in computer networking, which provides opportunities for various professional certification pathways.",
                            CourseName = "Master of Education"
                        },
                        new
                        {
                            ID = 5,
                            CourseCode = "B.Ed_FT",
                            CourseDescription = "The world is increasingly becoming a global village, with Information and Communication Technologies (ICTs) playing a fundamental role in our day-to-day lives. South Africa, like other countries, realises that ICTs can indeed bring about positive change in its socio-economic development. CUT’s contribution to this national agenda is realised through diploma, BTech and MTech programmes offered in the Department of IT. Through these programmes, the university contributes to the ever-increasing demand for a wide range of highly skilled information technology professionals in fields such as web applications, communication networks and software development. The department is particularly unique in the country, as it offers courses in mobile programming and games development. The department has state-of-the-art Cisco equipment through which students get hands-on experience in computer networking, which provides opportunities for various professional certification pathways.",
                            CourseName = "B. Ed: Foundation Phase Teaching"
                        },
                        new
                        {
                            ID = 6,
                            CourseCode = "DP_MDS",
                            CourseDescription = "The world is increasingly becoming a global village, with Information and Communication Technologies (ICTs) playing a fundamental role in our day-to-day lives. South Africa, like other countries, realises that ICTs can indeed bring about positive change in its socio-economic development. CUT’s contribution to this national agenda is realised through diploma, BTech and MTech programmes offered in the Department of IT. Through these programmes, the university contributes to the ever-increasing demand for a wide range of highly skilled information technology professionals in fields such as web applications, communication networks and software development. The department is particularly unique in the country, as it offers courses in mobile programming and games development. The department has state-of-the-art Cisco equipment through which students get hands-on experience in computer networking, which provides opportunities for various professional certification pathways.",
                            CourseName = "Language Practice and Media Studies"
                        },
                        new
                        {
                            ID = 7,
                            CourseCode = "B_MAN",
                            CourseDescription = "The world is increasingly becoming a global village, with Information and Communication Technologies (ICTs) playing a fundamental role in our day-to-day lives. South Africa, like other countries, realises that ICTs can indeed bring about positive change in its socio-economic development. CUT’s contribution to this national agenda is realised through diploma, BTech and MTech programmes offered in the Department of IT. Through these programmes, the university contributes to the ever-increasing demand for a wide range of highly skilled information technology professionals in fields such as web applications, communication networks and software development. The department is particularly unique in the country, as it offers courses in mobile programming and games development. The department has state-of-the-art Cisco equipment through which students get hands-on experience in computer networking, which provides opportunities for various professional certification pathways.",
                            CourseName = "Bachelor Management Sciences in Accountancy"
                        },
                        new
                        {
                            ID = 8,
                            CourseCode = "DP_ELE",
                            CourseDescription = "The world is increasingly becoming a global village, with Information and Communication Technologies (ICTs) playing a fundamental role in our day-to-day lives. South Africa, like other countries, realises that ICTs can indeed bring about positive change in its socio-economic development. CUT’s contribution to this national agenda is realised through diploma, BTech and MTech programmes offered in the Department of IT. Through these programmes, the university contributes to the ever-increasing demand for a wide range of highly skilled information technology professionals in fields such as web applications, communication networks and software development. The department is particularly unique in the country, as it offers courses in mobile programming and games development. The department has state-of-the-art Cisco equipment through which students get hands-on experience in computer networking, which provides opportunities for various professional certification pathways.",
                            CourseName = "Engineering Technology in Electrical Engineering"
                        },
                        new
                        {
                            ID = 9,
                            CourseCode = "DP_AGM",
                            CourseDescription = "The world is increasingly becoming a global village, with Information and Communication Technologies (ICTs) playing a fundamental role in our day-to-day lives. South Africa, like other countries, realises that ICTs can indeed bring about positive change in its socio-economic development. CUT’s contribution to this national agenda is realised through diploma, BTech and MTech programmes offered in the Department of IT. Through these programmes, the university contributes to the ever-increasing demand for a wide range of highly skilled information technology professionals in fields such as web applications, communication networks and software development. The department is particularly unique in the country, as it offers courses in mobile programming and games development. The department has state-of-the-art Cisco equipment through which students get hands-on experience in computer networking, which provides opportunities for various professional certification pathways.",
                            CourseName = "Diploma Agricultural Management"
                        },
                        new
                        {
                            ID = 10,
                            CourseCode = "AD_HMN",
                            CourseDescription = "The world is increasingly becoming a global village, with Information and Communication Technologies (ICTs) playing a fundamental role in our day-to-day lives. South Africa, like other countries, realises that ICTs can indeed bring about positive change in its socio-economic development. CUT’s contribution to this national agenda is realised through diploma, BTech and MTech programmes offered in the Department of IT. Through these programmes, the university contributes to the ever-increasing demand for a wide range of highly skilled information technology professionals in fields such as web applications, communication networks and software development. The department is particularly unique in the country, as it offers courses in mobile programming and games development. The department has state-of-the-art Cisco equipment through which students get hands-on experience in computer networking, which provides opportunities for various professional certification pathways.",
                            CourseName = "Advanced Diploma Health Management"
                        });
                });

            modelBuilder.Entity("Student_Card.Models.Student", b =>
                {
                    b.Property<string>("Student_Number")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<string>("Initials")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Student_Number");

                    b.HasIndex("CourseId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Student_Card.Models.StudentCard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Course")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StudentID");

                    b.ToTable("StudentCards");
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
                    b.HasOne("Student_Card.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Student_Card.Models.ApplicationUser", null)
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

                    b.HasOne("Student_Card.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Student_Card.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Student_Card.Models.Student", b =>
                {
                    b.HasOne("Student_Card.Models.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("Student_Card.Models.StudentCard", b =>
                {
                    b.HasOne("Student_Card.Models.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentID");

                    b.Navigation("Student");
                });
#pragma warning restore 612, 618
        }
    }
}
