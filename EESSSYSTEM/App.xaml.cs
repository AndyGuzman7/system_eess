using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace EESSSYSTEM
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            DependencyInjector.ConfigureContainer();

            // Resto del código de inicio de la aplicación...
        }

        private void Application_Startup(object sender, StartupEventArgs e)
        {

        }
    }
}
