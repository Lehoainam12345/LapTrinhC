using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai9
{
    class Bai9
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("\n\n");
            Console.WriteLine("Họ và tên: Lê Hoài Nam- MSV: 2415053122327");
            Console.WriteLine("Bài 9: Loại bỏ phần tử trùng lặp");
            Console.Write("Nhập số lượng phần tử: ");
            int n = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            int k;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhập phần tử thứ {0}: ", i + 1);
                k = int.Parse(Console.ReadLine());
                list.Add(k);
            }
            Console.Write("Phần tử trong list: ");
            foreach (int i in list)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine("\n");
            Console.Write("Danh sách sau khi loại bỏ phần tử trùng lặp: ");
            for (int i = list.Count - 1; i >= 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (list[i] == list[j])
                    {
                        list.RemoveAt(i);
                        break;
                    }
                }
            }

            foreach (int i in list)
            {
                Console.Write("{0} ", i);
            }
            Console.ReadLine();

        }
    }
}
