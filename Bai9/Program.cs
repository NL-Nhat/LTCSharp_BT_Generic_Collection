using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========================================");
            Console.WriteLine("NGUYEN LONG NHAT - 23115053122126");
            Console.WriteLine("========================================");

            List<int> arr = new List<int>() { 1, 2, 2, 3, 4, 4, 5 };

            Console.WriteLine("Danh sach phan tu:");
            Console.WriteLine(string.Join(", ", arr));


            Console.WriteLine("Danh sach khong trung:");
            Console.WriteLine(string.Join(", ", arr.Distinct().ToList()));
        }
    }
}
