using System;
using System.Collections.Generic;
using System.Diagnostics;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace T1904EHelloUWP.Demo
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class FileHandle : Page
    {
        public FileHandle()
        {
            this.InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {






            StorageFolder currentTemporaryFolder = Windows.Storage.ApplicationData.Current.TemporaryFolder;
            StorageFile file = await currentTemporaryFolder.CreateFileAsync("hello.txt", CreationCollisionOption);
            await FileIO.WriteTextAsync(file, "Hello File");
            Debug.WriteLine("Write file success!");
        }
    }
}
