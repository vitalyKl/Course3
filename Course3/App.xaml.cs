using Course3.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
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

        private static IHost __Hosting;

        public static IServiceProvider Services => Hosting.Services;

        public static IHost Hosting
        {
            get 
            {
                if (__Hosting != null) return __Hosting;
                var host_builder = Host.CreateDefaultBuilder(Environment.GetCommandLineArgs());
                host_builder.ConfigureServices(ConfigureServices);
                return __Hosting = host_builder.Build();
            }
        }

        private static void ConfigureServices(HostBuilderContext host, IServiceCollection services)
        {
            services.AddSingleton<SendWindowViewModel>();
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
