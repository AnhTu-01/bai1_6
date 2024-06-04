using System;

class bai6
{
    static void Main(string[] args)
    {
        try
        {
            // Yêu cầu a: Tính trung bình cộng của các số trong mảng số thực
            Console.WriteLine("Nhập số phần tử của mảng:");
            int n = int.Parse(Console.ReadLine());

            double[] numbers = new double[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhập số thứ " + (i + 1) + ":");
                numbers[i] = double.Parse(Console.ReadLine());
            }

            double sum = 0;

            for (int i = 0; i < n; i++)
            {
                sum += numbers[i];
            }

            double average = sum / n;

            Console.WriteLine("Trung bình cộng của các số trong mảng: " + average);

            // Yêu cầu b: Tìm giá trị lớn nhất và nhỏ nhất trong mảng số thực
            double max = numbers[0];
            double min = numbers[0];

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

            Console.WriteLine("Giá trị lớn nhất trong mảng: " + max);
            Console.WriteLine("Giá trị nhỏ nhất trong mảng: " + min);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Đã xảy ra lỗi: " + ex.Message);
        }
    }
}