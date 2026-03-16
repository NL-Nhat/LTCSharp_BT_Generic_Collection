using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai8
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

            for (int i = 0, j = n - 1; i < j; i++, j--)
            {
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }

            Console.WriteLine("Danh sach sau khi dao nguoc:");
            Console.WriteLine(string.Join(", ", arr));
        }
    }
}
