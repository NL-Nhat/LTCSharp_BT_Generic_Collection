using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    internal class Program
    {

        public int max(List<int> arr)
        {
            int maxValue = arr[0];

            for (int i = 1; i < arr.Count; i++)
            {
                if (arr[i] > maxValue)
                {
                    maxValue = arr[i];
                }
            }
            return maxValue;
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
                int element = int.Parse(Console.ReadLine());
                arr.Add(element);
            }

            Program program = new Program();

            Console.WriteLine("So lon nhat trong mang la: {0}", program.max(arr));
        }
    }
}
