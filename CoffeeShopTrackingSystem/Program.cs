using CoffeeShopTrackingSystem.Abstract;
using CoffeeShopTrackingSystem.Adapters;
using CoffeeShopTrackingSystem.Concrete;
using System;

namespace CoffeeShopTrackingSystem
{
    class Program
    {
       
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbuksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer {DateOfBirth=new DateTime(1995, 8, 20), FirstName = "DİLEK", LastName="ŞEN", NationalityId="1111111111" });
            //doğru bilgi verdigimde eklendi yazar, yanlış bilgi verildiğinde exception fırlatır
        }

    }
}
