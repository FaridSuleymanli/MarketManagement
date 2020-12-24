using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketIdareEtmeSistemi
{
    public enum Category { Meyve_Terevez = 1, Ickiler, Sirniyyat, Et_Mehsullari, Un_Memulatlari }
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public Category Categ { get; set; }
        public int Count { get; set; }
        public int Code { get; set; }

        public Product(int code, string name, double price, int count, Category category)
        {
            Name = name;
            Price = price;
            Count = count;
            Code = code;
            Categ = category;
        }
        public override string ToString()
        {
            return $"{Code} {Name} {Price} {Count} {Categ}";
        }
    }


}