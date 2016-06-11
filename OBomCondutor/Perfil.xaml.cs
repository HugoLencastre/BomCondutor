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
using CrossPieCharts.UWP;
using CrossPieCharts.UWP.PieCharts;
using Windows.UI.Xaml.Shapes;

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
            AddIndiceChartPlusText();
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

        private void AddIndiceChartPlusText()
        {
            List<UIElement> lista = new List<UIElement>();
            TextBlock PrincipalValue;
            TextBlock PrincipalText;
            TextBlock Extra;
            Rectangle rectangle = doRectangle("rectangle1",2);
            PrincipalValue = doTexts("PrincipalValue", value + "%");
            PrincipalText = doTexts("PrincipalText", "Índice Bom Condutor");
            if (value < 70)
            {
                
                Extra = doTexts("Extra", "Aconselhamos que só realize o exame caso esteja entre o nível 70 e 100");
            }
            else
            {
                Extra = doTexts("Extra", "Consideramos que está pronto para realizar o exame, até lá continue a fazer exames.");
            }
            var piechart = doPieChart("piechart1", value , 70 , 10 , 100 );
            PrincipalValue.HorizontalAlignment = HorizontalAlignment.Center;
            PrincipalValue.VerticalAlignment = VerticalAlignment.Top;
            PrincipalText.HorizontalAlignment = HorizontalAlignment.Center;
            PrincipalText.VerticalAlignment = VerticalAlignment.Top;
            piechart.VerticalAlignment = VerticalAlignment.Top;
            piechart.HorizontalAlignment = HorizontalAlignment.Stretch;
            Extra.HorizontalAlignment = HorizontalAlignment.Center;

            lista.Add(piechart);
            lista.Add(PrincipalValue);
            lista.Add(PrincipalText);
            lista.Add(rectangle);
            lista.Add(Extra);

            addChildren(PrincipalStack, lista);
        }

        #region Do zone

        private void addChildren(StackPanel objecto,List<UIElement> lista)
        {
            foreach(UIElement temp in lista)
            {
                objecto.Children.Add(temp);
            }
        }
    
        private void doPrePage()
        {
            String nome = "Logo";
            String uri = "Assets/logo_short_white_310x310.scale-100.png";
            int width = 310;
            int height = 310;
            Image img = doImage(nome,uri,width,height);
            
            img.VerticalAlignment = Windows.UI.Xaml.VerticalAlignment.Top;
            img.HorizontalAlignment = Windows.UI.Xaml.HorizontalAlignment.Center;
            img.Margin = new Thickness(20, 100 , 20 , 0);

            TextBox textbox = new TextBox();
            PasswordBox passwordbox = new PasswordBox();

            

            PrincipalStack.Children.Add(img);
            PrincipalStack.Children.Add(textbox);
            PrincipalStack.Children.Add(passwordbox);
        }

        private Image doImage(String name , String location , int width , int height)
        {
            BitmapImage img = new BitmapImage();
            Image imagem = new Image();
            /*
            BitmapImage bitmapImage = new BitmapImage();
            Uri uri = new Uri(location);
            bitmapImage.UriSource = uri;
            */

            //imagem.Source = bitmapImage;
            imagem.Name = name;
            imagem.Width = width;
            imagem.Height = height;
            return imagem;
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

        private PieChart doPieChart(String name, int value, int radius , int thickness , int max) {
            var piechart = new CrossPieCharts.UWP.PieCharts.PieChart
            {
                Percentage = dotransformValueToPercentage(value, max),
                Segment360Color = new SolidColorBrush(Color.FromArgb(255, 211, 211, 211)),
                SegmentColor = new SolidColorBrush(Color.FromArgb(255, 0, 128, 0)),
                Radius = radius,
                StrokeThickness = thickness,
                Name = name,
            };
            return piechart;
        }

        private Rectangle doRectangle(String name,int height)
        {
            //bug, não aparece não sei porque. é a primeira vês que estou a adicionar um rectangulo por aqui

            Rectangle rectangle = new Rectangle();
            rectangle.HorizontalAlignment = HorizontalAlignment.Center;
            rectangle.Fill = new SolidColorBrush(Color.FromArgb(255, 169, 169, 169));
            rectangle.Height = height;
            rectangle.IsTapEnabled = false;
            rectangle.Visibility = Visibility.Visible;
            rectangle.Name = name;
            return rectangle;
        }

        private int dotransformValueToPercentage(int value, int max)
        {
            return (value * 100) / max; 
        }

        #endregion

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
