using JeopardyGame.Game;
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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace JeopardyGame
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Categories : Page
    {
        private MainGame Game { get; set; }
        public Categories()
        {
            this.InitializeComponent();
        }

        

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            MainGame game = e.Parameter as MainGame;
            if (game == null)
            {
                return;                
            }

            Game = game;
            categories.ItemsSource = Game.Categories;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            if (sender == null)
            {
                return;
            }

            QuestionSet questionSet = button.CommandParameter as QuestionSet;
            
            if (questionSet == null)
            {
                return;
            }

            test.Visibility = Visibility.Visible;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            test.Visibility = Visibility.Collapsed;

        }
    }
}
