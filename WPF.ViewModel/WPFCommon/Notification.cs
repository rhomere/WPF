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
        public Notification(string text, Action closeAction)
        {
            NotificationText = text;
            CloseNotificationCommand = new RelayCommand(closeAction);
        }

        public string NotificationText { get; set; }
        public ICommand CloseNotificationCommand { get; set; }
    }
}
