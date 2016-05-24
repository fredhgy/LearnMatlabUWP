using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace Learn_Matlab_UWP
{
    public sealed partial class Ch4View : Page
    {
        public Ch4View()
        {
            this.InitializeComponent();
        }
        private void toggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            if (toggleSwitch.IsOn == true)
            {
                Uri ch4Uri = new Uri("http://matlab.heguangyu.net/ch4/ch4.html");
                ch4web.Source = ch4Uri;
            }
            else
            {
                Uri ch4Uri = new Uri("ms-appx-web:///web/ch4.html");
                ch4web.Source = ch4Uri;
            }
        }
    }
}