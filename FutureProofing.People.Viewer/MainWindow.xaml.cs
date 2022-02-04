using FutureProofing.Library;
using System.Collections;
using System.Collections.Generic;
using System.Windows;

namespace FutureProofing.People.Viewer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly PeopleRepository _repository;
        public MainWindow()
        {
            InitializeComponent();
            _repository = new PeopleRepository();
        }

        private void InterfaceFetchButton_Click(object sender, RoutedEventArgs e)
        {
            ClearListBox();
            IEnumerable people = _repository.GetPeople();
            PersonListBox.ItemsSource = people;
        }

        private void ConcreteFetchButton_Click(object sender, RoutedEventArgs e)
        {
            ClearListBox();
            List<Person> people = _repository.GetPeople();
            PersonListBox.ItemsSource = people;
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            ClearListBox();
        }

        private void ClearListBox()
        {
            PersonListBox.ItemsSource = null;
        }
    }
}
