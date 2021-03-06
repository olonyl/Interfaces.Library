//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace People.Repository.Service.PeopleWCFService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PeopleWCFService.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetPeople", ReplyAction="http://tempuri.org/IService/GetPeopleResponse")]
        System.Collections.Generic.List<People.Repository.Itnerface.Person> GetPeople();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetPeople", ReplyAction="http://tempuri.org/IService/GetPeopleResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<People.Repository.Itnerface.Person>> GetPeopleAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetPerson", ReplyAction="http://tempuri.org/IService/GetPersonResponse")]
        People.Repository.Itnerface.Person GetPerson(string lastName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetPerson", ReplyAction="http://tempuri.org/IService/GetPersonResponse")]
        System.Threading.Tasks.Task<People.Repository.Itnerface.Person> GetPersonAsync(string lastName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/AddPerson", ReplyAction="http://tempuri.org/IService/AddPersonResponse")]
        void AddPerson(People.Repository.Itnerface.Person newPerson);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/AddPerson", ReplyAction="http://tempuri.org/IService/AddPersonResponse")]
        System.Threading.Tasks.Task AddPersonAsync(People.Repository.Itnerface.Person newPerson);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/UpdatePerson", ReplyAction="http://tempuri.org/IService/UpdatePersonResponse")]
        void UpdatePerson(string lastName, People.Repository.Itnerface.Person updatedPerson);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/UpdatePerson", ReplyAction="http://tempuri.org/IService/UpdatePersonResponse")]
        System.Threading.Tasks.Task UpdatePersonAsync(string lastName, People.Repository.Itnerface.Person updatedPerson);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/DeletePerson", ReplyAction="http://tempuri.org/IService/DeletePersonResponse")]
        void DeletePerson(string lastName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/DeletePerson", ReplyAction="http://tempuri.org/IService/DeletePersonResponse")]
        System.Threading.Tasks.Task DeletePersonAsync(string lastName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/UpdatePeople", ReplyAction="http://tempuri.org/IService/UpdatePeopleResponse")]
        void UpdatePeople([System.ServiceModel.MessageParameterAttribute(Name="updatePeople")] System.Collections.Generic.List<People.Repository.Itnerface.Person> updatePeople1);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/UpdatePeople", ReplyAction="http://tempuri.org/IService/UpdatePeopleResponse")]
        System.Threading.Tasks.Task UpdatePeopleAsync(System.Collections.Generic.List<People.Repository.Itnerface.Person> updatePeople);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : People.Repository.Service.PeopleWCFService.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<People.Repository.Service.PeopleWCFService.IService>, People.Repository.Service.PeopleWCFService.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<People.Repository.Itnerface.Person> GetPeople() {
            return base.Channel.GetPeople();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<People.Repository.Itnerface.Person>> GetPeopleAsync() {
            return base.Channel.GetPeopleAsync();
        }
        
        public People.Repository.Itnerface.Person GetPerson(string lastName) {
            return base.Channel.GetPerson(lastName);
        }
        
        public System.Threading.Tasks.Task<People.Repository.Itnerface.Person> GetPersonAsync(string lastName) {
            return base.Channel.GetPersonAsync(lastName);
        }
        
        public void AddPerson(People.Repository.Itnerface.Person newPerson) {
            base.Channel.AddPerson(newPerson);
        }
        
        public System.Threading.Tasks.Task AddPersonAsync(People.Repository.Itnerface.Person newPerson) {
            return base.Channel.AddPersonAsync(newPerson);
        }
        
        public void UpdatePerson(string lastName, People.Repository.Itnerface.Person updatedPerson) {
            base.Channel.UpdatePerson(lastName, updatedPerson);
        }
        
        public System.Threading.Tasks.Task UpdatePersonAsync(string lastName, People.Repository.Itnerface.Person updatedPerson) {
            return base.Channel.UpdatePersonAsync(lastName, updatedPerson);
        }
        
        public void DeletePerson(string lastName) {
            base.Channel.DeletePerson(lastName);
        }
        
        public System.Threading.Tasks.Task DeletePersonAsync(string lastName) {
            return base.Channel.DeletePersonAsync(lastName);
        }
        
        public void UpdatePeople(System.Collections.Generic.List<People.Repository.Itnerface.Person> updatePeople1) {
            base.Channel.UpdatePeople(updatePeople1);
        }
        
        public System.Threading.Tasks.Task UpdatePeopleAsync(System.Collections.Generic.List<People.Repository.Itnerface.Person> updatePeople) {
            return base.Channel.UpdatePeopleAsync(updatePeople);
        }
    }
}
