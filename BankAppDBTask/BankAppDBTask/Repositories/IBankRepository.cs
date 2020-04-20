using BankAppDBTask.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankAppDBTask.Repositories
{
    public interface IBankRepository
    {
        List<Bank> Read();
        List<Bank> ReadAllCustomers();
    }
}
