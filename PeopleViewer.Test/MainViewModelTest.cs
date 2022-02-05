using DynamicRepository.WPFApplication;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace PeopleViewer.Test
{
    [TestClass]
    public class MainViewModelTest
    {
        [TestMethod]
        public void People_OnFetchData_IsPopulated()
        {
            var viewModel = new MainViewModel();

            viewModel.FetchData();

            Assert.IsNotNull(viewModel.People);
            Assert.AreEqual(2, viewModel.People.Count());
        }
        [TestMethod]
        public void RepositoryType_OnCreation_ReturnsFakeRepositoryString()
        {
            var viewModel = new MainViewModel();
            var expectedString = "PersonRepository.Fake.FakeRepository";

            Assert.AreEqual(expectedString, viewModel.RepositoryType);
        }
    }
}
