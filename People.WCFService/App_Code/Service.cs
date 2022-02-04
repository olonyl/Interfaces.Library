using People.Repository.Itnerface;
using System;
using System.Collections.Generic;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
    public void AddPerson(Person newPerson)
    {
        throw new NotImplementedException();
    }

    public void DeletePerson(string lastName)
    {
        throw new NotImplementedException();
    }

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
