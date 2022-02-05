using People.Repository.Itnerface;
using System;
using System.Configuration;

namespace DynamicRepository.WPFApplication
{
    public static class RepositoryFactory
    {
        public static IPersonRepository GetRepository()
        {
            string typeName = ConfigurationManager.AppSettings["RepositoryType"];
            Type repoType = Type.GetType(typeName);
            object repoInstance = Activator.CreateInstance(repoType);
            IPersonRepository repo = repoInstance as IPersonRepository;
            return repo;

        }
    }
    public enum RepositoryType
    {
        SQL,
        CSV,
        Service
    }
}
