using BankAppDBTask.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankAppDBTask.Models
{
    class CustomerView:ICustomerView
    {
        private readonly ICustomerRepository customerRepository = new CustomerRepository();
        private readonly IBankRepository bankRepository = new BankRepository();

        public void ReadAllData()
        {
            var customers = customerRepository.Read();
            PrintCustomerData(customers);
        }

        public void ReadBankCustomers()
        {
            Console.Clear();
            PrintAllBanks();
            Console.Write(  "Minkä pankin asiakkaat haluat nähdä?: ");
            var userInput = Console.ReadLine();
            var customers = customerRepository.ReadBankCustomers(int.Parse(userInput));
            PrintCustomerData(customers);
        }

        public void PrintAllBanks()
        {
            var banks = bankRepository.Read();
            foreach (var b in banks)
            {
                Console.WriteLine($"\nNimi:\t\t{b.Name}\nPankin BIC:\t{b.Bic}");
            }
        }

        private void PrintCustomerData(List<Customer> customers)
        {
            foreach (var p in customers)
            {
                Console.WriteLine($"{p.Firstname}\t\t {p.Lastname}\t\t {p.Bank.Name}");
            }
        }
    }
}
