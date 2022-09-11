using Microsoft.Extensions.DependencyInjection;
using RSA_Sign_App.Class;
using RSA_Sign_App.Interface;

namespace RSA_Sign_App
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var services = new ServiceCollection();
            ConfigurationServices(services);
            using (ServiceProvider provider = services.BuildServiceProvider())
            {
                var form1 = provider.GetRequiredService<Form1>();
                Application.Run(form1);
            }
        }
        private static void ConfigurationServices(ServiceCollection Service)
        {
            Service.AddSingleton<Form1>();
            Service.AddTransient<IEncryption, Encryption>();
            Service.AddTransient<IFileHandler, FileHandler>();
      
        }


    }
}