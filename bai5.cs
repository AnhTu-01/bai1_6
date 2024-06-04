using System;

class bai5
{
    static void Main(string[] args)
    {
        try
        {
            // Yêu cầu a: Tìm giá trị lớn nhất và nhỏ nhất trong mảng số thực
            Console.WriteLine("Nhập số phần tử của mảng:");
            int n = int.Parse(Console.ReadLine());

            float[] numbers = new float[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhập số thứ " + (i + 1) + ":");
                numbers[i] = float.Parse(Console.ReadLine());
            }

            float max = numbers[0];
            float min = numbers[0];

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

            // Yêu cầu b: Tính tổng các số trong mảng số thực
            float sum = 0;

            for (int i = 0; i < n; i++)
            {
                sum += numbers[i];
            }

            Console.WriteLine("Tổng các số trong mảng: " + sum);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Đã xảy ra lỗi: " + ex.Message);
        }
    }
}