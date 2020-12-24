using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketIdareEtmeSistemi
{
    class SaleItem //Satis Item klasi yaradiriq
    {
        public Product Product { get; set; } //Product klasindan property yaradiriq
        public Sale Sale { get; set; } //Sale klasindan property yaradiriq
        private static int _id = 0; 
        public readonly int Id;
        public int Count { get; set; }

        public SaleItem() //bos constructor yaradib private id-ni set edirik
        {
            _id++;
            Id = _id;
        }  //yeni bir constructor yaradib, parametrlerini veririk
        public SaleItem(Product product, int count) : this() //bos constructoru isletmek ucun
        {
            Product = product;
            Count = count;
        }
        public override string ToString()
        {   //ekrana cixacaq deyerleri stringe ceviririk
            return $"{Id} {Product.Name} {Count}";
        }

    }
}
