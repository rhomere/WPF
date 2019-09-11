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

            this.Items.Add(CreateItem("Discover", "&#xe501;", string.Empty, "Images/01.png", "Images/02.png", "Images/03.png"));
            this.Items.Add(CreateItem("I was there", "&#xe13d;", string.Empty, "Images/04.png", "Images/05.png", "Images/06.png"));
            this.Items.Add(CreateItem("Explore", "&#xe500;", string.Empty, "Images/07.png", "Images/08.png", "Images/09.png"));
            this.Items.Add(CreateItem("Favorite Photos", "&#xe303;", string.Empty, "Images/10.png", "Images/11.png", "Images/12.png"));

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
