using System;

class bai1
{
    static void Main(string[] args)
    {
        try
        {
            // Yêu cầu a: Nhập từ bàn phím hai số nguyên kiểu 4 byte
            int a, b;
            Console.WriteLine("Nhập số nguyên a:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số nguyên b:");
            b = int.Parse(Console.ReadLine());

            // Yêu cầu a: Tính tổng, hiệu, tích và thương (số nguyên) của a và b
            int sum = a + b;
            int difference = a - b;
            int product = a * b;
            int quotient = a / b;

            // Yêu cầu a: Tính thương số thực của a và b
            float floatQuotient = (float)a / b;

            Console.WriteLine("Tổng: " + sum);
            Console.WriteLine("Hiệu: " + difference);
            Console.WriteLine("Tích: " + product);
            Console.WriteLine("Thương (số nguyên): " + quotient);
            Console.WriteLine("Thương (số thực): " + floatQuotient);

            // Yêu cầu b: Nhập vào một mảng số nguyên có dấu kích thước 4 byte từ người dùng và tính tổng của các số trong mảng
            Console.WriteLine("Nhập số phần tử của mảng:");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhập phần tử thứ " + (i + 1) + ":");
                arr[i] = int.Parse(Console.ReadLine());
            }

            int arraySum = 0;
            for (int i = 0; i < n; i++)
            {
                arraySum += arr[i];
            }

            Console.WriteLine("Tổng của các số trong mảng: " + arraySum);

            // Yêu cầu c: Nhập vào một số nguyên không dấu kích thước 4 byte từ người dùng và đảo ngược các chữ số của số đó
            Console.WriteLine("Nhập số nguyên không dấu:");
            uint number = uint.Parse(Console.ReadLine());

            uint reversedNumber = 0;
            while (number > 0)
            {
                reversedNumber = reversedNumber * 10 + number % 10;
                number /= 10;
            }

            Console.WriteLine("Số sau khi đảo ngược các chữ số: " + reversedNumber);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Đã xảy ra lỗi: " + ex.Message);
        }
    }
}