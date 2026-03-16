using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========================================");
            Console.WriteLine("NGUYEN LONG NHAT - 23115053122126");
            Console.WriteLine("========================================");

            int n;
            List<int> arr = new List<int>();

            Console.Write("Nhap so luong phan tu: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap phan tu thu {i + 1}: ");
                arr.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine("Danh sach phan tu:");
            Console.WriteLine(string.Join(", ", arr));

            arr.Sort();
            Console.WriteLine("Danh sach phan tu sau khi sap xep:");
            Console.WriteLine(string.Join(", ", arr));
        }
    }
}
