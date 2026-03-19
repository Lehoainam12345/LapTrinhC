using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai10
{
    class Bai10
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("\n\n");
            Console.WriteLine("Họ và tên: Lê Hoài Nam- MSV: 2415053122327");
            Console.WriteLine("Bài 10: Tìm phần tử nhỏ nhất");
            List<int> list = new List<int>();
            Console.Write("Nhập số phần tử muốn có trong list: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhập phần tử thứ {0} ", i + 1);
                int a = int.Parse(Console.ReadLine());
                list.Add(a);
            }
            Console.WriteLine("Phần tử trong mảng vừa nhập là: ");
            foreach (int a in list)
            {
                Console.Write("{0} ", a);
            }
            Console.WriteLine("\t");
            Console.Write("Phần tử nhỏ nhất trong list: ");
            Console.WriteLine(list.Min());
            list.Min();
            Console.ReadLine();

        }
    }
}
