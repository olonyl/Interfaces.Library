using People.Repository.Itnerface;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DynamicRepository.WPFApplication
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private readonly IPersonRepository _repository;

        private IEnumerable<Person> people;
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

        public MainViewModel()
        {
            _repository = RepositoryFactory.GetRepository();
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
