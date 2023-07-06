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
            Data.ListProfile.Profiles.ToList().ForEach(value =>
            {
                spChats.Children.Add(new ccItemChat() { ValueContext = value });
            });
        }

        private void StatusBar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void StatusBar_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Normal;
        }
    }
}
