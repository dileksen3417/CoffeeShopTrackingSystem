using CoffeeShopTrackingSystem.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopTrackingSystem.Concrete
{
    public class StarbuksCustomerManager:BaseCustomerManager
    {
        ICustomerCheckService _customerCheckService; //check servisten field tanımladım

        public StarbuksCustomerManager(ICustomerCheckService customerCheckService)//constractor, starbucks ilk newlendiğinde burası calısacak
        {
            _customerCheckService = customerCheckService; //check servisin yönetim classından gelen nesne benim yarattgım fielda esittir dedim.
        }

        public override void Save(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))//check operasyonu true dönerse if(true) yani
            {
                base.Save(customer);
            }
            else
            {
                throw new Exception("Not a valid person");
            }
            
        }

    }
}
