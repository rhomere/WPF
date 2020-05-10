using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPF.ViewModel.Utilities;

namespace WPF.ViewModel.WPFCommon
{
    public class Notification
    {
        public Notification(string text, Action closeAction, int height, int width)
        {
            NotificationText = text;
            CloseNotificationCommand = new RelayCommand(closeAction);
            Height = height;
            Width = width;
        }

        public string NotificationText { get; set; }
        public ICommand CloseNotificationCommand { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
    }
}
