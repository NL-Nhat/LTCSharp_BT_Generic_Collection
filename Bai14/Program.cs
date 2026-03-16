using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai14
{
    class Student
    {
        public int id;
        public String name;
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
                new Student() { id = 1, name = "Nhat" },
                new Student() { id = 2, name = "Nam" },
                new Student() { id = 3, name = "Nhan" }
            };

            Console.WriteLine("Danh sách sinh viên:");
            foreach (Student student in students)
            {
                Console.WriteLine($"ID: {student.id}, Name: {student.name}");
            }

            Console.Write("Nhap ID sv can xoa: ");
            int idXoa = int.Parse(Console.ReadLine());

            Student studentXoa = students.FirstOrDefault(s => s.id == idXoa);

            if (studentXoa != null)
            {
                students.Remove(studentXoa);
                Console.WriteLine($"Da xoa sv co ID: {idXoa}");
            }
            else
            {
                Console.WriteLine($"Ko tim thay sv co ID: {idXoa}");
            }

            Console.WriteLine("Danh sách sinh viên sau khi xóa:");
            foreach (Student student in students)
            {
                Console.WriteLine($"ID: {student.id}, Name: {student.name}");
            }
        }
    }
}
