using System;
using System.Linq;
using BankAppDBTask.Data;
using BankAppDBTask.Models;
using BankAppDBTask.Repositories;
using BankAppDBTask.Views;

namespace BankAppDBTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice = null;
            CustomerView _personView = new CustomerView();
            BankViews _bankView = new BankViews();
            TransactionView _transactionView = new TransactionView();

            string msg = "";
            string startingMsg = "Tietokannan käsittely esimerkki!\n" +
                                  "[1] Luettele kaikki asiakkaat.\n" +
                                  "[2] Luettele valitun pankin asiakkaat.\n" +
                                  "[3] Luettele kaikki pankit.\n" +
                                  "[4] Lue kaikki tilitapahtumat.\n" +
                                  "[5] Lisää uusi asiakas.\n" +
                                  "[6] Poista asiakas.\n" +
                                  "[7] Lisää uusi pankki.\n";
            do
            {
                Console.WriteLine(startingMsg);
                msg = "\n----------------------------> \nPaina Enter jatkaaksesi!";
                choice = Console.ReadLine();

                switch (choice.ToUpper())
                {
                    case "1":
                        _personView.ReadAllData();
                        break;
                    case "2":
                        _personView.ReadBankCustomers();
                        break;
                    case "3":
                        _personView.PrintAllBanks();
                        break;
                    case "4":
                        _transactionView.ReadTransactions();
                        break;
                    case "5":
                        _personView.CreateCustomer();
                        break;
                    case "6":
                        _personView.DeleteCustomer();
                        break;
                    case "7":
                        _bankView.CreateBank();
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
