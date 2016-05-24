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
	public sealed partial class Ch3View : Page
    {
		public Ch3View()
        {
            this.InitializeComponent();
        }
		private void toggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            if (toggleSwitch.IsOn == true)
            {
                Uri ch3Uri = new Uri("http://matlab.heguangyu.net/ch3/ch3.html");
                ch3web.Source = ch3Uri;
            }
            else
            {
                Uri ch3Uri = new Uri("ms-appx-web:///web/ch3.html");
                ch3web.Source = ch3Uri;
            }
        }    
	}
}
