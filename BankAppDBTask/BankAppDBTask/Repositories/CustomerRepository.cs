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
        private readonly BankappContext _context = new BankappContext();

        public String Create(Customer customer)
        {
            string result = "";

            try
            {
                _context.Customer.Add(customer);
                _context.SaveChanges();
                result = "Data has been saved.";
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }
            
            return result;
        }

        public string Delete(long id)
        {
            //Tarkasta tietokannasta id
            var isCustomer = Read(id);

            if (isCustomer == null)
            {
                return "Customer was removed";
            }
            else
            {
                _context.Customer.Remove(isCustomer);
                _context.SaveChanges();
                return "Customer has been removed";
                
            }
        }

        public Customer Read(long id)
        {
            var customer = _context.Customer.Where(c => c.Id == id).FirstOrDefault();
            return customer;
        }

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