using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai11
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

    class Bai11
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("\n\n");
            Console.WriteLine("Họ và tên: Lê Hoài Nam- MSV: 2415053122327");
            Console.WriteLine("Bài 11: Lưu danh sách sinh viên");
            List<Student> student = new List<Student>();
            while (true)
            {
                Console.WriteLine("Nhập thông tin sinh viên(Nhập 0 để dừng)");
                Console.Write("Nhập id (Nhập 0 để dừng): ");
                int id = int.Parse(Console.ReadLine());
                if (id == 0) break;
                Console.Write("Nhập họ tên: ");
                string hten = Console.ReadLine();
                Student st = new Student(id, hten);
                student.Add(st);
                Console.WriteLine("Đã thêm thông tin sinh viên");
            }
            Console.WriteLine("\n===============================");
            Console.WriteLine("-----DANH SÁCH SINH VIÊN-----");
            Console.WriteLine("{0, -10} {1, -20}", "ID", "Ho ten");
            foreach (var sinhvien in student)
            {
                Console.WriteLine("{0, -10} {1, -20}", sinhvien.Id.ToString("D4"), sinhvien.Name);
            }
            Console.ReadLine();

        }
    }
}
