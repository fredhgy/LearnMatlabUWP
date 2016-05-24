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
        StorageFolder appFolder = ApplicationData.Current.LocalFolder;




        private async void toggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {

            StorageFolder webFolder = await localFolder.GetFolderAsync("web");
            IStorageFile namesave = await appFolder.CreateFileAsync("namesave", CreationCollisionOption.OpenIfExists);



            if (importSwitch.IsOn == true)
            {
                Windows.Storage.Pickers.FileOpenPicker openPicker = new Windows.Storage.Pickers.FileOpenPicker();
                //openPicker.SuggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.PicturesLibrary;
                //openPicker.ViewMode = Windows.Storage.Pickers.PickerViewMode.Thumbnail;

                openPicker.FileTypeFilter.Clear();
                openPicker.FileTypeFilter.Add(".html");
                StorageFile updatefile = await openPicker.PickSingleFileAsync();
                
                if (updatefile != null)
                {
                    string updatename = updatefile.Name;
                    Windows.Storage.Streams.IRandomAccessStream fileStream = await updatefile.OpenAsync(FileAccessMode.Read);
                    await updatefile.CopyAsync(webFolder, updatename, NameCollisionOption.ReplaceExisting);

                    //var buffer = Windows.Security.Cryptography.CryptographicBuffer.ConvertStringToBinary(
    //updatename , Windows.Security.Cryptography.BinaryStringEncoding.Utf8);
                    //await Windows.Storage.FileIO.WriteBufferAsync(namesave , buffer);

                    await FileIO.WriteTextAsync(namesave, updatename,0);
                    
                    text.Text = "已更新:" + updatename;
                    Uri Uri = new Uri("ms-appx-web:///web/"+updatename);
                    updateweb.Source = Uri;
                }
                else
                {
                    string updatename = "index.html";
                    await FileIO.WriteTextAsync(namesave, updatename, 0);
                }
            }
            else
            {
                IStorageFile name = await appFolder.GetFileAsync("namesave");
                string updatename = await FileIO.ReadTextAsync(name);
                //await localFolder.CreateFolderAsync("web", CreationCollisionOption.GenerateUniqueName);
                StorageFile restorefile = await StorageFile.GetFileFromApplicationUriAsync(new Uri("ms-appx:///originweb/"+updatename));
                //string restorename = restorefile.Name;
                await restorefile.CopyAsync(webFolder, updatename, NameCollisionOption.ReplaceExisting);
                Uri Uri = new Uri("ms-appx-web:///web/"+updatename);
                updateweb.Source = Uri;
                await namesave.DeleteAsync();
                text.Text = "已还原:" + updatename;
            }
        }
    }
}
