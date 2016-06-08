using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage;
using Windows.UI;
using Windows.UI.ViewManagement;
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
            changeBase();
            
            //if PC
            TitleBar();

            //if Smartphone
            StatusBar();

        }

        #region StatusTitleBar and TitleBar

        //Actualy change the color of the title bar in pc, to green

        private void TitleBar()
        {
            //Verifica se é computador
            if (ApiInformation.IsTypePresent("Windows.UI.ViewManagement.ApplicationView"))
            {
                var view = ApplicationView.GetForCurrentView();
                view.TitleBar.BackgroundColor = Colors.Green;
                view.TitleBar.ForegroundColor = Colors.White;

                view.TitleBar.ButtonBackgroundColor = Colors.Green;
                view.TitleBar.ButtonForegroundColor = Colors.White;

                view.TitleBar.ButtonHoverBackgroundColor = Colors.LightGreen;
                view.TitleBar.ButtonHoverForegroundColor = Colors.White;

                view.TitleBar.ButtonPressedBackgroundColor = Colors.LightGreen;
                view.TitleBar.ButtonPressedForegroundColor = Colors.White;

                view.TitleBar.ButtonInactiveBackgroundColor = Colors.Green;
                view.TitleBar.ButtonInactiveForegroundColor = Colors.White;

                view.TitleBar.InactiveBackgroundColor = Colors.Green;
                view.TitleBar.InactiveForegroundColor = Colors.White;
            }
        }

        //Actualy change the color of the Status bar in smartphone, to grey (i want to put transparent)

        private /*async*/ void StatusBar()
        {
            // Verifica se é telemóvel
            if (Windows.Foundation.Metadata.ApiInformation.IsTypePresent("Windows.UI.ViewManagement.StatusBar"))
            {

                var statusbar = Windows.UI.ViewManagement.StatusBar.GetForCurrentView();
                //await statusbar.HideAsync(); 
                // ^ Caso queiram tirar a barra descomentem a 
                //linha e comentem as 3 seguintes e tirem o comentário de async
                statusbar.BackgroundColor = Windows.UI.Colors.Transparent;
                statusbar.BackgroundOpacity = 1;
                //statusbar.ForegroundColor = Windows.UI.Colors.Black;
            }
        }

        private async void ShowStatusBar()
        {
            //verifica se é telemóvel
            if (Windows.Foundation.Metadata.ApiInformation.IsTypePresent("Windows.UI.ViewManagement.StatusBar"))
            {
                var statusbar = Windows.UI.ViewManagement.StatusBar.GetForCurrentView();
                await statusbar.ShowAsync();
                //statusbar.BackgroundColor = Windows.UI.Colors.Transparent;
                //statusbar.BackgroundOpacity = 1;
                //statusbar.ForegroundColor = Windows.UI.Colors.Red;
            }
        }
        #endregion

        #region Main Menu Panel Settings

        private void ShowPanel_Click(object sender, RoutedEventArgs e)
        {
            MainMenu.IsPaneOpen = !MainMenu.IsPaneOpen;
        }

        #endregion

        #region Menu Buttons

        private void Teste_Codigo_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Teste));
        }

        private void Perfil_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Perfil));
        }

        private void Biblioteca_Click(object sender, RoutedEventArgs e)
        {
            //Frame.Navigate(typeof(Biblioteca));
        }

        private void Settings_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Settings));
        }

        #endregion

        #region Main Frame Button

        private void Enter_Click(object sender, RoutedEventArgs e)
        {

        }

        #endregion

        #region Design

        private void changeBase()
        {
            //(alpha , red , green , blue)

            HamburgerButton.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            MenuButton.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            TestText.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            PerfilText.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            BiblioText.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            DefText.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
        }
        #endregion
    }
}
