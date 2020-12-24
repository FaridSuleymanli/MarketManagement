using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketIdareEtmeSistemi
{
    public enum Category { Meyve_Terevez = 1, Ickiler, Sirniyyat, Et_Mehsullari, Un_Memulatlari } //Kategoriya yaradiriq enumdan
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public Category Categ { get; set; } //enumdan instance alib, property yaradiriq
        public int Count { get; set; }
        public int Code { get; set; }

        public Product(int code, string name, double price, int count, Category category)
        {   //product constructor yaradib, parametrleri elave edirik
            Name = name;
            Price = price;
            Count = count;
            Code = code;
            Categ = category;
        }
        public override string ToString()
        {   //ekrana cixacaq deyerleri stringe ceviririk
            return $"{Code} {Name} {Price} {Count} {Categ}";
        }
    }


}
