using System;
using System.Collections.Generic;
using System.Text;

namespace BankAppDBTask.Models
{
    public interface ICustomerView
    {
        void ReadAllData();
        //List<Customer> Read();
        void ReadBankCustomers();
        void CreateCustomer();
        void DeleteCustomer();
    }
}
