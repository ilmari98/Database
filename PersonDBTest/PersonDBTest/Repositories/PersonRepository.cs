using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using PersonDBTest.Data;
using PersonDBTest.Models;

namespace PersonDBTest.Repositories
{
    class PersonRepository : IPersonRepository
    {

        private readonly PersonexampledbContext _context;

        public PersonRepository()
        {
            _context = new PersonexampledbContext();
        }

        public Person Create(Person newPerson)
        {
            try
            {
                _context.Person.Add(newPerson);
                _context.SaveChanges();
                return newPerson;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                return null;
            }
        }
        public List<Person> Read()
        {
            var persons = _context.Person.ToList();
            return persons;
        }

        public Person Read(long id)
        {
            var persons = _context
                .Person
                .FirstOrDefault(p => p.Id == id);
            return persons;
        }

        public List<Person> Read(string city)
        {
            var persons = _context
                .Person.
                Where(p => p.City==city)
                .ToList();
            return persons;             
        }

        public Person Update(Person updatePerson)
        {
            _context.Person.Update(updatePerson);
            _context.SaveChanges();
            return updatePerson;
        }

        //List<Person> IPersonRepository.Read(string city)
        //{
        //    throw new NotImplementedException();
        //}
        public void Delete(Person removePerson)
        {
            _context.Person.Remove(removePerson);
            _context.SaveChanges();
        }
    }
}
