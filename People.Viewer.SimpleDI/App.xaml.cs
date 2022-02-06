using People.Repository.Itnerface;
using PersonRepository.Fake;
using System.Windows;

namespace People.Viewer.SimpleDI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            FakeRepository repository = new FakeRepository();
            SimpleContainer.MapInstance<IPersonRepository>(repository);
        }
    }
}
