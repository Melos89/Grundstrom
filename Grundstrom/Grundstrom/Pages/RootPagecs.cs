using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Grundstrom.Resources;
using Grundstrom.Pages.PersonalPages;

namespace Grundstrom.Pages
{
    public class RootPage : MasterDetailPage
    {
        NavigationPage navigator;
        public RootPage()
        {
            navigator = new NavigationPage(new OrderTelephonePage());
            var menuPage = new MenuPage();
            menuPage.Menu.ItemSelected += (sender, e) => NavigateTo(e.SelectedItem as Resources.MenuItem);
            Master = menuPage;
            Detail = navigator;
            MasterBehavior = MasterBehavior.Popover;
            //
            if (Device.OS == TargetPlatform.iOS)
            {
                IsPresented = false;
            }
            else
            {
                IsPresented = true;
            }
            IsPresented = true;
            menuPage.BackgroundColor = Color.Transparent;
        }

        void NavigateTo(Resources.MenuItem menu)
        {
            Page displayPage = (Page)Activator.CreateInstance(menu.TargetType);
            navigator.PushAsync(displayPage, true);
            IsPresented = false;
        }
    }
}
