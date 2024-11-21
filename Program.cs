using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {

        static void Main()
        {
            // Tạo một danh sách các đối tượng Student
            List<student> students = new List<student>();

            // Thêm các đối tượng Student vào danh sách
            students.Add(new student(1, " Minh", 14));
            students.Add(new student(2, "Minh2", 15));
            students.Add(new student(3, "Anh3", 16));
            students.Add(new student(4, "Minh4", 17));
            students.Add(new student(5, "Minh5", 18));

            // In thông tin của tất cả các học sinh trong danh sách
            Console.WriteLine("Danh sach toan bo hoc sinh :");
            foreach (var student in students)
            {
                Console.WriteLine(student.ToString());
            }
            var filteredStudents = students.Where(student => student.Age >= 15 && student.Age <= 18).ToList();
           

            // In thông tin các học sinh thỏa mãn điều kiện
            Console.WriteLine("Danh sach hoc sinh co tuoi tu 15 den 18:");
            foreach (var student in filteredStudents)
            {
                Console.WriteLine(student.ToString());
            }

            int totalAge = students.Sum(student => student.Age);

            var studentsWithA = students
            .Where(student => student.Name.StartsWith("A", StringComparison.OrdinalIgnoreCase))
            .ToList();

            Console.WriteLine("Danh sach sinh vien có ten bat đau bang chu 'A':");
            foreach (var student in studentsWithA)
            {
                Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}");
            }

            // In ra tổng tuổi
            Console.WriteLine("Tong tuoi cua tat ca hoc sinh: " + totalAge);

            int maxAge = students.Max(student => student.Age);

            // Tìm học sinh có tuổi lớn nhất
            var oldestStudent = students.FirstOrDefault(student => student.Age == maxAge);

            // In thông tin học sinh có tuổi lớn nhất
            if (oldestStudent != null)
            {
                Console.WriteLine("Hoc sinh có tuoi lon nhat:");
                Console.WriteLine(oldestStudent.ToString());
            }
            else
            {
                Console.WriteLine("Khong tim thay hoc sinh.");
            }

            var sortedStudents = students.OrderBy(student => student.Age).ToList();

            // In danh sách học sinh sau khi sắp xếp
            Console.WriteLine("Danh sach học sinh sau khi sap xep theo tuoi tang dan:");
            foreach (var student in sortedStudents)
            {
                Console.WriteLine(student.ToString());
            }
        }

    }
}
