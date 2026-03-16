using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========================================");
            Console.WriteLine("NGUYEN LONG NHAT - 23115053122126");
            Console.WriteLine("========================================");

            List<int> arr = new List<int>() { 7, 2, 9, 3, 10, 12, 5 };

            Console.WriteLine("Danh sach phan tu:");
            Console.WriteLine(string.Join(", ", arr));

            Console.Write("Gia tri nho nhat trong danh sach: ");
            Console.WriteLine(arr.Min());
        }
    }
}
