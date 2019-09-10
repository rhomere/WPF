using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF.ViewModel.Interfaces;

namespace WPF.ViewModel.Utilities
{
    public static class Controller
    {
        public static IINavigator Navigator { get; set; }

        public static void StartUp()
        {
            Navigator.StartUp();


        }
    }
}
