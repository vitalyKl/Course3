using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Course3
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static IServiceProvider _services;
        public static IServiceProvider Services => _services ??= GetServices().BuildServiceProvider();

        private static IServiceCollection GetServices()
        {
            var services = new ServiceCollection();
            InitializeService(services);
            return services;
        }

        private static void InitializeService(IServiceCollection services)
        {
            services.AddTransient<IDialogService, WindowDialog>();
        }
        
    }

    interface IDialogService
    {
        void ShowInfo(string msg);
    }

    class WindowDialog : IDialogService
    {
        public void ShowInfo(string msg) => MessageBox.Show(msg);
    }
}
