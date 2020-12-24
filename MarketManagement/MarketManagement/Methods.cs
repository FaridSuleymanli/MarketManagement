using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketIdareEtmeSistemi
{
    class Methods : IProducts
    {
        List<Product> product = new List<Product>();
        public Methods()
        {
            product.Add(new Product(12, "Corek", 0.5, 50, Category.Un_Memulatlari));
            product.Add(new Product(13, "Cola", 1.5, 50, Category.Ickiler));
            product.Add(new Product(14, "Tort", 10.5, 10, Category.Sirniyyat));
            product.Add(new Product(15, "Pepsi", 1.3, 50, Category.Meyve_Terevez));
        }
        public void Showlist()
        {
            //product.Add(new Product(12, "Corek", 0.5, 50, Category.Un_Memulatlari));
            //product.Add(new Product(13, "Cola", 1.5, 50, Category.Ickiler));
            //product.Add(new Product(14, "Tort", 5.5, 10, Category.Sirniyyat));
            //product.Add(new Product(15, "Pepsi", 1.3, 50, Category.Meyve_Terevez));
            foreach (Product item in product)
            {
                System.Console.WriteLine(item);
            }
        }
        public void AddProduct()
        {
            Console.WriteLine("Yeni mehsul elave etmek ucun, lazim olan melumatlari daxil edin");
            int code = Convert.ToInt32(Console.ReadLine());
            string name = Console.ReadLine();
            double price = Double.Parse(Console.ReadLine());
            int count = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Yeni mehsul elave edildi!");
        }
        public void ChangeProduct()
        {
            Console.WriteLine("Duzelis edilecek mehsulun kodunu daxil edin : ");
            int code = Convert.ToInt32(Console.ReadLine());
            foreach (Product item in product)
            {
                if (item.Code == code)
                {
                    string name = Console.ReadLine();
                    double price = Double.Parse(Console.ReadLine());
                    int count = Convert.ToInt32(Console.ReadLine());
                    item.Name = name;
                    item.Price = price;
                    item.Count = count;
                }
                Console.WriteLine(item);
            }
        }
        public void RemoveProduct()
        {
            Console.WriteLine("Silinecek mehsulun kodunu daxil edin : ");
            int code = Convert.ToInt32(Console.ReadLine());
            foreach (Product item in product)
            {
                if (item.Code == code)
                {
                    item.Name = null;
                    item.Price = 0;
                    item.Count = 0;
                    item.Code = 0;
                }
                Console.WriteLine(item);
            }
        }
        public void ShowByCategory()
        {
            int choice;
            foreach (var item in Enum.GetValues(typeof(Category)))
            {
                Console.WriteLine(item);
            }
            choice = Convert.ToInt32(Console.ReadLine());
            foreach (Product item in product)
            {
                switch (choice)
                {
                    case (int)Category.Et_Mehsullari:
                        Console.WriteLine(item);
                        break;
                    case (int)Category.Ickiler:
                        Console.WriteLine(item);
                        break;
                    case (int)Category.Meyve_Terevez:
                        Console.WriteLine(item);
                        break;
                    case (int)Category.Sirniyyat:
                        Console.WriteLine(item);
                        break;
                    case (int)Category.Un_Memulatlari:
                        Console.WriteLine(item);
                        break;
                    default:
    
                        break;
                }
            }
            
        }
        public void SearchByPrice()
        {
            Console.WriteLine("Qiymet araliqlarini daxil edin : ");
            int price1 = Convert.ToInt32(Console.ReadLine());
            int price2 = Convert.ToInt32(Console.ReadLine());
            foreach (Product item in product)
            {
                if (item.Price >= price1 && item.Price <= price2)
                {
                    Console.WriteLine(item);
                }
            }
        }
        public void SearchByName()
        {
            Console.WriteLine("Mehsulun adini daxil edin : ");
            string name = Console.ReadLine();
            foreach (Product item in product)
            {
                if (item.Name == name)
                {
                    Console.WriteLine("Bu qiymet araligindaki mehsullar : ");
                    Console.WriteLine(item);
                }
                else
                {

                }
                
               
                
            }
        }
    }
}