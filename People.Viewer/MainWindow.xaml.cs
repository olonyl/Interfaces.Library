using People.Repository.Itnerface;
using System.Windows;

namespace People.Viewer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            ClearListBox();
        }

        private void ServiceRepositoryButton_Click(object sender, RoutedEventArgs e)
        {
            FetchData(RepositoryType.Service);

        }

        private void CSVRepositoryButton_Click(object sender, RoutedEventArgs e)
        {
            FetchData(RepositoryType.CSV);
        }

        private void SQLRepositoryButton_Click(object sender, RoutedEventArgs e)
        {
            FetchData(RepositoryType.SQL);
        }

        private void FetchData(RepositoryType type)
        {
            ClearListBox();
            IPersonRepository repository = RepositoryFactory.GetRepository(type);
            var people = repository.GetPeople();

            PersonListBox.ItemsSource = people;

            ShowRepositoryType(repository);
        }

        private void ClearListBox()
        {
            PersonListBox.ItemsSource = null;
        }


        private void ShowRepositoryType(IPersonRepository repository)
        {
            MessageBox.Show(string.Format("Repositry Type:\n{0}",
                repository.GetType().ToString()));
        }

    }
}
