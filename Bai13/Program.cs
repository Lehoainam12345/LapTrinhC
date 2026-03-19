using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai13
{
    class Student
    {
        public int Id;
        public string Name;
        public Student(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }
    }

    class Bai13
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("\n\n");
            Console.WriteLine("Họ và tên: Lê Hoài Nam- MSV: 2415053122327");
            Console.WriteLine("Bài 13: Đếm số sinh viên");
            Console.Write("Nhập thông tin sinh viên trong list: ");
            List<Student> student = new List<Student>();
            while (true)
            {
                Console.Write("\nNhập ID (hoặc gõ '0' để dừng): ");
                string inputId = Console.ReadLine();

                if (inputId == "0") break;

                int id = int.Parse(inputId);

                Console.Write("Nhập họ và tên: ");
                string hten = Console.ReadLine();

                student.Add(new Student(id, hten));

                Console.WriteLine("=> Đã thêm thành công.");
            }
            int dem = 0;
            Console.WriteLine("===============================");
            Console.WriteLine("-----DANH SÁCH SINH VIÊN-----");
            Console.WriteLine("{0, -10} {1, -20}", "ID", "Họ và tên");
            foreach (var sv in student)
            {
                Console.WriteLine("{0, -10} {1, -20}", sv.Id.ToString("D4"), sv.Name);
                dem++;
            }
            Console.WriteLine("Tổng số sinh viên: {0}", student.Count);
            Console.ReadLine();

        }
    }
}
