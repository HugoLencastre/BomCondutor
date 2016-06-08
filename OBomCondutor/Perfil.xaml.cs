using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace OBomCondutor
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Perfil : Page
    {

        private int value { get; set; }
        private Boolean isLogin { get; set; }
        private long token { get; set; }

        public Perfil()
        {
            this.InitializeComponent();
            //if (isLogin)
            //{
            //isLogin = false;
            //doPrePage();
            value = 75;
            AddBars();
            /*}
            //else if (!isLogin)
            //{
                if (username!= "null")
                {
                    if(password != "")
                    {
                        Login();
                    }
                    else
                    {

                    }
                }
                else
                {
                    doPrePage();
                }
            }*/
        }

        private void AddBars()
        {
            TextBlock PrincipalValue;
            TextBlock Extra;
            if (value < 70)
            {
                PrincipalValue = doTexts("PrincipalValue", value + " - Este é o seu nivel corrente");
                Extra = doTexts("Extra", "Aconselhamos que só realize o exame caso esteja entre o nível 70 e 100");
            }
            else
            {
                PrincipalValue = doTexts("PrincipalValue", value + " - Este é o seu nivel corrente");
                Extra = doTexts("Extra", "Consideramos que está pronto para realizar o exame, até lá continue a fazer exames.");
            }
            var progress1 = doBars("progress1", 0, 100);
            PrincipalStack.Children.Add(PrincipalValue);
            PrincipalStack.Children.Add(Extra);
            PrincipalStack.Children.Add(progress1); 
        }

        private void doPrePage()
        {
            Image img = new Image();
            /*
            BitmapImage bitmapImage = new BitmapImage();
            Uri uri = new Uri("Assets/logo_short_white_310x310.scale-100.png");
            bitmapImage.UriSource = uri;
            */
            img.Name = "Logo";
            //img.Source = bitmapImage;
            img.Width = 310;
            img.Height = 310;
            img.VerticalAlignment = Windows.UI.Xaml.VerticalAlignment.Top;
            img.HorizontalAlignment = Windows.UI.Xaml.HorizontalAlignment.Center;
            img.Margin = new Thickness(20, 100 , 20 , 0);

            TextBox textbox = new TextBox();
            PasswordBox passwordbox = new PasswordBox();

            

            PrincipalStack.Children.Add(img);
            PrincipalStack.Children.Add(textbox);
            PrincipalStack.Children.Add(passwordbox);
        }

        private TextBlock doTexts(String name, String text)
        {
            TextBlock textblock = new TextBlock();
            textblock.Name = name;
            textblock.Text = text;
            textblock.FontSize = 25;
            textblock.IsTextScaleFactorEnabled = true;
            return textblock;
        }

        private ProgressBar doBars(String name, int min, int max) {
            ProgressBar progress = new ProgressBar();
            progress.Background = new SolidColorBrush(Color.FromArgb(255, 211, 211, 211));
            progress.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 128, 0));
            progress.Maximum = max;
            progress.Minimum = min;
            progress.Value = value;
            progress.Name = name;
            return progress;
        }

        private void Login()
        {
            //try
            //{
                //var login = new Uri("http://www.bomcondutor.pt/entrar/submit");
                
            /*}
            catch(Exception e)
            {
                PricipalValue.Text = "ERROR";
            }*/
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

    }
}
