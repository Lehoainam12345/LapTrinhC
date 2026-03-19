using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Họ và tên: Lê Hoài Nam- MSV: 2415053122327");
            Console.WriteLine("Bài 17: Tìm phần tử xuất hiện nhiều nhất");
            List<int> list = new List<int>();
            while (true)
            {
                Console.Write("(Nhập 'y' để thoát hoặc nhập kí tự bất kỳ để tiếp tục): ");
                char nhap = Char.Parse(Console.ReadLine().ToLower());
                if (nhap == 'y')
                {
                    break;
                }
                else
                {
                    Console.Write("Nhập phần tử trong list: ");
                    int n = int.Parse(Console.ReadLine());
                    list.Add(n);
                }
            }
            Console.WriteLine("Danh sách List ");

            foreach (int n in list)
            {
                Console.Write("{0} ", n);
            }
            Dictionary<int, int> Dem = new Dictionary<int, int>();
            foreach (int num in list)
            {
                if (Dem.ContainsKey(num))
                {
                    Dem[num]++;
                }
                else
                {
                    Dem[num] = 1;
                }
            }
            Console.WriteLine("Số lần xuất hiện của các phần tử trong List: ");
            foreach (var item in Dem)
            {
                Console.Write($"{item.Key}:{item.Value} ");
            }
            Console.WriteLine("\n");
            Console.Write("Phần tử xuất hiện nhiều nhất trong list: ");
            int max = Dem.Values.Max();

            foreach (var item in Dem)
            {
                if (item.Value == max)
                {
                    Console.Write("{0} ", item.Key);
                }
            }

            Console.WriteLine("\t");
            Console.ReadLine();
        }
    }
}
