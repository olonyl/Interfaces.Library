using People.Repository.Itnerface;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace People.Viewer.SimpleDI
{
    public class MainViewModel
    {
        private readonly IPersonRepository _repository;

        private IEnumerable<Person> people;

        public MainViewModel()
        {
            _repository = SimpleContainer.Get<IPersonRepository>();
        }

        public IEnumerable<Person> People
        {
            get => people; private set
            {
                people = value;
                OnPropertyChanged();
            }
        }

        public string RepositoryType
        {
            get { return _repository.GetType().ToString(); }
        }

        public void FetchData()
        {
            People = _repository.GetPeople();
        }

        public void ClearData()
        {
            People = new List<Person>();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        // Create the OnPropertyChanged method to raise the event
        // The calling member's name will be used as the parameter.
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
