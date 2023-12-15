using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Student_Card.Migrations
{
    /// <inheritdoc />
    public partial class New : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    StudentNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CourseNumber = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Initials = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CourseDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CourseCode = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Student_Number = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Initials = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Student_Number);
                    table.ForeignKey(
                        name: "FK_Students_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentCards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Year = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Course = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentCards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudentCards_Students_StudentID",
                        column: x => x.StudentID,
                        principalTable: "Students",
                        principalColumn: "Student_Number");
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "ID", "CourseCode", "CourseDescription", "CourseName" },
                values: new object[,]
                {
                    { 1, "DP_ITC", "The world is increasingly becoming a global village, with Information and Communication Technologies (ICTs) playing a fundamental role in our day-to-day lives. South Africa, like other countries, realises that ICTs can indeed bring about positive change in its socio-economic development. CUT’s contribution to this national agenda is realised through diploma, BTech and MTech programmes offered in the Department of IT. Through these programmes, the university contributes to the ever-increasing demand for a wide range of highly skilled information technology professionals in fields such as web applications, communication networks and software development. The department is particularly unique in the country, as it offers courses in mobile programming and games development. The department has state-of-the-art Cisco equipment through which students get hands-on experience in computer networking, which provides opportunities for various professional certification pathways.", "Diploma in Information Technology" },
                    { 2, "HC_ITC", "The world is increasingly becoming a global village, with Information and Communication Technologies (ICTs) playing a fundamental role in our day-to-day lives. South Africa, like other countries, realises that ICTs can indeed bring about positive change in its socio-economic development. CUT’s contribution to this national agenda is realised through diploma, BTech and MTech programmes offered in the Department of IT. Through these programmes, the university contributes to the ever-increasing demand for a wide range of highly skilled information technology professionals in fields such as web applications, communication networks and software development. The department is particularly unique in the country, as it offers courses in mobile programming and games development. The department has state-of-the-art Cisco equipment through which students get hands-on experience in computer networking, which provides opportunities for various professional certification pathways.", "Higher Certificate in Information Technology" },
                    { 3, "PGCE", "The world is increasingly becoming a global village, with Information and Communication Technologies (ICTs) playing a fundamental role in our day-to-day lives. South Africa, like other countries, realises that ICTs can indeed bring about positive change in its socio-economic development. CUT’s contribution to this national agenda is realised through diploma, BTech and MTech programmes offered in the Department of IT. Through these programmes, the university contributes to the ever-increasing demand for a wide range of highly skilled information technology professionals in fields such as web applications, communication networks and software development. The department is particularly unique in the country, as it offers courses in mobile programming and games development. The department has state-of-the-art Cisco equipment through which students get hands-on experience in computer networking, which provides opportunities for various professional certification pathways.", "Postgraduate Certificate In Education" },
                    { 4, "MEd", "The world is increasingly becoming a global village, with Information and Communication Technologies (ICTs) playing a fundamental role in our day-to-day lives. South Africa, like other countries, realises that ICTs can indeed bring about positive change in its socio-economic development. CUT’s contribution to this national agenda is realised through diploma, BTech and MTech programmes offered in the Department of IT. Through these programmes, the university contributes to the ever-increasing demand for a wide range of highly skilled information technology professionals in fields such as web applications, communication networks and software development. The department is particularly unique in the country, as it offers courses in mobile programming and games development. The department has state-of-the-art Cisco equipment through which students get hands-on experience in computer networking, which provides opportunities for various professional certification pathways.", "Master of Education" },
                    { 5, "B.Ed_FT", "The world is increasingly becoming a global village, with Information and Communication Technologies (ICTs) playing a fundamental role in our day-to-day lives. South Africa, like other countries, realises that ICTs can indeed bring about positive change in its socio-economic development. CUT’s contribution to this national agenda is realised through diploma, BTech and MTech programmes offered in the Department of IT. Through these programmes, the university contributes to the ever-increasing demand for a wide range of highly skilled information technology professionals in fields such as web applications, communication networks and software development. The department is particularly unique in the country, as it offers courses in mobile programming and games development. The department has state-of-the-art Cisco equipment through which students get hands-on experience in computer networking, which provides opportunities for various professional certification pathways.", "B. Ed: Foundation Phase Teaching" },
                    { 6, "DP_MDS", "The world is increasingly becoming a global village, with Information and Communication Technologies (ICTs) playing a fundamental role in our day-to-day lives. South Africa, like other countries, realises that ICTs can indeed bring about positive change in its socio-economic development. CUT’s contribution to this national agenda is realised through diploma, BTech and MTech programmes offered in the Department of IT. Through these programmes, the university contributes to the ever-increasing demand for a wide range of highly skilled information technology professionals in fields such as web applications, communication networks and software development. The department is particularly unique in the country, as it offers courses in mobile programming and games development. The department has state-of-the-art Cisco equipment through which students get hands-on experience in computer networking, which provides opportunities for various professional certification pathways.", "Language Practice and Media Studies" },
                    { 7, "B_MAN", "The world is increasingly becoming a global village, with Information and Communication Technologies (ICTs) playing a fundamental role in our day-to-day lives. South Africa, like other countries, realises that ICTs can indeed bring about positive change in its socio-economic development. CUT’s contribution to this national agenda is realised through diploma, BTech and MTech programmes offered in the Department of IT. Through these programmes, the university contributes to the ever-increasing demand for a wide range of highly skilled information technology professionals in fields such as web applications, communication networks and software development. The department is particularly unique in the country, as it offers courses in mobile programming and games development. The department has state-of-the-art Cisco equipment through which students get hands-on experience in computer networking, which provides opportunities for various professional certification pathways.", "Bachelor Management Sciences in Accountancy" },
                    { 8, "DP_ELE", "The world is increasingly becoming a global village, with Information and Communication Technologies (ICTs) playing a fundamental role in our day-to-day lives. South Africa, like other countries, realises that ICTs can indeed bring about positive change in its socio-economic development. CUT’s contribution to this national agenda is realised through diploma, BTech and MTech programmes offered in the Department of IT. Through these programmes, the university contributes to the ever-increasing demand for a wide range of highly skilled information technology professionals in fields such as web applications, communication networks and software development. The department is particularly unique in the country, as it offers courses in mobile programming and games development. The department has state-of-the-art Cisco equipment through which students get hands-on experience in computer networking, which provides opportunities for various professional certification pathways.", "Engineering Technology in Electrical Engineering" },
                    { 9, "DP_AGM", "The world is increasingly becoming a global village, with Information and Communication Technologies (ICTs) playing a fundamental role in our day-to-day lives. South Africa, like other countries, realises that ICTs can indeed bring about positive change in its socio-economic development. CUT’s contribution to this national agenda is realised through diploma, BTech and MTech programmes offered in the Department of IT. Through these programmes, the university contributes to the ever-increasing demand for a wide range of highly skilled information technology professionals in fields such as web applications, communication networks and software development. The department is particularly unique in the country, as it offers courses in mobile programming and games development. The department has state-of-the-art Cisco equipment through which students get hands-on experience in computer networking, which provides opportunities for various professional certification pathways.", "Diploma Agricultural Management" },
                    { 10, "AD_HMN", "The world is increasingly becoming a global village, with Information and Communication Technologies (ICTs) playing a fundamental role in our day-to-day lives. South Africa, like other countries, realises that ICTs can indeed bring about positive change in its socio-economic development. CUT’s contribution to this national agenda is realised through diploma, BTech and MTech programmes offered in the Department of IT. Through these programmes, the university contributes to the ever-increasing demand for a wide range of highly skilled information technology professionals in fields such as web applications, communication networks and software development. The department is particularly unique in the country, as it offers courses in mobile programming and games development. The department has state-of-the-art Cisco equipment through which students get hands-on experience in computer networking, which provides opportunities for various professional certification pathways.", "Advanced Diploma Health Management" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Student_Number", "CourseId", "Initials", "Surname", "Title" },
                values: new object[,]
                {
                    { "221032547", 2, "A", "Mavundla", "Ms" },
                    { "221056854", 1, "S", "Thusi", "Mrs" },
                    { "222102541", 1, "S", "Sithole", "Mr" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_StudentCards_StudentID",
                table: "StudentCards",
                column: "StudentID");

            migrationBuilder.CreateIndex(
                name: "IX_Students_CourseId",
                table: "Students",
                column: "CourseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "StudentCards");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Courses");
        }
    }
}
