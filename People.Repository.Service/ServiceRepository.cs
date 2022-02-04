using People.Repository.Itnerface;
using People.Repository.Service.PeopleWCFService;
using System.Collections.Generic;
using System.Linq;

namespace People.Repository.Service
{
    public class ServiceRepository : IPersonRepository
    {
        private ServiceClient _service;

        public ServiceRepository()
        {
            _service = new ServiceClient();
        }
        public void AddPerson(Person newPerson)
        {
            _service.AddPerson(newPerson);
        }

        public void DeletePerson(string lastName)
        {
            _service.DeletePerson(lastName);
        }

        public IEnumerable<Person> GetPeople()
        {
            return _service.GetPeople();
        }

        public Person GetPerson(string lastName)
        {
            return _service.GetPerson(lastName);
        }

        public void UpdatePeople(IEnumerable<Person> updatePeople)
        {
            _service.UpdatePeople(updatePeople.ToList());
        }

        public void UpdatePerson(string lastName, Person updatedPerson)
        {
            _service.UpdatePerson(lastName, updatedPerson);
        }
    }
}
