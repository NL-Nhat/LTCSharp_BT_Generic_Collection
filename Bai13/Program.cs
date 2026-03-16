using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai13
{
    class Student 
    {
        public int Id;
        public string Name;
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========================================");
            Console.WriteLine("NGUYEN LONG NHAT - 23115053122126");
            Console.WriteLine("========================================");

            List<Student> students = new List<Student>()
            {
                new Student() { Id = 1, Name = "Nhat" },
                new Student() { Id = 2, Name = "Nhan" },
                new Student() { Id = 3, Name = "Nam" }
            };

            Console.WriteLine("Danh sách sinh viên:");
            foreach (var student in students)
            {
                Console.WriteLine($"Id: {student.Id}, Name: {student.Name}");
            }

            Console.WriteLine("Tong so sinh vien la: {0}", students.Count());
        }
    }
}
