using System;

class bai3
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bài tập 3:");
        Console.WriteLine("a. Tính tổng các số nguyên không dấu trong mảng:");
        TinhTongKhongDau();
        Console.WriteLine("\nb. Tính tổng các số nguyên có dấu trong mảng:");
        TinhTongCoDau();
    }

    static void TinhTongKhongDau()
    {
        Console.WriteLine("Nhập số lượng phần tử trong mảng:");
        int n = int.Parse(Console.ReadLine());

        ushort[] arr = new ushort[n];

        Console.WriteLine("Nhập các phần tử của mảng:");
        for (int i = 0; i < n; i++)
        {
            arr[i] = ushort.Parse(Console.ReadLine());
        }

        ushort sum = 0;
        foreach (ushort num in arr)
        {
            sum += num;
        }

        Console.WriteLine("Tổng các số trong mảng là: " + sum);
    }

    static void TinhTongCoDau()
    {
        Console.WriteLine("Nhập số lượng phần tử trong mảng:");
        int n = int.Parse(Console.ReadLine());

        short[] arr = new short[n];

        Console.WriteLine("Nhập các phần tử của mảng:");
        for (int i = 0; i < n; i++)
        {
            arr[i] = short.Parse(Console.ReadLine());
        }

        short sum = 0;
        foreach (short num in arr)
        {
            sum += num;
        }

        Console.WriteLine("Tổng các số trong mảng là: " + sum);
    }
}