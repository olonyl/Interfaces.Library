using System;
using System.Runtime.Serialization;

namespace People.Repository.Itnerface
{
    [DataContract]
    public class Person
    {
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public DateTime StartDate { get; set; }
        [DataMember]
        public int Rating { get; set; }

    }
}
