using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Windows.Media.Animation;

namespace StartIt
{
    public partial class Draw : PhoneApplicationPage
    {
        public Draw()
        {
            InitializeComponent();
            this.CordovaView.Loaded += CordovaView_Loaded;
        }

        private void CordovaView_Loaded(object sender, RoutedEventArgs e)
        {
            this.CordovaView.Loaded -= CordovaView_Loaded;
            // first time load will have an animation
            Storyboard _storyBoard = new Storyboard();
            DoubleAnimation animation = new DoubleAnimation()
            {
                From = 0,
                Duration = TimeSpan.FromSeconds(0.6),
                To = 90
            };
            Storyboard.SetTarget(animation, SplashProjector);
            Storyboard.SetTargetProperty(animation, new PropertyPath("RotationY"));
            _storyBoard.Children.Add(animation);
            _storyBoard.Begin();
            _storyBoard.Completed += Splash_Completed;
        }

        void Splash_Completed(object sender, EventArgs e)
        {
            (sender as Storyboard).Completed -= Splash_Completed;
            LayoutRoot.Children.Remove(SplashImage);
        }
    }
}