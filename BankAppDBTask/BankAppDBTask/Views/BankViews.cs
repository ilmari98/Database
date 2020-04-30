using BankAppDBTask.Repositories;
using BankAppDBTask.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankAppDBTask.Models
{
    class BankViews : IBankViews
    {
        private readonly IBankRepository bankRepository = new BankRepository();
        public void CreateBank()
        {
            //Tässä olioon alustetaan arvot
            Bank newBank = new Bank();
            Console.Write("Syötä pankin nimi: ");
            newBank.Name = Console.ReadLine();
            Console.Write("Syötä pankin Bic: ");
            newBank.Bic = Console.ReadLine();
            // Tästä alkaa tietokantaan kysely
            string returnedValue = bankRepository.Create(newBank);
            Console.WriteLine(returnedValue);
        }
    }
}
