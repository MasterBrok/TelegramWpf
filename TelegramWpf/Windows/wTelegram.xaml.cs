using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

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
    }
}
