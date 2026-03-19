using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai14
{
    class Bai14
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
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("\n\n");
            Console.WriteLine("Họ và tên: Lê Hoài Nam- MSV: 2415053122327");
            Console.WriteLine("Bài 14: Xoá sinh viên theo ID");
            List<Student> student = new List<Student>();
            while (true)
            {
                Console.WriteLine("Nhập thông tin sinh viên(Nhập 0 để dừng lại)");
                Console.Write("Nhập ID sinh viên(nhập 0 để dừng): ");
                int id = int.Parse(Console.ReadLine());
                if (id == 0) break;
                Console.Write("Nhập họ và tên sinh viên: ");
                string hten = Console.ReadLine();
                Student sv = new Student(id, hten);
                student.Add(sv);
            }
            Console.WriteLine("==============================");
            Console.WriteLine("----- DANH SÁCH SINH VIÊN-----");
            Console.WriteLine("{0, -10} {1, -20}", "ID", "Họ và tên");
            foreach (var svien in student)
            {
                Console.WriteLine("{0, -10} {1, -20}", svien.Id.ToString("D4"), svien.Name);
            }
            Console.Write("Nhập ID sinh viên cần xoá: ");
            int ktra = int.Parse(Console.ReadLine());
            for (int i = student.Count - 1; i >= 0; i--)
            {
                if (student[i].Id.Equals(ktra))
                {
                    student.RemoveAt(i);
                }
            }
            Console.WriteLine("==============================");
            Console.WriteLine("----- DANH SÁCH SINH VIÊN SAU KHI XOÁ-----");
            Console.WriteLine("{0, -10} {1, -20}", "ID", "Họ và tên");
            foreach (var svien in student)
            {
                Console.WriteLine("{0, -10} {1, -20}", svien.Id.ToString("D4"), svien.Name);
            }
            Console.ReadLine();
        }
    }
}
