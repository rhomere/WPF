using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF.ViewModel
{
    public class MainViewModel
    {
        public ObservableCollection<NavigationItemModel> Items { get; set; }

        public MainViewModel()
        {
            this.Items = new ObservableCollection<NavigationItemModel>();

            this.Items.Add(CreateItem("Order Activity", "&#xe13e;;", string.Empty, "Images/01.png", "Images/02.png", "Images/03.png"));
            this.Items.Add(CreateItem("Order Queue", "&#xe024;", string.Empty, "Images/04.png", "Images/05.png", "Images/06.png"));
            this.Items.Add(CreateItem("Orders Pending", "&#xe107;", string.Empty, "Images/07.png", "Images/08.png", "Images/09.png"));
            this.Items.Add(CreateItem("Orders Sent", "&#xe809;", string.Empty, "Images/10.png", "Images/11.png", "Images/12.png"));
            this.Items.Add(CreateItem("Pending Review", "&#xe651;", string.Empty, "Images/13.png", "Images/14.png", "Images/15.png"));
            this.Items.Add(CreateItem("Non Productive", "&#xe64e;", string.Empty, "Images/16.png", "Images/17png", "Images/18.png"));
            this.Items.Add(CreateItem("Reports", "&#xe124;", string.Empty, "Images/16.png", "Images/17png", "Images/18.png"));
            this.Items.Add(CreateItem("Admin", "&#xe801;", string.Empty, "Images/16.png", "Images/17png", "Images/18.png"));

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
