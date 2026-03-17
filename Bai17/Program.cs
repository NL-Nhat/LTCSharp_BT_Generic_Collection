using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========================================");
            Console.WriteLine("NGUYEN LONG NHAT - 23115053122126");
            Console.WriteLine("========================================");

            List<int> numbers = new List<int>() { 1, 2, 3, 4, 2, 8, 2, 8, 9, 1 };  

            Console.Write("Danh sach ban dau: ");
            foreach (int number in numbers)
            {
                Console.Write(number + ", ");
            }

            Console.Write("\nSo xuat hien nhieu nhat: ");
            var mostFrequent = numbers.GroupBy(n => n)
                                        .OrderByDescending(g => g.Count())
                                        .First()
                                        .Key;
            Console.WriteLine(mostFrequent);
        }
    }
}
