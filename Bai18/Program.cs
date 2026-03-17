using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai18
{

    class Student { 
        public string Name;
        public double Score; 
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
                new Student() { Name = "Nhat", Score = 85 },
                new Student() { Name = "Nhan", Score = 92 },
                new Student() { Name = "Nam", Score = 78 },
                new Student() { Name = "Duc", Score = 90 },
                new Student() { Name = "Hoa", Score = 88 }
            };

            Console.WriteLine("Danh sach sinh vien:");

            foreach (var student in students)
            {
                Console.WriteLine($"Ten: {student.Name}, Diem: {student.Score}");
            }

            Console.WriteLine("\nSinh vien co diem cao nhat:");

            //Sắp xếp danh sách giảm dần theo điểm và lấy sinh viên đầu tiên
            var topStudent = students.OrderByDescending(s => s.Score).FirstOrDefault();

            if (topStudent != null)
            {
                Console.WriteLine($"Ten: {topStudent.Name}, Diem: {topStudent.Score}");
            }
        }
    }
}
