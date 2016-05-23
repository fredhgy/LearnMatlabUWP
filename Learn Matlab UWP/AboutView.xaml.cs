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

// “空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=234238 上有介绍

namespace Learn_Matlab_UWP
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class AboutView : Page
    {
        public AboutView()
        {
            this.InitializeComponent();
        }


        private void toggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            if (toggleSwitch.IsOn == true)
            {
                Uri aboutUri = new Uri("http://matlab.heguangyu.net");
                //Uri myUri = new Uri(baseUri, "catalog/shownew.htm");
                aboutweb.Source = aboutUri;
            }
            else
            {
                Uri aboutUri = new Uri("ms-appx-web:///about.html");
                //Uri myUri = new Uri(baseUri, "catalog/shownew.htm");
                aboutweb.Source = aboutUri;
            }


        }
        
    }
}
