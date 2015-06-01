using System.Windows;
using Autofac;
using Unicorn.Core.Server;
using Unicorn.ViewModel;

namespace Unicorn
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void App_OnStartup(object sender, StartupEventArgs e)
        {
            var builder = new ContainerBuilder();
            builder.RegisterInstance(new Server()).As<IServer>();
            builder.RegisterType<MainViewModel>();

            var container = builder.Build();
        }
    }
}
