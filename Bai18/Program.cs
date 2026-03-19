using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai18
{
    class Student
    {
        public string Name;
        public double Score;
        public Student(string Name, double Score)
        {
            this.Name = Name;
            this.Score = Score;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Họ và tên: Lê Hoài Nam- MSV: 2415053122327");
            Console.WriteLine("Bài 18: Quản lý điểm sinh viên");
            List<Student> students = new List<Student>();
            while (true)
            {
                Console.WriteLine("Nhập thông tin sinh viên(nhập 0 để dừng) ");
                Console.Write("Nhập tên sinh viên: ");
                String ten = Console.ReadLine();
                if (ten == "0") break;
                Console.Write("Nhập điểm: ");
                double diem = double.Parse(Console.ReadLine());
                students.Add(new Student(ten, diem));
            }
            Console.WriteLine("\n===============================");
            Console.WriteLine("-----DANH SÁCH SINH VIÊN-----");
            Console.WriteLine("{0, -10} {1, -20}", "Tên", "Điểm");
            foreach (var sinhvien in students)
            {
                Console.WriteLine("{0, -10} {1, -20}", sinhvien.Name, sinhvien.Score);
            }
            Console.WriteLine("\n===============================");
            Console.WriteLine("-----DANH SÁCH SINH VIÊN CÓ ĐIỂM CAO NHẤT-----");
            double maxDiem = students.Max(s => s.Score);
            foreach (var sinhvien in students)
            {
                if (sinhvien.Score == maxDiem)
                {
                    Console.WriteLine("{0, -10} {1, -20}", sinhvien.Name, sinhvien.Score);
                }
            }
            Console.ReadLine();

        }
    }
}
