using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========================================");
            Console.WriteLine("NGUYEN LONG NHAT - 23115053122126");
            Console.WriteLine("========================================");

            Console.Write("Nhap mot chuoi: ");
            string input = Console.ReadLine();

            Dictionary<char, int> charCount = new Dictionary<char, int>();
            foreach (char c in input)
            {
                if (charCount.ContainsKey(c))
                {
                    charCount[c]++;
                }
                else
                {
                    charCount[c] = 1;
                }
            }

            Console.WriteLine("So lan xuat hien cua moi ky tu:");
            foreach (var kvp in charCount)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }
}
