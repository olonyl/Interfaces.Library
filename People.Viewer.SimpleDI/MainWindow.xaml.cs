using System.Windows;

namespace People.Viewer.SimpleDI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly MainViewModel _viewModel;

        public MainWindow()
        {
            InitializeComponent();
            _viewModel = new MainViewModel();
            this.DataContext = _viewModel;
        }

        private void DynamicReposositoryButton_Click(object sender, RoutedEventArgs e)
        {
            _viewModel.FetchData();
            ShowRepositoryType();

        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            _viewModel.ClearData();
        }

        private void ShowRepositoryType()
        {
            MessageBox.Show(string.Format("Repositry Type:\n{0}",
                _viewModel.RepositoryType));
        }
    }
}
