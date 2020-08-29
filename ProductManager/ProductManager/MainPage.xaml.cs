using ProductManager.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ProductManager
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private List<Img> Imgs;
        
        private ObservableCollection<Info> Infor;
        public MainPage()
        {
            this.InitializeComponent();

            Imgs = new List<Img>();
            Imgs.Add(new Img { ImgPath = "Assets/rau.png" });
            Imgs.Add(new Img { ImgPath = "Assets/bun.png" });
            Imgs.Add(new Img { ImgPath = "Assets/tomato.png" });
            Imgs.Add(new Img { ImgPath = "Assets/garlic.png" });
            Imgs.Add(new Img { ImgPath = "Assets/suplo.png" });
            Imgs.Add(new Img { ImgPath = "Assets/carrot.png" });

            Infor = new ObservableCollection<Info>();
        }

        private void NewInfoButton_Click(object sender, RoutedEventArgs e)
        {
            string img = ((Img)ImageComboBox.SelectedValue).ImgPath;
            Infor.Add(new Info { Product = ProductTextBox.Text, Description = DescriptionTextBox.Text, ImagePath = img });

            ProductTextBox.Text = "";
            DescriptionTextBox.Text = "";
            ImageComboBox.SelectedIndex = -1;

            ProductTextBox.Focus(FocusState.Programmatic);
        }
    }
}
