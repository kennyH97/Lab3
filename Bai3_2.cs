using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Bai3_2
    {
        public void Mang2Chieu()
        {
            int[,] a = new int[4, 4];
            Console.WriteLine("Nhap phan tu cho mang: ");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write("Phan tu [{0},{1}]: ", i, j);
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine();
            Console.WriteLine("Mang 2 chieu: ");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(" {0} ", a[i, j]);
                }
                Console.WriteLine();
            }

            // Tinh tong cac phan tu co chi so hang bang chi so cot
            int tongDuongCheo = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        tongDuongCheo += a[i, j];
                    }
                }
            }
            Console.WriteLine("Tong cac phan tu co chi so hang bang chi so cot la: {0}", tongDuongCheo);
            Console.WriteLine();

            Console.WriteLine("In ra cac phan tu nho nhat tren cot:");
            for (int i = 0; i < a.GetLength(1); i++)
            {
                int min = a[0, i];
                for (int j = 0; j < a.GetLength(0); j++)
                {
                    if (min > a[j, i])
                    {
                        min = a[j, i];
                    }
                }
                Console.WriteLine("Phan tu nho nhat cot {0} la {1}", i + 1, min);

            }
            Console.WriteLine();

            //Liet ke cac phan tu chia het cho 7
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] % 7 == 0)
                    {
                        Console.WriteLine("Phan tu a[{0}, {1}] = {2} chia het cho 7", i, j, a[i, j]);
                    }
                }
            }
            Console.WriteLine();

            //Tim tong cac phan tu nam tren duong vien
            int tongDuongVien = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (i == 0 || j == 0 || i == 3 || j == 3)
                    {
                        tongDuongVien += a[i, j];
                    }
                }
            }
            Console.WriteLine($"Tong cac phan tu nam tren duong vien = {tongDuongVien}.");
            Console.WriteLine();

            //Chuyen thanh mang 1 chieu roi sap xep dang dan
            int[] b = new int[16];
            int k = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    b[k] = a[i, j];
                    k++;
                }
            }
            Console.WriteLine();


            int temp;
            for (int i = 0; i < k - 1; i++)
            {
                for (int j = i + 1; j < k; j++)
                {
                    if (b[i] > b[j])
                    {
                        temp = b[i];
                        b[i] = b[j];
                        b[j] = temp;
                    }
                }
            }
            Console.WriteLine("Thu tu tang dan cua mang 1 chieu la: ");
            for (int i = 0; i < k; i++)
            {
                Console.Write(" {0} ", b[i]);
            }
        }



    }
}
