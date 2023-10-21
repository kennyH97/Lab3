using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Bai3_3
    {
        public void CanChi()
        {
            Console.WriteLine("Nhap vao mot nam: ");
            int nam = Convert.ToInt32(Console.ReadLine());
            string[] can = new string[] { "Canh", "Tan", "Nham", "Quy", "Giap", "At", "Binh", "Dinh", "Mau", "Ky" };
            string[] chi = new string[] { " Than", "Dau", "Tuat", "Hoi", "Ty", "Suu", "Dan", "Mao", "Thin", "Ti", "Ngo", "Mui" };


            Console.WriteLine("Nam do la nam " + can[nam % 10] + " " + chi[nam % 12]);
        }
    }
}
