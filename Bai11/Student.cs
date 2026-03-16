using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai11
{
    internal class Student
    {

        public int Id;
        public string Name;

        public Student(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("========================================");
            Console.WriteLine("NGUYEN LONG NHAT - 23115053122126");
            Console.WriteLine("========================================");

            List<Student> students = new List<Student>()
            {
                new Student(1, "Nhat"),
                new Student(2, "Nhan"),
                new Student(3, "Nam")
            };

            Console.WriteLine("Danh sach sinh vien:");

            foreach (var student in students)
            {
                Console.WriteLine($"ID: {student.Id}, Name: {student.Name}");
            }
        }
    }
}
