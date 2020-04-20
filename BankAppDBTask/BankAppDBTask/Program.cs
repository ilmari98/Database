using System;
using System.Linq;
using BankAppDBTask.Data;
using BankAppDBTask.Models;
using BankAppDBTask.Repositories;

namespace BankAppDBTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice = null;
            CustomerView _personView = new CustomerView();
            BankRepository _bankRepository = new BankRepository();

            string msg = "";
            string startingMsg =  "Tietokannan käsittely esimerkki!" +
                                  "[1] Luettele kaikki asiakkaat" +
                                  "[2] Luettele valitun pankin asiakkaat" +
                                  "[3] Luettele kaikki pankit\n";
            do
            {
                Console.WriteLine(startingMsg);

                choice = Console.ReadLine();

                switch (choice.ToUpper())
                {
                    case "1":
                        _personView.ReadAllData();
                        msg = "\n----------------------------> \nPaina Enter jatkaaksesi!";
                        break;
                    case "2":
                        _personView.ReadBankCustomers();
                        msg = "\n----------------------------> \nPaina Enter jatkaaksesi!";
                        break;
                    case "3":
                        _personView.PrintAllBanks();
                        break;
                    default:
                        msg = "Nyt tuli huti yritä uudestaan - Paina Enter ja aloita alusta!";
                        break;
                }

                Console.WriteLine(msg);
                Console.ReadLine();
                Console.Clear();
            }
            while (choice.ToUpper() != "X");

        }
    }
}
