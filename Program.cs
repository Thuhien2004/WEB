using System;
using Love; // Namespace từ DLL

namespace LoveConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap ngay bat dau yeu (dd/MM/yyyy)💕:");
            string input = Console.ReadLine();

            DateTime startDate;
            if (!DateTime.TryParse(input, out startDate))
            {
                Console.WriteLine("Ngay khong hop le!");
                return;
            }

            // Tạo đối tượng LoveCalculator từ DLL
            LoveCalculator calc = new LoveCalculator();
            calc.StartDate = startDate;
            calc.Calculate(); // gọi hàm tính số ngày

            // Hiển thị kết quả
            Console.WriteLine(calc.Message);

            Console.WriteLine("Nhan Enter de thoat...");
            Console.ReadLine();
        }
    }
}
