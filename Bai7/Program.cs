using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("\t");
            Console.WriteLine("Họ và tên: Lê Hoài Nam- MSV: 2415053122327");
            Console.WriteLine("Bài 7: Sắp xếp danh sách ");
            Console.Write("Nhập số lượng phần tử có trong list: ");
            int n = int.Parse(Console.ReadLine());
            List<int> List = new List<int>(n);
            Random r = new Random();
            Console.Write("{0} số được tạo bất kỳ: ", n);
            for (int i = 0; i < n; i++)
            {
                List.Add(r.Next(100));
            }
            foreach (int i in List)
            {
                Console.Write(i + "  ");
            }
            Console.WriteLine("\t");
            Console.Write("Danh sách sắp xếp tăng dần: ");
            List.Sort();
            foreach (int i in List)
            {
                Console.Write(i + "  ");
            }
            Console.ReadLine();

        }
    }
}
