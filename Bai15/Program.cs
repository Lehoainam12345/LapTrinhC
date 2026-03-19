using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("\n\n");
            Console.WriteLine("Họ và tên: Lê Hoài Nam- MSV: 2415053122327");
            Console.WriteLine("Bài 15: Sử dụng Dictionary");
            Dictionary<String, String> TuDien = new Dictionary<string, string>();
            while (true)
            {
                Console.WriteLine("Thêm từ điển Anh - Việt (nhập 0 để thoát)");
                Console.Write("Nhập từ tiếng Anh: ");
                string eng = Console.ReadLine().Trim().ToLower();
                if (eng == "0") break;
                if (TuDien.ContainsKey(eng))
                {
                    Console.WriteLine("Từ này đã có trong từ điển rồi!");
                }
                else
                {
                    Console.Write("Nhập nghĩa tiếng Việt: ");
                    string vie = Console.ReadLine();
                    TuDien.Add(eng, vie);
                }
            }
            while (true)
            {
                Console.Write("Nhập từ để tra nghĩa(nhập 0 để dừng): ");
                string ktra = Console.ReadLine().Trim().ToLower();
                if (ktra == "0") break;
                if (TuDien.ContainsKey(ktra))
                {
                    Console.WriteLine("Nghĩa của từ '{0}' là: {1}", ktra, TuDien[ktra]);
                }
                else
                {
                    Console.WriteLine("Từ này không có trong từ điển!");
                }
            }

            Console.ReadLine();

        }
    }
}
