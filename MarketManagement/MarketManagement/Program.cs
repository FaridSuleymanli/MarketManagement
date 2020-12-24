using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketIdareEtmeSistemi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Product product = new Product(12, "Corek", 0.5, 50, Category.Un_Memulatlari);
            //Product product1 = new Product(13, "Cola", 1.5, 50, Category.Ickiler);
            //Product product2 = new Product(14, "Tort", 5.5, 10, Category.Sirniyyat);
            //Product product3 = new Product(15, "Pepsi", 1.3, 50, Category.Ickiler);
            //SaleItem sl = new SaleItem(product, 20);
            //SaleItem sl1 = new SaleItem(product1, 25);
            //SaleItem sl2 = new SaleItem(product2, 3);
            ShowMenu();

            //ShowMenu();
            //method.List(product);
            //method.List(product1);
            //method.List(product2);
            //method.Showlist();
            //method.AddProduct();
            //method.ChangeProduct();
            //method.RemoveProduct();
            //method.SearchByName();

        }
        static void ShowMenu()
        {
            int choice;
            System.Console.WriteLine("1. Mehsullar uzerinde emeliyyat aparmaq");
            System.Console.WriteLine("2. Satishlar uzerinde emeliyyat aparmaq");
            System.Console.WriteLine("3. Sistemden cixmaq");

            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    ShowProductMenu();
                    break;
                case 2:
                    ShowSaleMenu();
                    break;
                case 3:
                    break;
                default:
                    break;
            }
        }
        static void ShowProductMenu()
        {
            int choice2;
            System.Console.WriteLine("1. Yeni mehsul elave et");
            System.Console.WriteLine("2. Mehsul uzerinde duzelis et");
            System.Console.WriteLine("3. Mehsulu sil");
            System.Console.WriteLine("4. Butun mehsullari goster");
            System.Console.WriteLine("5. Kateqoriyaya gore mehsullari goster");
            System.Console.WriteLine("6. Qiymet araligina gore mehsullari goster");
            System.Console.WriteLine("7. Mehsullar arasinda ada gore axtaris");

            //Product product = new Product(12, "Corek", 0.5, 50, Category.Un_Memulatlari);
            //Product product1 = new Product(13, "Cola", 1.5, 50, Category.Ickiler);
            //Product product2 = new Product(14, "Tort", 5.5, 10, Category.Sirniyyat);
            //Product product3 = new Product(15, "Pepsi", 1.3, 50, Category.Ickiler);

            Methods method = new Methods();
            choice2 = Convert.ToInt32(Console.ReadLine());
            switch (choice2)
            {
                case 1:
                    method.AddProduct();
                    break;
                case 2:
                    method.ChangeProduct();
                    break;
                case 3:
                    method.RemoveProduct();
                    break;
                case 4:
                    //method.List(product);
                    //method.List(product1);
                    //method.List(product2);
                    //method.List(product3);
                    method.Showlist();
                    break;
                case 5:
                    method.ShowByCategory();
                    break;
                case 6:
                    method.SearchByPrice();
                    break;
                case 7:
                    method.SearchByName();
                    break;
                default:
                    break;
            }
        }
        static void ShowSaleMenu()
        {
            int choice3;
            System.Console.WriteLine("1. Yeni satis elave etmek");
            System.Console.WriteLine("2. Satisdaki mehsulun satisdan cixarilmasi");
            System.Console.WriteLine("3. Satisin silinmesi");
            System.Console.WriteLine("4. Butun satislari goster");
            System.Console.WriteLine("5. Satislari goster (tarix araligina gore)");
            System.Console.WriteLine("6. Satislari goster (mebleg araligina gore)");
            System.Console.WriteLine("7. Verilmis tarixe gore satislari goster");
            System.Console.WriteLine("8. Satis melumatlarini goster (nomreye gore)");
            Product product = new Product(12, "Corek", 0.5, 50, Category.Un_Memulatlari);
            Product product1 = new Product(13, "Cola", 1.5, 50, Category.Ickiler);
            Product product2 = new Product(14, "Tort", 5.5, 10, Category.Sirniyyat);
            Product product3 = new Product(15, "Pepsi", 1.3, 50, Category.Ickiler);
            SaleItem item1 = new SaleItem(product, 10);
            SaleItem item2 = new SaleItem(product1, 10);
            SaleItem item3 = new SaleItem(product2, 10);
            SaleItem item4 = new SaleItem(product3, 10);
            Sale sale = new Sale(20, new DateTime(2020, 12, 15), product);
            Sale sale1 = new Sale(20, new DateTime(2020, 12, 16), product1);
            Sale sale2 = new Sale(20, new DateTime(2020, 12, 16), product2);
            Sale sale3 = new Sale(20, new DateTime(2020, 12, 15), product3);

            choice3 = Convert.ToInt32(Console.ReadLine());
            switch (choice3)
            {
                case 1:
                    sale.Satislar(item1);
                    sale.Satislar(item2);
                    sale.Showlist();
                    break;
                case 2:
                    sale.AddSale();
                    break;
                case 3:

                    break;
            }
        }
    }
}