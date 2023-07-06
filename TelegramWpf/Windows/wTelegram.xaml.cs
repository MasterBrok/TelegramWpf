using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.TextFormatting;
using System.Windows.Shapes;
using TelegramWpf.CustomControls;

namespace TelegramWpf.Windows
{
    /// <summary>
    /// Interaction logic for wTelegram.xaml
    /// </summary>
    public partial class wTelegram : Window
    {
        public wTelegram()
        {
            InitializeComponent();
        }

        private void wMain_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ccItemChat chat = new ccItemChat();
            
            chat.ValueContext = new Models.Profile("Brok","Hi",DateTime.Now.ToString(),"",6);
            spChats.Children.Add(chat);
        }
    }
}
