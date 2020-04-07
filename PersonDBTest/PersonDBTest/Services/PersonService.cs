using PersonDBTest.Models;
using PersonDBTest.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonDBTest.Services
{
    class PersonService:IPersonService
    {
        private readonly IPersonRepository _personRepository;
        public PersonService()
        {
            _personRepository = new PersonRepository();
        }

        public Person Create(Person newPerson)
        {
            var addedPerson = _personRepository.Create(newPerson);
            return addedPerson;
        }

        public string Delete(long id)
        {
            var isPerson = _personRepository.Read(id);
            if(isPerson != null)
            {
                _personRepository.Delete(isPerson);
                return $"Data successfully deleted: {isPerson.Id} {isPerson.FirstName}";
            }
            return "Henkilö on jo poistettu";
        }
        public List<Person> Read()
        {
            var person = _personRepository.Read();
            return person;
        }

        public Person Read(long id)
        {
            var person = _personRepository.Read(id);
            return person;

        }

        public List<Person> Read(string city)
        {
            var persons = _personRepository.Read(city);
            return persons;
        }

        public Person Update(long id, Person upPerson)
        {
            var getPerson = Read(id);

            if (getPerson == null)
            {
                Console.WriteLine("Henkilöä ei löydy - päivitys ei onnistu");
                return null;
            }

            var updatedPerson = _personRepository.Update(upPerson);
            return updatedPerson;
        }

        void IPersonService.Delete(long id)
        {
            var getPerson = Read(id);
            if (getPerson == null)
            {
                Console.WriteLine("Henkilöä on jo poistettu");

            }
            else
            {
                _personRepository.Delete(getPerson);
                Console.WriteLine($"henkilö {getPerson.FirstName} {getPerson.LastName} ID:{getPerson.Id} on poistettu");
            }
        }
    }
}
