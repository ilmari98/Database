using PersonDBTest.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonDBTest.Services
{
    interface IPersonService
    {
        Person Create(Person newperson);
        List<Person> Read();
        Person Read(long id);
        List<Person> Read(string city);
        Person Update(long id,Person upPerson);
        void Delete(long id);
    }
}
