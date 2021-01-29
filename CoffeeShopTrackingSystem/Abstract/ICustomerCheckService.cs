using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopTrackingSystem.Abstract
{
    public interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
