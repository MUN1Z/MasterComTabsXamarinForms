using MasterComTabs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MasterComTabs.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterPage : ContentPage
    {
        public ListView ListView { get { return listView; } }
        public MasterPage()
        {
            InitializeComponent();

            var masterPageItem = new List<MasterPageItem>();
            masterPageItem.Add(new MasterPageItem
            {
                Title = "Home",
                IconSource = "home.png",
                TargetType = typeof(HomePage)
            });
            masterPageItem.Add(new MasterPageItem
            {
                Title = "Page 1",
                IconSource = "page1.png",
                TargetType = typeof(Page1)
            });
            masterPageItem.Add(new MasterPageItem
            {
                Title = "Page 2",
                IconSource = "page2.png",
                TargetType = typeof(Page2)
            });
            masterPageItem.Add(new MasterPageItem
            {
                Title = "Page 3",
                IconSource = "page3.png",
                TargetType = typeof(Page3)
            });

            listView.ItemsSource = masterPageItem;
        }
    }
}
