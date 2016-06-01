using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace OBomCondutor
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    
    public sealed partial class Settings : Page
    {

        public Settings()
        {
            this.InitializeComponent();
            if (ApplicationData.Current.LocalSettings.Values["appTheme"].Equals("Light"))
            {
                putWhite();
            }
            else if (ApplicationData.Current.LocalSettings.Values["appTheme"].Equals("Dark"))
            { 
                putBlack();
            }
        }

        #region Main Menu Panel Settings

        private void ShowPanel_Click(object sender, RoutedEventArgs e)
        {
            MainMenu.IsPaneOpen = !MainMenu.IsPaneOpen;
        }

        #endregion

        #region Menu Buttons

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

        private void Teste_Codigo_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Teste));
        }

        private void Perfil_Click(object sender, RoutedEventArgs e)
        {
            // Frame.Navigate(typeof(Perfil));
        }

        private void Biblioteca_Click(object sender, RoutedEventArgs e)
        {
            // Frame.Navigate(typeof(Biblioteca));
        }

        private void Settings_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Settings));
        }

        #endregion

        #region Design

        private void ThemeToggleSwitch(object sender, RoutedEventArgs e)
        {
            ToggleSwitch toggle = sender as ToggleSwitch;
            if (toggle != null)
            {
                if (ApplicationData.Current.LocalSettings.Values["appTheme"].Equals("Light"))
                {
                    putBlack();
                    ApplicationData.Current.LocalSettings.Values["appTheme"] = "Dark";
                }
                else if (ApplicationData.Current.LocalSettings.Values["appTheme"].Equals("Dark"))
                {
                    putWhite();
                    ApplicationData.Current.LocalSettings.Values["appTheme"] = "Light";
                }
            }
        }

        private void putWhite()
        {
            changeBase();
            // Mete as coisas a branco
            TelaPrincipalSettings.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
            ToggleSwitch.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            TemaText.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            ToggleSwitch.BorderBrush= new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
        }

        private void putBlack()
        {
            changeBase();
            // Mete as coisas a preto
            TelaPrincipalSettings.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            ToggleSwitch.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
            TemaText.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
            ToggleSwitch.BorderBrush = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
        }

        private void changeBase()
        {
            //(alpha , red , green , blue)

            HamburgerButton.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            HomeText.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            TestText.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            PerfilText.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            BiblioText.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            DefText.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            SettingsText.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
        }

        #endregion

        private void Help_Click(object sender, RoutedEventArgs e)
        {
            //Frame.Navigate(typeof(Help));
        }

    }
}
