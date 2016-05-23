using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
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
    public sealed partial class UpdateView : Page
    {

        

        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            StorageFolder localFolder = Windows.ApplicationModel.Package.Current.InstalledLocation;
            //StorageFolder RoamingFolder = ApplicationData.Current.RoamingFolder;
            //StorageFile fileWrite = await localFolder.CreateFileAsync(@"heguangyu\index.html", CreationCollisionOption.ReplaceExisting);
            //await FileIO.WriteTextAsync(fileWrite, "matlab.heguangyu.net/index");
            //StorageFile htmlFile = await StorageFile.GetFileFromPathAsync("");
            StorageFile htmlFile = await StorageFile.GetFileFromApplicationUriAsync(new Uri("ms-appx:///update/index.html"));
            await htmlFile.CopyAsync(localFolder, "index.html", NameCollisionOption.ReplaceExisting);

        }

        public UpdateView()
        {
            this.InitializeComponent();
        }

    }


}


