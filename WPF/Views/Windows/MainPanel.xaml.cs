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
            this.DataContext = new WPF.ViewModel.MainViewModel();
        }

        private void Example_ThemeChanged(object sender, System.EventArgs e)
        {
            this.Resources.MergedDictionaries.Clear();
            this.Resources.MergedDictionaries.Add(new ResourceDictionary() { Source = new Uri("/WPF;component/FirstLook/Resources.xaml", UriKind.RelativeOrAbsolute) });
        }

        private void MainWindow_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (MainWindow.WindowState != WindowState.Maximized)
            {
                navigationView.Width = MainWindow.Width;
                navigationView.Height = MainWindow.Height - 39;
            }
            else
            {
                //if (SystemParameters.WorkArea.Left > 0)
                //{
                //    // TaskBar left
                //    return;
                //}
                //else if (SystemParameters.WorkArea.Top > 0)
                //{
                //    // TaskBar top
                //    return;
                //}
                //else if (SystemParameters.WorkArea.Left == 0 && SystemParameters.WorkArea.Width < SystemParameters.PrimaryScreenWidth)
                //{
                //    // Task bar right
                //    navigationView.Width = System.Windows.SystemParameters.PrimaryScreenWidth;
                //    navigationView.Height = System.Windows.SystemParameters.PrimaryScreenHeight - 20;
                //    return;
                //}

                // Task bar bottom
                navigationView.Width = System.Windows.SystemParameters.PrimaryScreenWidth;
                navigationView.Height = System.Windows.SystemParameters.PrimaryScreenHeight - 60;
            }
        }
    }
}
