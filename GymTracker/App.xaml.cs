using System;
using System.IO;
using System.Windows;

namespace GymTracker
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "GymTracker");

            try
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);

                    Console.WriteLine("The directory was created successfully at {0}.", Directory.GetCreationTime(path));                    
                }

                AppDomain.CurrentDomain.SetData("DataDirectory", path);
            }
            catch (Exception exception)
            {
                Console.WriteLine("The process failed: {0}", exception);

                Shutdown(1);
            }
        }
    }
}