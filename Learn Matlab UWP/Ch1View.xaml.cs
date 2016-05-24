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
	public sealed partial class Ch1View : Page
    {
		public Ch1View()
        {
            this.InitializeComponent();
        }
		Uri ch1Uri = new Uri("ms-appx-web:///web/ch1.html");
        //Uri myUri = new Uri(baseUri, "catalog/shownew.htm");
        ch1web.Source = ch1Uri;
        private void toggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            if (toggleSwitch.IsOn == true)
            {
                Uri ch1Uri = new Uri("http://matlab.heguangyu.net");
                indexweb.Source = ch1Uri;
            }
            else
            {
                Uri ch1Uri = new Uri("ms-appx-web:///web/ch1.html");
                indexweb.Source = ch1Uri;
            }
        }    
	}
}