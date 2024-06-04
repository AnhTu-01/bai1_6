using System;

class bai4
{
    static void Main(string[] args)
    {
        try
        {
            // Yêu cầu a: Kiểm tra số Palindrome
            Console.WriteLine("Nhập số nguyên không dấu:");
            ulong number = ulong.Parse(Console.ReadLine());

            bool isPalindrome = IsPalindrome(number);

            if (isPalindrome)
            {
                Console.WriteLine("Số " + number + " là số Palindrome");
            }
            else
            {
                Console.WriteLine("Số " + number + " không là số Palindrome");
            }

            // Yêu cầu b: Tính tổng các số trong mảng có dấu kích thước 8 byte
            Console.WriteLine("Nhập số phần tử của mảng:");
            int n = int.Parse(Console.ReadLine());

            long[] numbers = new long[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhập số thứ " + (i + 1) + ":");
                numbers[i] = long.Parse(Console.ReadLine());
            }

            long sum = 0;

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

    static bool IsPalindrome(ulong number)
    {
        ulong temp = number;
        ulong reverse = 0;

        while (temp != 0)
        {
            reverse = reverse * 10 + temp % 10;
            temp /= 10;
        }

        return number == reverse;
    }
}