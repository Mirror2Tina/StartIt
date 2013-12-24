using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace StartIt
{
    public partial class ShowSample : PhoneApplicationPage
    {
        public ShowSample()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            if (e.IsNavigationInitiator == true)
            {
             var path=   NavigationContext.QueryString["path"];
             this.browser.Source = new Uri(path, UriKind.Relative);
            }
        }
    }
}