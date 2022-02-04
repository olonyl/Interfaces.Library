using People.Repository.Itnerface;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;

namespace People.Repository.CSV
{
    public class CSVRepository : IPersonRepository
    {
        private string _path;

        public CSVRepository()
        {
            var filename = ConfigurationManager.AppSettings["CSVFileName"];
            _path = AppDomain.CurrentDomain.BaseDirectory + filename;
        }
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
            var people = new List<Person>();
            if (File.Exists(_path))
            {
                var sr = new StreamReader(_path);
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    var elems = line.Split(',');
                    var per = new Person()
                    {
                        FirstName = elems[0],
                        LastName = elems[1],
                        StartDate = DateTime.Parse(elems[2]),
                        Rating = Int32.Parse(elems[3]),
                    };
                    people.Add(per);
                }
            }
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
