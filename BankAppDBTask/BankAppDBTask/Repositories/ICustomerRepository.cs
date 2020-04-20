using BankAppDBTask.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankAppDBTask.Repositories
{
    public interface ICustomerRepository
    {
        List<Customer>Read();
        List<Customer>ReadBankCustomers(int bankId);
    }
}
