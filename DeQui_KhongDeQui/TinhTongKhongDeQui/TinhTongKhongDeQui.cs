using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhTongKhongDeQui
{
    class TinhTongKhongDeQui
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

            Console.WriteLine("Mang da duoc sap xep:");
            Array.Sort(a, 0, n);
            XuatMang(a, n);

            int ketqua = Sum(a, n);
            Console.WriteLine($"\nKet qua: {ketqua}");
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

        static int Sum(int[] a, int n)     //Không đệ qui
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += a[i];
            }
            return sum;
        }
    }
}
