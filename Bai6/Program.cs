using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("\t");
            Console.WriteLine("Họ và tên: Lê Hoài Nam- MSV: 2415053122327");
            Console.WriteLine("Bài 6: Kiểm tra phần tử tồn tại ");
            Console.WriteLine("Nhập số lượng phần tử trong list: ");
            int n = int.Parse(Console.ReadLine());
            List<String> list = new List<String>();
            String hten;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhập chuỗi thứ {0}: ", i + 1);
                hten = Console.ReadLine().Trim();
                list.Add(hten);
            }
            Console.WriteLine("Danh sách chuỗi vừa nhập: ");
            foreach (String s in list)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("Nhập chuỗi cần kiểm tra: ");
            String ktra = Console.ReadLine().Trim();
            int dem = 0;
            foreach (String s in list)
            {
                if (s.Equals(ktra))
                {
                    dem++;
                }
            }
            if (dem == 1)
            {
                Console.WriteLine("{0} có trong List", ktra);
            }
            else
            {
                Console.WriteLine("{0} không có trong List", ktra);
            }
            Console.ReadLine();

        }
    }
}
