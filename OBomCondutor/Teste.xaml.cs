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
    public sealed partial class Teste : Page
    {
        public Teste()
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

        #region Testes Buttons

        private void Nova_Click(object sender, RoutedEventArgs e)
        {

        }

        #endregion

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
            Frame.Navigate(typeof(Perfil));
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

        // RGB
        //
        // White (255,255,255,255)
        //
        // Black (255,0,0,0)

        private void putBlack()
        {
            changeBase();
            // Mete as coisas a preto
            TelaPrincipal.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            TesteB.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
            TesteBseta.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
            TesteA.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
            TesteAseta.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
        }

        private void putWhite()
        {
            changeBase();
            // Mete as coisas a branco
            TelaPrincipal.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
            TesteB.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            TesteBseta.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            TesteA.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            TesteAseta.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
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

            TesteText.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
        }
        #endregion
    }
}
