using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WPF.ViewModel.Utilities;

namespace WPF.ViewModel
{
    public class MainViewModel
    {
        public bool _newFeatures { get; set; }
        public ObservableCollection<NavigationItemModel> Items { get; set; }
        public RelayCommand UserNameCommand { get; set; }
        public RelayCommand TestCommand { get; set; }

        public MainViewModel()
        {
            this.Items = new ObservableCollection<NavigationItemModel>();

            this.Items.Add(CreateItem("Page 1", "&#xe13e;;", "blah", "Images/01.png", "Images/02.png", "Images/03.png"));
            this.Items.Add(CreateItem("Page 2", "&#xe024;", string.Empty, "Images/04.png", "Images/05.png", "Images/06.png"));
            this.Items.Add(CreateItem("Page 3", "&#xe107;", string.Empty, "Images/07.png", "Images/08.png", "Images/09.png"));
            this.Items.Add(CreateItem("Page 4", "&#xe809;", string.Empty, "Images/10.png", "Images/11.png", "Images/12.png"));
            this.Items.Add(CreateItem("Page 5", "&#xe651;", string.Empty, "Images/13.png", "Images/14.png", "Images/15.png"));
            this.Items.Add(CreateItem("Page 6", "&#xe64e;", string.Empty, "Images/16.png", "Images/17png", "Images/18.png"));
            this.Items.Add(CreateItem("Page 7", "&#xe124;", string.Empty, "Images/16.png", "Images/17png", "Images/18.png"));
            this.Items.Add(CreateItem("Page 8", "&#xe700;", string.Empty, "Images/16.png", "Images/17png", "Images/18.png"));

            this.Items.Add(CreateItem(
                "Need To Know",
                "&#xe401;",

                "Discover our beautiful collection. Download up to 750 Images/Month! Speedy Search & Discovery. 4k Images added per hour. No daily\n download limit. Footage & music libraries. Types: Images, Photos, Vectors, Illustrations, Editorial, Icons. \n\n" +
                "Discover our beautiful collection. Download up to 750 Images/Month! Speedy Search & Discovery. 4k Images added per hour. No daily\n download limit. Footage & music libraries. Types: Images, Photos, Vectors, Illustrations, Editorial, Icons. \n\n" +
                "Discover our beautiful collection. Download up to 750 Images/Month! Speedy Search & Discovery. 4k Images added per hour. No daily\n download limit. Footage & music libraries. Types: Images, Photos, Vectors, Illustrations, Editorial, Icons. \n\n",

                "Images/06.png",
                "Images/02.png",
                "Images/08.png",
                "Images/09.png",
                "Images/05.png"));

            UserNameCommand = new RelayCommand(UserNameCmd);
            TestCommand = new RelayCommand(TestCmd);

            _newFeatures = true;

            if (_newFeatures)
            {
                Controller.Navigator.OpenNotificationWindow("What's New", 600, 500);
            }
        }

        private void UserNameCmd(object obj)
        {
            Controller.Navigator.OpenNotificationWindow("This is a test notification", 200, 400);
        }

        private void TestCmd(object obj)
        {
            Controller.Navigator.OpenNotificationWindow("Test Command", 400, 600);
        }

        private static NavigationItemModel CreateItem(string title, string iconGlyph, string text, params string[] imagePaths)
        {
            NavigationItemModel item = new NavigationItemModel();
            item.Title = title;
            item.Text = text;
            item.IconGlyph = iconGlyph;
            item.ImagePaths = imagePaths;

            return item;
        }
    }

    public class NavigationItemModel
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public string IconGlyph { get; set; }
        public IEnumerable<string> ImagePaths { get; set; }
    }
}
