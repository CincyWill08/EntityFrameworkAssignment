using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            EFAssignmentDBContext db = new EFAssignmentDBContext();

            //Task 1 - Print the number of students in the db
            int studentCount = db.Students.Count();
            Console.WriteLine("The number of students in the db is " + studentCount.ToString());
            Console.WriteLine(" ");

            //Task 2 - Print all students on the db to the console
            Console.WriteLine("List of All Students");
            Student[] students = db.Students.ToArray();
            foreach (Student student in students)
            {
                string message = $"Student Name = {student.Name}";
                Console.WriteLine(message);
            }
            Console.WriteLine(" ");

            //Task 3 - Print a list of all students that graduated w/ honors
            //         ordered by grad year asc
            Console.WriteLine("List of Honor Students");
            Student[] honorStudents = db.Students.Where(student => student.GradWithHonors == true).OrderBy(student => student.GradYear).ToArray();
            foreach (Student student in honorStudents)
            {
                string message = $"Studen" +
                    $"t Name = {student.Name}, Graduation Year = {student.GradYear}";
                Console.WriteLine(message);
            }
            Console.ReadKey();
        }
    }
}
