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
    public sealed partial class Ch7View : Page
    {
        public Ch7View()
        {
            this.InitializeComponent();
        }
        private void toggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            if (toggleSwitch.IsOn == true)
            {
                Uri ch7Uri = new Uri("http://matlab.heguangyu.net/ch7/ch7.html");
                ch7web.Source = ch7Uri;
            }
            else
            {
                Uri ch7Uri = new Uri("ms-appx-web:///web/ch7.html");
                ch7web.Source = ch7Uri;
            }
        }
    }
}