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


    }
}