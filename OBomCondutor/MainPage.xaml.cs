using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace OBomCondutor
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        public MainPage()
        {
            this.InitializeComponent();
            HideStatusBar();
        }

        private async void HideStatusBar()
        {
            // turn on SystemTray for mobile
            // don't forget to add a Reference to Windows Mobile Extensions For The UWP
            if (Windows.Foundation.Metadata.ApiInformation.IsTypePresent("Windows.UI.ViewManagement.StatusBar"))
            {
                var statusbar = Windows.UI.ViewManagement.StatusBar.GetForCurrentView();
                await statusbar.HideAsync();
                //statusbar.BackgroundColor = Windows.UI.Colors.Transparent;
                //statusbar.BackgroundOpacity = 1;
                //statusbar.ForegroundColor = Windows.UI.Colors.Red;
            }
        }

        private async void ShowStatusBar()
        {
            // turn on SystemTray for mobile
            // don't forget to add a Reference to Windows Mobile Extensions For The UWP
            if (Windows.Foundation.Metadata.ApiInformation.IsTypePresent("Windows.UI.ViewManagement.StatusBar"))
            {
                var statusbar = Windows.UI.ViewManagement.StatusBar.GetForCurrentView();
                await statusbar.ShowAsync();
                //statusbar.BackgroundColor = Windows.UI.Colors.Transparent;
                //statusbar.BackgroundOpacity = 1;
                //statusbar.ForegroundColor = Windows.UI.Colors.Red;
            }
        }

        private void ShowPanel_Click(object sender, RoutedEventArgs e)
        {
            MainMenu.IsPaneOpen = !MainMenu.IsPaneOpen;
        }

        private void Teste_Codigo_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Perfil_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Biblioteca_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Settings_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Help_Click (object sender, RoutedEventArgs e)
        {

        } 

        private void Feedback_Click (object sender, RoutedEventArgs e)
        {

        }

        private void Change_Theme(object sender, RoutedEventArgs e)
        {

        }

        private void CommandBar_Opened(object sender, object e)
        {
            CommandBar.IsOpen = !CommandBar.IsOpen;
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Enter_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
