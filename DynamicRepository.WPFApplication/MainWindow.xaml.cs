using People.Repository.Itnerface;
using System.Windows;

namespace DynamicRepository.WPFApplication
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

        }

        private void DynamicReposositoryButton_Click(object sender, RoutedEventArgs e)
        {
            ClearListBox();
            IPersonRepository repository = RepositoryFactory.GetRepository();
            var peopple = repository.GetPeople();
            PersonListBox.ItemsSource = peopple;
            ShowRepositoryType(repository);

        }

        private void ClearListBox()
        {
            this.PersonListBox.ItemsSource = null;
        }


        private void ShowRepositoryType(IPersonRepository repository)
        {
            MessageBox.Show(string.Format("Repositry Type:\n{0}",
                repository.GetType().ToString()));
        }
    }
}
