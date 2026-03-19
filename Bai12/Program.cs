using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai12
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

    class Bai12

    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("\n\n");
            Console.WriteLine("Họ và tên: Lê Hoài Nam- MSV: 2415053122327");
            Console.WriteLine("Bài 12: Tìm sinh viên theo tên");
            List<Student> student = new List<Student>();
            while (true)
            {
                Console.WriteLine("Nhập thông tin sinh viên(nhập 0 để dừng) ");
                Console.Write("Nhập id sinh viên(nhập 0 để dừng): ");
                int id = int.Parse(Console.ReadLine());
                if (id == 0) break;
                Console.Write("Nhập họ tên sinh viên: ");
                string name = Console.ReadLine();
                Student sv = new Student(id, name);
                student.Add(sv);
                Console.WriteLine("Đã thêm sinh viên...");
            }
            Console.WriteLine("===============================");
            Console.WriteLine("-----DANH SÁCH SINH VIÊN-----");
            Console.WriteLine("{0, -10} {1, -20}", "ID", "Họ và tên");
            foreach (var sinhvien in student)
            {
                Console.WriteLine("{0, -10} {1, -20}", sinhvien.Id.ToString("D4"), sinhvien.Name);
            }
            Console.WriteLine("Nhập họ tên sinh viên cần tìm: ");
            String timkiem = Console.ReadLine();
            Console.WriteLine("===============================");
            Console.WriteLine("-----DANH SÁCH SINH VIÊN-----");
            Console.WriteLine("{0, -10} {1, -20}", "ID", "Họ và tên");
            foreach (var sinhvien in student)
            {
                if (sinhvien.Name.Equals(timkiem, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("{0, -10} {1, -20}", sinhvien.Id.ToString("D4"), sinhvien.Name);
                }
            }
            Console.ReadLine();

        }
    }
}
