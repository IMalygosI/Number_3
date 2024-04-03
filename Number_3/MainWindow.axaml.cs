using Avalonia.Controls;
using Avalonia.Controls.Shapes;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml.MarkupExtensions;
using System.Threading;
using Tmds.DBus.Protocol;

namespace Number_3
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent(); Null.Click += Click_Null;
            One.Click += Click_One; Two.Click += Click_Two;
            Three.Click += Click_Three; Four.Click += Click_Four;
            Five.Click += Click_Five; Six.Click += Click_Six;
            Seven.Click += Click_Seven; Eight.Click += Click_Eight;
            Nine.Click += Click_Nine;
            Clear.Click += Click_Clear; Submit.Click += Click_Submit;
        }
        public void Click_Null(object sender, RoutedEventArgs args)
        {
            string nom0 = "0";
            message.Text += nom0;
        }
        public void Click_One(object sender, RoutedEventArgs args)
        {
            string nom1 = "1"; message.Text += nom1;
        }
        public void Click_Two(object sender, RoutedEventArgs args)
        {
            string nom2 = "2";
            message.Text += nom2;
        }
        public void Click_Three(object sender, RoutedEventArgs args)
        {
            string nom3 = "3"; message.Text += nom3;
        }
        public void Click_Four(object sender, RoutedEventArgs args)
        {
            string nom4 = "4";
            message.Text += nom4;
        }
        public void Click_Five(object sender, RoutedEventArgs args)
        {
            string nom5 = "5"; message.Text += nom5;
        }
        public void Click_Six(object sender, RoutedEventArgs args)
        {
            string nom6 = "6";
            message.Text += nom6;
        }
        public void Click_Seven(object sender, RoutedEventArgs args)
        {
            string nom7 = "7"; message.Text += nom7;
        }
        public void Click_Eight(object sender, RoutedEventArgs args)
        {
            string nom8 = "8";
            message.Text += nom8;
        }
        public void Click_Nine(object sender, RoutedEventArgs args)
        {
            string nom9 = "9"; message.Text += nom9;
        }
        public void Click_Clear(object sender, RoutedEventArgs args)
        {
            string Clear = " "; message.Text = Clear;
        }
        public void Click_Submit(object sender, RoutedEventArgs args)
        {
        }


    }
}