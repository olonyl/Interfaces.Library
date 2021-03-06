using ExplicitImplementation.Library;
using System;

namespace ExplicitImplementation.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            StandardCatalog standardCatalog = new StandardCatalog();
            ISaveable saveable = new StandardCatalog();
            IPersistable persistable = new StandardCatalog();

            Console.WriteLine("Standard Implementation\n");
            Console.WriteLine("Concreate Class: {0}", standardCatalog.Save());
            Console.WriteLine("ISaveable: {0}", saveable.Save());
            Console.WriteLine("IPersistable: {0}", persistable.Save());
            Console.WriteLine();

            Console.WriteLine("Concreate Class: {0}", standardCatalog.Save());
            Console.WriteLine("ISaveable: {0}", ((ISaveable)standardCatalog).Save());
            Console.WriteLine("IPersistable: {0}", ((IPersistable)standardCatalog).Save());
            Console.WriteLine();

            Console.WriteLine("==========================================================");

            ExplicitCatalog explicitCatalog = new ExplicitCatalog();
            saveable = new ExplicitCatalog();
            persistable = new ExplicitCatalog();
            Console.WriteLine("Explicit Implementation\n");
            Console.WriteLine("Concreate Class: {0}", explicitCatalog.Save());
            Console.WriteLine("ISaveable: {0}", saveable.Save());
            Console.WriteLine("IPersistable: {0}", persistable.Save());
            Console.WriteLine();

            Console.WriteLine("Concreate Class: {0}", explicitCatalog.Save());
            Console.WriteLine("(ISaveable) Catalog: {0}", ((ISaveable)explicitCatalog).Save());
            Console.WriteLine("(IPersistable) Catalog: {0}", ((IPersistable)explicitCatalog).Save());
            Console.WriteLine();

            Console.Read();
        }
    }

}
