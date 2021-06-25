using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using TutionManagementSystem.Models;

namespace TutionManagementSystem.Controllers
{
    class CourseViewController
    {
        static Database db = new Database();
        static Courses c = new Courses();
        public static ArrayList GetAllCourses()
        {
            return db.Courses.GetAllCourses();
        }public static ArrayList StudentAllCourses(string student)
        {
            return db.Courses.StudentAllCourses(student);
        }
        public static void AddCourse(string courseName, string courseId, string courseFee,string courseTeacher)

        {
            Course u = new Course()
            {

               CourseName=courseName,
               CourseFee=courseFee,
               CourseId=courseId,
               TeacherName=courseTeacher

            };
            db.Courses.AddCourse(u);

        }
        public static void UpdateCourse(string courseName, string courseId, string courseFee)

        {
            Course u = new Course()
            {

                CourseName = courseName,
                CourseFee = courseFee,
                CourseId = courseId


            };
            db.Courses.UpdateCourse(u);

        }
        public static void DeleteCourse(string courseName, string courseId, string courseFee)

        {
            Course u = new Course()
            {

                CourseName = courseName,
                CourseFee = courseFee,
                CourseId = courseId


            };
            db.Courses.DeleteCourse(u);

        }
        public static void StudentCourse(string studentName,string teacherName,string courseId,string courseName,string courseFee)

        {

            c.StudentCourse(studentName, teacherName, courseId, courseName, courseFee);

        }public static void SetClass(string courseId,string Class,string link)

        {

            c.SetClass(courseId,Class,link);

        }
        public static ArrayList GetAllCourses(string username)
        {
            return db.Teachers.GetAllCourses(username);
        }public static Course GetSelectedCourse(string courseId)
        {
            Course U = new Course();
           U= db.Courses.GetSelectedCourse(courseId);
            return U;

        }
        public static ArrayList GetSelectedDetails(string courseId)
        {
            return db.Courses.GetSelectedDetails(courseId);
        }
    }
}

