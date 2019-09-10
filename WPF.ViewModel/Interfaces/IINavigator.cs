using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF.ViewModel.Interfaces
{
    public interface IINavigator
    {
        void StartUp();
        void OpenNotificationWindow(string notificationText);
    }
}
