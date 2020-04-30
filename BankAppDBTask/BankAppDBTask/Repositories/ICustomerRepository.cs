using BankAppDBTask.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankAppDBTask.Repositories
{
    public interface ICustomerRepository
    {
        List<Customer>Read();
        Customer Read(long id);
        List<Customer>ReadBankCustomers(int bankId);
        String Create(Customer customer);
        String Delete(long id);
        
    }
}
