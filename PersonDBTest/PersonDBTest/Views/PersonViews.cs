using PersonDBTest.Models;
using PersonDBTest.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonDBTest.Views
{
    class PersonView:IPersonViews
    {
        private readonly IPersonService _personService;
        public PersonView()
        {
            _personService = new PersonService();
        }

        private void PrintAllData()
        {
            var persons = _personService.Read();
            foreach (var p in persons)
            {
                Console.WriteLine($"{p.FirstName} {p.LastName}");
            }   
        }
        public void ReadAllData()
        {
            var persons = _personService;
        }
        public void ReadByCity()
        {
            Console.WriteLine("Syötä kaupungin nimi:");
            string city = Console.ReadLine();
            var persons = _personService.Read(city);
            PrintPersonData(persons);
        }

        public void UpdatePerson()
        {
            Console.WriteLine("Kenentietoja muokataan? Syötä ID: ");
            var userInput = Console.ReadLine();
            long id = long.Parse(userInput);

            var person = _personService.Read(id);
            person.FirstName = "jaska";

            var updatedPerson = _personService.Update(id, person);
            PrintPersonData(updatedPerson);
        }

        public void DeletePerson()
        {
            Console.WriteLine("Kenen tiedot poistetaan? Syötä ID: ");
            var userInput = Console.ReadLine();
            long id = long.Parse(userInput);
            _personService.Delete(id);

        }

        private void PrintPersonData(List<Person> persons)
        {
            Console.WriteLine("ID/Sex/Kaupunki/Etunim/Sukunimi");
            foreach (var p in persons)
            {
                Console.WriteLine($"{p.Id}\t{p.Sex}\t{p.City}\t{p.FirstName}\t\t{p.LastName}");
            }
        }
        private void PrintPersonData(Person person)
        {
            Console.WriteLine("ID/Sex/Kaupunki/Etunim/Sukunimi");
            Console.WriteLine($"{person.Id}\t{person.Sex}\t{person.City}\t{person.FirstName}\t\t{person.LastName}");
        }
        public void CreatePerson()
        {
            Person newPerson = new Person();
            newPerson.FirstName = "";
            newPerson.LastName = "";
            newPerson.City = "";
            newPerson.ShoeSize = 0;
            newPerson.DateOfBirth = new DateTime(2020, 02, 15);

            var results = _personService.Create(newPerson);
            Console.WriteLine($"{results.FirstName} Lisätty onnistuneesti");
        }
    }
}

 
