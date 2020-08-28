using ASMNews.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.DataTransfer;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ASMNews
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        private ObservableCollection<News> News;

        private List<String> Suggestions;

        private List<MenuItem> MenuItems;
        public MainPage()
        {
            this.InitializeComponent();
            this.InitializeComponent();
            News = new ObservableCollection<News>();
            NewsManager.GetAllNews(News);
            MenuItems = new List<MenuItem>();
            MenuItems.Add(new MenuItem { IConFile = "Assets/Icons/basketball.png", Category = NewsCategory.Sports });
            MenuItems.Add(new MenuItem { IConFile = "Assets/Icons/bank.png", Category = NewsCategory.International });
            MenuItems.Add(new MenuItem { IConFile = "Assets/Icons/tv.png", Category = NewsCategory.Entertainment });
            MenuItems.Add(new MenuItem { IConFile = "Assets/Icons/school.png", Category = NewsCategory.Education });
            MenuItems.Add(new MenuItem { IConFile = "Assets/Icons/car.png", Category = NewsCategory.Car });
            MenuItems.Add(new MenuItem { IConFile = "Assets/Icons/food.png", Category = NewsCategory.Food });
            BackButton.Visibility = Visibility.Collapsed;
        }

        private void NewsButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            NewsManager.GetAllNews(News);
            CategoryTextBlock.Text = "All News";
            MenuItemsListView.SelectedItem = null;
            BackButton.Visibility = Visibility.Collapsed;
        }

        private void SearchAutoSuggestBox_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            NewsManager.GetAllNews(News);
            Suggestions = News.Where(p => p.Name.StartsWith(sender.Text)).Select(p => p.Name).ToList();
            SearchAutoSuggestBox.ItemsSource = Suggestions;
        }

        private void SearchAutoSuggestBox_QuerySubmitted(AutoSuggestBox sender, AutoSuggestBoxQuerySubmittedEventArgs args)
        {

        }

        private void MenuItemsListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var menuItem = (MenuItem)e.ClickedItem;

            //Filter on category
            CategoryTextBlock.Text = menuItem.Category.ToString();
            NewsManager.GetNewsByCategory(News, menuItem.Category);
            BackButton.Visibility = Visibility.Visible;
        }

        private async void NewsGridView_Drop(object sender, DragEventArgs e)
        {
            if (e.DataView.Contains(StandardDataFormats.StorageItems))
            {
                var items = await e.DataView.GetStorageItemsAsync();

                if (items.Any())
                {
                    var storageFile = items[0] as StorageFile;
                    var contentType = storageFile.ContentType;

                    StorageFolder folder = ApplicationData.Current.LocalFolder;

                    if (contentType == "audio/wav" || contentType == "audio/mpeg")
                    {
                        StorageFile newFile = await storageFile.CopyAsync(folder,
                            storageFile.Name, NameCollisionOption.GenerateUniqueName);
                        MyMediaElement.SetSource(await storageFile.OpenAsync(FileAccessMode.Read),
                            contentType);
                        MyMediaElement.Play();
                    }
                }
            }
        }

        private void NewsGridView_DragOver(object sender, DragEventArgs e)
        {
            e.AcceptedOperation = DataPackageOperation.Copy;

            e.DragUIOverride.Caption = "drop to create a custom sound and title";
            e.DragUIOverride.IsCaptionVisible = true;
            e.DragUIOverride.IsContentVisible = true;
            e.DragUIOverride.IsGlyphVisible = true;
        }

        private void NewsGridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var news = (News)e.ClickedItem;
        }
    }
}
