using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WPF.ViewModel
{
    public class NavigationContentTemplateSelector : DataTemplateSelector
    {
        public DataTemplate Template { get; set; }
        public DataTemplate TemplateAlternative { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            if (item != null)
            {
                NavigationItemModel model = (NavigationItemModel)item;
                if (!string.IsNullOrEmpty(model.Text))
                {
                    return this.TemplateAlternative;
                }
            }

            return this.Template;
        }
    }
}
