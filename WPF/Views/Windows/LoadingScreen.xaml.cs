using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace WPF.Views.Windows
{
    /// <summary>
    /// Interaction logic for LoadingScreen.xaml
    /// </summary>
    public partial class LoadingScreen : Window
    {
        public LoadingScreen()
        {
            InitializeComponent();
            Media.Source = new Uri(Environment.CurrentDirectory + @"\orcas.gif");
            Loading();
        }

        DispatcherTimer Timer = new DispatcherTimer();

        private void Media_MediaEnded(object sender, RoutedEventArgs e)
        {
            Media.Position = new TimeSpan(0, 0, 1);
            Media.Play();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Timer.Stop();
            Hide();
            MainPanel mainPanel = new MainPanel();
            mainPanel.ShowDialog();
            Close();
        }

        void Loading()
        {
            Timer.Tick += Timer_Tick;
            //Timer.Interval = new TimeSpan(0, 0, 8);
            Timer.Interval = new TimeSpan(0, 0, 2);
            Timer.Start();
        }
    }
}
