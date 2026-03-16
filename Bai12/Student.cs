using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai12
{
    internal class Student
    {
        public int Id;
        public string Name;

        public Student() { }

        public Student(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public Student timSV(List<Student> students, String name)
        {
            foreach (Student student in students)
            {
                if (student.Name.Equals(name))
                {
                    return student;
                }
            }

            return null;
        }

        static void Main(string[] args)
        {

            Console.WriteLine("========================================");
            Console.WriteLine("NGUYEN LONG NHAT - 23115053122126");
            Console.WriteLine("========================================");

            List<Student> students = new List<Student>() {
                new Student(1, "Nhat"),
                new Student(2, "Nhan"),
                new Student(3, "Nam")
            };

            Console.WriteLine("Danh sach sinh vien:");
            foreach (Student st in students)
            {
                Console.WriteLine("ID: " + st.Id + ", Name: " + st.Name);
            }

            Student student = new Student();

            Console.Write("Nhap ten sinh vien can tim: ");
            String name = Console.ReadLine();
            student = student.timSV(students, name);

            if(student != null)
            {
                Console.WriteLine("ID: " + student.Id + ", Name: " + student.Name);
            }
            else
            {
                Console.WriteLine("Khong tim thay sinh vien");
            }
        }
    }
}
