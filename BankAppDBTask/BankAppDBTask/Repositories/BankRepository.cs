using System;
using System.Collections.Generic;
using System.Text;
using BankAppDBTask.Models;
using System.Linq;
using BankAppDBTask.Data;

namespace BankAppDBTask.Repositories
{
    class BankRepository : IBankRepository
    {
        private readonly BankappContext _context = new BankappContext();
        public List<Bank> Read()
        {
            var banks = _context.Bank.ToList();
            return banks;
        }

        public List<Bank> ReadAllCustomers()
        {
            var banks = _context.Bank.ToList();
            return banks;
        }
    }
}
