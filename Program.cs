using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_tập_buổi_1_Trần_Quang_Hiển_2280600922
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soluong;
            decimal gia;
            decimal tonggiatri;

            try
            {
                Console.WriteLine("nhap so luong hang hoa:");
                soluong = Convert.ToInt32(Console.ReadLine());
            }
            catch(Exception loisoluong){
                Console.WriteLine("loi sl",loisoluong);
                return;
            }

            try
            {
                Console.WriteLine("nhap gia tri cua 1 hang hoa:");
                gia = Convert.ToDecimal(Console.ReadLine());
            }
            catch (Exception loigia)
            {
                Console.WriteLine("loi gia", loigia);
                return;
            }
            tonggiatri = soluong * gia;
            Console.WriteLine("tong gia tri don hang la: "+tonggiatri);
        }
    }
}
