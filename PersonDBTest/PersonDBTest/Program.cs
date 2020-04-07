using System;
using System.Linq;
using PersonDBTest.Data;
using PersonDBTest.Views;

namespace PersonDBTest
{
    class Program
    {
        static readonly IPersonViews _personView;
        static private readonly PersonexampledbContext context = new PersonexampledbContext();


        static void Main(string[] args)
        {
            string choice = null;
            PersonView _personView = new PersonView();

            string msg = "";
            do
            {
                choice = UserInterface();

                switch (choice.ToUpper())
                {
                    case "C":

                        _personView.CreatePerson();
                        msg = "\n----------------------------> \nPaina Enter jatkaaksesi!";
                        break;
                    case "R":
                        _personView.ReadAllData();
                        msg = "\n----------------------------> \nPaina Enter jatkaaksesi!";
                        break;
                    case "U":
                        _personView.UpdatePerson();
                        msg = "\n---------------------------->! \nPaina Enter jatkaaksesi!";
                        break;
                    case "D":
                        _personView.DeletePerson();
                        msg = "\n---------------------------->! \nPaina Enter jatkaaksesi!";
                        break;
                    case "R1":
                        _personView.ReadByCity(); ;
                        msg = "\n----------------------------> \nPaina Enter jatkaaksesi!";
                        break;
                    case "X":
                        msg = "\nOhjelman suoritus päättyy!";
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
        static string UserInterface()
        {
            Console.WriteLine("Tietokannan käsittely esimerkki!");
            Console.WriteLine("[C] Lisää tietokantaan uusi tietue");
            Console.WriteLine("[R] Lue tietokannasta tietoja");
            Console.WriteLine("[U] Päivitä henkilön tiedot");
            Console.WriteLine("[D] Poista henkilö tietokannasta");
            Console.WriteLine("[R1] Hae tiedot kaupungeittain");
            Console.WriteLine("[X] Lopeta ohjelmansuoritus");
            Console.WriteLine();
            Console.Write("Valitse mitä tehdään: ");

            return Console.ReadLine();
        }


    }
}
