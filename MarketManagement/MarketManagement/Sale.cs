using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketIdareEtmeSistemi
{
    class Sale : ISatislar //Satis klasi yaradib interface-den miras aliriq
    {
        private static int _id;
        public readonly int Id;
        public double SalePrice { get; set; }
        public SaleItem[] salearr = new SaleItem[0]; //saleitem type-dan yeni bir array yaradiriq
        public Product Prod { get; set; } //product klasindan bir property yaradiriq
        public SaleItem Sell { get; set; } //ve saleitem klasindan bir property
        public DateTime Date; //tarix vermek ucun field

        public Sale() //bos constructor veriirik id-ni set etmek ucun
        {
            _id++;
            Id = _id;
        }   //Yeni constructor yaradib parametrlerini veririk
        public Sale(double saleprice, DateTime date, Product prod) : this() //bos constructoru isletmek ucun
        {
            SalePrice = saleprice;
            Date = date;
            Prod = prod;
        }
        public override string ToString()
        {    //ekranan cixacaq deyerleri stringe cevirib veririk
            return $"{Id} {SalePrice} {Date} {Prod.Categ}";
        }
        public void Satislar(SaleItem newSale) 
        {    //Arrayin size-ni 1 artitiriq
            Array.Resize(ref salearr, salearr.Length + 1);
            salearr[salearr.Length - 1] = newSale;
        }
        public void Showlist()
        {   //sale listimizi gosterir
            foreach (SaleItem item in salearr)
            {
                System.Console.WriteLine(item);
            }
        }
        public void AddSale() //yeni bir satis elave edirik
        {
            Console.WriteLine("Yeni mehsul elave etmek ucun, lazim olan melumatlari daxil edin");
            int code = Convert.ToInt32(Console.ReadLine()); //user input
            int count = Convert.ToInt32(Console.ReadLine()); //user input
            Console.WriteLine("Yeni mehsul elave edildi!");
        }
        public void SaleReturn() //satisin geri qaytarilmasi metodu
        {
            int id = Convert.ToInt32(Console.ReadLine()); //user input
            int count = Convert.ToInt32(Console.ReadLine()); //user input
            foreach (SaleItem item in salearr) //foreach-e saliriq ve eger verdiyimiz id, item id-e eyni olsa, hemin mehsulu satisdan qaytaririq
            {
                if (item.Id == id)
                {
                    item.Count -= count; //satis sayi azalir
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
        {   //butun satisin qayitmasi
            int id = Convert.ToInt32(Console.ReadLine()); //user input
            foreach (SaleItem item in salearr) //foreach-e saliriq ve eger verdiyimiz id, item id-e eyni olsa, hemin mehsulun hamisini satisdan qaytaririq
            {
                if (item.Id == id)
                {
                    item.Count = 0; //satis sayi 0 olur
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
