using People.Repository.Itnerface;
using System.Collections.Generic;
using System.Linq;

namespace People.Repository.SQL
{
    public class SQLRepository : IPersonRepository
    {
        public void AddPerson(Itnerface.Person newPerson)
        {
            throw new System.NotImplementedException();
        }

        public void DeletePerson(string lastName)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Itnerface.Person> GetPeople()
        {
            using (var ctx = new PeopleModelContainer())
            {
                var people = ctx.People.Select(
                    p =>
                    new Itnerface.Person
                    {
                        FirstName = p.FirstName,
                        LastName = p.LastName,
                        StartDate = p.StartDate,
                        Rating = p.Rating
                    });

                return people.ToList();
            }
        }

        public Itnerface.Person GetPerson(string lastName)
        {
            throw new System.NotImplementedException();
        }

        public void UpdatePeople(IEnumerable<Itnerface.Person> updatePeople)
        {
            throw new System.NotImplementedException();
        }

        public void UpdatePerson(string lastName, Itnerface.Person updatedPerson)
        {
            throw new System.NotImplementedException();
        }
    }
}
