using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort_DeQui
{
    class QuickSort_DeQui
    {
        const int MAX = 100;

        static void Main()
        {
            int[] a = new int[MAX];
            int n;

            do
            {
                Console.Write("Nhap phan tu cua mang: ");
            } 
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0 || n > MAX);

            NhapMang(a, ref n);
            Console.WriteLine("Mang chua duoc sap xep:");
            XuatMang(a, n);
            QuickSort(a, 0, n - 1);
            Console.WriteLine("\nMang sau khi duoc sap xep:");
            XuatMang(a, n);
            Console.ReadLine();
        }

        static void NhapMang(int[] a, ref int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap phan tu a[{i}]: ");
                while (!int.TryParse(Console.ReadLine(), out a[i]))
                {
                    Console.Write($"Nhap phan tu a[{i}]: ");
                }
            }
        }

        static void XuatMang(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"\t{a[i]}");
            }
            Console.WriteLine();
        }

        static void QuickSort(int[] a, int left, int right)
        {
            if (left < right)
            {
                int s = Partition(a, left, right);
                QuickSort(a, left, s - 1);              //Gọi đệ qui để sắp xếp nửa đầu của mảng
                QuickSort(a, s + 1, right);             //Gọi đệ qui để sắp xếp nửa sau của mảng
            }
        }

        static int Partition(int[] a, int left, int right)
        {
            int k = a[right];
            int i = left - 1; 

            for (int j = left; j < right; j++)
            {
                if (a[j] <= k)
                {
                    i++;
                    Swap(ref a[i], ref a[j]);
                }
            }

            Swap(ref a[i + 1], ref a[right]); 
            return i + 1;
        }

        static void Swap(ref int x, ref int y)
        {
            int t = x;
            x = y;
            y = t;
        }
    }
}
