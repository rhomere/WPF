using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WPF.Utilities;
using WPF.ViewModel.Utilities;

namespace WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            Controller.Navigator = new Navigator();

            // Always returns false?
            if (CheckProcesses()) return;

            Controller.StartUp();

            ShutdownMode = ShutdownMode.OnMainWindowClose;


        }

        private static bool CheckProcesses()
        {
            var currentProcess = Process.GetCurrentProcess();

            var processes = Process.GetProcesses()
                .Where(p => p.ProcessName == currentProcess.ProcessName && p.Id != currentProcess.Id).ToList();

            if (processes.Count > 0)
            {
                Controller.Navigator.OpenNotificationWindow("One instance of Solstice is already running.", 200, 500);
                return false;
            }
            return false;
        }
    }
}
