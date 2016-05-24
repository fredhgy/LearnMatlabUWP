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
	public sealed partial class Ch2View : Page
    {
		public Ch2View()
        {
            this.InitializeComponent();
        }
		Uri ch2Uri = new Uri("ms-appx-web:///web/ch2.html");
        //Uri myUri = new Uri(baseUri, "catalog/shownew.htm");
        ch2web.Source = ch2Uri;
        private void toggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            if (toggleSwitch.IsOn == true)
            {
                Uri ch2Uri = new Uri("http://matlab.heguangyu.net");
                ch2web.Source = ch2Uri;
            }
            else
            {
                Uri ch2Uri = new Uri("ms-appx-web:///web/ch2.html");
                ch2web.Source = ch2Uri;
            }
        }    
	}
}
