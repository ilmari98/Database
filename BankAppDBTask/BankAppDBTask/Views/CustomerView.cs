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
            Console.WriteLine("\nName:\t\tBIC:\t\t\tID:\n");
            foreach (var b in banks)
            {            
                Console.WriteLine($"{b.Name}\t\t{b.Bic}\t\t{b.Id}");
            }
            Console.WriteLine();
        }

        private void PrintCustomerData(List<Customer> customers)
        {
            Console.WriteLine("\nName:\t\tLastname:\t\tBank:\t\tID:\n");
            foreach (var p in customers)
            {
                if (p.Lastname.Length > 8)
                {
                    Console.WriteLine($"{p.Firstname}\t\t{p.Lastname}\t\t{p.Bank.Name}\t\t{p.Id}");
                }
                else
                {
                    Console.WriteLine($"{p.Firstname}\t\t{p.Lastname}\t\t\t{p.Bank.Name}\t\t{p.Id}");
                }
            }
            Console.WriteLine();
        }

        public void CreateCustomer()
        {
            //Tässä olioon alustetaan arvot
            Customer newCustomer = new Customer();
            Console.Write("Syötä etunimi uudelle asiakkaalle: ");
            newCustomer.Firstname = Console.ReadLine();
            Console.Write("Syötä sukunimi uudelle asiakkaalle: ");
            newCustomer.Lastname = Console.ReadLine();
            Console.WriteLine("Lista olevista pankeista.");
            PrintAllBanks();
            Console.Write("Valitse uuden asiakkaan pankin ID: ");
            newCustomer.BankId = int.Parse(Console.ReadLine());
            // Tästä alkaa tietokantaan kysely
            string returnedValue = customerRepository.Create(newCustomer);
            Console.WriteLine(returnedValue);
        }

        public void DeleteCustomer()
        {
            ReadAllData();
            Console.Write("Mikä asiakas poistetaan [ID]: ");
            long id = long.Parse(Console.ReadLine());
            string returnedValue = customerRepository.Delete(id);
            Console.WriteLine(returnedValue);
        }
    }
}
