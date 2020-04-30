using BankAppDBTask.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Banks;

namespace BankAppDBTask.Repositories
{
    public interface IBankRepository
    {
        List<Bank> Read();
        List<Bank> ReadAllCustomers();
        String Create(Bank bank);
    }
}
