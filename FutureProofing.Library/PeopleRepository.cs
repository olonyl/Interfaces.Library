using System;
using System.Collections.Generic;

namespace FutureProofing.Library
{
    public class PeopleRepository
    {
        public List<Person> GetPeople()
        {
            var people = new List<Person>
            {
               new Person {FirstName="Olonyl",LastName="Landeros",StartDate = DateTime.Parse("06/11/1987"),Rating=28},
               new Person {FirstName="Jose",LastName="Horacio",StartDate = DateTime.Parse("06/05/1967"),Rating=28},
               new Person {FirstName="Dante",LastName="Jordan",StartDate = DateTime.Parse("12/12/1960"),Rating=28}
            };
            return people;
        }

        public Person GetPerson(string lastName)
        {
            return null;
        }

        public void AddPerson(Person newPerson)
        {

        }

        public void UpdatePerson(string lastName, Person updatedPerson)
        {

        }

        public void DeletePerson(string lastName)
        {

        }

        public void UpdatePeople(List<Person> updatePeople)
        {

        }
    }
}
