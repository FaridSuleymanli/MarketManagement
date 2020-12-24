using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketIdareEtmeSistemi
{
    class SaleItem
    {
        public Product Product { get; set; }
        public Sale Sale { get; set; }
        private static int _id = 0;
        public readonly int Id;
        public int Count { get; set; }

        public SaleItem()
        {
            _id++;
            Id = _id;
        }
        public SaleItem(Product product, int count) : this()
        {
            Product = product;
            Count = count;
        }
        public override string ToString()
        {
            return $"{Id} {Product.Name} {Count}";
        }

    }
}