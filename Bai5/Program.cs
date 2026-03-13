using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
    internal class Program
    {

        public void xoa(List<String> names)
        {
            Console.Write("nhap ten sinh vien can xoa: ");
            String name = Console.ReadLine();

            foreach(String s in names)
            {
                if(s.Equals(name))
                {
                    names.Remove(s);
                    Console.WriteLine("Da xoa sinh vien {0} khoi danh sach", name);
                    return;
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("========================================");
            Console.WriteLine("NGUYEN LONG NHAT - 23115053122126");
            Console.WriteLine("========================================");

            List<String> names = new List<string>();
            int n;

            Console.Write("Nhap so sinh vien: ");
            n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                Console.Write("Nhap ten sinh thu {0}: ", i + 1);
                names.Add(Console.ReadLine());
            }

            Console.WriteLine("Danh sach sinh vien: ");
            foreach(String s in names)
            {
                Console.WriteLine(s);
            }

            Program p = new Program();
            p.xoa(names);

            Console.WriteLine("Danh sach sinh vien sau khi xoa: ");
            foreach (String s in names)
            {
                Console.WriteLine(s);
            }

        }
    }
}
