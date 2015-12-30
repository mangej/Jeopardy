using JeopardyGame.Game;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace JeopardyGame
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private MainGame Game { get; set; }
        public MainPage()
        {
            this.InitializeComponent();
            Game = new MainGame();
            Game.Players = new ObservableCollection<Player>();
            lbTeams.ItemsSource = Game.Players;
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var name = teamName.Text;
            var player = new Player();
            player.Name = name;
            Game.Players.Add(player);
            teamName.Text = "";
        }

        private async void PickAFileButton_Click(object sender, RoutedEventArgs e)
        {
            // Clear previous returned file name, if it exists, between iterations of this scenario
   
            FileOpenPicker openPicker = new FileOpenPicker();
            openPicker.ViewMode = PickerViewMode.List;
            openPicker.SuggestedStartLocation = PickerLocationId.Desktop;
            openPicker.FileTypeFilter.Add(".json");
            StorageFile file = await openPicker.PickSingleFileAsync();
            if (file != null)
            {
                // Application now has read/write access to the picked file
                questionsName.Text = file.Name + " is loaded";
                var json = await FileIO.ReadTextAsync(file);
                Game.Categories = JsonConvert.DeserializeObject<ObservableCollection<CategoryModel>>(json);
                
            }
            else
            {
                questionsName.Text = "Operation cancelled.";
            }
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Categories), Game);

        }
    }
}
