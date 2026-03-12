using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    internal class Program
    {

        public int demSoChan(List<int> arr)
        {
            int count = 0;
            foreach (int num in arr)
            {
                if (num % 2 == 0)
                {
                    count++;
                }
            }
            return count;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("========================================");
            Console.WriteLine("NGUYEN LONG NHAT - 23115053122126");
            Console.WriteLine("========================================");

            int n;
            List<int> arr = new List<int>();

            Console.Write("Nhap so phan tu cho mang: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap phan tu thu {0}: ", i + 1);
                arr.Add(int.Parse(Console.ReadLine()));
            }

            Program program = new Program();

            Console.WriteLine("So luong so chan trong mang la: {0}", program.demSoChan(arr));

        }
    }
}
