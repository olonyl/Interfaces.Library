using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using People.Repository.Itnerface;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
[ServiceContract]
public interface IService
{

	[OperationContract]
	List<Person> GetPeople();
	[OperationContract]
	Person GetPerson(string lastName);
	[OperationContract]
	void AddPerson(Person newPerson);
	[OperationContract]
	void UpdatePerson(string lastName, Person updatedPerson);
	[OperationContract]
	void DeletePerson(string lastName);
	[OperationContract]
	void UpdatePeople(IEnumerable<Person> updatePeople);
}

