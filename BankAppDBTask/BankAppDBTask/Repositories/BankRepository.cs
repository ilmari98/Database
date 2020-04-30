using System;
using System.Collections.Generic;
using System.Text;
using BankAppDBTask.Data;
using BankAppDBTask.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace BankAppDBTask.Repositories
{
    class BankRepository : IBankRepository
    {
        private readonly BankappContext _context = new BankappContext();

        public string Create(Bank bank)
        {
            string result = "";

            try
            {
                _context.Bank.Add(bank);
                _context.SaveChanges();
                result = "Data has been saved.";
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }

            return result;
        }

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
