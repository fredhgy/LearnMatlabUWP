using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.Storage.AccessCache;
using Windows.Storage.Pickers;
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
    public sealed partial class ImportView : Page
    {
        public ImportView()
        {
            this.InitializeComponent();
        }
        StorageFolder localFolder = Windows.ApplicationModel.Package.Current.InstalledLocation;

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
           
            Windows.Storage.Pickers.FileOpenPicker openPicker = new Windows.Storage.Pickers.FileOpenPicker();
            openPicker.SuggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.PicturesLibrary;
            openPicker.ViewMode = Windows.Storage.Pickers.PickerViewMode.Thumbnail;

            StorageFolder webFolder = await localFolder.GetFolderAsync("web");
            // Filter to include a sample subset of file types.
            openPicker.FileTypeFilter.Clear();
            openPicker.FileTypeFilter.Add(".html");
            //openPicker.FileTypeFilter.Add(".png");
            //openPicker.FileTypeFilter.Add(".jpeg");
            //openPicker.FileTypeFilter.Add(".jpg");

            // Open the file picker.
            StorageFile updatefile = await openPicker.PickSingleFileAsync();
            string updatename = updatefile.Name;
            // file is null if user cancels the file picker.
            if (updatefile != null)
            {
                // Open a stream for the selected file.
                Windows.Storage.Streams.IRandomAccessStream fileStream = await updatefile.OpenAsync(FileAccessMode.Read);
                await updatefile.CopyAsync(webFolder, updatename, NameCollisionOption.ReplaceExisting);
                text.Text = "已更新";
                Uri ch1Uri = new Uri("ms-appx-web:///web/index.html");
                updateweb.Source = ch1Uri;
            }



        }

        private async void button1_Click(object sender, RoutedEventArgs e)
        {


            await localFolder.CreateFolderAsync("web", CreationCollisionOption.GenerateUniqueName);
            StorageFolder webFolder = await localFolder.GetFolderAsync("web");
            StorageFile restorefile = await StorageFile.GetFileFromApplicationUriAsync(new Uri("ms-appx:///originweb/index.html"));
            string restorename = restorefile.Name;
            await restorefile.CopyAsync(webFolder, restorename, NameCollisionOption.ReplaceExisting);
            Uri ch1Uri = new Uri("ms-appx-web:///web/index.html");
            updateweb.Source = ch1Uri;

        }
    }
}
