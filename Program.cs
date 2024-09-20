
using System;

class Program
{
    static void Main()
    {
        // Nhập số a
        Console.Write("Nhập số a: ");
        int a = int.Parse(Console.ReadLine());

        // Nhập số b
        Console.Write("Nhập số b: ");
        int b = int.Parse(Console.ReadLine());

        // Tính tổng a + b
        int result = a + b;

        // Hiển thị kết quả
        Console.WriteLine($"{a} + {b} = {result}");
    }
}
