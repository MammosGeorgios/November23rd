using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student
            {
                StudentID = 201,
                FirstName = "Sam",
                LastName = "Fisher",
                Gender = "Male",
                TotalMark=450
            };

            Student student2 = new Student
            {
                StudentID = 205,
                FirstName = "Max",
                LastName = "Payne",
                Gender = "Male",
                TotalMark = 300
            };

            Student student3 = new Student
            {
                StudentID = 210,
                FirstName = "Lara",
                LastName = "Croft",
                Gender = "Female",
                TotalMark = 480
            };

            Student student4 = new Student
            {
                StudentID = 250,
                FirstName = "Aiden",
                LastName = "Pearce",
                Gender = "Male",
                TotalMark = 490
            };


            List<Student> studentList = new List<Student>() { student1, student2, student3, student4 };

            IEnumerable<int> ids = studentList.Select(s => s.StudentID).Take(4).OrderByDescending(x => x);
            foreach (var id in ids)
            {
                Console.WriteLine("Student ID: "+ id);
            }


            var query = from student in studentList
                        orderby student.FirstName descending
                        where student.StudentID > 205
                        select student;

            foreach (var item in query)
            {
                Console.WriteLine(item.FirstName);
            }

        }
    }
}
