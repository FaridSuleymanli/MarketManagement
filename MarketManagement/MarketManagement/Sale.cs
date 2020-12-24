using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketIdareEtmeSistemi
{
    class Sale : ISatislar
    {
        private static int _id;
        public readonly int Id;
        public double SalePrice { get; set; }
        public SaleItem[] salearr = new SaleItem[0];
        public Product Prod { get; set; }
        public SaleItem Sell { get; set; }
        public DateTime Date;

        public Sale()
        {
            _id++;
            Id = _id;
        }
        public Sale(double saleprice, DateTime date, Product prod) : this()
        {
            SalePrice = saleprice;
            Date = date;
            Prod = prod;
        }
        public override string ToString()
        {
            return $"{Id} {SalePrice} {Date} {Prod.Categ}";
        }
        public void Satislar(SaleItem newSale)
        {
            Array.Resize(ref salearr, salearr.Length + 1);
            salearr[salearr.Length - 1] = newSale;
        }
        public void Showlist()
        {
            foreach (SaleItem item in salearr)
            {
                System.Console.WriteLine(item);
            }
        }
        public void AddSale()
        {
            Console.WriteLine("Yeni mehsul elave etmek ucun, lazim olan melumatlari daxil edin");
            int code = Convert.ToInt32(Console.ReadLine());
            int count = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Yeni mehsul elave edildi!");
        }
        public void SaleReturn()
        {
            int id = Convert.ToInt32(Console.ReadLine());
            int count = Convert.ToInt32(Console.ReadLine());
            foreach (SaleItem item in salearr)
            {
                if (item.Id == id)
                {
                    item.Count -= count;
                    System.Console.WriteLine($"Id-si {id} olan mehsulun satisi geri qaytarildi!");
                }
                else
                {
                    System.Console.WriteLine($"Id-si {id} olan mehsul tapilmadi!");
                }
                System.Console.WriteLine(item);
            }
        }
        public void ReturnTotalSale()
        {
            int id = Convert.ToInt32(Console.ReadLine());
            foreach (SaleItem item in salearr)
            {
                if (item.Id == id)
                {
                    item.Count = 0;
                }
                else
                {
                    System.Console.WriteLine("Bu mehsuldan tapilmadi");
                }
                System.Console.WriteLine(item);
            }
        }
        //public void BetweenDates(DateTime dt1, DateTime dt2)
        //{
        // foreach (SaleItem item in salearr)
        //  {
        //      if (dt1 < item.Sale && dt2 > item.Sale)
        //     {
        //         System.Console.WriteLine(item);
        //     }
        //     else
        //     {
        //         System.Console.WriteLine("Bu tarixler arasi satis olmayib");
        //     }   
        // }
        //}
    }
}