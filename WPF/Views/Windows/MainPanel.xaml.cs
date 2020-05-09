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
    /// Interaction logic for MainPanel.xaml
    /// </summary>
    public partial class MainPanel : Window
    {
        public MainPanel()
        {
            InitializeComponent();
            //Media.Source = new Uri(Environment.CurrentDirectory + @"\orcas.gif");
            //Loading();
            this.DataContext = new WPF.ViewModel.MainViewModel();
            //ApplicationThemeManager.GetInstance().ThemeChanged += Example_ThemeChanged;
        }

        //DispatcherTimer Timer = new DispatcherTimer();

        private void Example_ThemeChanged(object sender, System.EventArgs e)
        {
            this.Resources.MergedDictionaries.Clear();
            this.Resources.MergedDictionaries.Add(new ResourceDictionary() { Source = new Uri("/WPF;component/FirstLook/Resources.xaml", UriKind.RelativeOrAbsolute) });
        }

        //private void MediaElement_MediaEnded(object sender, RoutedEventArgs e)
        //{
        //    Media.Position = new TimeSpan(0, 0, 1);
        //    Media.Play();
        //}

        //private void Timer_Tick(object sender, EventArgs e)
        //{
        //    Timer.Stop();
        //    Media.Visibility = Visibility.Hidden;
        //    Lab.Visibility = Visibility.Hidden;
        //    Can.Visibility = Visibility.Visible;
        //}

        //void Loading()
        //{
        //    Timer.Tick += Timer_Tick;
        //    Timer.Interval = new TimeSpan(0,0,8);
        //    Timer.Start();
        //}
    }
}
