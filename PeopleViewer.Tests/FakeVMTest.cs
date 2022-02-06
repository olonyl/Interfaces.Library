using Microsoft.VisualStudio.TestTools.UnitTesting;
using People.Repository.Itnerface;
using People.Viewer.SimpleDI;
using PersonRepository.Fake;
using System.Linq;

namespace PeopleViewer.Tests
{
    [TestClass]
    public class FakeVMTest
    {
        [TestInitialize]
        public void Setup()
        {
            FakeRepository repository = new FakeRepository();
            SimpleContainer.MapInstance<IPersonRepository>(repository);
        }

        [TestMethod]
        public void People_WithFakeOnFetchData_IsPopulated()
        {
            var viewModel = new MainViewModel();
            viewModel.FetchData();

            Assert.IsNotNull(viewModel.People);
            Assert.AreEqual(2, viewModel.People.Count());
        }

        [TestMethod]
        public void RepositoryType_WithFakeOnCreation_returnsFakeRepositoryString()
        {
            var viewModel = new MainViewModel();
            var expectedString = "PersonRepository.Fake.FakeRepository";

            Assert.AreEqual(expectedString, viewModel.RepositoryType);
        }
    }
}
