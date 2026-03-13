using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6
{
    internal class Program
    {

        public void kiemTraTonTai(List<String> list, String str) {
            if (list.Contains(str)) {
                Console.WriteLine($"Chuoi '{str}' ton tai trong danh sach.");
            } else {
                Console.WriteLine($"Chuoi '{str}' khong ton tai trong danh sach.");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("========================================");
            Console.WriteLine("NGUYEN LONG NHAT - 23115053122126");
            Console.WriteLine("========================================");

            List<String> list = new List<string>();
            list.Add("Hello");
            list.Add("nguyen long nhat");
            list.Add("nhat nguyen");
            list.Add("hello world");

            Console.WriteLine("Danh sach chuoi:");
            foreach (var item in list) {
                Console.WriteLine(item);
            }

            Console.Write("Nhap chuoi can kiem tra:");
            String str = Console.ReadLine();
            Program program = new Program();
            program.kiemTraTonTai(list, str);
        }
    }
}
