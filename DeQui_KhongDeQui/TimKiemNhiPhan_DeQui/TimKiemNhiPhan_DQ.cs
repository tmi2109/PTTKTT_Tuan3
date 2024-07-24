using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimKiemNhiPhan_DeQui
{
    class TimKiemNhiPhan_DQ
    {
        const int MAX = 100;

        static void Main()
        {
            int[] a = new int[MAX];
            int n, x;

            do
            {
                Console.Write("Nhap phan tu cua mang: ");
            }
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0 || n > MAX);

            NhapMang(a, ref n);
            Console.WriteLine("Mang chua duoc sap xep:");
            XuatMang(a, n);

            
            Console.WriteLine("Mang da duoc sap xep:");
            Array.Sort(a, 0, n);
            XuatMang(a, n);

            Console.Write("\nNhap x can tim: ");
            while (!int.TryParse(Console.ReadLine(), out x))
            {
                Console.Write("Nhap x can tim: ");
            }


            int kq = BinarySearch(a, 0, n - 1, x);
            if (kq == -1)
            {
                Console.WriteLine($"Khong tim thay {x} trong mang");
            }
            else
            {
                Console.WriteLine($"Tim thay {x} tai vi tri thu {kq}");
            }
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

        static int BinarySearch(int[] a, int left, int right, int x)                    
        {
            if (left > right)
                return -1;

            int mid = (left + right) / 2;
            if (a[mid] == x)
                return mid;
            if (a[mid] > x)
                return BinarySearch(a, left, mid - 1, x);
            else
                return BinarySearch(a, mid + 1, right, x);
        }
    }
}
