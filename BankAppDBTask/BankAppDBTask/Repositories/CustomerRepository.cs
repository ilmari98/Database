using System;
using System.Collections.Generic;
using System.Text;
using BankAppDBTask.Data;
using BankAppDBTask.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace BankAppDBTask.Repositories
{
    class CustomerRepository : ICustomerRepository
    {
        private readonly BankappContext _context= new BankappContext();
        public List<Customer> Read()
        {
            var customers = _context
                .Customer
                .Include(c=>c.Bank)
                .ToList();
            return customers;
        }

        public List<Customer> ReadBankCustomers(int bankId)
        {
            var customers = _context.Customer.Include(c=>c.Bank).Where(c => c.BankId == bankId).ToList();
            return customers;
        }
    }
}