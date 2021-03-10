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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace wpfSample
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        Window1 wnd1 = null;
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void ShowDialog(Window window)
        {
            window.Owner = this;
            window.Show();
        }

        private void BtnHandler(object sender, RoutedEventArgs e)
        {
            wnd1 = Window1.Instance;
            ShowDialog(wnd1);
        }
    }
}
