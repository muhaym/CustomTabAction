using ElegantTabs.Abstraction;
using Rg.Plugins.Popup.Extensions;
using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CustomTabAction.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();
            Transforms.TabIconClicked += Transforms_TabIconClicked;
        }

        async private void Transforms_TabIconClicked(object sender, ElegentTabsEventArgs e)
        {
            if (e.selectedIndex == 1)
            {
                await Navigation.PushPopupAsync(new PopupPage());
            }

        }
    }
}