using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketIdareEtmeSistemi
{
    class Methods : IProducts //yeni klass yaradib, interface-den miras aliriq
    {
        List<Product> product = new List<Product>(); //product type-dan list yaradiriq
        public Methods()
        {
            product.Add(new Product(12, "Corek", 0.5, 50, Category.Un_Memulatlari)); //liste elave edirik
            product.Add(new Product(13, "Cola", 1.5, 50, Category.Ickiler));
            product.Add(new Product(14, "Tort", 10.5, 10, Category.Sirniyyat));
            product.Add(new Product(15, "Pepsi", 1.3, 50, Category.Meyve_Terevez));
        }
        public void Showlist()
        {    //listde olanlari ekrana cixardir
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
        {   //yeni product add edirik
            Console.WriteLine("Yeni mehsul elave etmek ucun, lazim olan melumatlari daxil edin");
            int code = Convert.ToInt32(Console.ReadLine()); //4 ferqli user input veririk
            string name = Console.ReadLine();
            double price = Double.Parse(Console.ReadLine());
            int count = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Yeni mehsul elave edildi!");
        }
        public void ChangeProduct()
        {   //productda deyisiklik edirik
            Console.WriteLine("Duzelis edilecek mehsulun kodunu daxil edin : ");
            int code = Convert.ToInt32(Console.ReadLine());
            foreach (Product item in product) //foreach-de yoxlayiriq, eger verdiyimiz mehsul kodu, olan kodla eynidirse, hemen mehsulun parametrlerininde deyisiklik edirik
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
                Console.WriteLine(item); //deyisilmis mehsulu ekrana cixardir
            }
        }
        public void RemoveProduct()
        {   //mehsulun silinmesi
            Console.WriteLine("Silinecek mehsulun kodunu daxil edin : ");
            int code = Convert.ToInt32(Console.ReadLine());
            foreach (Product item in product)  //foreach-de yoxlayiriq, eger verdiyimiz mehsul kodu, olan kodla eynidirse, hemen mehsulu silirik
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
        {  //enum kategoriyasina gore mehsullari gosterir
            int choice;
            foreach (var item in Enum.GetValues(typeof(Category))) //kateqoriyalari ekrana cixardiririq
            {
                Console.WriteLine(item);
            }
            choice = Convert.ToInt32(Console.ReadLine());
            foreach (Product item in product)   //foreach-de yoxlayiriq, eger daxil etdiyimiz input, kateqoriyanin id-si ile uygun gelirse, hemin kateqoriyada olan mehsullari gosterir
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
                if (item.Price >= price1 && item.Price <= price2)  //yoxlayiriq, eger itemin qiymeti bizim verdiyimiz araliqdadirsa, o araliqda olan mehsullari gosterir
                {
                    Console.WriteLine(item);
                }
            }
        }
        public void SearchByName()
        {   
            Console.WriteLine("Mehsulun adini daxil edin : ");
            string name = Console.ReadLine();
            foreach (Product item in product)  //eger verdiyimiz adla item-in adi uygun gelirse, o itemi ekrana cixardir
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
