using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========================================");
            Console.WriteLine("NGUYEN LONG NHAT - 23115053122126");
            Console.WriteLine("========================================");

            Dictionary<string, string> tudien = new Dictionary<string, string>();

            tudien.Add("Hello", "Xin chào");
            tudien.Add("Goodbye", "Tạm biệt");
            tudien.Add("Thank you", "Cảm ơn");
            tudien.Add("Yes", "Vâng");
            tudien.Add("No", "Không");

            Console.Write("Nhap tu tieng anh can tra: ");
            string tuCanTra = Console.ReadLine();

            if (tudien.ContainsKey(tuCanTra))
            {
                Console.WriteLine($"Nghia cua '{tuCanTra}' la: {tudien[tuCanTra]}");
            }
            else
            {
                Console.WriteLine($"Tu '{tuCanTra}' ko co trong tu dien.");
            }
        }
    }
}
