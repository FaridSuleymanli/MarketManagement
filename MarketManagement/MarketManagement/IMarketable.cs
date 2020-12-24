using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketIdareEtmeSistemi
{
    interface ISatislar
    {
        void Satislar(SaleItem newSale);
        void AddSale();
        void SaleReturn();
        void ReturnTotalSale();
        // void BetweenDates(DateTime dt1, DateTime dt2);
        // void ExactDateReturn();
        //void BetweenPrice();
        //int SaleNumber(int n);
        }
        interface IProducts
        {
            void Showlist();
            void AddProduct();
            void ChangeProduct();
            void RemoveProduct();
            void ShowByCategory();
            void SearchByPrice();
            void SearchByName();
        }
    }
