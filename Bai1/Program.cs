using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========================================");
            Console.WriteLine("NGUYEN LONG NHAT - 23115053122126");
            Console.WriteLine("========================================");

            List<int> numbers = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Nhap so nguyen thu {0}: ", i + 1);
                int number = int.Parse(Console.ReadLine());
                numbers.Add(number);
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine("So nguyen thu {0} la: {1}", i + 1, numbers[i]);
            }
        }
    }
}
