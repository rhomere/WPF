using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WPF.ViewModel.Interfaces;
using WPF.ViewModel.WPFCommon;
using WPF.Views.Windows;

namespace WPF.Utilities
{
    public class Navigator : IINavigator
    {
        private MainPanel MainPanel { get; set; }

        //public event EventHandler MainWindowClosing;

        public void StartUp()
        {
            //if (MainPanel == null)
            //{
            //    MainPanel = new MainPanel();
            //    MainPanel.Closing += MainWindowOnClosing;
            //    Application.Current.MainWindow = MainPanel;
            //    Application.Current.MainWindow.LocationChanged += LocationChanged;
            //    Application.Current.MainWindow.SizeChanged += LocationChanged;
            //}

            //MainPanel.Show();
            var loadingScreen = new LoadingScreen();
            loadingScreen.Show();
        }

        public void LocationChanged(object sender, EventArgs e)
        {

        }

        public void OpenNotificationWindow(string notificationText)
        {
            var notification = new Views.Windows.Notification { Topmost = true };
            notification.DataContext = new ViewModel.WPFCommon.Notification(notificationText, notification.Close);

            notification.ShowDialog();
        }

        //private void MainWindowOnClosing(object sender, CancelEventArgs cancelEventArgs)
        //{
        //    MainWindowClosing?.Invoke(sender, cancelEventArgs);
        //    MainWindowClosing = null;
        //}
    }
}
