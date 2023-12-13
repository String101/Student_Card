using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Student_Card.Models;

namespace Student_Card.Data
{
    public class SqlDbContext:IdentityDbContext<ApplicationUser>
    {
        public SqlDbContext(DbContextOptions options) : base(options) 
        { 
        
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<StudentCard> StudentCards { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Course>().HasData(
                new Course
                {
                    ID = 1,
                    CourseName = "Diploma in Information Technology",
                    CourseCode = "DP_ITC",
                    CourseDescription = "The world is increasingly becoming a global village, with Information and Communication Technologies (ICTs) " +
                      "playing a fundamental role in our day-to-day lives. South Africa, like other countries, realises that ICTs can indeed bring about positive change in its socio-economic development. CUT’s contribution to this national agenda is realised through diploma, BTech and MTech programmes offered in the Department of IT. Through these programmes, the university contributes to " +
                      "the ever-increasing demand for a wide range of highly skilled information technology professionals in fields such as web applications, communication networks and software development. The department is particularly unique in the country, as it offers courses in mobile programming and games development. The department has state-of-the-art Cisco equipment through which students get hands-on experience in computer networking, which provides opportunities for" +
                      " various professional certification pathways."
                },
                  new Course
                  {
                      ID = 2,
                      CourseName = "Higher Certificate in Information Technology",
                      CourseCode = "HC_ITC",
                      CourseDescription = "The world is increasingly becoming a global village, with Information and Communication Technologies (ICTs) " +
                      "playing a fundamental role in our day-to-day lives. South Africa, like other countries, realises that ICTs can indeed bring about positive change in its socio-economic development. CUT’s contribution to this national agenda is realised through diploma, BTech and MTech programmes offered in the Department of IT. Through these programmes, the university contributes to " +
                      "the ever-increasing demand for a wide range of highly skilled information technology professionals in fields such as web applications, communication networks and software development. The department is particularly unique in the country, as it offers courses in mobile programming and games development. The department has state-of-the-art Cisco equipment through which students get hands-on experience in computer networking, which provides opportunities for" +
                      " various professional certification pathways."
                  },
                     new Course
                     {
                         ID = 3,
                         CourseName = "Postgraduate Certificate In Education",
                         CourseCode = "PGCE",
                         CourseDescription = "The world is increasingly becoming a global village, with Information and Communication Technologies (ICTs) " +
                          "playing a fundamental role in our day-to-day lives. South Africa, like other countries, realises that ICTs can indeed bring about positive change in its socio-economic development. CUT’s contribution to this national agenda is realised through diploma, BTech and MTech programmes offered in the Department of IT. Through these programmes, the university contributes to " +
                          "the ever-increasing demand for a wide range of highly skilled information technology professionals in fields such as web applications, communication networks and software development. The department is particularly unique in the country, as it offers courses in mobile programming and games development. The department has state-of-the-art Cisco equipment through which students get hands-on experience in computer networking, which provides opportunities for" +
                          " various professional certification pathways."
                     },
                  new Course
                  {
                      ID = 4,
                      CourseName = "Master of Education",
                      CourseCode = "MEd",
                      CourseDescription = "The world is increasingly becoming a global village, with Information and Communication Technologies (ICTs) " +
                      "playing a fundamental role in our day-to-day lives. South Africa, like other countries, realises that ICTs can indeed bring about positive change in its socio-economic development. CUT’s contribution to this national agenda is realised through diploma, BTech and MTech programmes offered in the Department of IT. Through these programmes, the university contributes to " +
                      "the ever-increasing demand for a wide range of highly skilled information technology professionals in fields such as web applications, communication networks and software development. The department is particularly unique in the country, as it offers courses in mobile programming and games development. The department has state-of-the-art Cisco equipment through which students get hands-on experience in computer networking, which provides opportunities for" +
                      " various professional certification pathways."
                  },
                     new Course
                     {
                         ID = 5,
                         CourseName = "B. Ed: Foundation Phase Teaching",
                         CourseCode = "B.Ed_FT",
                         CourseDescription = "The world is increasingly becoming a global village, with Information and Communication Technologies (ICTs) " +
                          "playing a fundamental role in our day-to-day lives. South Africa, like other countries, realises that ICTs can indeed bring about positive change in its socio-economic development. CUT’s contribution to this national agenda is realised through diploma, BTech and MTech programmes offered in the Department of IT. Through these programmes, the university contributes to " +
                          "the ever-increasing demand for a wide range of highly skilled information technology professionals in fields such as web applications, communication networks and software development. The department is particularly unique in the country, as it offers courses in mobile programming and games development. The department has state-of-the-art Cisco equipment through which students get hands-on experience in computer networking, which provides opportunities for" +
                          " various professional certification pathways."
                     },
                  new Course
                  {
                      ID = 6,
                      CourseName = "Language Practice and Media Studies",
                      CourseCode = "DP_MDS",
                      CourseDescription = "The world is increasingly becoming a global village, with Information and Communication Technologies (ICTs) " +
                      "playing a fundamental role in our day-to-day lives. South Africa, like other countries, realises that ICTs can indeed bring about positive change in its socio-economic development. CUT’s contribution to this national agenda is realised through diploma, BTech and MTech programmes offered in the Department of IT. Through these programmes, the university contributes to " +
                      "the ever-increasing demand for a wide range of highly skilled information technology professionals in fields such as web applications, communication networks and software development. The department is particularly unique in the country, as it offers courses in mobile programming and games development. The department has state-of-the-art Cisco equipment through which students get hands-on experience in computer networking, which provides opportunities for" +
                      " various professional certification pathways."
                  },
                     new Course
                     {
                         ID = 7,
                         CourseName = "Bachelor Management Sciences in Accountancy",
                         CourseCode = "B_MAN",
                         CourseDescription = "The world is increasingly becoming a global village, with Information and Communication Technologies (ICTs) " +
                      "playing a fundamental role in our day-to-day lives. South Africa, like other countries, realises that ICTs can indeed bring about positive change in its socio-economic development. CUT’s contribution to this national agenda is realised through diploma, BTech and MTech programmes offered in the Department of IT. Through these programmes, the university contributes to " +
                      "the ever-increasing demand for a wide range of highly skilled information technology professionals in fields such as web applications, communication networks and software development. The department is particularly unique in the country, as it offers courses in mobile programming and games development. The department has state-of-the-art Cisco equipment through which students get hands-on experience in computer networking, which provides opportunities for" +
                      " various professional certification pathways."
                     },
                  new Course
                  {
                      ID = 8,
                      CourseName = "Engineering Technology in Electrical Engineering",
                      CourseCode = "DP_ELE",
                      CourseDescription = "The world is increasingly becoming a global village, with Information and Communication Technologies (ICTs) " +
                      "playing a fundamental role in our day-to-day lives. South Africa, like other countries, realises that ICTs can indeed bring about positive change in its socio-economic development. CUT’s contribution to this national agenda is realised through diploma, BTech and MTech programmes offered in the Department of IT. Through these programmes, the university contributes to " +
                      "the ever-increasing demand for a wide range of highly skilled information technology professionals in fields such as web applications, communication networks and software development. The department is particularly unique in the country, as it offers courses in mobile programming and games development. The department has state-of-the-art Cisco equipment through which students get hands-on experience in computer networking, which provides opportunities for" +
                      " various professional certification pathways."
                  },
                   new Course
                   {
                       ID = 9,
                       CourseName = "Diploma Agricultural Management",
                       CourseCode = "DP_AGM",
                       CourseDescription = "The world is increasingly becoming a global village, with Information and Communication Technologies (ICTs) " +
                      "playing a fundamental role in our day-to-day lives. South Africa, like other countries, realises that ICTs can indeed bring about positive change in its socio-economic development. CUT’s contribution to this national agenda is realised through diploma, BTech and MTech programmes offered in the Department of IT. Through these programmes, the university contributes to " +
                      "the ever-increasing demand for a wide range of highly skilled information technology professionals in fields such as web applications, communication networks and software development. The department is particularly unique in the country, as it offers courses in mobile programming and games development. The department has state-of-the-art Cisco equipment through which students get hands-on experience in computer networking, which provides opportunities for" +
                      " various professional certification pathways."
                   },
                    new Course
                    {
                        ID = 10,
                        CourseName = "Advanced Diploma Health Management",
                        CourseCode = "AD_HMN",
                        CourseDescription = "The world is increasingly becoming a global village, with Information and Communication Technologies (ICTs) " +
                          "playing a fundamental role in our day-to-day lives. South Africa, like other countries, realises that ICTs can indeed bring about positive change in its socio-economic development. CUT’s contribution to this national agenda is realised through diploma, BTech and MTech programmes offered in the Department of IT. Through these programmes, the university contributes to " +
                          "the ever-increasing demand for a wide range of highly skilled information technology professionals in fields such as web applications, communication networks and software development. The department is particularly unique in the country, as it offers courses in mobile programming and games development. The department has state-of-the-art Cisco equipment through which students get hands-on experience in computer networking, which provides opportunities for" +
                          " various professional certification pathways."
                    }
            );
            modelBuilder.Entity<Student>().HasData
                (
                new Student
                {
                    CourseId = 1,
                    Student_Number = "222102541",
                    Title = "Mr",
                    Initials = "S",
                    Surname = "Sithole"
                },
                new Student
                {
                    CourseId = 2,
                    Student_Number = "221032547",
                    Title = "Ms",
                    Initials = "A",
                    Surname = "Mavundla"
                },
                new Student
                {
                    CourseId = 1,
                    Student_Number = "221056854",
                    Title = "Mrs",
                    Initials = "S",
                    Surname = "Thusi"
                }
                );
            //modelBuilder.Entity<StudentCard>().HasData(

            //     new StudentCard
            //     {
            //         Id = 1,
            //         Year = DateTime.Now.Year,
            //         StudentID = "222102541",
            //         ImageUrl = "https://placehold.co/600x400",
            //     },
            //      new StudentCard
            //      {
            //          Id = 2,
            //          Year = DateTime.Now.Year,
            //          StudentID = "221032547",
            //          ImageUrl = "https://placehold.co/600x400",
            //      }
            //      , new StudentCard
            //      {
            //          Id = 3,
            //          Year = DateTime.Now.Year,
            //          StudentID = "221056854",
            //          ImageUrl = "https://placehold.co/600x400",
            //      }

            //    );
        }
    }
}
