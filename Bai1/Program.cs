using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("\n");
            Console.WriteLine("Họ và tên: Lê Hoài Nam- MSV: 2415053122327");
            Console.WriteLine("Bài 1: Tạo danh sách số nguyên");
            List<int> List = new List<int>(5);
            Random r = new Random();
            Console.Write("5 số được tạo bất kỳ: ");
            for (int i = 0; i < 5; i++)
            {
                List.Add(r.Next(100));
            }
            foreach (int i in List)
            {
                Console.Write(i + "  ");
            }
            Console.WriteLine("\n\n\n");
            Console.ReadLine();

        }
    }
}
