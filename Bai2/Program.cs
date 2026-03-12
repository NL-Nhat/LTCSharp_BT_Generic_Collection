using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class Program
    {

        public int Tong(List<int> arr)
        {
            int tong = 0;
            
            foreach (int item in arr)
            {
                tong += item;
            }

            return tong;
        }
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
                Console.Write("Nhap phan tu thu {0}: ", i + 1);
                int x = int.Parse(Console.ReadLine());
                arr.Add(x);
            }

            Program p = new Program();
            int tong = p.Tong(arr);
            Console.WriteLine("Tong cac phan tu trong mang: {0}", tong);
        }
    }
}
