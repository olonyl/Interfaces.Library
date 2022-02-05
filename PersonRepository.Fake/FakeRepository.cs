using People.Repository.Itnerface;
using System;
using System.Collections.Generic;

namespace PersonRepository.Fake
{
    public class FakeRepository : IPersonRepository
    {
        public void AddPerson(Person newPerson)
        {
            throw new NotImplementedException();
        }

        public void DeletePerson(string lastName)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Person> GetPeople()
        {
            var people = new List<Person>
            {
                new Person{FirstName="Jhon", LastName="Smith",Rating=7, StartDate = DateTime.Parse("10/01/2000")},
                new Person{FirstName="Mary", LastName="Thomas",Rating=9, StartDate = DateTime.Parse("07/23/1971")}
            };
            return people;
        }

        public Person GetPerson(string lastName)
        {
            throw new NotImplementedException();
        }

        public void UpdatePeople(IEnumerable<Person> updatePeople)
        {
            throw new NotImplementedException();
        }

        public void UpdatePerson(string lastName, Person updatedPerson)
        {
            throw new NotImplementedException();
        }
    }
}
