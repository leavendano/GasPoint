using Autofac;
using GasPoint.Core.Interfaces;


namespace GasPoint
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            ApplicationConfiguration.Initialize();
           

            var container = ContainerConfig.Configure();

            using (var scope = container.BeginLifetimeScope())
            {
                var formMain = scope.Resolve<FormMain>();

                Application.Run( formMain);
            }
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            
        }
    }
}