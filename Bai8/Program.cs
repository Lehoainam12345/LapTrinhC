using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai8
{
    class Bai8
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("\t");
            Console.WriteLine("Họ và tên: Lê Hoài Nam- MSV: 2415053122327");
            Console.WriteLine("Bài 8: Đảo ngược danh sách");
            Console.WriteLine("\t");
            Console.Write("Nhập số lượng phần tử: ");
            int n = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            int so;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhập phần tử thứ {0}: ", i + 1);
                so = int.Parse(Console.ReadLine());
                list.Add(so);
            }
            Console.Write("Các phần tử có trong list: ");
            foreach (int a in list)
            {
                Console.Write("{0} ", a);
            }
            Console.WriteLine("\t");
            list.Reverse();
            Console.Write("Các phần tử sau khi đảo ngược: ");
            foreach (int a in list)
            {
                Console.Write("{0} ", a);
            }
            Console.ReadLine();

        }
    }
}
