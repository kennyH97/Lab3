using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Bai3_1
    {
        public void Mang1Chieu()
        {
            int[] soNguyen = new int[10];
            Console.WriteLine("Nhap cac phan tu cua mang: ");
            for (int i = 0; i < soNguyen.Length; i++)
            {
                Console.WriteLine("Phan tu thu {0}: ", i + 1);
                soNguyen[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();

            Console.WriteLine("Mang co 10 phan tu gom: ");
            for (int i = 0; i < soNguyen.Length; i++)
            {
                Console.Write(" {0} ", soNguyen[i]);
            }
            Console.WriteLine();

            Console.WriteLine("Dao nguoc mang: ");
            for (int i = soNguyen.Length - 1; i >= 0; i--)
            {
                Console.Write(" {0} ", soNguyen[i]);
            }
            Console.WriteLine();


            Console.WriteLine("Tim phan tu la so nguyen to: ");
            foreach (int i in soNguyen)
            {
                bool check = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        check = false;
                    }
                }
                if (check)
                {
                    Console.Write(" {0} ", i);
                }
            }
            Console.WriteLine();

            // So luong cac so duong lien tiep nhieu nhat
            int count = 0;
            int[] soduong = new int[soNguyen.Length];
            for (int i = 0; i < soNguyen.Length - 1; i++)
            {
                if (soNguyen[i] > 0)
                {
                    count++;
                    soduong[i] = count;
                }
                else
                {
                    count = 0;
                    soduong[i] = 0;
                }
            }
            Console.WriteLine("So luong cac so duong lien tiep nhieu nhat la {0}.", soduong.Max());

            Console.WriteLine("Kiem tra cac phan tu am duong dan xen:");
            bool check2 = true;
            for (int i = 0; i < soNguyen.Length - 1; i++)
            {
                if ((soNguyen[i]) > 0 && soNguyen[i + 1] > 0 || (soNguyen[i]) < 0 && soNguyen[i + 1] < 0)
                {
                    check2 = false;
                    break;
                }
            }
            if (check2)
            {
                Console.WriteLine("Mang co cac phan tu am duong dan xen.");
            }
            else
            {
                Console.WriteLine("Mang khong co cac phan tu am duong dan xen.");
            }

            Console.WriteLine("Mang tang dan: ");
            int temp;
            for (int i = 0; i < soNguyen.Length - 1; i++)
            {
                for (int j = i + 1; j < soNguyen.Length; j++)
                {
                    if (soNguyen[i] > soNguyen[j])
                    {
                        temp = soNguyen[i];
                        soNguyen[i] = soNguyen[j];
                        soNguyen[j] = temp;
                    }
                }
            }
            for (int i = 0; i < soNguyen.Length; i++)
            {
                Console.Write(" {0} ", soNguyen[i]);
            }
            Console.WriteLine();

            int tong = 0, count2 = 0;
            float trungBinh;
            for (int i = 0; i < soNguyen.Length; i++)
            {
                if (soNguyen[i] > 0)
                {
                    tong += soNguyen[i];
                    count2++;
                }
            }
            trungBinh = (float)tong / count2;
            Console.WriteLine("Trung binh cong cac phan tu duong = {0}", trungBinh);
            Console.WriteLine();


        }
    }
}
