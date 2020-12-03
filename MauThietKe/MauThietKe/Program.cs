using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MauThietKe.Cafe;
namespace MauThietKe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            CafeChồn cafeChồn = new CafeChồn();
            CafeChồn cloneOfCafeChon = (CafeChồn)cafeChồn.Clone();

            CafePhin cafePhin = new CafePhin();
            CafePhin cloneOfcafePhin = (CafePhin)cafePhin.Clone();

            CafeRangXay cafeRangXay = new CafeRangXay();
            CafeRangXay cloneOfCafeRangXay =(CafeRangXay)cafeRangXay.Clone();

            Console.WriteLine($"Tên sản phẩm: {cloneOfCafeChon.GetMôTả()}, {cloneOfCafeChon.GetGiá()}");
            Console.WriteLine($"Tên sản phẩm: {cloneOfcafePhin.GetMôTả()}, {cloneOfcafePhin.GetGiá()}");
            Console.WriteLine($"Tên sản phẩm: {cloneOfCafeRangXay.GetMôTả()}, {cloneOfCafeRangXay.GetGiá()}");
            Console.ReadLine();
        }
    }
}
