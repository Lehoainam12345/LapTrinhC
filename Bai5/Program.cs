using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("\t");
            Console.WriteLine("Họ và tên: Lê Hoài Nam- MSV: 2415053122327");
            Console.WriteLine("Bài 5: Xoá phần tử khỏi List");
            List<String> list = new List<String>();
            Console.Write("Nhập số lượng họ tên cần nhập: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhập tên sinh viên thứ {0}: ", i + 1);
                String hten = Console.ReadLine();
                list.Add(hten);
            }
            Console.WriteLine("Tên sinh viên trong list: ");
            foreach (string hten in list)
            {
                Console.WriteLine(hten);
            }
            Console.WriteLine("Nhập tên cần xoá: ");
            string xoa = Console.ReadLine();
            for (int i = list.Count - 1; i >= 0; i--) //Count dùng để đếm số lượng phần tử có trong list
            {
                if (list[i] == xoa)
                {
                    list.RemoveAt(i);
                }
            }
            Console.WriteLine("List sau khi xoá: ");
            foreach (string hten in list)
            {
                Console.WriteLine(hten);
            }
            Console.ReadLine();

        }
    }
}
