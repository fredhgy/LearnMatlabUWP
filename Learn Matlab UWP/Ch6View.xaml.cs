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
    public sealed partial class Ch6View : Page
    {
        public Ch6View()
        {
            this.InitializeComponent();
        }
        private void toggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            if (toggleSwitch.IsOn == true)
            {
                Uri ch6Uri = new Uri("http://matlab.heguangyu.net/ch6/ch6.html");
                ch6web.Source = ch6Uri;
            }
            else
            {
                Uri ch6Uri = new Uri("ms-appx-web:///web/ch6.html");
                ch6web.Source = ch6Uri;
            }
        }
    }
}