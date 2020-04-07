using PersonDBTest.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonDBTest.Repositories
{
    public interface IPersonRepository
    {
        Person Create(Person newPerson);
        List<Person> Read();
        Person Read(long id);
        //Person ReadPersonPhone(long id);
        List<Person> Read(string city);
        Person Update(Person updatePerson);
        void Delete(Person removePerson);
    }
}
