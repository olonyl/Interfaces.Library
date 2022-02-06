using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using People.Repository.Itnerface;
using People.Viewer.SimpleDI;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PeopleViewer.Tests
{
    [TestClass]
    public class MockVMTests
    {
        [TestInitialize]
        public void Setup()
        {
            var people = new List<Person>
            {
                new Person{FirstName="Jhon", LastName="Smith",Rating=7, StartDate = DateTime.Parse("10/01/2000")},
                new Person{FirstName="Mary", LastName="Thomas",Rating=9, StartDate = DateTime.Parse("07/23/1971")}
            };
            var mockRepository = new Mock<IPersonRepository>();
            mockRepository.Setup(r => r.GetPeople()).Returns(people);

            SimpleContainer.MapInstance<IPersonRepository>(mockRepository.Object);

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
        public void RepositoryType_WithMockOnCreation_returnsFakeRepositoryString()
        {
            var viewModel = new MainViewModel();
            var expectedString = "PersonRepository.Fake.FakeRepository";

            Assert.AreNotEqual(expectedString, viewModel.RepositoryType);
        }
    }
}
