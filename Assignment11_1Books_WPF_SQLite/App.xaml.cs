using Assignment11_1Books_WPF_SQLite.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using System.Data;
using System.Windows;

namespace Assignment11_1Books_WPF_SQLite
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private ServiceProvider _serviceProvider;
        public App()
        {
            ServiceCollection services = new ServiceCollection();

            services.AddDbContext<BookContext> ( option =>
            {
                option.UseSqlite("Data Source = Books_WPF_SQLite.db");
            });

            services.AddSingleton<MainWindow>();
            _serviceProvider = services.BuildServiceProvider ();
        }
        private void OnStartUp(object sender, StartupEventArgs e)
        {
            var mainWindow = _serviceProvider.GetService<MainWindow>();
            mainWindow.Show();
        }
    }

}
