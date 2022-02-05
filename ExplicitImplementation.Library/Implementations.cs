using System.Collections;
using System.Collections.Generic;

namespace ExplicitImplementation.Library
{
    public class StandardCatalog : ISaveable, IPersistable
    {
        public void Load()
        {

        }

        public string Save()
        {
            return "Catalog Save";
        }
    }

    public class ExplicitCatalog :
        ISaveable,
        IPersistable
    {
        string IPersistable.Save()
        {
            return "IPersistable Save";
        }
        string ISaveable.Save()
        {
            return "ISaveable Save";
        }
        public string Save()
        {
            return "Catalog Save";
        }
    }

    public class Catalog : ISaveable, IVoidSaveable
    {
        public string Save()
        {
            throw new System.NotImplementedException();
        }

        void IVoidSaveable.Save()
        {
            throw new System.NotImplementedException();
        }
    }

    public class EnumarableCatalog : IEnumerable<string>
    {
        public IEnumerator<string> GetEnumerator()
        {
            return null;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
