using System;

class bai2
{
    static void Main(string[] args)
    {
        try
        {
            // Yêu cầu a: Tìm số lớn nhất và nhỏ nhất trong dãy số nguyên có dấu kích thước 1 byte
            Console.WriteLine("Nhập số phần tử của dãy số:");
            int n = int.Parse(Console.ReadLine());

            sbyte[] numbers = new sbyte[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhập số thứ " + (i + 1) + ":");
                numbers[i] = sbyte.Parse(Console.ReadLine());
            }

            sbyte max = numbers[0];
            sbyte min = numbers[0];

            for (int i = 1; i < n; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }

                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }

            Console.WriteLine("Số lớn nhất trong dãy số: " + max);
            Console.WriteLine("Số nhỏ nhất trong dãy số: " + min);

            // Yêu cầu b: Tính tổng các số chẵn trong dãy số nguyên có dấu kích thước 1 byte
            int sumEven = 0;

            for (int i = 0; i < n; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sumEven += numbers[i];
                }
            }

            Console.WriteLine("Tổng các số chẵn trong dãy số: " + sumEven);

            // Yêu cầu c: Tính tổng các số từ 1 đến n (số nguyên không dấu kích thước 1 byte)
            Console.WriteLine("Nhập số nguyên không dấu n:");
            byte nUnsigned = byte.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 1; i <= nUnsigned; i++)
            {
                sum += i;
            }

            Console.WriteLine("Tổng các số từ 1 đến " + nUnsigned + ": " + sum);

            // Yêu cầu d: Tính tổng các chữ số trong số nguyên không dấu kiểu byte
            Console.WriteLine("Nhập số nguyên không dấu:");
            byte number = byte.Parse(Console.ReadLine());

            int digitSum = 0;

            while (number > 0)
            {
                digitSum += number % 10;
                number /= 10;
            }

            Console.WriteLine("Tổng các chữ số trong số: " + digitSum);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Đã xảy ra lỗi: " + ex.Message);
        }
    }
}